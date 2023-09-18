using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class updatecourseControl : UserControl
    {
        public class Level
        {
            public int ID;
            public string Name;
            public string Major;
        }
        public class Subject
        {
            public int Sub_ID;
            public string Sub_Name;

        }

        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        List<Level> levels = new List<Level>();
        List<Subject> subjects = new List<Subject>();

        public updatecourseControl()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            conn.Open();
            RetreveAllLevel();
            conn.Close();

            checkedListBox1.Enabled = true;

        }
        public void RetreveAllSubject(int LevelID)
        {
            conn.Open();
            string query = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter da = null;
            DataTable dt = null;

            query = "SELECT * FROM Subject WHERE Level_ID ='" + LevelID + "' ";
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
                    subjects.Clear();
                    ComboBoxSelectedSubject.Items.Clear();
                }
                Subject pnn = new Subject();
                pnn.Sub_ID = Convert.ToInt32(dt.Rows[i][0]);
                pnn.Sub_Name = dt.Rows[i][1].ToString();
                ComboBoxSelectedSubject.Items.Add(pnn.Sub_Name);
                subjects.Add(pnn);
            }
            conn.Close();
        }

        public void RetreveAllLevel()
        {

            string query2 = null;
            MySqlCommand cmd2 = null;
            MySqlDataAdapter da2 = null;
            DataTable dt2 = null;

            query2 = "SELECT * FROM Levels ";
            cmd2 = new MySqlCommand(query2, conn);
            da2 = new MySqlDataAdapter(cmd2);
            dt2 = new DataTable();
            da2.Fill(dt2);

            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if(i==0)
                {
                    levels.Clear();
                    ComboBoxLevels.Items.Clear();
                }
                Level pnn = new Level();
                pnn.ID = Convert.ToInt32(dt2.Rows[i][0]);
                pnn.Name = dt2.Rows[i][1].ToString();
                pnn.Major = dt2.Rows[i][2].ToString();
                levels.Add(pnn);
                ComboBoxNewSubjectLevel.Items.Add(pnn.Name + " " + pnn.Major);
                ComboBoxLevels.Items.Add(pnn.Name + " " + pnn.Major);
            }

        }
        private void ButUpdateSubject_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (ComboBoxLevels.SelectedIndex != -1 && ComboBoxSelectedSubject.SelectedIndex != -1 && TextNewSubjectName.Text.Length > 0 && ComboBoxNewSubjectLevel.SelectedIndex != -1)
            {
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    UpdateInToSujectTable(TextNewSubjectName.Text, levels[ComboBoxNewSubjectLevel.SelectedIndex].ID, subjects[ComboBoxSelectedSubject.SelectedIndex].Sub_ID);

                    string selectedItems = string.Join(",", checkedListBox1.CheckedItems.Cast<string>());
                    SaveSelectedItemsToDatabase(selectedItems);

                   // MessageBox.Show("Update in section done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select at least one item in the checklist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ComboBoxLevels.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ComboBoxSelectedSubject.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (TextNewSubjectName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a section name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ComboBoxNewSubjectLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a new section class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }


        private void SaveSelectedItemsToDatabase(string selectedItems)
        {
            // Update the 'days' and 'num_of_days' columns in the database with the selected items
            string query = "UPDATE Subject SET days = @selectedItems, num_of_days = @numOfDays WHERE Sub_ID = @subjectID";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@selectedItems", selectedItems);
                cmd.Parameters.AddWithValue("@numOfDays", checkedListBox1.CheckedItems.Count);
                cmd.Parameters.AddWithValue("@subjectID", subjects[ComboBoxSelectedSubject.SelectedIndex].Sub_ID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update in section done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateInToSujectTable(string SubjectName, int LevelID, int SubjectID)
        {
            string query = null;

            query = " UPDATE Subject SET Sub_Name = '" + SubjectName + "', Level_ID = '" + LevelID + "'  WHERE Sub_ID = '" + SubjectID + "' ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Update in section done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
                subjects.Clear();                
                ComboBoxSelectedSubject.Items.Clear();
                RetreveAllSubject(levels[ComboBoxLevels.SelectedIndex].ID);




        }

        private void ComboBoxSelectedSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextNewSubjectName.Clear();

            TextNewSubjectName.Text = subjects[ComboBoxSelectedSubject.SelectedIndex].Sub_Name;
        }

        private void updatecourseControl_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            RetreveAllLevel();
            conn.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void TextNewSubjectName_TextChanged(object sender, EventArgs e)
        {
        }




    }
}
