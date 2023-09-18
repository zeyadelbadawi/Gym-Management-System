using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ZXing;
using new_project1.classes;

namespace new_project1
{
    public partial class InsertStudentControl : UserControl
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
        List<SelectSubject> Subs = new List<SelectSubject>();

        string Path = "";
        public string gh;
        Random rr = new Random();

        public InsertStudentControl()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            SelectAllLevel();
            //  listView1.Show();
            listView1.Columns.Add("MemberID", 70);
            listView1.Columns.Add("MemberName", 190);
            listView1.Columns.Add("Phone", 130);
            listView1.Columns.Add("Level", 120);
            listView1.Columns.Add("section", 120);
            listView1.Columns.Add("Barcode", 120);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("Registeration date", 180);
            conn.Open();
            SelectIformationOfStudent();
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
                    ComboBoxLevel.Items.Clear();
                }
                level pnn = new level();
                pnn.id = Convert.ToInt32(dt.Rows[i][0]);
                pnn.name = dt.Rows[i][1].ToString();
                pnn.major = dt.Rows[i][2].ToString();
                levels.Add(pnn);
                ComboBoxLevel.Items.Add(pnn.name + " " + pnn.major);
            }

            conn.Close();
        }



        private void ComboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLevel.SelectedIndex >= 0)
            {
                materialComboSection.Items.Clear();
                Subs.Clear();
                SelectSubjectNameFromLevelID(levels[ComboBoxLevel.SelectedIndex].id);

                // Enable the materialComboSection and set its selected index to -1
                materialComboSection.Enabled = true;
                materialComboSection.SelectedIndex = -1;
            }
            else
            {
                // If no level is selected, disable the materialComboSection
                materialComboSection.Enabled = false;
            }
        }




        private void materialComboSection_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (materialComboSection.SelectedIndex >= 0)
            {
                SelectSubjectNameFromLevelID(Subs[materialComboSection.SelectedIndex].id);
            }

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
                    materialComboSection.Items.Add(pnn.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void TextStudentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TextParentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public bool GendarSelected = false;
        public string GanderName = null;
        private void ButSubmetStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            bool flagbarcode = false;
            if (TextStudentName.Text.Length > 0 && TextStudentPhone.Text.Length > 0 && ComboBoxLevel.SelectedIndex != -1 && (Ratio_btnMale.Checked == true || Ratio_btnFemale.Checked == true))
            {
                int selectedSubID = Subs[materialComboSection.SelectedIndex].id; // Get the selected section ID
                InsertInToStudentTable(TextStudentName.Text, Convert.ToInt32(TextStudentPhone.Text), "0000000", DateTime.Now.ToShortDateString(), GanderName, levels[ComboBoxLevel.SelectedIndex].id, selectedSubID);
                flagbarcode = true;
            }

            else
            {
                if (TextStudentName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter member Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TextStudentPhone.Text.Length == 0)
                {
                    MessageBox.Show("Please enter member Phone.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                if (ComboBoxLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Level.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (materialComboSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select section.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Ratio_btnFemale.Checked == false && Ratio_btnMale.Checked == false)
                {
                    MessageBox.Show("Please Select Gender.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                }
            }


            if (flagbarcode)
            {
                string Location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "Bar_code";
                string level = null;
                if (levels[ComboBoxLevel.SelectedIndex].major == "")
                {
                    level = levels[ComboBoxLevel.SelectedIndex].name;
                }
                else
                {
                    level = ComboBoxLevel.SelectedItem.ToString();
                }
                string Date = DateTime.Now.ToLongDateString();
                Path = System.IO.Path.Combine(Location, level);

                try
                {
                    System.IO.Directory.CreateDirectory(Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Location = Path;
                Path = System.IO.Path.Combine(Location, Date);
                try
                {
                    System.IO.Directory.CreateDirectory(Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                retrivebarcode("0000000");
                SelectIformationOfStudent();
                Reset();
            }
            conn.Close();
        }

        public void Reset()
        {
            TextStudentName.Clear();
            TextStudentPhone.Clear();

        }


        public void SelectIformationOfStudent()
        {

            query = "SELECT Student.Student_ID AS StudentID, Student.Full_Name AS StudentName, Student.phone AS StudentPhone, Levels.Name AS LevelName, Subject.Sub_Name AS SectionName, Student.bar_code AS StudentBarCode, Student.Gender, Student.date AS RegisterDate, Student.Sub_ID FROM Student JOIN Levels ON Levels.ID = Student.Level_ID JOIN Subject ON Subject.Sub_ID = Student.Sub_ID";
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

                        if (j + 1 == dt.Columns.Count)
                        {

                            string[] t = dt.Rows[i][j].ToString().Split(' ');
                            x[j] = t[0];
                        }
                        else
                        {
                            x[j] = dt.Rows[i][j].ToString();
                        }

                    }
                    listView1.Items.Add(new ListViewItem(x));
                }

            }
        }

        public void retrivebarcode(string barcode)
        {
            query = "SELECT Student_ID , Full_Name FROM Student WHERE bar_code = '" + barcode + "' ";
            cmd = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            try
            {
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    int r = rr.Next(1001, 9999);
                    string barcodee = dt.Rows[i][0].ToString() + r;
                    pictureBox1.Image = writer.Write(barcodee);
                    UpdateOnStudentTable(Convert.ToInt32(dt.Rows[i][0].ToString()), barcodee);
                    pictureBox1.Image.Save(Path + "\\" + dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateOnStudentTable(int StudentID, string barcode1)
        {
            query = " UPDATE Student SET bar_code = '" + barcode1 + "'  WHERE Student_ID = '" + StudentID + "' ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                //  MessageBox.Show("Update Student Done Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void InsertInToStudentTable(string StudentName, int Studentphone, string BarCode, string Date, string Gender, int LevelID, int Sub_ID)
        {
            query = "INSERT INTO Student(Full_Name, Phone, bar_code, date, Gender, Level_ID, Sub_ID) VALUES('" + StudentName + "','" + Studentphone + "','" + BarCode + "','" + Date + "','" + Gender + "','" + LevelID + "','" + Sub_ID + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add New Member Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GendarSelected = true;
                GanderName = Ratio_btnMale.Text;
            }
        }

        private void Ratio_btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (Ratio_btnFemale.Checked)
            {
                GendarSelected = true;
                GanderName = Ratio_btnFemale.Text;
            }
        }



        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void InsertStudentControl_Load(object sender, EventArgs e)
        {
        }

        private void TextStudentSchool_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextStudentName_TextChanged(object sender, EventArgs e)
        {
            if (TextStudentName.Text.Length > 0)
            {
                SelectAllLevel();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
