using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace new_project1
{
    public partial class LoginForm : MaterialForm
    {
        Connection_DB db = new Connection_DB();
        MySqlConnection sqlConnect;
        public string query = null;
        MySqlCommand cmd ;
        MySqlDataAdapter da ;
        DataTable dt;
        public LoginForm()
        {
            InitializeComponent();
            sqlConnect = db.Connect_with_Database();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        




        private void LogincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LogincheckBox.Checked == true)
            {
                Password.Password = false;
            }
            else
            {
                Password.Password = true;
            }
        }
        public bool isFind=false;

        public void GetAdminFromDB()
        {
            sqlConnect.Open();
            query = "SELECT Username,Password FROM Admins ";
            cmd = new MySqlCommand(query, sqlConnect);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }






        private void butLogIn_Click(object sender, EventArgs e)
        {

                isFind= false;
                GetAdminFromDB();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == Username.Text && dt.Rows[i][1].ToString() ==Password.Text)
                {
                    isFind= true;
                    break;
                }
            }
            if (isFind == true)
            {                
                Form1 homeForm = new Form1();
                this.Hide();
                homeForm.Show();

            }
            else 
            {
                MessageBox.Show("NO User found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







        private void Username_Enter(object sender, EventArgs e)
        {
            Username.Text = null;
            this.Username.BackColor = System.Drawing.Color.Black;
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Text = null;
            Password.Password = true;
            LogincheckBox.Checked = false;
            this.Password.BackColor = System.Drawing.Color.Black;
        }

   
        private void ChangeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Changepassword changepassword = new Changepassword();
            changepassword.Show();
          //  changepassword.BringToFront();

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
