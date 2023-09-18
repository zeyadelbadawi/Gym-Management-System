namespace new_project1
{
    partial class deleteteachercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteteachercontrol));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ButDeleteTeacher = new MaterialSkin.Controls.MaterialButton();
            this.TextTeacherID = new MaterialSkin.Controls.MaterialTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 10);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Enter Coach ID";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ButDeleteTeacher
            // 
            this.ButDeleteTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDeleteTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButDeleteTeacher.Depth = 0;
            this.ButDeleteTeacher.HighEmphasis = true;
            this.ButDeleteTeacher.Icon = null;
            this.ButDeleteTeacher.Location = new System.Drawing.Point(35, 76);
            this.ButDeleteTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButDeleteTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButDeleteTeacher.Name = "ButDeleteTeacher";
            this.ButDeleteTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButDeleteTeacher.Size = new System.Drawing.Size(142, 36);
            this.ButDeleteTeacher.TabIndex = 5;
            this.ButDeleteTeacher.Text = "Delete Coach";
            this.ButDeleteTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButDeleteTeacher.UseAccentColor = false;
            this.ButDeleteTeacher.UseVisualStyleBackColor = true;
            this.ButDeleteTeacher.Click += new System.EventHandler(this.ButDeleteTeacher_Click);
            // 
            // TextTeacherID
            // 
            this.TextTeacherID.AnimateReadOnly = false;
            this.TextTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherID.Depth = 0;
            this.TextTeacherID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherID.LeadingIcon = null;
            this.TextTeacherID.Location = new System.Drawing.Point(9, 28);
            this.TextTeacherID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTeacherID.MaxLength = 50;
            this.TextTeacherID.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherID.Multiline = false;
            this.TextTeacherID.Name = "TextTeacherID";
            this.TextTeacherID.Size = new System.Drawing.Size(166, 50);
            this.TextTeacherID.TabIndex = 6;
            this.TextTeacherID.Text = "";
            this.TextTeacherID.TrailingIcon = null;
            this.TextTeacherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTeacherID_KeyPress);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 313);
            this.listView1.TabIndex = 42;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phone";
            this.columnHeader1.Width = 160;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(189, 28);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 43;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // deleteteachercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TextTeacherID);
            this.Controls.Add(this.ButDeleteTeacher);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "deleteteachercontrol";
            this.Size = new System.Drawing.Size(668, 507);
            this.Load += new System.EventHandler(this.deleteteachercontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButDeleteTeacher;
        private MaterialSkin.Controls.MaterialTextBox TextTeacherID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
