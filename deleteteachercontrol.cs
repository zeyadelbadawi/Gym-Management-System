using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class deleteteachercontrol : UserControl
    {
        public class Teacher
        {
            public int ID;
            public string Name;
            public string Phone;
        }
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        List<Teacher> teachers = new List<Teacher>();
        public deleteteachercontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            conn.Open();
            RetriveAllTeacher();
            conn.Close();
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ButDeleteTeacher_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (TextTeacherID.Text.Length > 0)
            {
                if (DeleteFromTeacherTable(Convert.ToInt32(TextTeacherID.Text)))
                {
                    MessageBox.Show("Deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RetriveAllTeacher();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select coach ID ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void RetriveAllTeacher()
        {
           
            query = "SELECT * FROM Teacher ";
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
                Teacher pnn = new Teacher();
                pnn.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                pnn.Name = dt.Rows[i]["Full_Name"].ToString();
                pnn.Phone = dt.Rows[i]["Phone"].ToString();
                teachers.Add(pnn);
                listView1.Items.Clear();
                string[] x = new string[dt.Columns.Count];
                for (int ik= 0; ik < dt.Rows.Count; ik++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        x[j] = dt.Rows[ik][j].ToString();

                    }
                    listView1.Items.Add(new ListViewItem(x));
                }
                //ComboBoxTeacherName.Items.Add(pnn.Name);
            }                                
            
        }

        public bool DeleteFromTeacherTable(int TeacherID)
        {
            
            query = "DELETE FROM Teacher WHERE ID ='" + TeacherID + "'";

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
        }

        private void TextTeacherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void deleteteachercontrol_Load(object sender, EventArgs e)
        {
          
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            RetriveAllTeacher();
            conn.Close();
        }
    }
}
