using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class deletestudentcontrol : UserControl
    {
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;

        public deletestudentcontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
        }


        private void deletestudentcontrol_Load(object sender, EventArgs e)
        {

        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ButDeleteStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (TextStudentID.Text.Length > 0)
            {
                if (StudentFind)
                {
                    //MessageBox.Show(TextStudentID.Text, Information);
                    DeleteFromStudentTable(Convert.ToInt32(TextStudentID.Text));
                }
                else
                {
                    //MessageBox.Show(name);
                    MessageBox.Show("Member not find,Please enter another Member ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter Member ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public void DeleteFromStudentTable(int StudentID)
        {
            query = "DELETE FROM Student WHERE Student_ID = @StudentID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", StudentID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Member Done Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string Information;
        public bool CheckStudent(int studentID)
        {
            query = "SELECT s.Student_ID, s.Full_Name, su.Sub_name " +
                    "FROM Student s " +
                    "INNER JOIN Subject su ON s.sub_id = su.sub_ID " +
                    "WHERE s.Student_ID = '" + studentID + "'";

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
                Information = dt.Rows[0]["Full_Name"].ToString() + " / " + dt.Rows[0]["Sub_name"].ToString();
                return true;
            }
            else
            {
                Information = "Member Not found.";
                return false;
            }
        }

        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public bool StudentFind = false;
        private void TextStudentID_TextChanged(object sender, EventArgs e)
        {
            TextStudentInformation.Clear();
            conn.Open();
            try
            {
                if (CheckStudent(Convert.ToInt32(TextStudentID.Text)))
                {
                    StudentFind = true;
                    TextStudentInformation.Text = Information;
                }
                else
                {
                    StudentFind = false;
                    TextStudentInformation.Text = Information;
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();
        }
    }
}
