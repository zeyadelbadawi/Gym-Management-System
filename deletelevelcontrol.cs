using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class deletelevelcontrol : UserControl
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
        public deletelevelcontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void deletelevelcontrol_Load(object sender, EventArgs e)
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
                
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
                ComboBoxDeleteLevel.Items.Add(pnn.name + " " + pnn.major);
            }



            conn.Close();
        }
        public void rebuild()
        {
        
            levels.Clear();
            ComboBoxDeleteLevel.Items.Clear();
            SelectAllLevel();
        }
        private void ButDelete_Click(object sender, EventArgs e)
        {         
            if (ComboBoxDeleteLevel.SelectedItem != null)
            {
                if (DeleteFromLevelTable(levels[ComboBoxDeleteLevel.SelectedIndex].id))
                {
                    MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rebuild();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please select class", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        public bool DeleteFromLevelTable(int LevelID)
        { 
            conn.Open();
            query = "DELETE FROM Levels WHERE ID = '" + LevelID + "' ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
           
        }

        private void ComboBoxDeleteLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            rebuild();
        }
    }
}
