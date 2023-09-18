using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class Insert_new_teacher : UserControl
    {

        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        public Insert_new_teacher()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
        }


      

        private void Insert_new_teacher_Load(object sender, EventArgs e)
        {
            conn.Open();
            checkteacher();
            conn.Close();
        }

        private void TextTeacherPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ButAddTeacher_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (TextTeacherName.Text.Length > 0)
            {
               
                //Check
                if (CheckNewTeacherIsNotAdded(TextTeacherName.Text, TextTeacherPhone.Text))
                {
                    MessageBox.Show("This coach is already added,please add another one!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    //insert
                  if (InsertInToTeacherTable(TextTeacherName.Text, TextTeacherPhone.Text))
                    {
                        MessageBox.Show("New coach is added successfully","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter coach Name ", "Messge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listView1.Items.Clear();
            checkteacher();
            conn.Close();
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
        public bool CheckNewTeacherIsNotAdded(string TeacherName, string TeacherPhone)
        {
            query = "SELECT Full_Name FROM Teacher WHERE Full_Name ='" + TeacherName + "' AND Phone='" + TeacherPhone + "' ";
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
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool InsertInToTeacherTable(string TeacherName, string Teacherphone)
        {


            query = "INSERT INTO Teacher(Full_Name,Phone) VALUES('" + TeacherName + "','" + Teacherphone + "') ";
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

        private void TextTeacherPhone_TextChanged(object sender, EventArgs e)
        {
            TextTeacherPhone.MaxLength = 11;
        }
    }
}
