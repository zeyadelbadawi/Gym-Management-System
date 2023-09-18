namespace new_project1
{
    partial class Insert_new_teacher
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TextTeacherName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextTeacherPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.ButAddTeacher = new MaterialSkin.Controls.MaterialButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(14, 7);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Coach Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 78);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Phone";
            // 
            // TextTeacherName
            // 
            this.TextTeacherName.AnimateReadOnly = false;
            this.TextTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherName.Depth = 0;
            this.TextTeacherName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherName.LeadingIcon = null;
            this.TextTeacherName.Location = new System.Drawing.Point(9, 33);
            this.TextTeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTeacherName.MaxLength = 50;
            this.TextTeacherName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherName.Multiline = false;
            this.TextTeacherName.Name = "TextTeacherName";
            this.TextTeacherName.Size = new System.Drawing.Size(149, 50);
            this.TextTeacherName.TabIndex = 3;
            this.TextTeacherName.Text = "";
            this.TextTeacherName.TrailingIcon = null;
            // 
            // TextTeacherPhone
            // 
            this.TextTeacherPhone.AnimateReadOnly = false;
            this.TextTeacherPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherPhone.Depth = 0;
            this.TextTeacherPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherPhone.LeadingIcon = null;
            this.TextTeacherPhone.Location = new System.Drawing.Point(9, 103);
            this.TextTeacherPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTeacherPhone.MaxLength = 50;
            this.TextTeacherPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherPhone.Multiline = false;
            this.TextTeacherPhone.Name = "TextTeacherPhone";
            this.TextTeacherPhone.Size = new System.Drawing.Size(149, 50);
            this.TextTeacherPhone.TabIndex = 4;
            this.TextTeacherPhone.Text = "";
            this.TextTeacherPhone.TrailingIcon = null;
            this.TextTeacherPhone.TextChanged += new System.EventHandler(this.TextTeacherPhone_TextChanged);
            this.TextTeacherPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTeacherPhone_KeyPress);
            // 
            // ButAddTeacher
            // 
            this.ButAddTeacher.AutoSize = false;
            this.ButAddTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButAddTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButAddTeacher.Depth = 0;
            this.ButAddTeacher.HighEmphasis = true;
            this.ButAddTeacher.Icon = null;
            this.ButAddTeacher.Location = new System.Drawing.Point(31, 151);
            this.ButAddTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButAddTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButAddTeacher.Name = "ButAddTeacher";
            this.ButAddTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButAddTeacher.Size = new System.Drawing.Size(95, 35);
            this.ButAddTeacher.TabIndex = 5;
            this.ButAddTeacher.Text = "Submit";
            this.ButAddTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButAddTeacher.UseAccentColor = false;
            this.ButAddTeacher.UseVisualStyleBackColor = true;
            this.ButAddTeacher.Click += new System.EventHandler(this.ButAddTeacher_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(206, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 309);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Coach Name";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 140;
            // 
            // Insert_new_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButAddTeacher);
            this.Controls.Add(this.TextTeacherPhone);
            this.Controls.Add(this.TextTeacherName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Insert_new_teacher";
            this.Size = new System.Drawing.Size(564, 409);
            this.Load += new System.EventHandler(this.Insert_new_teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox TextTeacherName;
        private MaterialSkin.Controls.MaterialTextBox TextTeacherPhone;
        private MaterialSkin.Controls.MaterialButton ButAddTeacher;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
