namespace new_project1
{
    partial class AttendanceHome
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
            this.attendanceStudent1 = new new_project1.AttendanceStudent();
            this.SuspendLayout();
            // 
            // attendanceStudent1
            // 
            this.attendanceStudent1.BackColor = System.Drawing.Color.Transparent;
            this.attendanceStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceStudent1.Location = new System.Drawing.Point(0, 0);
            this.attendanceStudent1.Name = "attendanceStudent1";
            this.attendanceStudent1.Size = new System.Drawing.Size(1377, 861);
            this.attendanceStudent1.TabIndex = 1;
            this.attendanceStudent1.Load += new System.EventHandler(this.attendanceStudent1_Load);
            // 
            // AttendanceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.attendanceStudent1);
            this.Name = "AttendanceHome";
            this.Size = new System.Drawing.Size(1377, 861);
            this.Load += new System.EventHandler(this.AttendanceHome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private AttendanceStudent attendanceStudent1;
    }
}
