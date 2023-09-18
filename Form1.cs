using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace new_project1
{
    public partial class Form1 : MaterialForm
    {
       
        Timer tt = new Timer();
        public bool PanelFlag = false;
        Random r= new Random();
       
        public Form1()
        {
            InitializeComponent();
            changepanel();
            this.WindowState = FormWindowState.Maximized;      
            var materialSkinManager = MaterialSkinManager.Instance;           
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE);
            tt.Tick += Tt_Tick;
            tt.Start();

            //drawscene(CreateGraphics());
         
           // MessageBox.Show(this.ClientSize.Width.ToString());
            //MessageBox.Show(this.ClientSize.Height.ToString());
        }

       
        private void Tt_Tick(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        
            studenthomepage1.Hide();
            levelhomepage1.Hide();
            coursecontrol1.Hide();
            teacherhomepage1.Hide();
            centerschedule1.Hide();
            studentReportsControls1.Hide();
            teacherSchedule1.Hide();
            attendancecontrol1.Hide();
            

           // drawscene(CreateGraphics());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {          
            levelhomepage1.Hide();
            coursecontrol1.Hide();
            teacherhomepage1.Hide();
            studenthomepage1.Show();
            studenthomepage1.BringToFront();
          
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            studenthomepage1.Hide();
            coursecontrol1.Hide();
            teacherhomepage1.Hide();
            levelhomepage1.Show();
            levelhomepage1.BringToFront();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            //insertStudentControl1.Hide();
            studenthomepage1.Hide();
            levelhomepage1.Hide();
            coursecontrol1.Show();
            coursecontrol1.BringToFront();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Show_Hide_Click(object sender, EventArgs e)
        {

        }

        private void Show_Hide_Click_1(object sender, EventArgs e)
        {

            changepanel();
        }
        public  void changepanel()
        {
            if (PanelFlag)
            {
                panel1.Hide();
                PanelFlag = !PanelFlag;
                this.Show_Hide.ImageIndex = 1;            
                this.Show_Hide.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                panel1.Show();
                PanelFlag = !PanelFlag;
                this.Show_Hide.ImageIndex = 0;
                this.materialDivider1.BackColor = System.Drawing.Color.Black;
                this.panel1.BackColor = System.Drawing.Color.DimGray;
                this.Show_Hide.BackColor = System.Drawing.Color.DimGray;
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
          
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }


        private void Show_Hide_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Show_Hide_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }
  
      

        private void levelhomepage1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            teacherhomepage1.Show();
            teacherhomepage1.BringToFront();
            levelhomepage1.Hide();
            studenthomepage1.Hide();
            coursecontrol1.Hide();          
            //insertStudentControl1.Hide();
        }

        private void teacherhomepage1_Load(object sender, EventArgs e)
        {

        }

        private void coursecontrol1_Load(object sender, EventArgs e)
        {

        }

        private void studenthomepage1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            studenthomepage1.Hide();
            teacherhomepage1.Hide();
            coursecontrol1.Hide();
            levelhomepage1.Hide();
        }

        private void schedules_Home1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            centerschedule1.Show();
            centerschedule1.BringToFront();
            teacherSchedule1.Hide();
        }

       

        private void materialButton9_Click(object sender, EventArgs e)
        {
            studentReportsControls1.Show();
            studentReportsControls1.BringToFront();
            attendancecontrol1.Hide();
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void centerschedule1_Load(object sender, EventArgs e)
        {

        }

        private void centerschedule1_Load_1(object sender, EventArgs e)
        {

        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            studentReportsControls1.Hide();
            attendancecontrol1.Hide();
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            studentReportsControls1.Hide();
            attendancecontrol1.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click_1(object sender, EventArgs e)
        {

        }

        private void findStudentThatRegestOnTeacher1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            teacherSchedule1.Show();
            teacherSchedule1.BringToFront();
            centerschedule1.Hide();
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            attendancecontrol1.Show();
            attendancecontrol1.BringToFront();
            studentReportsControls1.Hide();

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            studenthomepage1.Hide();
            levelhomepage1.Hide();
            coursecontrol1.Hide();
            teacherhomepage1.Hide();
            centerschedule1.Hide();
            studentReportsControls1.Hide();
            teacherSchedule1.Hide();
            attendancecontrol1.Hide();                 
        }

        private void logo1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attendanceHome1_Load(object sender, EventArgs e)
        {

        }
    }
}
