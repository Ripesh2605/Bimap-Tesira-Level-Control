namespace Bimap_Tesira_Level_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIP = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CurrentLevel = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.InstanceTagdrp = new System.Windows.Forms.ComboBox();
            this.Channels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(55, 36);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(61, 13);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP Address:";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(124, 33);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(200, 20);
            this.IPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UsedID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(124, 77);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(200, 20);
            this.UserID.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(124, 106);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(200, 20);
            this.Password.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(124, 152);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IPAddress);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UserID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurrentLevel);
            this.groupBox2.Controls.Add(this.Down);
            this.groupBox2.Controls.Add(this.Up);
            this.groupBox2.Controls.Add(this.InstanceTagdrp);
            this.groupBox2.Controls.Add(this.Channels);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(405, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 201);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Level";
            // 
            // CurrentLevel
            // 
            this.CurrentLevel.AutoSize = true;
            this.CurrentLevel.Location = new System.Drawing.Point(41, 161);
            this.CurrentLevel.Name = "CurrentLevel";
            this.CurrentLevel.Size = new System.Drawing.Size(73, 13);
            this.CurrentLevel.TabIndex = 9;
            this.CurrentLevel.Text = "Current Level:";
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(139, 90);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 48);
            this.Down.TabIndex = 8;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(44, 90);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(80, 48);
            this.Up.TabIndex = 7;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // InstanceTagdrp
            // 
            this.InstanceTagdrp.FormattingEnabled = true;
            this.InstanceTagdrp.Location = new System.Drawing.Point(44, 50);
            this.InstanceTagdrp.Name = "InstanceTagdrp";
            this.InstanceTagdrp.Size = new System.Drawing.Size(80, 21);
            this.InstanceTagdrp.TabIndex = 6;
            this.InstanceTagdrp.SelectedIndexChanged += new System.EventHandler(this.InstanceTagdrp_SelectedIndexChanged);
            // 
            // Channels
            // 
            this.Channels.FormattingEnabled = true;
            this.Channels.Location = new System.Drawing.Point(139, 51);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(75, 21);
            this.Channels.TabIndex = 5;
            this.Channels.SelectedIndexChanged += new System.EventHandler(this.Channels_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Channel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Instance Tag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 226);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bimap Tesira  - Level Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Channels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InstanceTagdrp;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Label CurrentLevel;
    }
}

