using FakingMongo.Utils;
using LiteDB;

namespace FakingMongo {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            LiteDB = new LiteDatabase("items.db");
            var form1 = new Form1();
            var dbs = new DbService();
            _ = dbs.BackupScheduleRunner(form1);
            Application.Run(form1);
        }

        public static LiteDatabase LiteDB;
    }
}