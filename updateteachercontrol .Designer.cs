namespace new_project1
{
    partial class updateteachercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateteachercontrol));
            this.TextTeacherID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxLevels = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxSubjects = new MaterialSkin.Controls.MaterialComboBox();
            this.ButAddSubject = new MaterialSkin.Controls.MaterialButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextTeacherID
            // 
            this.TextTeacherID.AnimateReadOnly = false;
            this.TextTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTeacherID.Depth = 0;
            this.TextTeacherID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTeacherID.LeadingIcon = null;
            this.TextTeacherID.Location = new System.Drawing.Point(10, 28);
            this.TextTeacherID.Margin = new System.Windows.Forms.Padding(2);
            this.TextTeacherID.MaxLength = 50;
            this.TextTeacherID.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTeacherID.Multiline = false;
            this.TextTeacherID.Name = "TextTeacherID";
            this.TextTeacherID.Size = new System.Drawing.Size(184, 50);
            this.TextTeacherID.TabIndex = 0;
            this.TextTeacherID.Text = "";
            this.TextTeacherID.TrailingIcon = null;
            this.TextTeacherID.TextChanged += new System.EventHandler(this.TextTeacherID_TextChanged);
            this.TextTeacherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTeacherID_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 11);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Coach ID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 76);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Select Class";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 143);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(101, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Select Section";
            // 
            // ComboBoxLevels
            // 
            this.ComboBoxLevels.AutoResize = false;
            this.ComboBoxLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxLevels.Depth = 0;
            this.ComboBoxLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxLevels.DropDownHeight = 174;
            this.ComboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLevels.DropDownWidth = 121;
            this.ComboBoxLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxLevels.FormattingEnabled = true;
            this.ComboBoxLevels.IntegralHeight = false;
            this.ComboBoxLevels.ItemHeight = 43;
            this.ComboBoxLevels.Location = new System.Drawing.Point(11, 94);
            this.ComboBoxLevels.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxLevels.MaxDropDownItems = 4;
            this.ComboBoxLevels.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxLevels.Name = "ComboBoxLevels";
            this.ComboBoxLevels.Size = new System.Drawing.Size(184, 49);
            this.ComboBoxLevels.StartIndex = 0;
            this.ComboBoxLevels.TabIndex = 8;
            this.ComboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLevels_SelectedIndexChanged);
            // 
            // ComboBoxSubjects
            // 
            this.ComboBoxSubjects.AutoResize = false;
            this.ComboBoxSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSubjects.Depth = 0;
            this.ComboBoxSubjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSubjects.DropDownHeight = 174;
            this.ComboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubjects.DropDownWidth = 121;
            this.ComboBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSubjects.FormattingEnabled = true;
            this.ComboBoxSubjects.IntegralHeight = false;
            this.ComboBoxSubjects.ItemHeight = 43;
            this.ComboBoxSubjects.Location = new System.Drawing.Point(11, 161);
            this.ComboBoxSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxSubjects.MaxDropDownItems = 4;
            this.ComboBoxSubjects.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSubjects.Name = "ComboBoxSubjects";
            this.ComboBoxSubjects.Size = new System.Drawing.Size(184, 49);
            this.ComboBoxSubjects.StartIndex = 0;
            this.ComboBoxSubjects.TabIndex = 9;
            this.ComboBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubjects_SelectedIndexChanged);
            // 
            // ButAddSubject
            // 
            this.ButAddSubject.AutoSize = false;
            this.ButAddSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButAddSubject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButAddSubject.Depth = 0;
            this.ButAddSubject.HighEmphasis = true;
            this.ButAddSubject.Icon = null;
            this.ButAddSubject.Location = new System.Drawing.Point(33, 208);
            this.ButAddSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButAddSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButAddSubject.Name = "ButAddSubject";
            this.ButAddSubject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButAddSubject.Size = new System.Drawing.Size(106, 33);
            this.ButAddSubject.TabIndex = 10;
            this.ButAddSubject.Text = "Add section";
            this.ButAddSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButAddSubject.UseAccentColor = false;
            this.ButAddSubject.UseVisualStyleBackColor = true;
            this.ButAddSubject.Click += new System.EventHandler(this.ButAddSubject_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(282, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(497, 366);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.columnHeader3.Text = "section";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Class";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "gender";
            this.columnHeader2.Width = 140;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(219, 28);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 44;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // updateteachercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButAddSubject);
            this.Controls.Add(this.ComboBoxSubjects);
            this.Controls.Add(this.ComboBoxLevels);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextTeacherID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "updateteachercontrol";
            this.Size = new System.Drawing.Size(903, 425);
            this.Load += new System.EventHandler(this.updateteachercontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextTeacherID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxLevels;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSubjects;
        private MaterialSkin.Controls.MaterialButton ButAddSubject;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
