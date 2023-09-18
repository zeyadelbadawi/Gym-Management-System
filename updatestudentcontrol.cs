using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using MySql.Data.MySqlClient;
using new_project1.classes;

namespace new_project1
{
    public partial class updatestudentcontrol : UserControl
    {
        public class level
        {
            public int id;
            public string name;
            public string major;
        }

        List<int> subjectIDs = new List<int>();
        List<int> levelIDs = new List<int>();
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        List<level> levels = new List<level>();
        List<SelectSubject> Subs = new List<SelectSubject>();
        private bool materialButton1Clicked = false;
        private bool ButUpdateStudentClicked = false;

        public updatestudentcontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
            materialComboBox2.Items.Add("Member ID");
            materialComboBox2.Items.Add("Member Barcode");
            listView1.Columns.Add("MemberID", 70);
            listView1.Columns.Add("MemberName", 190);
            listView1.Columns.Add("Phone", 130);
            listView1.Columns.Add("Level", 120);
            listView1.Columns.Add("section", 120);
            listView1.Columns.Add("Barcode", 120);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("Registeration date", 180);
            MoreComboBoxsection.Visible = false;
            MoreComboBoxLevel.Visible = false;
            materialLabel3.Visible = false;
            materialLabel4.Visible = false;
            ButUpdateStudent.Enabled = false;
            materialButton2.Enabled = false;
        


        }

        public void SelectSubjectNameFromLevelID(int id)
        {
            conn.Open();
            query = "SELECT Sub_ID,Sub_Name FROM Subject where Level_ID = '" + id + "'";
            cmd = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            try
            {
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SelectSubject pnn = new SelectSubject();
                    pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                    pnn.name = dt.Rows[i][1].ToString();
                    Subs.Add(pnn);
                    ComboBoxsectioon.Items.Add(pnn.name);
                    MoreComboBoxsection.Items.Add(pnn.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void materialComboSection_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBoxsectioon.SelectedIndex >= 0)
            {
                SelectSubjectNameFromLevelID(Subs[ComboBoxsectioon.SelectedIndex].id);
            }

        }


        private void ComboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLevel.SelectedIndex >= 0)
            {
                ComboBoxsectioon.Items.Clear();
                Subs.Clear();
                SelectSubjectNameFromLevelID(levels[ComboBoxLevel.SelectedIndex].id);

                // Enable the materialComboSection and set its selected index to -1
                ComboBoxsectioon.Enabled = true;
                ComboBoxsectioon.SelectedIndex = -1;
            }
            else
            {
                // If no level is selected, disable the materialComboSection
                ComboBoxsectioon.Enabled = false;
            }
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
                if (i == 0)
                {
                    levels.Clear();
                    ComboBoxLevel.Items.Clear();
                    MoreComboBoxLevel.Items.Clear();

                }
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
            
                
                ComboBoxLevel.Items.Add(pnn.name + " " + pnn.major);
                MoreComboBoxLevel.Items.Add(pnn.name + " " + pnn.major);

            }


            conn.Close();
        }
        private void updatestudentcontrol_Load(object sender, EventArgs e)
        {

        }

      

        private void TextStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public List<string> Information = new List<string>();
        public bool StudentFind = false;
        public string levelname = null;
        private void TextStudentID_TextChanged(object sender, EventArgs e)
        {
            TextStudentName.Clear();
            TextStudentPhone.Clear();
            student_levels.Items.Clear();
            if (TextStudentID.Text.Length > 0)
            {
                SelectAllLevel();
            }
            if (int.TryParse(TextStudentID.Text, out int studentID))
            {
                // Populate student_levels and student_subjects based on the student ID
                PopulateStudentLevels(studentID);
            }
            Ratio_btnMale.Checked = false;
            Ratio_btnFemale.Checked = false;
            ComboBoxLevel.SelectedIndex = -1;
            ComboBoxsectioon.SelectedIndex = -1;
            MoreComboBoxLevel.SelectedIndex = -1;
            MoreComboBoxsection.SelectedIndex = -1;
            Information.Clear();
            conn.Open();
            try
            {
                if (materialComboBox2.SelectedIndex == 0)
                {
                    if (CheackStudent(Convert.ToInt32(TextStudentID.Text)))
                    {
                        StudentFind = true;
                        TextStudentName.Text = Information[1];
                        TextStudentPhone.Text = Information[2];
                        
                        // materialComboBox2.Items.Add (Information[6]);
                        for (int i = 0; i < ComboBoxLevel.Items.Count; i++)
                        {
                            if (Information[7] != " " && Information[7] != null && Information[7] != "")
                            {
                                if (ComboBoxLevel.Items[i].ToString() == Information[3] + " " + Information[7])
                                {
                                    ComboBoxLevel.SelectedIndex = i;
                                    break;
                                }
                            }
                            else if (ComboBoxLevel.Items[i].ToString() == Information[3] + " ")
                            {
                                ComboBoxLevel.SelectedIndex = i;
                                break;
                            }

                        }



                        if (Information[6] == "Male" || Information[6] == "male")
                        {
                            Ratio_btnMale.Checked = true;
                        }
                        if (Information[6] == "Female" || Information[6] == "female")
                        {
                            Ratio_btnFemale.Checked = true;
                        }

                        for (int i = 0; i < levels.Count; i++)
                        {
                            if (Information[7] == levels[i].name)
                            {
                                ComboBoxLevel.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        StudentFind = false;
                    }
                }
                if (materialComboBox2.SelectedIndex == 1)
                {
                    if (CheackStudentbybarcode(TextStudentID.Text.ToString()))
                    {
                        StudentFind = true;
                        TextStudentName.Text = Information[1];
                        TextStudentPhone.Text = Information[2];
                        
                        for (int i = 0; i < ComboBoxLevel.Items.Count; i++)
                        {
                            if (Information[7] != " " && Information[7] != null && Information[7] != "")
                            {
                                if (ComboBoxLevel.Items[i].ToString() == Information[3] + " " + Information[7])
                                {
                                    ComboBoxLevel.SelectedIndex = i;
                                    break;
                                }
                            }
                            else if (ComboBoxLevel.Items[i].ToString() == Information[3] + " ")
                            {
                                ComboBoxLevel.SelectedIndex = i;
                                break;
                            }

                        }
                        

                        if (Information[6] == "Male" || Information[6] == "male")
                        {
                            Ratio_btnMale.Checked = true;
                        }
                        if (Information[6] == "Female" || Information[6] == "female")
                        {
                            Ratio_btnFemale.Checked = true;
                        }

                        for (int i = 0; i < levels.Count; i++)
                        {
                            if (Information[7] == levels[i].name)
                            {
                                ComboBoxLevel.SelectedIndex = i;
                                break;
                            }

                        }
                    }
                    else
                    {
                        StudentFind = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();

        }

        public bool CheackStudentbybarcode(string barcod)
        {

            query = "SELECT Student.Student_ID  ,Student.Full_Name  ,Student.phone  ,Levels.Name  ,Student.Major ,Student.bar_code  ,Student.Gender ,Student.date,Levels.Major  FROM Student JOIN Levels ON Levels.ID = Student.Level_ID WHERE bar_code ='" + barcod + "' ";

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
                listView1.Items.Clear();
                string[] x = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j + 2 == dt.Columns.Count)
                        {

                            string[] t = dt.Rows[i][j].ToString().Split(' ');
                            x[j] = t[0];
                        }
                        else
                        {
                            Information.Add(dt.Rows[i][j].ToString());
                            x[j] = dt.Rows[i][j].ToString();
                        }
                    }
                    listView1.Items.Add(new ListViewItem(x));
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheackStudent(int StudentID)
        {

            query = "SELECT Student.Student_ID  ,Student.Full_Name  ,Student.phone ,student.sub_ID ,Levels.Name  ,Student.bar_code  ,Student.Gender ,Student.date, Levels.Major  FROM Student JOIN Levels ON Levels.ID = Student.Level_ID WHERE Student_ID ='" + StudentID + "' ";

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
                listView1.Items.Clear();
                string[] x = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j + 2 == dt.Columns.Count)
                        {

                            string[] t = dt.Rows[i][j].ToString().Split(' ');
                            x[j] = t[0];
                        }
                        else
                        {
                            Information.Add(dt.Rows[i][j].ToString());
                            x[j] = dt.Rows[i][j].ToString();
                        }

                    }
                    listView1.Items.Add(new ListViewItem(x));
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GendarSelected = false;
        public string GanderName = null;

        private void ButUpdateStudent_Click(object sender, EventArgs e)
        {
            insert.Enabled = true;
            materialButton1Clicked = true;
            materialButton2.Enabled = false;
            ButUpdateStudent.Enabled = false;



            conn.Open();
            if (TextStudentID.Text.Length > 0 && StudentFind)
            {

                if (TextStudentName.Text.Length > 0 && TextStudentPhone.Text.Length > 0 && ComboBoxLevel.SelectedIndex != -1 && ComboBoxsectioon.SelectedIndex != -1)
                {
                    UpdateOnStudentTable(Convert.ToInt32(TextStudentID.Text), TextStudentName.Text, Convert.ToInt32(TextStudentPhone.Text), GanderName, levels[ComboBoxLevel.SelectedIndex].id, Subs[ComboBoxsectioon.SelectedIndex].id);
                    if (materialComboBox2.SelectedIndex == 0)
                    {
                        CheackStudent(Convert.ToInt32(TextStudentID.Text));
                    }
                    if (materialComboBox2.SelectedIndex == 1)
                    {
                        CheackStudentbybarcode(TextStudentID.Text);
                    }
                }
                else
                {
                    if (TextStudentName.Text.Length == 0)
                    {
                        MessageBox.Show("Please enter Member Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (TextStudentPhone.Text.Length == 0)
                    {
                        MessageBox.Show("Please enter Member Phone.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    if (ComboBoxLevel.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select class.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ComboBoxsectioon.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select section.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                if (TextStudentID.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter member ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (StudentFind == false)
                {
                    MessageBox.Show("member Not Found,Please Enter Another member ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        public void UpdateOnStudentTable(int StudentID, string StudentName, int StudentPhone, string Gender, int LevelID, int sub_ID)
        {
            query = "UPDATE Student SET Full_Name = @StudentName, phone = @StudentPhone, Gender = @Gender, Level_ID = @LevelID, sub_ID = @SubjectID WHERE Student_ID = @StudentID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentName", StudentName);
            cmd.Parameters.AddWithValue("@StudentPhone", StudentPhone);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@LevelID", LevelID);
            cmd.Parameters.AddWithValue("@SubjectID", sub_ID);
            cmd.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update member Information Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }


        private void Ratio_btnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (Ratio_btnMale.Checked)
            {
                GanderName = Ratio_btnMale.Text;
            }
        }

        private void Ratio_btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (Ratio_btnFemale.Checked)
            {
                GanderName = Ratio_btnFemale.Text;
            }
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Updateselectstudent_Click(object sender, EventArgs e)
        {


        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel2.Text = "Enter " + materialComboBox2.SelectedItem.ToString();
        }
        
        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MoreComboBoxsection.Items.Clear();
            MoreComboBoxLevel.Items.Clear();
            MoreComboBoxsection.Visible = false;
            MoreComboBoxLevel.Visible = false;
            materialLabel3.Visible = false;
            materialLabel4.Visible = false;
            ButUpdateStudent.Enabled = true;
            materialButton2.Enabled = false;
            insert.Enabled = false;

            materialLabel1.Visible = true;
            Name_Label.Visible = true;
            materialLabel_section.Visible = true;
            Level_Label.Visible = true;
            materialLabel8.Visible = true;
            ComboBoxsectioon.Visible = true;
            ComboBoxLevel.Visible = true;
            TextStudentName.Visible = true;
            TextStudentPhone.Visible = true;
            Ratio_btnFemale.Visible = true;
            Ratio_btnMale.Visible = true;
            student_levels.Visible = false;
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Level_Label_Click(object sender, EventArgs e)
        {

        }

        private void TextStudentSchool_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void School_label_Click(object sender, EventArgs e)
        {

        }

        private void Parent_Label_Click(object sender, EventArgs e)
        {

        }

        private void TextParentPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void TextStudentPhone_TextChanged(object sender, EventArgs e)
        {

        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        List<int> selectedLevelIDs = new List<int>();
        List<int> selectedSubjectIDs = new List<int>();
       private void insert_Click(object sender, EventArgs e)
{
            ComboBoxsectioon.Items.Clear();
            ComboBoxLevel.Items.Clear();
            materialLabel1.Visible = false;
            Name_Label.Visible = false;
            materialLabel_section.Visible = false;
            Level_Label.Visible = false;
            materialLabel8.Visible = false;
            ComboBoxsectioon.Visible = false;
            ComboBoxLevel.Visible = false;
            TextStudentName.Visible = false;
            TextStudentPhone.Visible = false;
            Ratio_btnFemale.Visible = false;
            Ratio_btnMale.Visible = false;
            materialButton1.Enabled = false;
            materialButton2.Enabled = true;
            ButUpdateStudent.Enabled = false;
            student_levels.Visible = false;
            MoreComboBoxsection.Visible = true;
    MoreComboBoxLevel.Visible = true;
    materialLabel3.Visible = true;
    materialLabel4.Visible = true;

    if (MoreComboBoxLevel.SelectedIndex >= 0 && MoreComboBoxsection.SelectedIndex >= 0)
    {
        int selectedLevelID = levels[MoreComboBoxLevel.SelectedIndex].id;
        int selectedSubjectID = Subs[MoreComboBoxsection.SelectedIndex].id;

        selectedLevelIDs.Add(selectedLevelID);
        selectedSubjectIDs.Add(selectedSubjectID);

        MoreComboBoxLevel.SelectedIndex = -1;
        MoreComboBoxsection.SelectedIndex = -1;
    }

}



        private void MoreComboBoxsection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
        private void MoreComboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoreComboBoxLevel.SelectedIndex >= 0)
            {
                MoreComboBoxsection.Items.Clear();
                Subs.Clear();
                SelectSubjectNameFromLevelID(levels[MoreComboBoxLevel.SelectedIndex].id);

                // Enable the MoreComboBoxsection and set its selected index to -1
                MoreComboBoxsection.Enabled = true;
                MoreComboBoxsection.SelectedIndex = -1;
            }
            else
            {
                // If no level is selected, disable the MoreComboBoxsection
                MoreComboBoxsection.Enabled = false;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {        materialButton1.Enabled = true;
            insert.Enabled = true;
            ButUpdateStudentClicked = false;
            materialButton2.Enabled = false;


            if (MoreComboBoxLevel.SelectedIndex >= 0 && MoreComboBoxsection.SelectedIndex >= 0)
            {
                // Get the selected level and subject IDs
                int selectedLevelID = levels[MoreComboBoxLevel.SelectedIndex].id;
                int selectedSubjectID = Subs[MoreComboBoxsection.SelectedIndex].id;

                // Add them to the respective lists
                selectedLevelIDs.Add(selectedLevelID);
                selectedSubjectIDs.Add(selectedSubjectID);

                // Construct the new value for the "alllo" column
                string more = string.Join(",", selectedLevelIDs) + "|" + string.Join(",", selectedSubjectIDs);

                // Update the "alllo" column in the student table
                UpdatemoreColumn(Convert.ToInt32(TextStudentID.Text), more);

                // Clear the selections in MoreComboBoxLevel and MoreComboBoxsection
                MoreComboBoxLevel.SelectedIndex = -1;
                MoreComboBoxsection.SelectedIndex = -1;

                // Show a success message
                MessageBox.Show("New level and subject added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where either MoreComboBoxLevel or MoreComboBoxsection is not selected
                MessageBox.Show("Please select both a New level and a New subject.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdatemoreColumn(int studentID, string more)
        {
            query = "UPDATE Student SET more = @more WHERE Student_ID = @studentID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@more", more);
            cmd.Parameters.AddWithValue("@studentID", studentID);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ComboBoxsectioon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void student_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLevel = student_levels.SelectedItem.ToString();
            int selectedLevelID;

            if (int.TryParse(selectedLevel, out selectedLevelID))
            {
                PopulateStudentLevels(selectedLevelID);
            }
        }

 


        private void PopulateStudentLevels(int studentID)
        {

            // Clear the existing items in the ComboBox
            if (student_levels.SelectedIndex != -1)
            {
                student_levels.Items.Clear();
            }

            // Query to retrieve the level_id and more columns for the selected student
            query = "SELECT level_id, more FROM Student WHERE Student_ID = @studentID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentID", studentID);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Get the level_id from the database
                    int levelID = reader.GetInt32("level_id");

                    // Add the level_id to the ComboBox
                    student_levels.Items.Add(levelID);

                    // Check if there is data in the more column
                    if (!reader.IsDBNull(reader.GetOrdinal("more")))
                    {
                        // Parse the more column data (e.g., "1,2|10,11,12") and extract level IDs
                        string moreData = reader.GetString("more");
                        string[] levelData = moreData.Split('|')[0].Split(',');

                        foreach (string levelIDStr in levelData)
                        {
                            if (int.TryParse(levelIDStr, out int additionalLevelID))
                            {
                                // Add the additional level IDs to the ComboBox
                                student_levels.Items.Add(additionalLevelID);
                            }
                        }
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


      

              

    }
}
