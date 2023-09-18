namespace new_project1
{
    partial class StudentReportsControls
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
            this.LabelSearchType = new MaterialSkin.Controls.MaterialLabel();
            this.TextTypeSearchOfStudent = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxTypeOfSearch = new MaterialSkin.Controls.MaterialComboBox();
            this.ButSelectStudents = new MaterialSkin.Controls.MaterialButton();
            this.ComboBoxTypeOfReport = new MaterialSkin.Controls.MaterialComboBox();
            this.LabelofReporttype = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LabelSearchType
            // 
            this.LabelSearchType.AutoSize = true;
            this.LabelSearchType.Depth = 0;
            this.LabelSearchType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelSearchType.Location = new System.Drawing.Point(208, 10);
            this.LabelSearchType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSearchType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelSearchType.Name = "LabelSearchType";
            this.LabelSearchType.Size = new System.Drawing.Size(99, 19);
            this.LabelSearchType.TabIndex = 30;
            this.LabelSearchType.Text = "Enter Member";
            this.LabelSearchType.Visible = false;
            this.LabelSearchType.Click += new System.EventHandler(this.LabelSearchType_Click);
            // 
            // TextTypeSearchOfStudent
            // 
            this.TextTypeSearchOfStudent.AnimateReadOnly = false;
            this.TextTypeSearchOfStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTypeSearchOfStudent.Depth = 0;
            this.TextTypeSearchOfStudent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTypeSearchOfStudent.LeadingIcon = null;
            this.TextTypeSearchOfStudent.Location = new System.Drawing.Point(201, 34);
            this.TextTypeSearchOfStudent.Margin = new System.Windows.Forms.Padding(2);
            this.TextTypeSearchOfStudent.MaxLength = 50;
            this.TextTypeSearchOfStudent.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTypeSearchOfStudent.Multiline = false;
            this.TextTypeSearchOfStudent.Name = "TextTypeSearchOfStudent";
            this.TextTypeSearchOfStudent.Size = new System.Drawing.Size(178, 50);
            this.TextTypeSearchOfStudent.TabIndex = 2;
            this.TextTypeSearchOfStudent.Text = "";
            this.TextTypeSearchOfStudent.TrailingIcon = null;
            this.TextTypeSearchOfStudent.Visible = false;
            this.TextTypeSearchOfStudent.TextChanged += new System.EventHandler(this.TextTypeSearchOfStudent_TextChanged);
            this.TextTypeSearchOfStudent.Enter += new System.EventHandler(this.TextTypeSearchOfStudent_Enter);
            this.TextTypeSearchOfStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTypeSearchOfStudent_KeyPress);
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
            this.materialLabel1.Size = new System.Drawing.Size(157, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Select Type Of Search";
            // 
            // ComboBoxTypeOfSearch
            // 
            this.ComboBoxTypeOfSearch.AutoResize = false;
            this.ComboBoxTypeOfSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeOfSearch.Depth = 0;
            this.ComboBoxTypeOfSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxTypeOfSearch.DropDownHeight = 174;
            this.ComboBoxTypeOfSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeOfSearch.DropDownWidth = 121;
            this.ComboBoxTypeOfSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxTypeOfSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxTypeOfSearch.FormattingEnabled = true;
            this.ComboBoxTypeOfSearch.IntegralHeight = false;
            this.ComboBoxTypeOfSearch.ItemHeight = 43;
            this.ComboBoxTypeOfSearch.Location = new System.Drawing.Point(10, 35);
            this.ComboBoxTypeOfSearch.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTypeOfSearch.MaxDropDownItems = 4;
            this.ComboBoxTypeOfSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxTypeOfSearch.Name = "ComboBoxTypeOfSearch";
            this.ComboBoxTypeOfSearch.Size = new System.Drawing.Size(179, 49);
            this.ComboBoxTypeOfSearch.StartIndex = 0;
            this.ComboBoxTypeOfSearch.TabIndex = 1;
            this.ComboBoxTypeOfSearch.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeOfSearch_SelectedIndexChanged);
            // 
            // ButSelectStudents
            // 
            this.ButSelectStudents.AutoSize = false;
            this.ButSelectStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSelectStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButSelectStudents.Depth = 0;
            this.ButSelectStudents.HighEmphasis = true;
            this.ButSelectStudents.Icon = null;
            this.ButSelectStudents.Location = new System.Drawing.Point(602, 34);
            this.ButSelectStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButSelectStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButSelectStudents.Name = "ButSelectStudents";
            this.ButSelectStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButSelectStudents.Size = new System.Drawing.Size(108, 29);
            this.ButSelectStudents.TabIndex = 4;
            this.ButSelectStudents.Text = "Select Member";
            this.ButSelectStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButSelectStudents.UseAccentColor = false;
            this.ButSelectStudents.UseVisualStyleBackColor = true;
            this.ButSelectStudents.Visible = false;
            this.ButSelectStudents.Click += new System.EventHandler(this.ButSelectStudents_Click);
            // 
            // ComboBoxTypeOfReport
            // 
            this.ComboBoxTypeOfReport.AutoResize = false;
            this.ComboBoxTypeOfReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeOfReport.Depth = 0;
            this.ComboBoxTypeOfReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxTypeOfReport.DropDownHeight = 174;
            this.ComboBoxTypeOfReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeOfReport.DropDownWidth = 121;
            this.ComboBoxTypeOfReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxTypeOfReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxTypeOfReport.FormattingEnabled = true;
            this.ComboBoxTypeOfReport.IntegralHeight = false;
            this.ComboBoxTypeOfReport.ItemHeight = 43;
            this.ComboBoxTypeOfReport.Location = new System.Drawing.Point(393, 35);
            this.ComboBoxTypeOfReport.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTypeOfReport.MaxDropDownItems = 4;
            this.ComboBoxTypeOfReport.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxTypeOfReport.Name = "ComboBoxTypeOfReport";
            this.ComboBoxTypeOfReport.Size = new System.Drawing.Size(179, 49);
            this.ComboBoxTypeOfReport.StartIndex = 0;
            this.ComboBoxTypeOfReport.TabIndex = 3;
            this.ComboBoxTypeOfReport.Visible = false;
            this.ComboBoxTypeOfReport.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeOfReport_SelectedIndexChanged);
            // 
            // LabelofReporttype
            // 
            this.LabelofReporttype.AutoSize = true;
            this.LabelofReporttype.Depth = 0;
            this.LabelofReporttype.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelofReporttype.Location = new System.Drawing.Point(399, 10);
            this.LabelofReporttype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelofReporttype.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelofReporttype.Name = "LabelofReporttype";
            this.LabelofReporttype.Size = new System.Drawing.Size(154, 19);
            this.LabelofReporttype.TabIndex = 27;
            this.LabelofReporttype.Text = "Select Type Of Report";
            this.LabelofReporttype.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.listView1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 99);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1044, 162);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = " ";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = " ";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = " ";
            this.columnHeader10.Width = 160;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = " ";
            this.columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = " ";
            this.columnHeader12.Width = 140;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = " ";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = " ";
            this.columnHeader14.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " ";
            this.columnHeader2.Width = 160;
            // 
            // StudentReportsControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LabelSearchType);
            this.Controls.Add(this.TextTypeSearchOfStudent);
            this.Controls.Add(this.LabelofReporttype);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ComboBoxTypeOfReport);
            this.Controls.Add(this.ComboBoxTypeOfSearch);
            this.Controls.Add(this.ButSelectStudents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentReportsControls";
            this.Size = new System.Drawing.Size(1658, 587);
            this.Load += new System.EventHandler(this.StudentReportsControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelSearchType;
        private MaterialSkin.Controls.MaterialTextBox TextTypeSearchOfStudent;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxTypeOfSearch;
        private MaterialSkin.Controls.MaterialButton ButSelectStudents;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxTypeOfReport;
        private MaterialSkin.Controls.MaterialLabel LabelofReporttype;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
