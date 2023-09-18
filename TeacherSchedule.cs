using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class TeacherSchedule : UserControl
    {
        public class Teacher
        {
            public int ID;
            public string Full_Name;
        }
        Connection_DB db = new Connection_DB();
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        MySqlConnection conn = null;
        DataTable info = new DataTable();
        List<Teacher> teachers = new List<Teacher>();
        public TeacherSchedule()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllTeacher();
        }
        public void SelectAllTeacher()
        {
            conn.Open();

            query = "SELECT ID,Full_Name  FROM Teacher ";

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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher pnn = new Teacher();
                    pnn.ID = Convert.ToInt32(dt.Rows[i][0]);
                    pnn.Full_Name = dt.Rows[i][1].ToString();
                    teachers.Add(pnn);
                    ComboBoxTeachers.Items.Add(pnn.Full_Name);
                }
            }
            else
            {

            }
            conn.Close();
        }
        private void ComboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButFindTheSchedule.Enabled = true;
        }
        private void ButFindTheSchedule_Click(object sender, EventArgs e)
        {
            if (ComboBoxTeachers.SelectedIndex != -1)
            {
                listView1.Items.Clear();
                info = SelectScheduleIformationOfTeacher(teachers[ComboBoxTeachers.SelectedIndex].ID);

                // Loop through the rows in the DataTable
                foreach (DataRow row in info.Rows)
                {
                    // Create a ListViewItem with the data from each row
                    ListViewItem item = new ListViewItem(row["TeacherName"].ToString());
                    item.SubItems.Add(row["LevelName"].ToString());
                    item.SubItems.Add(row["MajorName"].ToString());
                    item.SubItems.Add(row["SubjectName"].ToString());
                    item.SubItems.Add(row["WorkDays"].ToString()); // Add Subject.days to the ListViewItem

                    listView1.Items.Add(item);
                }

                if (info.Rows.Count == 0)
                {
                    MessageBox.Show("There is No Schedule For The Selected coach.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select Coach To Get The Schedule.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable SelectScheduleIformationOfTeacher(int TeacherID)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=gym;user=root"))
            {
                conn.Open();

                string query = @"SELECT
                    Teacher.Full_Name AS TeacherName,
                    Levels.Name AS LevelName,
                    Levels.Major AS MajorName,
                    Subject.Sub_Name AS SubjectName,
                    Subject.days AS WorkDays
                FROM
                    Teacher
                JOIN
                    teacher_subject ON Teacher.ID = teacher_subject.Tch_ID
                JOIN
                    subject ON teacher_subject.Sub_ID = subject.Sub_ID
                JOIN
                    Levels ON subject.Level_ID = levels.ID
                WHERE
                    Teacher.ID = @TeacherID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Close();

                return dt;
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            excelsheet ry = new excelsheet();
            ry.abuio(listView1);
        }

        private void TeacherSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
