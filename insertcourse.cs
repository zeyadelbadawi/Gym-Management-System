using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class insertcourse : UserControl
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
        public insertcourse()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            conn.Open();
            SelectAllLevel();
            conn.Close();
        }
        public void SelectAllLevel()
        {
            query = "SELECT * FROM Levels";
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
                    ComboBoxSubjectLevel.Items.Clear();


                }
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                ComboBoxSubjectLevel.Items.Add(pnn.name + " " + pnn.major);
                levels.Add(pnn);
            }

        }
        private void Courses_Click(object sender, EventArgs e)
        {

        }

        private void insertcourse_Load(object sender, EventArgs e)
        {

        }

        private void ButAddSubject_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Check if TextSubjectName has data, ComboBoxSubjectLevel is selected, and checkedListBox1 has selected items
            if (TextSubjectName.Text.Length > 0 && ComboBoxSubjectLevel.SelectedIndex != -1 && checkedListBox1.CheckedItems.Count > 0)
            {
                if (CheckNewSubjectIsNotAdded(TextSubjectName.Text, levels[ComboBoxSubjectLevel.SelectedIndex].id))
                {
                    MessageBox.Show("This section is already added, please enter another section", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert the subject into the Subject table
                    InsertInToTableSubject(TextSubjectName.Text, levels[ComboBoxSubjectLevel.SelectedIndex].id);

                    // Save selected items from checkedListBox1 into the "days" column
                    SaveSelectedDays(TextSubjectName.Text);

                    MessageBox.Show("New section added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Display error messages for missing data
                if (TextSubjectName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter section", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ComboBoxSubjectLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select level", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one day", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            conn.Close();
        }


        private void SaveSelectedDays(string subjectName)
        {
            // Get the selected items from checkedListBox1
            List<string> selectedDays = new List<string>();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedDays.Add(item.ToString());
            }

            // Combine the selected days into a single string (e.g., "Monday,Wednesday,Friday")
            string daysString = string.Join(",", selectedDays);

            // Update the "days" column in the Subject table with the selected days
            string updateQuery = "UPDATE Subject SET days = @days, num_of_days = @numOfDays WHERE Sub_Name = @subjectName";
            MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@days", daysString);
            updateCmd.Parameters.AddWithValue("@numOfDays", selectedDays.Count); // Save the count of selected days
            updateCmd.Parameters.AddWithValue("@subjectName", subjectName);

            try
            {
                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckNewSubjectIsNotAdded(string SubjectName, int LevelID)
        {
            query = "SELECT * FROM Subject WHERE Sub_Name ='" + SubjectName + "' AND Level_ID='" + LevelID + "' ";
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
        public void InsertInToTableSubject(string SubjectName, int LevelID)
        {
            query = "INSERT INTO Subject(Sub_Name,Level_ID) VALUES('" + SubjectName + "','" + LevelID + "') ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
             //   MessageBox.Show("New section added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
      

        private void TextSubjectName_TextChanged_1(object sender, EventArgs e)
        {
            if (TextSubjectName.Text.Length == 0)
            {
                ComboBoxSubjectLevel.Enabled = false;
                checkedListBox1.Enabled = false;

            }
            else
            {
                ComboBoxSubjectLevel.Enabled = true;
                conn.Open();
                SelectAllLevel();
                conn.Close();
            }
        }


        private void ComboBoxSubjectLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if ComboBoxSubjectLevel is selected
            if (ComboBoxSubjectLevel.SelectedIndex != -1)
            {
                // Enable the checkedListBox1
                checkedListBox1.Enabled = true;
            }
            else
            {
                // Disable the checkedListBox1
                checkedListBox1.Enabled = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
