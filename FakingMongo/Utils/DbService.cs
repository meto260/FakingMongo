using FakingMongo.Models;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BsonDocument = MongoDB.Bson.BsonDocument;

namespace FakingMongo.Utils {
    public class DbService : IDisposable {
        MongoClient client;
        IMongoDatabase database;

        public DbService(){
        }

        public DbService(string connstr) {
            client = new MongoClient(connstr);
        }

        public async Task<List<string>> GetDatabases() {
            var data = await (await client.ListDatabaseNamesAsync()).ToListAsync();
            return data;
        }

        public async Task<List<string>> GetCollections(string dbname) {
            database = client.GetDatabase(dbname);
            var data = await database.ListCollectionNames().ToListAsync();
            return data;
        }

        public async Task<List<BsonDocument>> GetDocuments(string dbname, string collectionName) {
            database = client.GetDatabase(dbname);
            var colDocs = database.GetCollection<BsonDocument>(collectionName).Find(_ => true);
            var docList = colDocs.ToList();
            return docList;
        }
        public async Task BackupAction(string connName) {
            var data = new BackupModel();
            var dbs = await GetDatabases();
            foreach(var dbName in dbs) {
                var dbm = new DbModel { DbName = dbName };
                var cols = await GetCollections(dbName);
                cols.ForEach(async colName => {
                    var docs = await GetDocuments(dbName, colName);
                    dbm.Collections.Add(new ColModel { ColName = colName, Source = docs });
                });
                data.Datum.Add(dbm);
            }

            Directory.CreateDirectory(Path.Combine("Backups", connName));
            using (var stream = File.OpenWrite(Path.Combine("Backups", connName, $"{DateTime.Now.ToString("yyyyMMdd")}.bson"))) {
                using (var writer = new BsonBinaryWriter(stream)) {
                    BsonSerializer.Serialize(writer, data);
                }
            }

            //File.WriteAllText(
            //    Path.Combine("Backups", connName, $"{DateTime.Now.ToString("yyyyMMdd")}.json"),
            //    data.ToJson(new JsonWriterSettings { 
            //        OutputMode = JsonOutputMode.RelaxedExtendedJson
            //    }, BsonSerializer.)
            //);

            var recCollection = Program.LiteDB.GetCollection<Connections>("Connections");
            var rec = recCollection.FindOne(x => x.Name.Equals(connName));
            rec.LastRun = DateTime.Now;
            recCollection.Update(rec);
        }

        public async Task BackupManual() {
            var ccol = Program.LiteDB.GetCollection<Connections>();
            var cnns = ccol.FindAll().ToList();
            foreach (var c in cnns) {
                var dbs = new DbService(c.ConnStr);
                client = dbs.client;
                database = dbs.database;
                await BackupAction(c.Name);
            }
        }

        public async Task BackupScheduleRunner(Form1 mainFom) {
            var ccol = Program.LiteDB.GetCollection<Connections>();
            while (true) {
                var cnns = ccol.FindAll();
                foreach (var c in cnns) {
                    var dbs = new DbService(c.ConnStr);
                    client = dbs.client;
                    database = dbs.database;
                    await BackupAction(c.Name);
                    mainFom.LoadList();
                }
                await Task.Delay(TimeSpan.FromDays(1));
            }
        }

        public async Task RestoreDB(string dbName) {
            var db = client.GetDatabase(dbName);
        }

        public async Task RestoreServer(string jsonFileName, string connectionName) {
            var ccol = Program.LiteDB.GetCollection<Connections>("Connections");
            var conn = ccol.FindOne(x=>x.Name.Equals(connectionName));
            var dbs = new DbService(conn.ConnStr);
            client = dbs.client;
            database = dbs.database;

            using (var stream = File.OpenRead(jsonFileName)) {
                using (var reader = new BsonBinaryReader(stream)) {
                    var document = BsonSerializer.Deserialize<BackupModel>(reader);
                    document.Datum.ForEach(db => {
                        db.Collections.ForEach(colm => {
                            database = client.GetDatabase(db.DbName);
                            try {
                                database.CreateCollection(colm.ColName);
                                var dbo = client.GetDatabase(db.DbName);
                                var col = dbo.GetCollection<BsonDocument>(colm.ColName);
                                col.InsertMany(colm.Source);
                            }
                            catch (Exception exc) {
                                Debug.WriteLine(exc.Message);
                            }
                        });
                    });
                }
            }
        }

        public void Dispose() {
            client.Cluster.Dispose();
        }
    }
}
