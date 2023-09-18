using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class centerschedule : UserControl
    {
        Connection_DB db = new Connection_DB();
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        MySqlConnection conn = null;

        public string dayName ;
        public DataTable  cntrschedule = new DataTable();
      
        public centerschedule()
        {
           
            InitializeComponent();
            conn = db.Connect_with_Database();                 
            materialComboBox1.Items.Add("Saturday");
            materialComboBox1.Items.Add("Sunday");
            materialComboBox1.Items.Add("Monday");
            materialComboBox1.Items.Add("Tuesday");
            materialComboBox1.Items.Add("Wednesday");
            materialComboBox1.Items.Add("Thursday");            
            materialComboBox1.Items.Add("Friday");

            
        }

        //private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        //{           


        //}

        public DataTable selectcntrschedule(string dayname)
        {
            conn.Open();

            query = "SELECT subject.Sub_Name, levels.name, levels.major, teacher.Full_Name " +
                    "FROM subject " +
                    "INNER JOIN levels ON subject.level_id = levels.ID " +
                    "LEFT JOIN teacher_subject ON subject.Sub_ID = teacher_subject.Sub_ID " +
                    "LEFT JOIN teacher ON teacher_subject.tch_id = teacher.ID " +
                    "WHERE CONCAT(',', days, ',') LIKE @dayNameParam";

            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@dayNameParam", "%" + dayname + "%");
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
            return dt;
        }





        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            listView1.Items.Clear();
            cntrschedule.Clear();
            cntrschedule = selectcntrschedule(materialComboBox1.SelectedItem.ToString());
                     
            string[] x = new string[cntrschedule.Columns.Count];
            for (int i = 0; i < cntrschedule.Rows.Count; i++)
            {
                for (int j = 0; j < cntrschedule.Columns.Count; j++)
                {
                    x[j] = cntrschedule.Rows[i][j].ToString();

                }
               // to order them as you want
                // ListViewItem item = new ListViewItem(new string[] { x[3], x[0], x[1], x[2] });

                listView1.Items.Add(new ListViewItem(x));
                            
            }

        }

        private void centerschedule_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            excelsheet lp = new excelsheet();
            lp.abuio(listView1);
            
        }
    }
}
