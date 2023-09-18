namespace new_project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.logo1 = new new_project1.Logo();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.studenthomepage1 = new new_project1.studenthomepage();
            this.teacherhomepage1 = new new_project1.teacherhomepage();
            this.coursecontrol1 = new new_project1.coursecontrol();
            this.levelhomepage1 = new new_project1.levelhomepage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.Show_Hide = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.attendanceHome1 = new new_project1.AttendanceHome();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attendancecontrol1 = new new_project1.attendancecontrol();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.studentReportsControls1 = new new_project1.StudentReportsControls();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.teacherSchedule1 = new new_project1.TeacherSchedule();
            this.centerschedule1 = new new_project1.centerschedule();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.backup1 = new new_project1.backup();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.materialTabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.HotTrack = true;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.logo1);
            this.tabPage5.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click_1);
            // 
            // logo1
            // 
            resources.ApplyResources(this.logo1, "logo1");
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo1.Name = "logo1";
            this.logo1.Load += new System.EventHandler(this.logo1_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.studenthomepage1);
            this.tabPage1.Controls.Add(this.teacherhomepage1);
            this.tabPage1.Controls.Add(this.coursecontrol1);
            this.tabPage1.Controls.Add(this.levelhomepage1);
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Show_Hide);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // studenthomepage1
            // 
            resources.ApplyResources(this.studenthomepage1, "studenthomepage1");
            this.studenthomepage1.Name = "studenthomepage1";
            this.studenthomepage1.Load += new System.EventHandler(this.studenthomepage1_Load);
            // 
            // teacherhomepage1
            // 
            resources.ApplyResources(this.teacherhomepage1, "teacherhomepage1");
            this.teacherhomepage1.Name = "teacherhomepage1";
            this.teacherhomepage1.Load += new System.EventHandler(this.teacherhomepage1_Load);
            // 
            // coursecontrol1
            // 
            resources.ApplyResources(this.coursecontrol1, "coursecontrol1");
            this.coursecontrol1.BackColor = System.Drawing.Color.Transparent;
            this.coursecontrol1.Name = "coursecontrol1";
            this.coursecontrol1.Load += new System.EventHandler(this.coursecontrol1_Load);
            // 
            // levelhomepage1
            // 
            resources.ApplyResources(this.levelhomepage1, "levelhomepage1");
            this.levelhomepage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.levelhomepage1.Name = "levelhomepage1";
            this.levelhomepage1.Load += new System.EventHandler(this.levelhomepage1_Load);
            // 
            // materialLabel10
            // 
            resources.ApplyResources(this.materialLabel10, "materialLabel10");
            this.materialLabel10.Depth = 0;
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.materialCard2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.materialButton4);
            this.panel1.Controls.Add(this.materialCard4);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.materialCard3);
            this.panel1.Controls.Add(this.materialButton3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // materialButton2
            // 
            resources.ApplyResources(this.materialButton2, "materialButton2");
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            resources.ApplyResources(this.materialDivider1, "materialDivider1");
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AllowDrop = true;
            resources.ApplyResources(this.materialButton4, "materialButton4");
            this.materialButton4.BackColor = System.Drawing.Color.Transparent;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = false;
            this.materialButton4.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.pictureBox4);
            this.materialCard4.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.pictureBox3);
            this.materialCard3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // materialButton3
            // 
            resources.ApplyResources(this.materialButton3, "materialButton3");
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // Show_Hide
            // 
            this.Show_Hide.BackColor = System.Drawing.Color.Transparent;
            this.Show_Hide.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Show_Hide, "Show_Hide");
            this.Show_Hide.FlatAppearance.BorderSize = 0;
            this.Show_Hide.ImageList = this.imageList1;
            this.Show_Hide.Name = "Show_Hide";
            this.Show_Hide.UseVisualStyleBackColor = false;
            this.Show_Hide.Click += new System.EventHandler(this.Show_Hide_Click_1);
            this.Show_Hide.MouseEnter += new System.EventHandler(this.Show_Hide_MouseEnter);
            this.Show_Hide.MouseLeave += new System.EventHandler(this.Show_Hide_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chevron-up-30.png");
            this.imageList1.Images.SetKeyName(1, "chevron-down-30.png");
            this.imageList1.Images.SetKeyName(2, "icons8-attendance-80.png");
            this.imageList1.Images.SetKeyName(3, "icons8-graph-report-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-schedule-80.png");
            this.imageList1.Images.SetKeyName(5, "icons8-student-registration-50.png");
            this.imageList1.Images.SetKeyName(6, "icons8-teacher-50.png");
            this.imageList1.Images.SetKeyName(7, "icons8-attendance-80.png");
            this.imageList1.Images.SetKeyName(8, "icons8-schedule-64.png");
            this.imageList1.Images.SetKeyName(9, "icons8-home-50 (1).png");
            this.imageList1.Images.SetKeyName(10, "icons8-bookmark-50.png");
            this.imageList1.Images.SetKeyName(11, "icons8-bar-code-66.png");
            this.imageList1.Images.SetKeyName(12, "icons8-barcode-reader-80.png");
            this.imageList1.Images.SetKeyName(13, "icons8-student-card-64.png");
            this.imageList1.Images.SetKeyName(14, "icons8-menu-50.png");
            this.imageList1.Images.SetKeyName(15, "icons8-settings-32.png");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.attendanceHome1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // attendanceHome1
            // 
            this.attendanceHome1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.attendanceHome1, "attendanceHome1");
            this.attendanceHome1.Name = "attendanceHome1";
            this.attendanceHome1.Load += new System.EventHandler(this.attendanceHome1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.attendancecontrol1);
            this.tabPage3.Controls.Add(this.materialButton12);
            this.tabPage3.Controls.Add(this.materialButton9);
            this.tabPage3.Controls.Add(this.studentReportsControls1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // attendancecontrol1
            // 
            resources.ApplyResources(this.attendancecontrol1, "attendancecontrol1");
            this.attendancecontrol1.Name = "attendancecontrol1";
            // 
            // materialButton12
            // 
            resources.ApplyResources(this.materialButton12, "materialButton12");
            this.materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton12.Depth = 0;
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = null;
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = false;
            this.materialButton12.UseVisualStyleBackColor = true;
            this.materialButton12.Click += new System.EventHandler(this.materialButton12_Click);
            // 
            // materialButton9
            // 
            resources.ApplyResources(this.materialButton9, "materialButton9");
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // studentReportsControls1
            // 
            resources.ApplyResources(this.studentReportsControls1, "studentReportsControls1");
            this.studentReportsControls1.Name = "studentReportsControls1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.teacherSchedule1);
            this.tabPage4.Controls.Add(this.centerschedule1);
            this.tabPage4.Controls.Add(this.materialButton7);
            this.tabPage4.Controls.Add(this.materialButton6);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // teacherSchedule1
            // 
            resources.ApplyResources(this.teacherSchedule1, "teacherSchedule1");
            this.teacherSchedule1.Name = "teacherSchedule1";
            // 
            // centerschedule1
            // 
            resources.ApplyResources(this.centerschedule1, "centerschedule1");
            this.centerschedule1.BackColor = System.Drawing.Color.Transparent;
            this.centerschedule1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.centerschedule1.Name = "centerschedule1";
            this.centerschedule1.Load += new System.EventHandler(this.centerschedule1_Load_1);
            // 
            // materialButton7
            // 
            resources.ApplyResources(this.materialButton7, "materialButton7");
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // materialButton6
            // 
            resources.ApplyResources(this.materialButton6, "materialButton6");
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.backup1);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // backup1
            // 
            resources.ApplyResources(this.backup1, "backup1");
            this.backup1.Name = "backup1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 180;
            this.Name = "Form1";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Show_Hide;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private levelhomepage levelhomepage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private coursecontrol coursecontrol1;
        private teacherhomepage teacherhomepage1;
        private AttendanceHome attendanceHome1;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private centerschedule centerschedule1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private StudentReportsControls studentReportsControls1;
        private TeacherSchedule teacherSchedule1;
        private attendancecontrol attendancecontrol1;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        protected System.Windows.Forms.TabPage tabPage5;
        private studenthomepage studenthomepage1;
        private Logo logo1;
        private System.Windows.Forms.TabPage tabPage6;
        private backup backup1;
    }
}

