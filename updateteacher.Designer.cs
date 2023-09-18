namespace new_project1
{
    partial class UpdateTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTeacher));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ButUpdateTeacher = new MaterialSkin.Controls.MaterialButton();
            this.TextTeacherID = new MaterialSkin.Controls.MaterialTextBox();
            this.TextTeacherName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextteacherPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 11);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter Coach ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 80);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(127, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "New Coach Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 149);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(130, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "New Coach Phone";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // ButUpdateTeacher
            // 
            this.ButUpdateTeacher.AutoSize = false;
            this.ButUpdateTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButUpdateTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButUpdateTeacher.Depth = 0;
            this.ButUpdateTeacher.HighEmphasis = true;
            this.ButUpdateTeacher.Icon = null;
            this.ButUpdateTeacher.Location = new System.Drawing.Point(32, 223);
            this.ButUpdateTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButUpdateTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButUpdateTeacher.Name = "ButUpdateTeacher";
            this.ButUpdateTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButUpdateTeacher.Size = new System.Drawing.Size(82, 29);
            this.ButUpdateTeacher.TabIndex = 4;
            this.ButUpdateTeacher.Text = "Update";
            this.ButUpdateTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButUpdateTeacher.UseAccentColor = false;
            this.ButUpdateTeacher.UseVisualStyleBackColor = true;
            this.ButUpdateTeacher.Click += new System.EventHandler(this.ButUpdateTeacher_Click);
            // 
            // TextTeacherID
            // 
            this.TextTeacherID.AnimateReadOnly = false;
            this.TextTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherID.Depth = 0;
            this.TextTeacherID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherID.LeadingIcon = null;
            this.TextTeacherID.Location = new System.Drawing.Point(10, 29);
            this.TextTeacherID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTeacherID.MaxLength = 50;
            this.TextTeacherID.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherID.Multiline = false;
            this.TextTeacherID.Name = "TextTeacherID";
            this.TextTeacherID.Size = new System.Drawing.Size(167, 50);
            this.TextTeacherID.TabIndex = 1;
            this.TextTeacherID.Text = "";
            this.TextTeacherID.TrailingIcon = null;
            this.TextTeacherID.TextChanged += new System.EventHandler(this.TextTeacherID_TextChanged);
            this.TextTeacherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTeacherID_KeyPress);
            // 
            // TextTeacherName
            // 
            this.TextTeacherName.AnimateReadOnly = false;
            this.TextTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherName.Depth = 0;
            this.TextTeacherName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherName.LeadingIcon = null;
            this.TextTeacherName.Location = new System.Drawing.Point(10, 98);
            this.TextTeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTeacherName.MaxLength = 50;
            this.TextTeacherName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherName.Multiline = false;
            this.TextTeacherName.Name = "TextTeacherName";
            this.TextTeacherName.Size = new System.Drawing.Size(167, 50);
            this.TextTeacherName.TabIndex = 2;
            this.TextTeacherName.Text = "";
            this.TextTeacherName.TrailingIcon = null;
            // 
            // TextteacherPhone
            // 
            this.TextteacherPhone.AnimateReadOnly = false;
            this.TextteacherPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextteacherPhone.Depth = 0;
            this.TextteacherPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextteacherPhone.LeadingIcon = null;
            this.TextteacherPhone.Location = new System.Drawing.Point(10, 167);
            this.TextteacherPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextteacherPhone.MaxLength = 50;
            this.TextteacherPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TextteacherPhone.Multiline = false;
            this.TextteacherPhone.Name = "TextteacherPhone";
            this.TextteacherPhone.Size = new System.Drawing.Size(167, 50);
            this.TextteacherPhone.TabIndex = 3;
            this.TextteacherPhone.Text = "";
            this.TextteacherPhone.TrailingIcon = null;
            this.TextteacherPhone.TextChanged += new System.EventHandler(this.TextteacherPhone_TextChanged);
            this.TextteacherPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextteacherPhone_KeyPress);
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
            this.listView1.Location = new System.Drawing.Point(236, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 309);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "coach Name";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 140;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(183, 29);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 41;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TextteacherPhone);
            this.Controls.Add(this.TextTeacherName);
            this.Controls.Add(this.TextTeacherID);
            this.Controls.Add(this.ButUpdateTeacher);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateTeacher";
            this.Size = new System.Drawing.Size(568, 410);
            this.Load += new System.EventHandler(this.UpdateTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton ButUpdateTeacher;
        private MaterialSkin.Controls.MaterialTextBox TextTeacherID;
        private MaterialSkin.Controls.MaterialTextBox TextTeacherName;
        private MaterialSkin.Controls.MaterialTextBox TextteacherPhone;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
