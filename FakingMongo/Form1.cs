using FakingMongo.Models;
using FakingMongo.Utils;
using LiteDB;

namespace FakingMongo {
    public partial class Form1 : Form {
        ILiteCollection<Connections> conns = Program.LiteDB.GetCollection<Connections>("connections");
        public Form1() {
            InitializeComponent();
            Directory.CreateDirectory("Backups");
        }

        private void Form1_Load(object sender, EventArgs e) {
            LoadList();
        }

        public void LoadList() {
            listView1.Items.Clear();
            restoreToolStripMenuItem.DropDownItems.Clear();
            foreach (var conn in conns.FindAll()) {
                var lvi = new ListViewItem(conn.CreateDate.ToShortDateString());
                lvi.SubItems.Add(conn.Name);
                lvi.SubItems.Add(conn.ConnStr);
                lvi.SubItems.Add(conn.LastRun?.ToShortDateString());
                lvi.Tag = conn.Id;
                listView1.Items.Add(lvi);
                var menuitem = new ToolStripMenuItem { Text = conn.Name, Tag = conn.ConnStr };
                menuitem.Click += restoreToolStripMenuItemChild_Click;
                restoreToolStripMenuItem.DropDownItems.Add(menuitem);

            }
        }

        private void addConnectionToolStripMenuItem_Click(object sender, EventArgs e) {
            var page = new AddConnectionModal();
            page.Show();
            page.FormClosed += (q, w) => { LoadList(); };
        }

        private void listView1_Click(object s, EventArgs e) {
            var si = ((ListView)s).SelectedItems[0];
            DialogResult dialog = MessageBox.Show($"'{si.SubItems[1].Text}' silmek istediðinizden emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) {
                conns.Delete((ObjectId)si.Tag);
                LoadList();
            }
        }

        private async void quickRunToolStripMenuItem_Click(object sender, EventArgs e) {
            await new DbService().BackupManual();
        }

        private async void restoreToolStripMenuItemChild_Click(object sender, EventArgs e) {
            var item = (ToolStripMenuItem)sender;
            openFileDialog1.Tag = item.Text;
            openFileDialog1.ShowDialog();
        }

        private async void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            var dialog = (OpenFileDialog)sender;
            if (!e.Cancel) {
                await new DbService().RestoreServer(dialog.FileName, dialog.Tag.ToString());

            }
        }
    }
}
