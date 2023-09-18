namespace new_project1
{
    partial class insertcourse
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
            this.ComboBoxSubjectLevel = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TextSubjectName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ButAddSubject = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ComboBoxSubjectLevel
            // 
            this.ComboBoxSubjectLevel.AutoResize = false;
            this.ComboBoxSubjectLevel.BackColor = System.Drawing.Color.White;
            this.ComboBoxSubjectLevel.Depth = 0;
            this.ComboBoxSubjectLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSubjectLevel.DropDownHeight = 174;
            this.ComboBoxSubjectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubjectLevel.DropDownWidth = 121;
            this.ComboBoxSubjectLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSubjectLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboBoxSubjectLevel.FormattingEnabled = true;
            this.ComboBoxSubjectLevel.IntegralHeight = false;
            this.ComboBoxSubjectLevel.ItemHeight = 43;
            this.ComboBoxSubjectLevel.Location = new System.Drawing.Point(9, 97);
            this.ComboBoxSubjectLevel.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxSubjectLevel.MaxDropDownItems = 4;
            this.ComboBoxSubjectLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSubjectLevel.Name = "ComboBoxSubjectLevel";
            this.ComboBoxSubjectLevel.Size = new System.Drawing.Size(162, 49);
            this.ComboBoxSubjectLevel.StartIndex = 0;
            this.ComboBoxSubjectLevel.TabIndex = 13;
            this.ComboBoxSubjectLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubjectLevel_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 79);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "class";
            // 
            // TextSubjectName
            // 
            this.TextSubjectName.AnimateReadOnly = false;
            this.TextSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSubjectName.Depth = 0;
            this.TextSubjectName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextSubjectName.LeadingIcon = null;
            this.TextSubjectName.Location = new System.Drawing.Point(9, 26);
            this.TextSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TextSubjectName.MaxLength = 50;
            this.TextSubjectName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextSubjectName.Multiline = false;
            this.TextSubjectName.Name = "TextSubjectName";
            this.TextSubjectName.Size = new System.Drawing.Size(161, 50);
            this.TextSubjectName.TabIndex = 11;
            this.TextSubjectName.Text = "";
            this.TextSubjectName.TrailingIcon = null;
            this.TextSubjectName.TextChanged += new System.EventHandler(this.TextSubjectName_TextChanged_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 8);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Section Name";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ButAddSubject
            // 
            this.ButAddSubject.AutoSize = false;
            this.ButAddSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButAddSubject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButAddSubject.Depth = 0;
            this.ButAddSubject.HighEmphasis = true;
            this.ButAddSubject.Icon = null;
            this.ButAddSubject.Location = new System.Drawing.Point(8, 299);
            this.ButAddSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButAddSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButAddSubject.Name = "ButAddSubject";
            this.ButAddSubject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButAddSubject.Size = new System.Drawing.Size(108, 27);
            this.ButAddSubject.TabIndex = 14;
            this.ButAddSubject.Text = "Submit";
            this.ButAddSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButAddSubject.UseAccentColor = false;
            this.ButAddSubject.UseVisualStyleBackColor = true;
            this.ButAddSubject.Click += new System.EventHandler(this.ButAddSubject_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(16, 148);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(35, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "days";
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
            this.checkedListBox1.Location = new System.Drawing.Point(8, 170);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 109);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // insertcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ButAddSubject);
            this.Controls.Add(this.ComboBoxSubjectLevel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.TextSubjectName);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "insertcourse";
            this.Size = new System.Drawing.Size(280, 362);
            this.Load += new System.EventHandler(this.insertcourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ComboBoxSubjectLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox TextSubjectName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButAddSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
