namespace new_project1
{
    partial class InsertStudentControl
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
            this.Level_Label = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxLevel = new MaterialSkin.Controls.MaterialComboBox();
            this.Ratio_btnMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.Ratio_btnFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.Name_Label = new MaterialSkin.Controls.MaterialLabel();
            this.TextStudentPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.TextStudentName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ButSubmetStudent = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.materialComboSection = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabelSection = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Level_Label
            // 
            this.Level_Label.AutoSize = true;
            this.Level_Label.Depth = 0;
            this.Level_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Level_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Level_Label.Location = new System.Drawing.Point(2, 75);
            this.Level_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Level_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Level_Label.Name = "Level_Label";
            this.Level_Label.Size = new System.Drawing.Size(40, 19);
            this.Level_Label.TabIndex = 41;
            this.Level_Label.Text = "Class";
            // 
            // ComboBoxLevel
            // 
            this.ComboBoxLevel.AllowDrop = true;
            this.ComboBoxLevel.AutoResize = false;
            this.ComboBoxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxLevel.Depth = 0;
            this.ComboBoxLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxLevel.DropDownHeight = 174;
            this.ComboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLevel.DropDownWidth = 121;
            this.ComboBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxLevel.FormattingEnabled = true;
            this.ComboBoxLevel.IntegralHeight = false;
            this.ComboBoxLevel.ItemHeight = 43;
            this.ComboBoxLevel.Location = new System.Drawing.Point(2, 96);
            this.ComboBoxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxLevel.MaxDropDownItems = 4;
            this.ComboBoxLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxLevel.Name = "ComboBoxLevel";
            this.ComboBoxLevel.Size = new System.Drawing.Size(175, 49);
            this.ComboBoxLevel.StartIndex = 0;
            this.ComboBoxLevel.TabIndex = 6;
            this.ComboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLevel_SelectedIndexChanged);
            // 
            // Ratio_btnMale
            // 
            this.Ratio_btnMale.AutoSize = true;
            this.Ratio_btnMale.Depth = 0;
            this.Ratio_btnMale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ratio_btnMale.Location = new System.Drawing.Point(72, 212);
            this.Ratio_btnMale.Margin = new System.Windows.Forms.Padding(0);
            this.Ratio_btnMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Ratio_btnMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ratio_btnMale.Name = "Ratio_btnMale";
            this.Ratio_btnMale.Ripple = true;
            this.Ratio_btnMale.Size = new System.Drawing.Size(70, 37);
            this.Ratio_btnMale.TabIndex = 8;
            this.Ratio_btnMale.TabStop = true;
            this.Ratio_btnMale.Text = "Male";
            this.Ratio_btnMale.UseVisualStyleBackColor = true;
            this.Ratio_btnMale.CheckedChanged += new System.EventHandler(this.Ratio_btnMale_CheckedChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel8.Location = new System.Drawing.Point(2, 222);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(59, 19);
            this.materialLabel8.TabIndex = 38;
            this.materialLabel8.Text = "Gender :";
            // 
            // Ratio_btnFemale
            // 
            this.Ratio_btnFemale.AutoSize = true;
            this.Ratio_btnFemale.Depth = 0;
            this.Ratio_btnFemale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ratio_btnFemale.Location = new System.Drawing.Point(168, 212);
            this.Ratio_btnFemale.Margin = new System.Windows.Forms.Padding(0);
            this.Ratio_btnFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Ratio_btnFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ratio_btnFemale.Name = "Ratio_btnFemale";
            this.Ratio_btnFemale.Ripple = true;
            this.Ratio_btnFemale.Size = new System.Drawing.Size(87, 37);
            this.Ratio_btnFemale.TabIndex = 9;
            this.Ratio_btnFemale.TabStop = true;
            this.Ratio_btnFemale.Text = "Female";
            this.Ratio_btnFemale.UseVisualStyleBackColor = true;
            this.Ratio_btnFemale.CheckedChanged += new System.EventHandler(this.Ratio_btnFemale_CheckedChanged);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Depth = 0;
            this.Name_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name_Label.Location = new System.Drawing.Point(8, 4);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(105, 19);
            this.Name_Label.TabIndex = 43;
            this.Name_Label.Text = "Member Name";
            // 
            // TextStudentPhone
            // 
            this.TextStudentPhone.AnimateReadOnly = false;
            this.TextStudentPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStudentPhone.Depth = 0;
            this.TextStudentPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextStudentPhone.LeadingIcon = null;
            this.TextStudentPhone.Location = new System.Drawing.Point(178, 22);
            this.TextStudentPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TextStudentPhone.MaxLength = 11;
            this.TextStudentPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TextStudentPhone.Multiline = false;
            this.TextStudentPhone.Name = "TextStudentPhone";
            this.TextStudentPhone.Size = new System.Drawing.Size(172, 50);
            this.TextStudentPhone.TabIndex = 2;
            this.TextStudentPhone.Text = "";
            this.TextStudentPhone.TrailingIcon = null;
            this.TextStudentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStudentPhone_KeyPress);
            // 
            // TextStudentName
            // 
            this.TextStudentName.AnimateReadOnly = false;
            this.TextStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStudentName.Depth = 0;
            this.TextStudentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextStudentName.LeadingIcon = null;
            this.TextStudentName.Location = new System.Drawing.Point(2, 22);
            this.TextStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.TextStudentName.MaxLength = 50;
            this.TextStudentName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextStudentName.Multiline = false;
            this.TextStudentName.Name = "TextStudentName";
            this.TextStudentName.Size = new System.Drawing.Size(172, 50);
            this.TextStudentName.TabIndex = 1;
            this.TextStudentName.Text = "";
            this.TextStudentName.TrailingIcon = null;
            this.TextStudentName.TextChanged += new System.EventHandler(this.TextStudentName_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(188, 4);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Member phone number ";
            // 
            // ButSubmetStudent
            // 
            this.ButSubmetStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSubmetStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButSubmetStudent.Depth = 0;
            this.ButSubmetStudent.HighEmphasis = true;
            this.ButSubmetStudent.Icon = null;
            this.ButSubmetStudent.Location = new System.Drawing.Point(2, 279);
            this.ButSubmetStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButSubmetStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButSubmetStudent.Name = "ButSubmetStudent";
            this.ButSubmetStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButSubmetStudent.Size = new System.Drawing.Size(140, 36);
            this.ButSubmetStudent.TabIndex = 10;
            this.ButSubmetStudent.Text = "Submit Member";
            this.ButSubmetStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButSubmetStudent.UseAccentColor = false;
            this.ButSubmetStudent.UseVisualStyleBackColor = true;
            this.ButSubmetStudent.Click += new System.EventHandler(this.ButSubmetStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(361, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.listView1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(503, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 370);
            this.listView1.TabIndex = 354;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // materialComboSection
            // 
            this.materialComboSection.AllowDrop = true;
            this.materialComboSection.AutoResize = false;
            this.materialComboSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboSection.Depth = 0;
            this.materialComboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboSection.DropDownHeight = 174;
            this.materialComboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboSection.DropDownWidth = 121;
            this.materialComboSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboSection.FormattingEnabled = true;
            this.materialComboSection.IntegralHeight = false;
            this.materialComboSection.ItemHeight = 43;
            this.materialComboSection.Location = new System.Drawing.Point(182, 96);
            this.materialComboSection.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboSection.MaxDropDownItems = 4;
            this.materialComboSection.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboSection.Name = "materialComboSection";
            this.materialComboSection.Size = new System.Drawing.Size(175, 49);
            this.materialComboSection.StartIndex = 0;
            this.materialComboSection.TabIndex = 355;
            // 
            // materialLabelSection
            // 
            this.materialLabelSection.AutoSize = true;
            this.materialLabelSection.Depth = 0;
            this.materialLabelSection.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabelSection.Location = new System.Drawing.Point(188, 75);
            this.materialLabelSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabelSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSection.Name = "materialLabelSection";
            this.materialLabelSection.Size = new System.Drawing.Size(52, 19);
            this.materialLabelSection.TabIndex = 356;
            this.materialLabelSection.Text = "section";
            // 
            // InsertStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabelSection);
            this.Controls.Add(this.materialComboSection);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButSubmetStudent);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Level_Label);
            this.Controls.Add(this.ComboBoxLevel);
            this.Controls.Add(this.Ratio_btnMale);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.Ratio_btnFemale);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.TextStudentPhone);
            this.Controls.Add(this.TextStudentName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertStudentControl";
            this.Size = new System.Drawing.Size(1164, 613);
            this.Load += new System.EventHandler(this.InsertStudentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel Level_Label;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxLevel;
        private MaterialSkin.Controls.MaterialRadioButton Ratio_btnMale;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRadioButton Ratio_btnFemale;
        private MaterialSkin.Controls.MaterialLabel Name_Label;
        private MaterialSkin.Controls.MaterialTextBox TextStudentPhone;
        private MaterialSkin.Controls.MaterialTextBox TextStudentName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButSubmetStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialComboBox materialComboSection;
        private MaterialSkin.Controls.MaterialLabel materialLabelSection;
    }
}
