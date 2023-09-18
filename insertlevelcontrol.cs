using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class insertlevelcontrol : UserControl
    {
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        public insertlevelcontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
        }

        private void insertlevelcontrol_Load(object sender, EventArgs e)
        {
            //ComboBoxinsertMajor.Items.Add("Null");            
        }

        private void ButInsert_Click(object sender, EventArgs e)
        {

        }

        private void insertlevelcontrol_Load_1(object sender, EventArgs e)
        {
            ComboBoxinsertMajor.Items.Add("children");
            ComboBoxinsertMajor.Items.Add("Men");
            ComboBoxinsertMajor.Items.Add("Wemen");

        }

        private void ButAddLevel_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (TextBoxLevelName.Text.Length > 0 && ComboBoxinsertMajor.SelectedIndex != -1)
            {
                if (CheckLevelIsAlredyAdd(TextBoxLevelName.Text, ComboBoxinsertMajor.SelectedItem.ToString()))
                {
                    MessageBox.Show("This class is already add , Please Try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertInToTableLevels(TextBoxLevelName.Text, ComboBoxinsertMajor.SelectedItem.ToString());
                }
            }
            else
            {
                if (TextBoxLevelName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter class name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ComboBoxinsertMajor.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select category ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }
        public bool CheckLevelIsAlredyAdd(string LevelName, string MajorName)
        {

            if (ComboBoxinsertMajor.SelectedIndex == 0)
            {
                query = "SELECT * FROM Levels WHERE Name ='" + LevelName + "' AND Major  IS NULL ";
            }
            else
            {
                query = "SELECT * FROM Levels WHERE Name ='" + LevelName + "' AND Major ='" + MajorName + "' ";
            }

            cmd = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show(dt.Rows.Count.ToString()+"K");
                //for (int i = 0; i < dt.Rows.Count; i++) { }
                return true;

            }
            else
            {
                //MessageBox.Show(dt.Rows.Count.ToString());
                return false;
            }
        }

        public void InsertInToTableLevels(string LevelName, string MajorName)
        {
            

            
                query = "INSERT INTO Levels(Name,Major) VALUES('" + LevelName + "','" + MajorName + "') ";
            

            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Succsessfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
