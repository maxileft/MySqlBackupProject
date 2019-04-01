using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlBackupProjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int dStatus = 0;

        private void btnDoBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "Routes.Dll";
                File.WriteAllText(path, String.Empty);
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine(boxServer.Text);
                tw.WriteLine(boxUsername.Text);
                tw.WriteLine(boxPassword.Text);
                tw.WriteLine(boxDatabase.Text);
                tw.WriteLine(boxFrequency.SelectedItem);
                tw.WriteLine(boxDirectory.Text);
                tw.Close();


                int frequency = Convert.ToInt32(boxFrequency.SelectedItem);
                mainTimer.Interval = (int)TimeSpan.FromMinutes(frequency).TotalMilliseconds;
                mainTimer.Enabled = true;

                if (dStatus == 0)
                {
                    btnDoBackup.Text = "Pause";
                    dStatus = 1;

                    boxServer.Enabled = false;
                    boxUsername.Enabled = false;
                    boxPassword.Enabled = false;
                    boxDatabase.Enabled = false;
                    boxFrequency.Enabled = false;
                    btnSelectDirectory.Enabled = false;
                    boxDirectory.Enabled = false;

                    Thread thread = new Thread(doBackup);
                    thread.Start();
                }
                else
                {
                    btnDoBackup.Text = "Start";
                    dStatus = 0;

                    boxServer.Enabled = true;
                    boxUsername.Enabled = true;
                    boxPassword.Enabled = true;
                    boxDatabase.Enabled = true;
                    boxFrequency.Enabled = true;
                    btnSelectDirectory.Enabled = true;
                    boxDirectory.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());        
                boxServer.Enabled = true;
                boxUsername.Enabled = true;
                boxPassword.Enabled = true;
                boxDatabase.Enabled = true;
                boxFrequency.Enabled = true;
                btnSelectDirectory.Enabled = true;
                boxDirectory.Enabled = true;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("Routes.dll");

            boxServer.Text = lines[0];
            boxUsername.Text = lines[1];
            boxPassword.Text = lines[2];
            boxDatabase.Text = lines[3];
            boxFrequency.SelectedItem = boxFrequency.FindStringExact(lines[4]);
            //MessageBox.Show(lines[4] + ":" + boxFrequency.FindStringExact(lines[4]));
            boxDirectory.Text = lines[5];

            CheckForIllegalCrossThreadCalls = false;
            boxFrequency.SelectedIndex = 0;

            if (!Directory.Exists("C:\\Backup"))
            {
                Directory.CreateDirectory("C:\\Backup");
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        public void doBackup() {
            if (this.InvokeRequired) {
                this.BeginInvoke((MethodInvoker)delegate ()
                {  progressBar.Visible = true; });
            }
                
            string directory = boxDirectory.Text;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            infoBox.AppendText("Start: " + DateTime.Now.ToString() + "\r\n");
            string server = boxServer.Text;
            string username = boxUsername.Text;
            string password = boxPassword.Text;
            string database = boxDatabase.Text;

            try
            {
                string connString = @"server=" + server + ";user=" + username + ";pwd=" + password + ";database=" + database + ";charset=utf8;convertzerodatetime=true;default command timeout=99999;Persist Security Info=False; Pooling = False;";

                string file = directory+ "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss") + ".sql";

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(" set net_read_timeout=99999 "))
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                            infoBox.AppendText("End: " + DateTime.Now.ToString() + "\r\n----------\r\n");

                            if (this.InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                { progressBar.Visible = false; });
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    { progressBar.Visible = false; });
                }


                MessageBox.Show(ex.ToString());

                btnDoBackup.Text = "Start";
                dStatus = 0;

                boxServer.Enabled = true;
                boxUsername.Enabled = true;
                boxPassword.Enabled = true;
                boxDatabase.Enabled = true;
                boxFrequency.Enabled = true;
                boxDirectory.Enabled = true;
            }

            
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(doBackup);
            thread.Start();
            //doBackup();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Close the window?",
                "Are you sure?",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }

        private void Form1_RegionChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                boxDirectory.Text = folderName;
            }
        }
    }
}
