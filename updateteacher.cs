using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{

    public partial class UpdateTeacher : UserControl
    {
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        public UpdateTeacher()
        {
            InitializeComponent();
            conn = db.Connect_with_Database(); 
            conn.Open();
            checkteacher();
            conn.Close();
        }

        private void TextTeacherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TextteacherPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ButUpdateTeacher_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (TextTeacherName.Text.Length > 0)
            {
                //MessageBox.Show(Convert.ToInt32(TextTeacherID.Text) + "//" + TextTeacherName.Text + "**" + TextteacherPhone.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (UpdateInToTeacherTable(TextTeacherName.Text, TextteacherPhone.Text, Convert.ToInt32(TextTeacherID.Text)))
                {
                    listView1.Items.Clear();
                    checkteacher();
                    MessageBox.Show("Update done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Please enter new coach name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public bool SelectTeacherToUpdateIt(int TeacherID)
        {
            conn.Open();
            query = "SELECT Full_Name,Phone FROM Teacher WHERE ID ='" + TeacherID + "' ";
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
                TextTeacherName.Text = dt.Rows[0][0].ToString();
                TextteacherPhone.Text = dt.Rows[0][1].ToString();
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }
        public void checkteacher()
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

            if (dt.Rows.Count > 0)
            {
                //listView1.Items.Clear();
                string[] x = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        x[j] = dt.Rows[i][j].ToString();

                    }
                    listView1.Items.Add(new ListViewItem(x));

                }

            }
            else
            {

            }
            

        }
        public bool UpdateInToTeacherTable(string TeacherName, string TeacherPhone, int TeacherID)
        {
            if (TextteacherPhone.Text.Length > 0)
            {
                query = " UPDATE Teacher SET Full_Name = '" + TeacherName + "', Phone = '" + TeacherPhone + "'  WHERE ID = '" + TeacherID + "' ";
            }
            else
            {
                query = " UPDATE Teacher SET Full_Name = '" + TeacherName + "', Phone = NULL  WHERE ID = '" + TeacherID + "' ";
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
        }

        private void TextTeacherID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SelectTeacherToUpdateIt(Convert.ToInt32(TextTeacherID.Text)))
                {

                }
                else
                {
                    MessageBox.Show("Canot find coach to Update it ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateTeacher_Load(object sender, EventArgs e)
        {
          
        }

        private void TextteacherPhone_TextChanged(object sender, EventArgs e)
        {
            TextteacherPhone.MaxLength = 11;

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            checkteacher();
            conn.Close();
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
