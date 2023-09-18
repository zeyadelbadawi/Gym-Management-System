using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace new_project1
{
    public partial class Changepassword : MaterialForm
    {
        Connection_DB db = new Connection_DB();
        MySqlConnection sqlConnect;
        MySqlCommand cmd;
        DataTable dt;

        public Changepassword()
        {
            InitializeComponent();
            sqlConnect = db.Connect_with_Database();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                GetAdminFromDB();

                bool isFound = false;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mail"].ToString() == Emailtextbox.Text)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    if (newpassord.Text == confirmnewpassword.Text)
                    {
                        int adminId = Convert.ToInt32(dt.Rows[0]["ID"]);
                        UpdatePassword(adminId, newpassord.Text);
                        MessageBox.Show("Password Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No user found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void GetAdminFromDB()
        {
            string query = "SELECT Mail, ID FROM Admins";
            cmd = new MySqlCommand(query, sqlConnect);
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                dt = new DataTable();
                da.Fill(dt);
            }
        }

        private void UpdatePassword(int id, string newPassword)
        {
            string query = "UPDATE Admins SET Password=@Password WHERE ID=@ID";
            cmd = new MySqlCommand(query, sqlConnect);
            cmd.Parameters.AddWithValue("@Password", newPassword);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }
    }
}
