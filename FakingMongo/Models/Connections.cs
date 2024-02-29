using LiteDB;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakingMongo.Models {
    public class Connections {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string ConnStr { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? LastRun { get; set; }
    }
}
