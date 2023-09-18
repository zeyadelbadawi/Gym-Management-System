namespace new_project1
{
    partial class studenthomepage
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
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.insertStudentControl1 = new new_project1.InsertStudentControl();
            this.deletestudentcontrol1 = new new_project1.deletestudentcontrol();
            this.updatestudentcontrol1 = new new_project1.updatestudentcontrol();
            this.SuspendLayout();
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(372, 23);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(138, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "Delete Member";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(208, 23);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(142, 36);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "Update Member";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(14, 23);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(172, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Insert New Member";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // insertStudentControl1
            // 
            this.insertStudentControl1.AutoScroll = true;
            this.insertStudentControl1.BackColor = System.Drawing.Color.White;
            this.insertStudentControl1.Location = new System.Drawing.Point(14, 59);
            this.insertStudentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.insertStudentControl1.Name = "insertStudentControl1";
            this.insertStudentControl1.Size = new System.Drawing.Size(1290, 509);
            this.insertStudentControl1.TabIndex = 11;
            this.insertStudentControl1.Load += new System.EventHandler(this.insertStudentControl1_Load_1);
            // 
            // deletestudentcontrol1
            // 
            this.deletestudentcontrol1.Location = new System.Drawing.Point(14, 59);
            this.deletestudentcontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.deletestudentcontrol1.Name = "deletestudentcontrol1";
            this.deletestudentcontrol1.Size = new System.Drawing.Size(670, 405);
            this.deletestudentcontrol1.TabIndex = 10;
            this.deletestudentcontrol1.Load += new System.EventHandler(this.deletestudentcontrol1_Load);
            // 
            // updatestudentcontrol1
            // 
            this.updatestudentcontrol1.BackColor = System.Drawing.Color.DarkGray;
            this.updatestudentcontrol1.Location = new System.Drawing.Point(14, 59);
            this.updatestudentcontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.updatestudentcontrol1.Name = "updatestudentcontrol1";
            this.updatestudentcontrol1.Size = new System.Drawing.Size(1290, 509);
            this.updatestudentcontrol1.TabIndex = 9;
            // 
            // studenthomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insertStudentControl1);
            this.Controls.Add(this.deletestudentcontrol1);
            this.Controls.Add(this.updatestudentcontrol1);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studenthomepage";
            this.Size = new System.Drawing.Size(2134, 714);
            this.Load += new System.EventHandler(this.studenthomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        //private InsertStudentControl insertStudentControl1;
        private updatestudentcontrol updatestudentcontrol1;
        private deletestudentcontrol deletestudentcontrol1;
        private InsertStudentControl insertStudentControl1;
    }
}
