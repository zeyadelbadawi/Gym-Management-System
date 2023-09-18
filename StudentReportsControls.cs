using System;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class StudentReportsControls : UserControl
    {
        Connection_DB db = new Connection_DB();
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        MySqlConnection conn = null;
        public string gh;
        public StudentReportsControls()
        {
            InitializeComponent();

            conn = db.Connect_with_Database();
            //Type of Search
            ComboBoxTypeOfSearch.Items.Add("Member ID");
            ComboBoxTypeOfSearch.Items.Add("Member Name");
            ComboBoxTypeOfSearch.Items.Add("Member BarCode");            
            //Type of student Records
            ComboBoxTypeOfReport.Items.Add("Member Information");
            ComboBoxTypeOfReport.Items.Add("Member Attendance Record");
            ComboBoxTypeOfReport.Items.Add("Member Absent Record");
        }
         public void filllist()
        {
            listView1.Clear();
            //Studentid = -1;
            if (ComboBoxTypeOfSearch.SelectedIndex != -1 && TextTypeSearchOfStudent.Text.Length > 0 && ComboBoxTypeOfReport.SelectedIndex != -1)
            {
                if (InfoTable.Rows.Count > 0)
                {
                    if (ComboBoxTypeOfReport.SelectedIndex == 0)
                    {
                        listView1.Columns.Add("MemberID", 70);
                        listView1.Columns.Add("MemberName", 190);
                        listView1.Columns.Add("Phone", 130);
                        listView1.Columns.Add("class", 120);
                        listView1.Columns.Add("section", 120);
                        listView1.Columns.Add("training days", 200);
                        listView1.Columns.Add("Barcode", 120);
                        listView1.Columns.Add("Gender", 100);
                        listView1.Columns.Add("Registeration date", 180);
                        listView1.Columns.Add("level_name", 120);
                        listView1.Columns.Add("level_major", 100);
                        listView1.Columns.Add("subject_name", 180);
                    }
                    if (ComboBoxTypeOfReport.SelectedIndex == 1)
                    {
                        listView1.Columns.Add("MemberID", 70);
                        listView1.Columns.Add("MemberName", 190);
                        listView1.Columns.Add("Subject", 130);
                        listView1.Columns.Add("class", 120);
                        listView1.Columns.Add("Attendance Date", 150);
                        listView1.Columns.Add("Attendance Time", 160);
                        listView1.Columns.Add("Attendance day of week", 160);

                    }
                    if (ComboBoxTypeOfReport.SelectedIndex == 2)
                    {
                        listView1.Columns.Add("MemberID", 70);
                        listView1.Columns.Add("MemberName", 190);
                        listView1.Columns.Add("Subject", 130);
                        listView1.Columns.Add("class", 120);
                        listView1.Columns.Add("Absent Date", 160);
                        listView1.Columns.Add("Absent day of week", 160);

                    }



                    string[] x = new string[InfoTable.Columns.Count];
                    for (int i = 0; i < InfoTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < InfoTable.Columns.Count; j++)
                        {
                            if (j + 1 == InfoTable.Columns.Count)
                            {

                                string[] t = InfoTable.Rows[i][j].ToString().Split(' ');
                                x[j] = t[0];
                            }
                            else
                            {
                                x[j] = InfoTable.Rows[i][j].ToString();
                                if (j != 9)
                                {
                                    x[j] = InfoTable.Rows[i][j].ToString();
                                }
                                else
                                {
                                    x[j] = gh;
                                }
                            }
                           
                        }
                        listView1.Items.Add(new ListViewItem(x));
                    }
                }

                else
                {
                    MessageBox.Show("Member Not Found,Please Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ComboBoxTypeOfSearch.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Type Of Search", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TextTypeSearchOfStudent.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter " + ComboBoxTypeOfSearch.SelectedItem.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ComboBoxTypeOfReport.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Type Of Report", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //TextTypeSearchOfStudent.Clear();
            ComboBoxTypeOfReport.SelectedIndex = -1;
        }

        private void ButSelectStudents_Click(object sender, EventArgs e)
        {

            filllist();
        }

        private void ComboBoxTypeOfSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextTypeSearchOfStudent.Clear();
            LabelSearchType.Text = ("Enter " + ComboBoxTypeOfSearch.SelectedItem.ToString());
            LabelSearchType.Visible = true;
            TextTypeSearchOfStudent.Visible = true;
            LabelofReporttype.Visible = true;
            ComboBoxTypeOfReport.Visible = true;
            ButSelectStudents.Visible = true;
            InfoTable.Clear();
            Studentid = -1;
            if(ComboBoxTypeOfSearch.SelectedIndex == 2 )
            {
                TextTypeSearchOfStudent.MaxLength = 9;
            }
            if(ComboBoxTypeOfSearch.SelectedIndex == 0 )
            {
               TextTypeSearchOfStudent.MaxLength = 5;
            }
            if(ComboBoxTypeOfSearch.SelectedIndex == 1 )
            {
               TextTypeSearchOfStudent.MaxLength = 100;
            }


        }
        DataTable InfoTable = new DataTable();
        private void ComboBoxTypeOfReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeOfReport.SelectedIndex == 0)
            {
                InfoTable = SelectIformationOfStudent(Studentid);
            }
            
            if (ComboBoxTypeOfReport.SelectedIndex == 1)
            {
                InfoTable = SelectAttendanceIformationOfStudent(Studentid);
            }
            if (ComboBoxTypeOfReport.SelectedIndex == 2)
            {
                InfoTable = SelectAbsentIformationOfStudent(Studentid);
            }
            
        }
      
        public DataTable SelectIformationOfStudent(int StudentID)
        {
            conn.Open();
            query = "SELECT " +
                      "Student.Student_ID AS StudentID, " +
                      "Student.Full_Name AS StudentName, " +
                      "Student.phone AS StudentPhone, " +
                      "Levels.Name AS LevelName, " +
                      "Subject.Sub_Name AS SubjectName, " +
                      "Subject.days AS SubjectDays, " + 
                      "Student.bar_code AS StudentBarCode, " +
                      "Student.Gender, " +
                      "Student.date AS RegisterDate " +
                      "FROM Student " +
                      "JOIN Levels ON Levels.ID = Student.Level_ID " +
                      "JOIN Subject ON Student.sub_ID = Subject.Sub_ID " + 
                      "WHERE Student.Student_ID = '" + StudentID + "'";

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
                //DataGridViewStudentsInformation.DataSource = dt;
               
                conn.Close();
                return dt;
            }

            else
            {
                conn.Close();
                return dt;
            }
        }
       
        public DataTable SelectAttendanceIformationOfStudent(int StudentID)
        {
            conn.Open();

            query = "SELECT Student.Student_ID, Student.Full_Name AS StudentName,Subject.Sub_Name AS SubjectName, Levels.Name AS LevelName,Attendance.Date AS AttendanceDate ,Attendance.Time AS AttendanceTime ,Attendance.day_week AS Attendance_day_week FROM Attendance JOIN Student ON Attendance.Stu_ID = Student_ID JOIN subject ON Attendance.Sub_ID = subject.sub_ID JOIN Levels ON Levels.ID = Subject.Level_ID WHERE Student_ID='" + StudentID + "' ";  

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
                conn.Close();
                return dt;
            }
            else
            {
                conn.Close();
                return dt;
            }
        }
        public DataTable SelectAbsentIformationOfStudent(int StudentID)
        {
            conn.Open();
            query = "SELECT Student.Student_ID, Student.Full_Name AS StudentName,Subject.Sub_Name AS SubjectName, Levels.Name AS LevelName,absent.Date AS absentDate ,absent.day_week AS absent_day_week FROM absent JOIN Student ON absent.Stu_ID = Student_ID JOIN subject ON absent.Sub_ID = subject.sub_ID JOIN Levels ON Levels.ID = Subject.Level_ID WHERE Student_ID='" + StudentID + "' ";
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
                conn.Close();
                return dt;
            }
            else
            {
                conn.Close();
                return dt;
            }
        }
        



        public int Studentid = -1;

        private void TextTypeSearchOfStudent_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeOfSearch.SelectedIndex == 0)
            {
                try
                {
                    Studentid = SelectStudentByID(Convert.ToInt32(TextTypeSearchOfStudent.Text));
                }
                catch (Exception ex)
                {
                }
            }
            if (ComboBoxTypeOfSearch.SelectedIndex == 1)
            {
                try
                {
                    Studentid = SelectStudentByName(TextTypeSearchOfStudent.Text);
                }
                catch (Exception ex)
                {
                }
            }
            if (ComboBoxTypeOfSearch.SelectedIndex == 2)
            {
                try
                {
                    Studentid = SelectStudentByBarCode(TextTypeSearchOfStudent.Text);
                }
                catch (Exception ex)
                {
                }
            }
        }

        public int SelectStudentByID(int StudentID)
        {
            conn.Open();

            query = "SELECT Student_ID FROM Student WHERE Student_ID ='" + StudentID + "' ";
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
              
                conn.Close();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                conn.Close();
                return -1;
            }
        }

        public int SelectStudentByName(string StudentName)
        {
            conn.Open();

            query = "SELECT Student_ID FROM Student WHERE Full_Name ='" + StudentName + "' ";
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
                
                conn.Close();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                conn.Close();
                return -1;
            }
        }

        public int SelectStudentByBarCode(string BarCode)
        {
            conn.Open();

            query = "SELECT Student_ID FROM Student WHERE bar_code ='" + BarCode + "' ";
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
               
                conn.Close();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                conn.Close();
                return -1;
            }
        }

        private void TextTypeSearchOfStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxTypeOfSearch.SelectedIndex == 0 || ComboBoxTypeOfSearch.SelectedIndex == 2)
            {
                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }

        }

      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void ButExcelSheet_Click(object sender, EventArgs e)
        {
            excelsheet yu = new excelsheet();
            yu.abuio(listView1);
        }

        private void StudentReportsControls_Load(object sender, EventArgs e)
        {
 
        }

        private void TextTypeSearchOfStudent_Enter(object sender, EventArgs e)
        {
            
        }
               
        

        private void LabelSearchType_Click(object sender, EventArgs e)
        {

        }
    }
}
