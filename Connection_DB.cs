using MySql.Data.MySqlClient;
using System;



namespace new_project1
{
    public class Connection_DB
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=gym;user=root");

        public MySqlConnection Connect_with_Database()
        {
            try
            {
                //con.Open();
                //MessageBox.Show("Connection In Database Is Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

    }
}
