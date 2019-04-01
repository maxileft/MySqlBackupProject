namespace MySqlBackupProjects
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDoBackup = new System.Windows.Forms.Button();
            this.dfgdfg = new System.Windows.Forms.Label();
            this.boxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxDatabase = new System.Windows.Forms.TextBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.boxFrequency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.boxDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoBackup
            // 
            this.btnDoBackup.Location = new System.Drawing.Point(174, 170);
            this.btnDoBackup.Name = "btnDoBackup";
            this.btnDoBackup.Size = new System.Drawing.Size(75, 23);
            this.btnDoBackup.TabIndex = 5;
            this.btnDoBackup.Text = "Start";
            this.btnDoBackup.UseVisualStyleBackColor = true;
            this.btnDoBackup.Click += new System.EventHandler(this.btnDoBackup_Click);
            // 
            // dfgdfg
            // 
            this.dfgdfg.AutoSize = true;
            this.dfgdfg.Location = new System.Drawing.Point(28, 12);
            this.dfgdfg.Name = "dfgdfg";
            this.dfgdfg.Size = new System.Drawing.Size(38, 13);
            this.dfgdfg.TabIndex = 4;
            this.dfgdfg.Text = "Server";
            // 
            // boxServer
            // 
            this.boxServer.Location = new System.Drawing.Point(72, 12);
            this.boxServer.Name = "boxServer";
            this.boxServer.Size = new System.Drawing.Size(177, 20);
            this.boxServer.TabIndex = 3;
            this.boxServer.Text = "208.113.188.168";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(72, 38);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(177, 20);
            this.boxUsername.TabIndex = 6;
            this.boxUsername.Text = "sis_database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(72, 64);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(177, 20);
            this.boxPassword.TabIndex = 8;
            this.boxPassword.Text = "00297985";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Database";
            // 
            // boxDatabase
            // 
            this.boxDatabase.Location = new System.Drawing.Point(72, 90);
            this.boxDatabase.Name = "boxDatabase";
            this.boxDatabase.Size = new System.Drawing.Size(177, 20);
            this.boxDatabase.TabIndex = 10;
            this.boxDatabase.Text = "sis_database";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // boxFrequency
            // 
            this.boxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFrequency.FormattingEnabled = true;
            this.boxFrequency.Items.AddRange(new object[] {
            "60",
            "120",
            "180",
            "240",
            "300",
            "360",
            "420",
            "480",
            "540",
            "600"});
            this.boxFrequency.Location = new System.Drawing.Point(72, 116);
            this.boxFrequency.Name = "boxFrequency";
            this.boxFrequency.Size = new System.Drawing.Size(177, 21);
            this.boxFrequency.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Frequency";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 201);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "By Kamo";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.ForeColor = System.Drawing.SystemColors.Control;
            this.infoBox.Location = new System.Drawing.Point(255, 14);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(152, 179);
            this.infoBox.TabIndex = 15;
            this.infoBox.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Click to restore";
            this.notifyIcon1.BalloonTipTitle = "MysqlBackup";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MySql Backup";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Directory";
            // 
            // boxDirectory
            // 
            this.boxDirectory.Location = new System.Drawing.Point(72, 143);
            this.boxDirectory.Name = "boxDirectory";
            this.boxDirectory.Size = new System.Drawing.Size(147, 20);
            this.boxDirectory.TabIndex = 16;
            this.boxDirectory.Text = "D:\\Backup";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(225, 141);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(24, 23);
            this.btnSelectDirectory.TabIndex = 18;
            this.btnSelectDirectory.Text = "...";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 223);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxDirectory);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.btnDoBackup);
            this.Controls.Add(this.dfgdfg);
            this.Controls.Add(this.boxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MySql Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegionChanged += new System.EventHandler(this.Form1_RegionChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoBackup;
        private System.Windows.Forms.Label dfgdfg;
        private System.Windows.Forms.TextBox boxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxDatabase;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ComboBox boxFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}

