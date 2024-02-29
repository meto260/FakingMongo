using MongoDB.Bson;

namespace FakingMongo.Models {
    public class BackupModel {
        public List<DbModel> Datum { get; set; } = new List<DbModel>();
    }
    public class DbModel {
        public string DbName { get; set; }
        public List<ColModel> Collections { get; set; } = new List<ColModel>();
    }

    public class ColModel {
        public string ColName { get; set; }
        public List<BsonDocument> Source { get; set; }
    }
}
