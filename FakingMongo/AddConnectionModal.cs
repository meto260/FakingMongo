using FakingMongo.Models;
using FakingMongo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakingMongo {
    public partial class AddConnectionModal : Form {
        public AddConnectionModal() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var col = Program.LiteDB.GetCollection<Connections>();
            if (string.IsNullOrEmpty(usernameTBX.Text)) {
                //var db = new DbService(serverTBX.Text, portTBX.Text);
                col.Insert(new Connections { 
                    Name = nameTBX.Text ,
                    ConnStr = $"mongodb://{serverTBX.Text}:{portTBX.Text}"
                });
            } else {
                col.Insert(new Connections {
                    Name = nameTBX.Text,
                    ConnStr = $"mongodb://{usernameTBX.Text}:{passwordTBX.Text}@{serverTBX.Text}:{portTBX.Text}"
                });
            }
            this.Close();
        }
    }
}
