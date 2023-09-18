using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class AttendanceStudent : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=gym;user=root";

        public AttendanceStudent()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PopulateCoursesForStudent(int studentId)
        {
            courseComboBox.Items.Clear();
            string query = @"
        SELECT subject.days, levels.name, levels.major, subject.Sub_Name
        FROM subject
        INNER JOIN student ON student.Sub_ID = subject.Sub_ID
        INNER JOIN levels ON levels.ID = subject.Level_ID
        WHERE student.Student_ID = @StudentID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StudentID", studentId);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string day = reader["days"].ToString().Trim();
                        string levelName = reader["name"].ToString();
                        string major = reader["major"].ToString();
                        string subjectName = reader["Sub_Name"].ToString();

                        // Construct the display string with all the information
                        string displayText = $"{day}, {levelName}, {major}, {subjectName}";

                        // Split the days into individual day names using ","
                        string[] dayArray = day.Split(',');

                        foreach (string singleDay in dayArray)
                        {
                            string trimmedDay = singleDay.Trim();
                            if (!string.IsNullOrEmpty(trimmedDay))
                            {
                                // Add each combination as a separate selection
                                courseComboBox.Items.Add($"{trimmedDay}, {levelName}, {major}, {subjectName}");
                            }
                        }
                    }
                }

                // Check if the student has additional data in the "more" column
                string moreData = GetMoreDataForStudent(studentId);
                if (!string.IsNullOrEmpty(moreData))
                {
                    // Split the "more" data into level_id and sub_id
                    string[] ids = moreData.Split('|');
                    if (ids.Length == 2)
                    {
                        int levelId = int.Parse(ids[0].Trim());
                        int subId = int.Parse(ids[1].Trim());

                        // Fetch additional course information based on level_id and sub_id
                        string additionalCourseInfo = GetAdditionalCourseInfo(levelId, subId);
                        if (!string.IsNullOrEmpty(additionalCourseInfo))
                        {
                            courseComboBox.Items.Add(additionalCourseInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetMoreDataForStudent(int studentId)
        {
            string query = "SELECT more FROM student WHERE Student_ID = @StudentID";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StudentID", studentId);

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private string GetAdditionalCourseInfo(int levelId, int subId)
        {
            string query = @"
        SELECT subject.days, levels.name, levels.major, subject.Sub_Name
        FROM subject
        INNER JOIN levels ON levels.ID = subject.Level_ID
        WHERE subject.Level_ID = @LevelID AND subject.Sub_ID = @SubID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LevelID", levelId);
            cmd.Parameters.AddWithValue("@SubID", subId);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string day = reader["days"].ToString().Trim();
                        string levelName = reader["name"].ToString();
                        string major = reader["major"].ToString();
                        string subjectName = reader["Sub_Name"].ToString();


                        string displayText = $"{day}, {levelName}, {major}, {subjectName}";

                        // Split the days into individual day names using ","
                        string[] dayArray = day.Split(',');

                        foreach (string singleDay in dayArray)
                        {
                            string trimmedDay = singleDay.Trim();
                            if (!string.IsNullOrEmpty(trimmedDay))
                            {
                                // Add each combination as a separate selection
                                courseComboBox.Items.Add($"{trimmedDay}, {levelName}, {major}, {subjectName}");
                            }

                    }}
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }





        private void btnAttend_Click(object sender, EventArgs e)
        {
            string studentName = TextAttendance.Text.Trim();
            string selectedDisplayText = courseComboBox.SelectedItem.ToString();

            // Extract the subject name from the selected display text
            string selectedCourse = selectedDisplayText.Split(',')[3].Trim();

            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(selectedDisplayText))
            {
                MessageBox.Show("Please enter a member name and select a section.");
                return;
            }

            // Check if the student exists in the database
            int studentId = FindStudentIdByName(studentName);
            if (studentId == -1)
            {
                MessageBox.Show("member not found in the database.");
                return;
            }

            // Insert attendance record
            InsertAttendanceRecord(studentId, selectedCourse);
        }


        private int FindStudentIdByName(string studentName)
        {
            string query = "SELECT Student_ID FROM student WHERE Full_Name = @Name";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", studentName);

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return -1;
        }

private void InsertAttendanceRecord(int studentId, string course)
{
    string selectedDay = courseComboBox.SelectedItem.ToString().Split(',')[0].Trim(); // Extract the selected day
    string query = "INSERT INTO attendance (Stu_ID, Date, Sub_ID, Time, day_week) VALUES (@StuID, @Date, @SubID, @Time, @DayOfWeek)";
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.Parameters.AddWithValue("@StuID", studentId);
    cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd/MM/yyyy"));
    cmd.Parameters.AddWithValue("@SubID", GetSubjectId(course));
    cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("HH:mm:ss"));
    cmd.Parameters.AddWithValue("@DayOfWeek", selectedDay); // Insert the selected day

    try
    {
        cmd.ExecuteNonQuery();
        MessageBox.Show("Attendance recorded successfully.");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}

        private int GetSubjectId(string course)
        {
            string query = "SELECT Sub_ID FROM subject WHERE Sub_Name = @Course";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Course", course);

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentName = TextAttendance.Text.Trim();
            string selectedDisplayText = courseComboBox.SelectedItem.ToString();

            // Extract the subject name from the selected display text
            string selectedCourse = selectedDisplayText.Split(',')[3].Trim();

            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(selectedDisplayText))
            {
                MessageBox.Show("Please enter a member name and select a section.");
                return;
            }

            // Check if the student exists in the database
            int studentId = FindStudentIdByName(studentName);
            if (studentId == -1)
            {
                MessageBox.Show("member not found in the database.");
                return;
            }

            // Insert absent record
            InsertAbsentRecord(studentId, selectedCourse);
        }




        private void InsertAbsentRecord(int studentId, string course)
        {
            string selectedDay = courseComboBox.SelectedItem.ToString().Split(',')[0].Trim(); // Extract the selected day
            string query = "INSERT INTO absent (Stu_ID, Date, Sub_ID, day_week) VALUES (@StuID, @Date, @SubID, @DayOfWeek)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StuID", studentId);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@SubID", GetSubjectId(course));
            cmd.Parameters.AddWithValue("@DayOfWeek", selectedDay); // Insert the selected day

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Absent recorded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string studentName = TextAttendance.Text.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter a member name.");
                return;
            }

            int studentId = FindStudentIdByName(studentName);
            if (studentId == -1)
            {
                MessageBox.Show("member not found in the database.");
                return;
            }

            // Populate the courses for the selected student
            PopulateCoursesForStudent(studentId);

            // Populate the ListView with student information
            PopulateStudentListView(studentId);
        }



        private void PopulateStudentListView(int studentId)
        {
            listView1.Items.Clear();

            string query = @"
        SELECT student.Student_ID, student.Full_Name, levels.name AS LevelName, levels.Major AS LevelMajor, subject.Sub_Name
        FROM student
        INNER JOIN subject ON student.Sub_ID = subject.Sub_ID
        INNER JOIN levels ON levels.ID = subject.Level_ID
        WHERE student.Student_ID = @StudentID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StudentID", studentId);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Student_ID"].ToString());
                        item.SubItems.Add(reader["Full_Name"].ToString());
                        item.SubItems.Add(reader["LevelName"].ToString());
                        item.SubItems.Add(reader["LevelMajor"].ToString()); // Add level.name
                                                                           // Add level.name
                        item.SubItems.Add(reader["Sub_Name"].ToString()); // Add subject.sub_name
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ScheduleLabel_Click(object sender, EventArgs e)
        {

        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
