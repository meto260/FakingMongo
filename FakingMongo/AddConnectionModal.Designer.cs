namespace FakingMongo {
    partial class AddConnectionModal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            serverTBX = new TextBox();
            portTBX = new TextBox();
            label2 = new Label();
            usernameTBX = new TextBox();
            label3 = new Label();
            passwordTBX = new TextBox();
            label4 = new Label();
            button1 = new Button();
            nameTBX = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F);
            label1.Location = new Point(55, 86);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // serverTBX
            // 
            serverTBX.Font = new Font("Segoe UI", 16F);
            serverTBX.Location = new Point(133, 82);
            serverTBX.Name = "serverTBX";
            serverTBX.Size = new Size(192, 36);
            serverTBX.TabIndex = 1;
            // 
            // portTBX
            // 
            portTBX.Font = new Font("Segoe UI", 16F);
            portTBX.Location = new Point(398, 82);
            portTBX.Name = "portTBX";
            portTBX.Size = new Size(173, 36);
            portTBX.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F);
            label2.Location = new Point(342, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 27);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // usernameTBX
            // 
            usernameTBX.Font = new Font("Segoe UI", 16F);
            usernameTBX.Location = new Point(133, 146);
            usernameTBX.Name = "usernameTBX";
            usernameTBX.Size = new Size(438, 36);
            usernameTBX.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F);
            label3.Location = new Point(21, 150);
            label3.Name = "label3";
            label3.Size = new Size(106, 27);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // passwordTBX
            // 
            passwordTBX.Font = new Font("Segoe UI", 16F);
            passwordTBX.Location = new Point(133, 212);
            passwordTBX.Name = "passwordTBX";
            passwordTBX.Size = new Size(438, 36);
            passwordTBX.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16F);
            label4.Location = new Point(21, 216);
            label4.Name = "label4";
            label4.Size = new Size(100, 27);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(133, 273);
            button1.Name = "button1";
            button1.Size = new Size(438, 83);
            button1.TabIndex = 8;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nameTBX
            // 
            nameTBX.Font = new Font("Segoe UI", 16F);
            nameTBX.Location = new Point(133, 23);
            nameTBX.Name = "nameTBX";
            nameTBX.Size = new Size(438, 36);
            nameTBX.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16F);
            label5.Location = new Point(59, 27);
            label5.Name = "label5";
            label5.Size = new Size(66, 27);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // AddConnectionModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 378);
            Controls.Add(nameTBX);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(passwordTBX);
            Controls.Add(label4);
            Controls.Add(usernameTBX);
            Controls.Add(label3);
            Controls.Add(portTBX);
            Controls.Add(label2);
            Controls.Add(serverTBX);
            Controls.Add(label1);
            Name = "AddConnectionModal";
            Text = "Add Connection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox serverTBX;
        private TextBox portTBX;
        private Label label2;
        private TextBox usernameTBX;
        private Label label3;
        private TextBox passwordTBX;
        private Label label4;
        private Button button1;
        private TextBox nameTBX;
        private Label label5;
    }
}