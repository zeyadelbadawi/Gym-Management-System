namespace new_project1
{
    partial class coursecontrol
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
            this.ButInsertLevel = new MaterialSkin.Controls.MaterialButton();
            this.ButUpdateLevel = new MaterialSkin.Controls.MaterialButton();
            this.ButDeleteLevel = new MaterialSkin.Controls.MaterialButton();
            this.deletecoursecontrol1 = new new_project1.deletecoursecontrol();
            this.updatecourseControl1 = new new_project1.updatecourseControl();
            this.insertcourse1 = new new_project1.insertcourse();
            this.SuspendLayout();
            // 
            // ButInsertLevel
            // 
            this.ButInsertLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButInsertLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButInsertLevel.Depth = 0;
            this.ButInsertLevel.HighEmphasis = true;
            this.ButInsertLevel.Icon = null;
            this.ButInsertLevel.Location = new System.Drawing.Point(12, 20);
            this.ButInsertLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButInsertLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButInsertLevel.Name = "ButInsertLevel";
            this.ButInsertLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButInsertLevel.Size = new System.Drawing.Size(136, 36);
            this.ButInsertLevel.TabIndex = 16;
            this.ButInsertLevel.Text = "Insert section";
            this.ButInsertLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButInsertLevel.UseAccentColor = false;
            this.ButInsertLevel.UseVisualStyleBackColor = true;
            this.ButInsertLevel.Click += new System.EventHandler(this.ButInsertLevel_Click);
            // 
            // ButUpdateLevel
            // 
            this.ButUpdateLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButUpdateLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButUpdateLevel.Depth = 0;
            this.ButUpdateLevel.HighEmphasis = true;
            this.ButUpdateLevel.Icon = null;
            this.ButUpdateLevel.Location = new System.Drawing.Point(183, 20);
            this.ButUpdateLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButUpdateLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButUpdateLevel.Name = "ButUpdateLevel";
            this.ButUpdateLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButUpdateLevel.Size = new System.Drawing.Size(141, 36);
            this.ButUpdateLevel.TabIndex = 20;
            this.ButUpdateLevel.Text = "Update section";
            this.ButUpdateLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButUpdateLevel.UseAccentColor = false;
            this.ButUpdateLevel.UseVisualStyleBackColor = true;
            this.ButUpdateLevel.Click += new System.EventHandler(this.ButUpdateLevel_Click);
            // 
            // ButDeleteLevel
            // 
            this.ButDeleteLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDeleteLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButDeleteLevel.Depth = 0;
            this.ButDeleteLevel.HighEmphasis = true;
            this.ButDeleteLevel.Icon = null;
            this.ButDeleteLevel.Location = new System.Drawing.Point(352, 20);
            this.ButDeleteLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButDeleteLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButDeleteLevel.Name = "ButDeleteLevel";
            this.ButDeleteLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButDeleteLevel.Size = new System.Drawing.Size(138, 36);
            this.ButDeleteLevel.TabIndex = 19;
            this.ButDeleteLevel.Text = "Delete section";
            this.ButDeleteLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButDeleteLevel.UseAccentColor = false;
            this.ButDeleteLevel.UseVisualStyleBackColor = true;
            this.ButDeleteLevel.Click += new System.EventHandler(this.ButDeleteLevel_Click);
            // 
            // deletecoursecontrol1
            // 
            this.deletecoursecontrol1.Location = new System.Drawing.Point(12, 57);
            this.deletecoursecontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.deletecoursecontrol1.Name = "deletecoursecontrol1";
            this.deletecoursecontrol1.Size = new System.Drawing.Size(280, 362);
            this.deletecoursecontrol1.TabIndex = 23;
            // 
            // updatecourseControl1
            // 
            this.updatecourseControl1.Location = new System.Drawing.Point(12, 57);
            this.updatecourseControl1.Margin = new System.Windows.Forms.Padding(2);
            this.updatecourseControl1.Name = "updatecourseControl1";
            this.updatecourseControl1.Size = new System.Drawing.Size(400, 400);
            this.updatecourseControl1.TabIndex = 22;
            this.updatecourseControl1.Load += new System.EventHandler(this.updatecourseControl1_Load);
            // 
            // insertcourse1
            // 
            this.insertcourse1.Location = new System.Drawing.Point(12, 57);
            this.insertcourse1.Margin = new System.Windows.Forms.Padding(2);
            this.insertcourse1.Name = "insertcourse1";
            this.insertcourse1.Size = new System.Drawing.Size(280, 362);
            this.insertcourse1.TabIndex = 21;
            // 
            // coursecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.deletecoursecontrol1);
            this.Controls.Add(this.updatecourseControl1);
            this.Controls.Add(this.insertcourse1);
            this.Controls.Add(this.ButDeleteLevel);
            this.Controls.Add(this.ButUpdateLevel);
            this.Controls.Add(this.ButInsertLevel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "coursecontrol";
            this.Size = new System.Drawing.Size(1124, 549);
            this.Load += new System.EventHandler(this.coursecontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButInsertLevel;
        private MaterialSkin.Controls.MaterialButton ButUpdateLevel;
        private MaterialSkin.Controls.MaterialButton ButDeleteLevel;
        private insertcourse insertcourse1;
        private updatecourseControl updatecourseControl1;
        private deletecoursecontrol deletecoursecontrol1;
    }
}
