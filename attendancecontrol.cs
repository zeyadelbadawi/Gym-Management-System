using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using MySql.Data.MySqlClient;


namespace new_project1
{
    public partial class attendancecontrol : UserControl
    {
        private bool noDataFound = false; // Add this variable

        public class level
        {
            public int id;
            public string name;
            public string major;
        }
        public class Subject
        {
            public int Sub_ID;
            public string Sub_Name;
        }        
        Connection_DB db = new Connection_DB();
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        MySqlConnection conn = null;
        List<level> levels = new List<level>();
        List<Subject> subjects = new List<Subject>();
        List<Subject> yy = new List<Subject>(); // Declare the 'yy' list here.

        public DataTable infoo = new DataTable();
       // public string x;
        public attendancecontrol()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
            materialComboBox5.Items.Add("Attendance Report ");
            materialComboBox5.Items.Add("Absent Report ");
     //       this.listView1.BackColor = Color.FromArgb(128, 128, 128, 128); // 50% transparent gray

            textBox1.Visible = false;
            materialLabel2.Visible = false;


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
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
                materialComboBox1.Items.Add(pnn.name + " " + pnn.major);
            }

            conn.Close();
        }
        private bool buttonClicked = false;

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjects.Clear();
            materialComboBox3.Items.Clear();
            materialComboBox4.Items.Clear(); 
            textBox1.Clear();
            RetreveAllSubject(levels[materialComboBox1.SelectedIndex].id);
                      
            
        }
        public void RetreveAllSubject(int LevelID)
        {
            conn.Open();

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

            yy.Clear(); // Clear the yy list before adding new items.

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Subject pnn = new Subject();
                pnn.Sub_ID = Convert.ToInt32(dt.Rows[i][0]);
                pnn.Sub_Name = dt.Rows[i][1].ToString();
                materialComboBox3.Items.Add(pnn.Sub_Name);
                yy.Add(pnn); // Add the Subject object to the yy list.
            }

            conn.Close();
        }


        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialComboBox4.Items.Clear();
            materialComboBox4.Items.Add("Saturday");
            materialComboBox4.Items.Add("Sunday");
            materialComboBox4.Items.Add("Monday");
            materialComboBox4.Items.Add("Tuesday");
            materialComboBox4.Items.Add("Wednesday");
            materialComboBox4.Items.Add("Thursday");
            materialComboBox4.Items.Add("Friday");
        }


        public DataTable search(string selectedDay, int subID, string Date)
        {
            conn.Open();
            query = "SELECT st.Student_ID, st.Full_Name, a.day_week, a.time, a.Date FROM Attendance a, Student st WHERE st.Student_ID = a.Stu_ID AND a.day_week = @selectedDay AND a.Date = @Date";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@subID", subID);
            cmd.Parameters.AddWithValue("@selectedDay", selectedDay);
            cmd.Parameters.AddWithValue("@Date", Date);

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

            conn.Close();
            if (dt.Rows.Count == 0)
            {
                noDataFound = true;
            }
            else
            {
                noDataFound = false;
            }
            return dt;
        }

        public DataTable search2(string selectedDay, int subID, string Date)
        {
            conn.Open();
            query = "SELECT st.Student_ID, st.Full_Name, a.day_week, a.time, a.Date FROM absent a, Student st WHERE st.Student_ID = a.Stu_ID AND a.day_week = @selectedDay AND a.Date = @Date";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@subID", subID);
            cmd.Parameters.AddWithValue("@selectedDay", selectedDay);
            cmd.Parameters.AddWithValue("@Date", Date);

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

            conn.Close();
            if (dt.Rows.Count == 0)
            {
                noDataFound = true;
            }
            else
            {
                noDataFound = false;
            }
            return dt;
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Set the buttonClicked flag to true
            buttonClicked = true;

            bool jj = true;

            if (materialComboBox1.SelectedIndex != -1 && materialComboBox3.SelectedIndex != -1 && materialComboBox4.SelectedIndex != -1 && materialComboBox5.SelectedIndex != -1)
            {
                if (materialComboBox5.SelectedIndex == 0)
                {
                    int subID = yy[materialComboBox3.SelectedIndex].Sub_ID;
                    string selectedDay = materialComboBox4.SelectedItem.ToString();
                    string Date = textBox1.Text;

                    infoo = search(selectedDay, subID, Date);
                    if (noDataFound)
                    {
                        MessageBox.Show("No data found for the selected criteria.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        listView1.Items.Clear();
                    string[] we = new string[infoo.Columns.Count];
                    for (int i = 0; i < infoo.Rows.Count; i++)
                    {
                        for (int j = 0; j < infoo.Columns.Count; j++)
                        {
                            we[j] = infoo.Rows[i][j].ToString();
                        }
                        listView1.Items.Add(new ListViewItem(we));
                    }
                    materialComboBox4.SelectedIndex = -1;
                }
                    }       
                else if (materialComboBox5.SelectedIndex == 1)
                {

                    int subID = subjects[materialComboBox3.SelectedIndex].Sub_ID;
                    string selectedDay = materialComboBox4.SelectedItem.ToString();
                    string Date = textBox1.Text;

                    infoo = search2(selectedDay, subID, Date);
                    if (noDataFound)
                    {
                        MessageBox.Show("No data found for the selected criteria.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        listView1.Items.Clear();
                    string[] we = new string[infoo.Columns.Count];
                    for (int i = 0; i < infoo.Rows.Count; i++)
                    {
                        for (int j = 0; j < infoo.Columns.Count; j++)
                        {
                            we[j] = infoo.Rows[i][j].ToString();
                        }
                        listView1.Items.Add(new ListViewItem(we));
                    }
                }
                     }

            }
            else
            {
                if (materialComboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Your Type of Data That You Want to Retrieve ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (materialComboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select class ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (materialComboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select section ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (infoo.Rows.Count == 0)
                {
                    //MessageBox.Show("this date isn't exist  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    jj = false;
                }
                if (jj == true)
                {
                    if (materialComboBox4.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Select Day ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text.Length == 0)
                    {
                        MessageBox.Show("Please Select Date ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ResetControls();

            }
        }

        private void ResetControls()
        {
            textBox1.Text = string.Empty;
            materialComboBox1.SelectedIndex = -1;
            materialComboBox3.SelectedIndex = -1;
            materialComboBox4.SelectedIndex = -1;
            materialComboBox5.SelectedIndex = -1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            excelsheet abuio=  new excelsheet();
            abuio.abuio(listView1);
        }

        private void attendancecontrol_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _TextChanged(object sender, EventArgs e)
        {

        }
        private void materialComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }




        private void materialComboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (materialComboBox5.SelectedIndex == 0)
            {
                // Show textbox1 when the first selection is made
                textBox1.Visible = true;
                materialLabel2.Visible = true;
            }
            else
            {
                // Hide textbox1 for other selections
                textBox1.Visible = false;
                materialLabel2.Visible = false;
            }
        }

    }
    }
