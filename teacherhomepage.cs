using System;
using System.Windows.Forms;

namespace new_project1
{
    public partial class teacherhomepage : UserControl
    {
        public teacherhomepage()
        {
            InitializeComponent();
        }

        private void teacherhomepage_Load(object sender, EventArgs e)
        {
           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            insert_new_teacher1.Show();
            insert_new_teacher1.BringToFront();
            updateteachercontrol1.Hide();
            updateTeacher1.Hide();
            deleteteachercontrol1.Hide();
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            updateTeacher1.Show();
            updateTeacher1.BringToFront();
            insert_new_teacher1.Hide();
            updateteachercontrol1.Hide();
            deleteteachercontrol1.Hide();
        }

        private void teacherhomepage_Load_1(object sender, EventArgs e)
        {
            insert_new_teacher1.Hide();
            updateTeacher1.Hide();
            updateteachercontrol1.Hide();
            deleteteachercontrol1.Hide();

        }

        private void insert_new_teacher1_Load(object sender, EventArgs e)
        {

        }

        private void updateteacherControl1_Load(object sender, EventArgs e)
        {

        }

        private void insert_new_teacher1_Load_1(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            deleteteachercontrol1.Show();
            deleteteachercontrol1.BringToFront();
            updateteachercontrol1.Hide();
            updateTeacher1.Hide();
            insert_new_teacher1.Hide();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            updateteachercontrol1.Show();
            updateteachercontrol1.BringToFront();
            insert_new_teacher1.Hide();
            updateTeacher1.Hide();
            deleteteachercontrol1.Hide();
        }
    }
}
