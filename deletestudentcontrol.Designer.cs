namespace new_project1
{
    partial class deletestudentcontrol
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
            this.TextStudentID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButDeleteStudent = new MaterialSkin.Controls.MaterialButton();
            this.TextStudentInformation = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // TextStudentID
            // 
            this.TextStudentID.AnimateReadOnly = false;
            this.TextStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStudentID.Depth = 0;
            this.TextStudentID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextStudentID.LeadingIcon = null;
            this.TextStudentID.Location = new System.Drawing.Point(8, 27);
            this.TextStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextStudentID.MaxLength = 50;
            this.TextStudentID.MouseState = MaterialSkin.MouseState.OUT;
            this.TextStudentID.Multiline = false;
            this.TextStudentID.Name = "TextStudentID";
            this.TextStudentID.Size = new System.Drawing.Size(179, 50);
            this.TextStudentID.TabIndex = 57;
            this.TextStudentID.Text = "";
            this.TextStudentID.TrailingIcon = null;
            this.TextStudentID.TextChanged += new System.EventHandler(this.TextStudentID_TextChanged);
            this.TextStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(5, 9);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "Member ID";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ButDeleteStudent
            // 
            this.ButDeleteStudent.AutoSize = false;
            this.ButDeleteStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDeleteStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButDeleteStudent.Depth = 0;
            this.ButDeleteStudent.HighEmphasis = true;
            this.ButDeleteStudent.Icon = null;
            this.ButDeleteStudent.Location = new System.Drawing.Point(8, 75);
            this.ButDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButDeleteStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButDeleteStudent.Name = "ButDeleteStudent";
            this.ButDeleteStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButDeleteStudent.Size = new System.Drawing.Size(149, 29);
            this.ButDeleteStudent.TabIndex = 70;
            this.ButDeleteStudent.Text = "Delete Member";
            this.ButDeleteStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButDeleteStudent.UseAccentColor = false;
            this.ButDeleteStudent.UseVisualStyleBackColor = true;
            this.ButDeleteStudent.Click += new System.EventHandler(this.ButDeleteStudent_Click);
            // 
            // TextStudentInformation
            // 
            this.TextStudentInformation.AnimateReadOnly = false;
            this.TextStudentInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStudentInformation.Depth = 0;
            this.TextStudentInformation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextStudentInformation.LeadingIcon = null;
            this.TextStudentInformation.Location = new System.Drawing.Point(192, 27);
            this.TextStudentInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextStudentInformation.MaxLength = 50;
            this.TextStudentInformation.MouseState = MaterialSkin.MouseState.OUT;
            this.TextStudentInformation.Multiline = false;
            this.TextStudentInformation.Name = "TextStudentInformation";
            this.TextStudentInformation.Size = new System.Drawing.Size(335, 50);
            this.TextStudentInformation.TabIndex = 71;
            this.TextStudentInformation.Text = "";
            this.TextStudentInformation.TrailingIcon = null;
            // 
            // deletestudentcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextStudentInformation);
            this.Controls.Add(this.ButDeleteStudent);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TextStudentID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "deletestudentcontrol";
            this.Size = new System.Drawing.Size(548, 340);
            this.Load += new System.EventHandler(this.deletestudentcontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox TextStudentID;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton ButDeleteStudent;
        private MaterialSkin.Controls.MaterialTextBox TextStudentInformation;
    }
}
