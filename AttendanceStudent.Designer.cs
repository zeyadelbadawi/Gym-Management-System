namespace new_project1
{
    partial class AttendanceStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextAttendance = new MaterialSkin.Controls.MaterialTextBox();
            this.AttendanceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.courseComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ScheduleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NonRegisterpanel = new System.Windows.Forms.Panel();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.btnAttend = new MaterialSkin.Controls.MaterialButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLevelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLevelMajor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
       
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NonRegisterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextAttendance
            // 
            this.TextAttendance.AnimateReadOnly = false;
            this.TextAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAttendance.Depth = 0;
            this.TextAttendance.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextAttendance.LeadingIcon = null;
            this.TextAttendance.Location = new System.Drawing.Point(0, 42);
            this.TextAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.TextAttendance.MaxLength = 50;
            this.TextAttendance.MouseState = MaterialSkin.MouseState.OUT;
            this.TextAttendance.Multiline = false;
            this.TextAttendance.Name = "TextAttendance";
            this.TextAttendance.Size = new System.Drawing.Size(262, 50);
            this.TextAttendance.TabIndex = 1;
            this.TextAttendance.Text = "";
            this.TextAttendance.TrailingIcon = null;
            // 
            // AttendanceLabel
            // 
            this.AttendanceLabel.AutoSize = true;
            this.AttendanceLabel.Depth = 0;
            this.AttendanceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AttendanceLabel.Location = new System.Drawing.Point(2, 0);
            this.AttendanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttendanceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AttendanceLabel.Name = "AttendanceLabel";
            this.AttendanceLabel.Size = new System.Drawing.Size(1, 0);
            this.AttendanceLabel.TabIndex = 2;
            // 
            // courseComboBox
            // 
            this.courseComboBox.AutoResize = false;
            this.courseComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.courseComboBox.Depth = 0;
            this.courseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.courseComboBox.DropDownHeight = 174;
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.DropDownWidth = 121;
            this.courseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.courseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.IntegralHeight = false;
            this.courseComboBox.ItemHeight = 43;
            this.courseComboBox.Location = new System.Drawing.Point(385, 43);
            this.courseComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseComboBox.MaxDropDownItems = 4;
            this.courseComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(375, 49);
            this.courseComboBox.StartIndex = 0;
            this.courseComboBox.TabIndex = 5;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Depth = 0;
            this.ScheduleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScheduleLabel.Location = new System.Drawing.Point(391, 22);
            this.ScheduleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(132, 19);
            this.ScheduleLabel.TabIndex = 6;
            this.ScheduleLabel.Text = "Select The Section";
            this.ScheduleLabel.Click += new System.EventHandler(this.ScheduleLabel_Click);
            // 
            // NonRegisterpanel
            // 
            this.NonRegisterpanel.Controls.Add(this.btnRegister);
            this.NonRegisterpanel.Controls.Add(this.btnAttend);
            this.NonRegisterpanel.Location = new System.Drawing.Point(2, 126);
            this.NonRegisterpanel.Margin = new System.Windows.Forms.Padding(2);
            this.NonRegisterpanel.Name = "NonRegisterpanel";
            this.NonRegisterpanel.Size = new System.Drawing.Size(399, 124);
            this.NonRegisterpanel.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(169, 65);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(77, 36);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "absent";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAttend
            // 
            this.btnAttend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttend.Depth = 0;
            this.btnAttend.HighEmphasis = true;
            this.btnAttend.Icon = null;
            this.btnAttend.Location = new System.Drawing.Point(18, 65);
            this.btnAttend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAttend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttend.Size = new System.Drawing.Size(77, 36);
            this.btnAttend.TabIndex = 0;
            this.btnAttend.Text = "Attend";
            this.btnAttend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttend.UseAccentColor = false;
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeaderLevelName,
            this.columnHeaderLevelMajor,
            this.columnHeaderSubjectName,
           });
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 299);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1090, 268);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Member ID";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Member Name";
            this.columnHeader8.Width = 180;
            // 
            // columnHeaderLevelName
            // 
            this.columnHeaderLevelName.Text = "class Name";
            this.columnHeaderLevelName.Width = 120;
            // 
            // columnHeaderLevelMajor
            // 
            this.columnHeaderLevelMajor.Text = "category";
            this.columnHeaderLevelMajor.Width = 120;
            // 
            // columnHeaderSubjectName
            // 
            this.columnHeaderSubjectName.Text = "section Name";
            this.columnHeaderSubjectName.Width = 120;
            // 
            // columnHeaderLevelName2
            // 

            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(280, 56);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(78, 36);
            this.materialButton1.TabIndex = 15;
            this.materialButton1.Text = "search";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(2, 11);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "enter member name";
            // 
            // AttendanceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.NonRegisterpanel);
            this.Controls.Add(this.ScheduleLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.AttendanceLabel);
            this.Controls.Add(this.TextAttendance);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttendanceStudent";
            this.Size = new System.Drawing.Size(1128, 722);
            this.NonRegisterpanel.ResumeLayout(false);
            this.NonRegisterpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox TextAttendance;
        private MaterialSkin.Controls.MaterialLabel AttendanceLabel;
        private MaterialSkin.Controls.MaterialComboBox courseComboBox;
        private MaterialSkin.Controls.MaterialLabel ScheduleLabel;
        private System.Windows.Forms.Panel NonRegisterpanel;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialButton btnAttend;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeaderLevelName;
        private System.Windows.Forms.ColumnHeader columnHeaderLevelMajor;

        private System.Windows.Forms.ColumnHeader columnHeaderSubjectName;
    
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}