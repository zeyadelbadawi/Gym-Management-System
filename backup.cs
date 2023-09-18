using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class backup : UserControl
    {
      //  MySqlConnection con = new MySqlConnection("server=DESKTOP-BKH8GKO;database=DatabaseTemplate;integrated security = true;TrustServerCertificate=True");
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        MySqlConnection con = null;
        string[] tables = new string[8] { "student", "levels","teacher", "subject", "teacher_subject", "Attendance", "Absent", "admins" };
        public backup()
        {
            InitializeComponent();            
            conn = db.Connect_with_Database();
            con = db.Connect_with_Database();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                btnBackUp.Enabled = true;
            }

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter a file location", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Specify the path for mysqldump executable
                string mysqldumpPath = "path_to_mysqldump"; // Replace with the actual path to mysqldump

                // Database name
                string dbName = conn.Database.ToString();

                // Backup file path
                string backupFilePath = textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".sql";

                // Create a process to execute mysqldump
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = mysqldumpPath;
                process.StartInfo.Arguments = $"--user=username --password=password --host=hostname {dbName} -r \"{backupFilePath}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Database backup completed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = process.StandardError.ReadToEnd();
                    MessageBox.Show($"Database backup failed. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                process.Close();
                btnBackUp.Enabled = false;
            }
        }



        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database back files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            btnRestore.Enabled = false;
            string db = con.Database.ToString();
            con.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + db + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + db + "] FROM DISK='" + textBox2.Text + "'WITH REPLACE;";
                MySqlCommand cmd2 = new MySqlCommand(str2, con);
                cmd2.ExecuteNonQuery();


                string str3 = string.Format("ALTER DATABASE [" + db + "] SET MULTI_USER");
                MySqlCommand cmd3 = new MySqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("database restored successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public void delete(string tablename, int identity = 0)
        {
            conn.Open();
            string query = null;
            query = $"DELETE FROM {tablename}; DBCC CHECKIDENT ('{tablename}', RESEED, {identity});";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void backup_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialButton2.Enabled = true;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tables.Length; i++)
            {
                if (i == 0)
                    delete(tables[i], 2299);
                else delete(tables[i]);
            }
            MessageBox.Show("Data deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
