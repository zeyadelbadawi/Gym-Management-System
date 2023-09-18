using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class updatelevelcontrol : UserControl
    {
        public class level
        {
            public int id;
            public string name;
            public string major;
        }
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        List<level> levels = new List<level>();
        public updatelevelcontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
            ComboBoxMajor.Items.Add("children");

            ComboBoxMajor.Items.Add("Men");
            ComboBoxMajor.Items.Add("Wemen");

        }

        private void updatelevelcontrol_Load(object sender, EventArgs e)
        {
            
        }
        public void SelectAllLevel()
        {
            conn.Open();

            query = "SELECT * FROM Levels ";
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

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(i==0)
                {
                    levels.Clear();
                    ComboBoxLevels.Items.Clear();
                }
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
                ComboBoxLevels.Items.Add(pnn.name + " " + pnn.major);
            }

            conn.Close();
        }
        public bool UpdateInToTableLevels(string NewLevelName, string NewLevelMajor, int LevelId)
        {
            //conn.Open();
            //MessageBox.Show(NewLevelMajor);

            if (NewLevelMajor == null)
            {
                query = " UPDATE Levels SET Name = '" + NewLevelName + "' , Major = NULL WHERE ID = '" + LevelId + "' ";
            }
            else
            {
                query = " UPDATE Levels SET Name = '" + NewLevelName + "' , Major ='" + NewLevelMajor + "' WHERE ID = '" + LevelId + "' ";
            }


            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //conn.Close();
        }

        public void ClearAll()
        {
            ComboBoxLevels.SelectedIndex = -1;
            TextUpdatedName.Text = null;
            ComboBoxMajor.SelectedIndex = -1;
            //levels.Clear();            
            //SelectAllLevel();

        }
        private void ButUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (ComboBoxLevels.SelectedIndex != -1 && TextUpdatedName.Text.Length > 0)
            {
                if (ComboBoxMajor.SelectedItem.ToString() == "None")
                {
                    if (UpdateInToTableLevels(TextUpdatedName.Text, null, levels[ComboBoxLevels.SelectedIndex].id))
                    {
                       // MessageBox.Show("Updated Class Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (UpdateInToTableLevels(TextUpdatedName.Text, ComboBoxMajor.SelectedItem.ToString(), levels[ComboBoxLevels.SelectedIndex].id))
                    {
                        MessageBox.Show("Updated Class Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {

                    }
                }

            }
            else
            {
                if (ComboBoxLevels.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Class ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TextUpdatedName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter new Class name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            conn.Close();
        }

        private void ComboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ComboBoxLevels.SelectedIndex != -1)
            {
                TextUpdatedName.Text = levels[ComboBoxLevels.SelectedIndex].name;              
                if (levels[ComboBoxLevels.SelectedIndex].major == "Men")
                {
                    ComboBoxMajor.SelectedIndex = 1;
                }
                else if (levels[ComboBoxLevels.SelectedIndex].major == "Wemen")
                {
                    ComboBoxMajor.SelectedIndex = 2;

                }
                else
                {
                    ComboBoxMajor.SelectedIndex = 0;
                }
            }
            else
            {
                ComboBoxMajor.SelectedIndex = 0;
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TextUpdatedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SelectAllLevel();
        }
    }
}
