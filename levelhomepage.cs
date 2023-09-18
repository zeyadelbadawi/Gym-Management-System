using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class levelhomepage : UserControl
    {
     
        Connection_DB db = new Connection_DB();
        MySqlConnection conn = null;
        string query = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;

        public levelhomepage()
        {
            InitializeComponent();
            conn = db.Connect_with_Database();
            filldatagridviewlevel();
        }

        public void filldatagridviewlevel()
        {
            conn.Open();

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
            //dataGridView1.DataSource = dt;

            conn.Close();
        }
        private void dataGridViewLevel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButInsertLevel_Click(object sender, EventArgs e)
        {
             
            insertlevelcontrol1.Show();
            insertlevelcontrol1.BringToFront();
        }

        private void levelhomepage_Load(object sender, EventArgs e)
        {
            insertlevelcontrol1.Hide();
            updatelevelcontrol1.Hide();
            deletelevelcontrol1.Hide();
            dataGridViewLevel.Hide();
           // filldatagridviewlevel();
        }

        private void ButUpdateLevel_Click(object sender, EventArgs e)
        {
            updatelevelcontrol1.Show();
            updatelevelcontrol1.BringToFront();
        }

        private void ButDeleteLevel_Click(object sender, EventArgs e)
        {
            deletelevelcontrol1.Show();
            deletelevelcontrol1.BringToFront();
        }

        private void ButSearchInLevel_Click(object sender, EventArgs e)
        {
            dataGridViewLevel.Show();
            dataGridViewLevel.BringToFront();
        }

        private void deletelevelcontrol1_Load(object sender, EventArgs e)
        {

        }
    }
}
