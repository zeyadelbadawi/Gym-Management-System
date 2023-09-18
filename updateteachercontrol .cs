using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class updateteachercontrol : UserControl
    {
        public class level
        {
            public int id;
            public string name;
            public string major;
        }
        public class Subject
        {
            public int Sub_ID;
            public string Sub_name;
            public int Level_ID;
        }
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        List<level> levels = new List<level>();
        List<Subject> subjects = new List<Subject>();
        public updateteachercontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
            conn.Open();
            SelectIformationOfteacher();
            conn.Close();
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
                    ComboBoxLevels.Items.Clear();
                }
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
                ComboBoxLevels.Items.Add(pnn.name + " " + pnn.major);
            }
            
            conn.Close();
        }
        public void SelectSubjectByLevelID(int LevelID)
        {
            conn.Open();

            query = "SELECT * FROM Subject WHERE Level_ID='" + LevelID + "'";
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
                    if(i==0)
                    {
                        subjects.Clear();
                        ComboBoxSubjects.Items.Clear();
                    }
                    Subject pnn = new Subject();
                    pnn.Sub_ID = Convert.ToInt32(dt.Rows[i][0]);
                    pnn.Sub_name = dt.Rows[i][1].ToString();
                    pnn.Level_ID = Convert.ToInt32(dt.Rows[i][2]);
                    subjects.Add(pnn);
                    ComboBoxSubjects.Items.Add(pnn.Sub_name);
                }
            }
            else
            {
                //ComboBoxSubjects.Items.Add("");
            }

            conn.Close();
        }


        private void TextTeacherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
         public bool checkteachersubject(int teacherid,int subid)
        {
            query = "SELECT *from Teacher_Subject where Tch_ID='"+teacherid+"' AND Sub_ID='"+subid+"'";
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
            if(dt.Rows.Count>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ButAddSubject_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (TextTeacherID.Text.Length > 0 && ComboBoxLevels.SelectedIndex != -1 && ComboBoxSubjects.SelectedIndex != -1)
            {
                //check teacher ID and retreve subject by level 
                if (SelectTeacherByID(Convert.ToInt32(TextTeacherID.Text)))
                {
                    if(checkteachersubject(Convert.ToInt32(TextTeacherID.Text), subjects[ComboBoxSubjects.SelectedIndex].Sub_ID))
                    {
                        InsertInToTableTeacherSubject(Convert.ToInt32(TextTeacherID.Text), subjects[ComboBoxSubjects.SelectedIndex].Sub_ID);
                    }
                    else
                    {
                        MessageBox.Show("Coach already register this section,please select another", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //MessageBox.Show("Teacher Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(Convert.ToInt32(TextTeacherID.Text) + "///" + subjects[ComboBoxSubjects.SelectedIndex].Sub_ID+"***"+ subjects[ComboBoxSubjects.SelectedIndex].Level_ID);
                }
                else
                {
                    MessageBox.Show("Coach not found,Please enter Try different ID!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Coach ID Or select class Or select section ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SelectIformationOfteacher();
            conn.Close();
        }
        public void SelectIformationOfteacher()
        {


            //  query = " SELECT t.ID,t.Full_Name,j.Sub_Name,l.Name From Teacher_Subject ts Join Subject j on ts.Sub_ID = j.Sub_ID Join Teacher t on ts.Tch_ID = t.ID join Levels l on j.Level_ID = l.ID  ";
            query = "Select t.ID,t.Full_Name,j.Sub_Name,l.Name,l.Major From Teacher_Subject ts join Subject j on ts.Sub_ID = j.Sub_ID join Levels l on j.Level_ID = l.ID right OUTER JOIN Teacher t on ts.Tch_ID = t.ID";           
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
                        x[j] = dt.Rows[i][j].ToString();

                    }
                    listView1.Items.Add(new ListViewItem(x));

                }

            }

            else
            {
                
            }        
        }

        public bool SelectTeacherByID(int TeacherID)
        {
            query = "SELECT * FROM Teacher WHERE ID ='" + TeacherID + "' ";
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

        public void InsertInToTableTeacherSubject(int TeacherID, int SubjectID)
        {


            query = "INSERT INTO Teacher_Subject(Tch_ID,Sub_ID) VALUES('" + TeacherID + "','" + SubjectID + "') ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added  coach successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ComboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLevels.SelectedIndex != -1)
            {
                SelectSubjectByLevelID(levels[ComboBoxLevels.SelectedIndex].id);
             //   MessageBox.Show("**" + levels.Count + "**" + ComboBoxLevels.SelectedIndex);              
            }

        }
        private void updateteachercontrol_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void TextTeacherID_TextChanged(object sender, EventArgs e)
        {
            if (TextTeacherID.Text.Length == 0)
            {
                ComboBoxLevels.Enabled = false;
                ComboBoxSubjects.Enabled = false;
            }
            else
            {
                ComboBoxLevels.Enabled = true;
                ComboBoxSubjects.Enabled = true;
                SelectAllLevel();               
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            SelectIformationOfteacher();           
            conn.Close();
            SelectAllLevel();
        }
    }
}
