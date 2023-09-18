using System;
using System.Windows.Forms;

namespace new_project1
{
    public partial class coursecontrol : UserControl
    {
        public coursecontrol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void coursecontrol_Load(object sender, EventArgs e)
        {
           
            updatecourseControl1.Hide();
            insertcourse1.Hide();
            deletecoursecontrol1.Hide();
            
        }

        private void TextSearchLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButUpdateLevel_Click(object sender, EventArgs e)
        {
            updatecourseControl1.Show();
            updatecourseControl1.BringToFront();
            insertcourse1.Hide();
            deletecoursecontrol1.Hide();
        }

        private void ButSearchInLevel_Click(object sender, EventArgs e)
        {
           
        }

        private void ButInsertLevel_Click(object sender, EventArgs e)
        {
            insertcourse1.Show();
            insertcourse1.BringToFront();
            updatecourseControl1.Hide();
            deletecoursecontrol1.Hide();
        }

        private void updatecourseControl1_Load(object sender, EventArgs e)
        {

        }

        private void ButDeleteLevel_Click(object sender, EventArgs e)
        {
            deletecoursecontrol1.Show();
            deletecoursecontrol1.BringToFront();
            insertcourse1.Hide();
            updatecourseControl1.Hide();
        }
    }
}
