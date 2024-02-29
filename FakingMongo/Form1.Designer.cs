namespace FakingMongo {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            connecToolStripMenuItem = new ToolStripMenuItem();
            addConnectionToolStripMenuItem = new ToolStripMenuItem();
            quickRunToolStripMenuItem = new ToolStripMenuItem();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImeMode = ImeMode.Katakana;
            menuStrip1.Items.AddRange(new ToolStripItem[] { connecToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1088, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connecToolStripMenuItem
            // 
            connecToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addConnectionToolStripMenuItem, quickRunToolStripMenuItem, restoreToolStripMenuItem });
            connecToolStripMenuItem.Name = "connecToolStripMenuItem";
            connecToolStripMenuItem.Size = new Size(50, 20);
            connecToolStripMenuItem.Text = "Menu";
            // 
            // addConnectionToolStripMenuItem
            // 
            addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
            addConnectionToolStripMenuItem.Size = new Size(180, 22);
            addConnectionToolStripMenuItem.Text = "Add Connection";
            addConnectionToolStripMenuItem.Click += addConnectionToolStripMenuItem_Click;
            // 
            // quickRunToolStripMenuItem
            // 
            quickRunToolStripMenuItem.Name = "quickRunToolStripMenuItem";
            quickRunToolStripMenuItem.Size = new Size(180, 22);
            quickRunToolStripMenuItem.Text = "Manual Backup";
            quickRunToolStripMenuItem.Click += quickRunToolStripMenuItem_Click;
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.Size = new Size(180, 22);
            restoreToolStripMenuItem.Text = "Restore Database";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2, columnHeader3 });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Segoe UI", 10F);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(0, 24);
            listView1.Name = "listView1";
            listView1.Size = new Size(1088, 426);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Created";
            columnHeader4.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Connection";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Connection String";
            columnHeader2.Width = 630;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LastRun";
            columnHeader3.Width = 160;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 450);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mongo Backup and Restore Daily Scheduler";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connecToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStripMenuItem addConnectionToolStripMenuItem;
        private ToolStripMenuItem quickRunToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ColumnHeader columnHeader4;
        private OpenFileDialog openFileDialog1;
    }
}
