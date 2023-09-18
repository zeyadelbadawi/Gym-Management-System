namespace new_project1
{
    partial class updatecourseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatecourseControl));
            this.ButUpdateSubject = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TextNewSubjectName = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBoxSelectedSubject = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxNewSubjectLevel = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxLevels = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ButUpdateSubject
            // 
            this.ButUpdateSubject.AutoSize = false;
            this.ButUpdateSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButUpdateSubject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButUpdateSubject.Depth = 0;
            this.ButUpdateSubject.HighEmphasis = true;
            this.ButUpdateSubject.Icon = null;
            this.ButUpdateSubject.Location = new System.Drawing.Point(202, 84);
            this.ButUpdateSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButUpdateSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButUpdateSubject.Name = "ButUpdateSubject";
            this.ButUpdateSubject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButUpdateSubject.Size = new System.Drawing.Size(106, 29);
            this.ButUpdateSubject.TabIndex = 20;
            this.ButUpdateSubject.Text = "Update";
            this.ButUpdateSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButUpdateSubject.UseAccentColor = false;
            this.ButUpdateSubject.UseVisualStyleBackColor = true;
            this.ButUpdateSubject.Click += new System.EventHandler(this.ButUpdateSubject_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(9, 197);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Enter New Class";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 66);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Select Section";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(9, 126);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(175, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Enter Section New Name";
            // 
            // TextNewSubjectName
            // 
            this.TextNewSubjectName.AnimateReadOnly = false;
            this.TextNewSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextNewSubjectName.Depth = 0;
            this.TextNewSubjectName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextNewSubjectName.LeadingIcon = null;
            this.TextNewSubjectName.Location = new System.Drawing.Point(2, 144);
            this.TextNewSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TextNewSubjectName.MaxLength = 50;
            this.TextNewSubjectName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextNewSubjectName.Multiline = false;
            this.TextNewSubjectName.Name = "TextNewSubjectName";
            this.TextNewSubjectName.Size = new System.Drawing.Size(190, 50);
            this.TextNewSubjectName.TabIndex = 18;
            this.TextNewSubjectName.Text = "";
            this.TextNewSubjectName.TrailingIcon = null;
            // 
            // ComboBoxSelectedSubject
            // 
            this.ComboBoxSelectedSubject.AutoResize = false;
            this.ComboBoxSelectedSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSelectedSubject.Depth = 0;
            this.ComboBoxSelectedSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSelectedSubject.DropDownHeight = 174;
            this.ComboBoxSelectedSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectedSubject.DropDownWidth = 121;
            this.ComboBoxSelectedSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSelectedSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSelectedSubject.FormattingEnabled = true;
            this.ComboBoxSelectedSubject.IntegralHeight = false;
            this.ComboBoxSelectedSubject.ItemHeight = 43;
            this.ComboBoxSelectedSubject.Location = new System.Drawing.Point(2, 84);
            this.ComboBoxSelectedSubject.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxSelectedSubject.MaxDropDownItems = 4;
            this.ComboBoxSelectedSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSelectedSubject.Name = "ComboBoxSelectedSubject";
            this.ComboBoxSelectedSubject.Size = new System.Drawing.Size(188, 49);
            this.ComboBoxSelectedSubject.StartIndex = 0;
            this.ComboBoxSelectedSubject.TabIndex = 21;
            this.ComboBoxSelectedSubject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedSubject_SelectedIndexChanged);
            // 
            // ComboBoxNewSubjectLevel
            // 
            this.ComboBoxNewSubjectLevel.AutoResize = false;
            this.ComboBoxNewSubjectLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxNewSubjectLevel.Depth = 0;
            this.ComboBoxNewSubjectLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxNewSubjectLevel.DropDownHeight = 174;
            this.ComboBoxNewSubjectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNewSubjectLevel.DropDownWidth = 121;
            this.ComboBoxNewSubjectLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxNewSubjectLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxNewSubjectLevel.FormattingEnabled = true;
            this.ComboBoxNewSubjectLevel.IntegralHeight = false;
            this.ComboBoxNewSubjectLevel.ItemHeight = 43;
            this.ComboBoxNewSubjectLevel.Location = new System.Drawing.Point(2, 222);
            this.ComboBoxNewSubjectLevel.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxNewSubjectLevel.MaxDropDownItems = 4;
            this.ComboBoxNewSubjectLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxNewSubjectLevel.Name = "ComboBoxNewSubjectLevel";
            this.ComboBoxNewSubjectLevel.Size = new System.Drawing.Size(188, 49);
            this.ComboBoxNewSubjectLevel.StartIndex = 0;
            this.ComboBoxNewSubjectLevel.TabIndex = 21;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(9, 6);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Select Class";
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
            this.ComboBoxLevels.Location = new System.Drawing.Point(2, 24);
            this.ComboBoxLevels.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxLevels.MaxDropDownItems = 4;
            this.ComboBoxLevels.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxLevels.Name = "ComboBoxLevels";
            this.ComboBoxLevels.Size = new System.Drawing.Size(188, 49);
            this.ComboBoxLevels.StartIndex = 0;
            this.ComboBoxLevels.TabIndex = 21;
            this.ComboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLevels_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(202, 35);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(32, 28);
            this.materialButton1.TabIndex = 22;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 295);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(189, 109);
            this.checkedListBox1.TabIndex = 25;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(9, 273);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "new days";
            // 
            // updatecourseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.ComboBoxLevels);
            this.Controls.Add(this.ComboBoxNewSubjectLevel);
            this.Controls.Add(this.ComboBoxSelectedSubject);
            this.Controls.Add(this.TextNewSubjectName);
            this.Controls.Add(this.ButUpdateSubject);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "updatecourseControl";
            this.Size = new System.Drawing.Size(471, 703);
            this.Load += new System.EventHandler(this.updatecourseControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButUpdateSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox TextNewSubjectName;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSelectedSubject;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxNewSubjectLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxLevels;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}
