namespace new_project1
{
    partial class TeacherSchedule
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
            this.ComboBoxTeachers = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ButFindTheSchedule = new MaterialSkin.Controls.MaterialButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ComboBoxTeachers
            // 
            this.ComboBoxTeachers.AutoResize = false;
            this.ComboBoxTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxTeachers.Depth = 0;
            this.ComboBoxTeachers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxTeachers.DropDownHeight = 174;
            this.ComboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTeachers.DropDownWidth = 121;
            this.ComboBoxTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxTeachers.FormattingEnabled = true;
            this.ComboBoxTeachers.IntegralHeight = false;
            this.ComboBoxTeachers.ItemHeight = 43;
            this.ComboBoxTeachers.Location = new System.Drawing.Point(30, 46);
            this.ComboBoxTeachers.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTeachers.MaxDropDownItems = 4;
            this.ComboBoxTeachers.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxTeachers.Name = "ComboBoxTeachers";
            this.ComboBoxTeachers.Size = new System.Drawing.Size(210, 49);
            this.ComboBoxTeachers.StartIndex = 0;
            this.ComboBoxTeachers.TabIndex = 1;
            this.ComboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTeachers_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 28);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Select Coach";
            // 
            // ButFindTheSchedule
            // 
            this.ButFindTheSchedule.AutoSize = false;
            this.ButFindTheSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButFindTheSchedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButFindTheSchedule.Depth = 0;
            this.ButFindTheSchedule.HighEmphasis = true;
            this.ButFindTheSchedule.Icon = null;
            this.ButFindTheSchedule.Location = new System.Drawing.Point(272, 46);
            this.ButFindTheSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButFindTheSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButFindTheSchedule.Name = "ButFindTheSchedule";
            this.ButFindTheSchedule.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButFindTheSchedule.Size = new System.Drawing.Size(154, 29);
            this.ButFindTheSchedule.TabIndex = 2;
            this.ButFindTheSchedule.Text = "find the schedule";
            this.ButFindTheSchedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButFindTheSchedule.UseAccentColor = false;
            this.ButFindTheSchedule.UseVisualStyleBackColor = true;
            this.ButFindTheSchedule.Click += new System.EventHandler(this.ButFindTheSchedule_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader10,
            this.columnHeader13});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.listView1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 116);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(926, 202);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CoachName";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "class";
            this.columnHeader11.Width = 140;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "gender";
            this.columnHeader14.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "section";
            this.columnHeader10.Width = 160;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Day";
            this.columnHeader13.Width = 150;
            // 
            // TeacherSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButFindTheSchedule);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ComboBoxTeachers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherSchedule";
            this.Size = new System.Drawing.Size(1139, 548);
            this.Load += new System.EventHandler(this.TeacherSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ComboBoxTeachers;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButFindTheSchedule;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}
