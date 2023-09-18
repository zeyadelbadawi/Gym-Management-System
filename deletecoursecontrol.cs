using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class deletecoursecontrol : UserControl
    {
        public class Subject
        {
            public int Sub_ID;
            public string Sub_name;
            public int Level_ID;
        }
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        List<Subject> subjects = new List<Subject>();
        public deletecoursecontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            conn.Open();
            RetreveAllSubject();
            conn.Close();
        }
        public string SelectLevelName(int LevelID)
        {

            string query = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter da = null;
            DataTable dt = null;

            query = "SELECT Name,Major FROM Levels WHERE ID ='" + LevelID + "' ";
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
                return dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
            }
            else
            {
                return null;
            }
        }
        public void RetreveAllSubject()
        {
            string query = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter da = null;
            DataTable dt = null;

            query = "SELECT * FROM Subject ";
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
                Subject pnn = new Subject();
                pnn.Sub_ID = Convert.ToInt32(dt.Rows[i][0]);
                pnn.Sub_name = dt.Rows[i][1].ToString();
                pnn.Level_ID = Convert.ToInt32(dt.Rows[i][2]);
                string levelnameandMejor = SelectLevelName(pnn.Level_ID);
                ComboBoxSubject.Items.Add(pnn.Sub_name + " " + levelnameandMejor);
                subjects.Add(pnn);
            }

        }
        private void ButDeleteSubject_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (ComboBoxSubject.SelectedIndex != -1)
            {
                DeleteFromSubjectTable(subjects[ComboBoxSubject.SelectedIndex].Sub_ID);
                RetreveAllSubject();

            }
            else
            {
                MessageBox.Show("Please select section", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void DeleteFromSubjectTable(int SubjectID)
        {
            string query = null;
            query = "DELETE FROM Subject WHERE Sub_ID='" + SubjectID + "'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("section deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void ComboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            subjects.Clear();
            ComboBoxSubject.Items.Clear();
            conn.Open();
            RetreveAllSubject();
            conn.Close();
        }
    }
}
