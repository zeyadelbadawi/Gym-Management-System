using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class studenthomepage : UserControl
    {
        Connection_DB db = new Connection_DB();
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        MySqlConnection conn = null;
        public string gh;
        public studenthomepage()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
        }

        private void insertStudentControl1_Load(object sender, EventArgs e)
        {
            
        }
        public DataTable SelectIformationOfStudent()
        {
            conn.Open();
             query = "SELECT Student.Student_ID AS StudentID ,Student.Full_Name AS StudentName ,Student.phone AS StudentPhone ,Student.parent_phone AS ParentPhone ,Student.School AS SchoolName ,Student.Twin_ID AS TwinsName ,Levels.Name AS LevelName ,Student.Major ,Student.bar_code AS StudentBarCode ,Student.Gender ,Student.date AS RegisterDate FROM Student JOIN Levels ON Levels.ID = Student.Level_ID ";
          //  query = "Sel";
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
                
                
                    gh = null;
                conn.Close();
                return dt;
            }

            else
            {
                conn.Close();
                return dt;
            }
        }
        
        private void materialButton1_Click(object sender, EventArgs e)
        {
         //   listviewcontrol list1 = new listviewcontrol();
         //   list1.InfoTable = SelectIformationOfStudent();    
         //   list1.gh = gh;
         //   list1.fill();
         //   list1.Dock = DockStyle.Right;
         ////   list1.Location = new System.Drawing.Point(250, 73);
         //   this.Controls.Add(list1);
         //   list1.Show();
         //   list1.BringToFront();
            insertStudentControl1.Show();
            insertStudentControl1.BringToFront();          
            updatestudentcontrol1.Hide();
            deletestudentcontrol1.Hide();
        }       
        private void materialButton2_Click(object sender, EventArgs e)
        {
            updatestudentcontrol1.Show();
            updatestudentcontrol1.BringToFront();
            insertStudentControl1.Hide();
            deletestudentcontrol1.Hide();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            deletestudentcontrol1.Show();
            deletestudentcontrol1.BringToFront();
            updatestudentcontrol1.Hide();
            insertStudentControl1.Hide();
        }

        private void studenthomepage_Load(object sender, EventArgs e)
        {
            insertStudentControl1.Hide();
            updatestudentcontrol1.Hide();
            deletestudentcontrol1.Hide();         
        }

        private void deletestudentcontrol1_Load(object sender, EventArgs e)
        {

        }

        private void insertStudentControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
