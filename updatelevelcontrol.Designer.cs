namespace new_project1
{
    partial class updatelevelcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatelevelcontrol));
            this.ButUpdate = new MaterialSkin.Controls.MaterialButton();
            this.TextUpdatedName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxLevels = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxMajor = new MaterialSkin.Controls.MaterialComboBox();
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ButUpdate
            // 
            this.ButUpdate.AutoSize = false;
            this.ButUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButUpdate.Depth = 0;
            this.ButUpdate.HighEmphasis = true;
            this.ButUpdate.Icon = null;
            this.ButUpdate.Location = new System.Drawing.Point(50, 201);
            this.ButUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButUpdate.Name = "ButUpdate";
            this.ButUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButUpdate.Size = new System.Drawing.Size(97, 29);
            this.ButUpdate.TabIndex = 13;
            this.ButUpdate.Text = "Update";
            this.ButUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButUpdate.UseAccentColor = false;
            this.ButUpdate.UseVisualStyleBackColor = true;
            this.ButUpdate.Click += new System.EventHandler(this.ButUpdate_Click);
            // 
            // TextUpdatedName
            // 
            this.TextUpdatedName.AnimateReadOnly = false;
            this.TextUpdatedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUpdatedName.Depth = 0;
            this.TextUpdatedName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextUpdatedName.LeadingIcon = null;
            this.TextUpdatedName.Location = new System.Drawing.Point(9, 93);
            this.TextUpdatedName.Margin = new System.Windows.Forms.Padding(2);
            this.TextUpdatedName.MaxLength = 50;
            this.TextUpdatedName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextUpdatedName.Multiline = false;
            this.TextUpdatedName.Name = "TextUpdatedName";
            this.TextUpdatedName.Size = new System.Drawing.Size(190, 50);
            this.TextUpdatedName.TabIndex = 11;
            this.TextUpdatedName.Text = "";
            this.TextUpdatedName.TrailingIcon = null;
            this.TextUpdatedName.TextChanged += new System.EventHandler(this.TextUpdatedName_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(14, 67);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "New Class Name";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 3);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Select Class";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 136);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "catagory";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
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
            this.ComboBoxLevels.Location = new System.Drawing.Point(10, 21);
            this.ComboBoxLevels.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxLevels.MaxDropDownItems = 4;
            this.ComboBoxLevels.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxLevels.Name = "ComboBoxLevels";
            this.ComboBoxLevels.Size = new System.Drawing.Size(190, 49);
            this.ComboBoxLevels.StartIndex = 0;
            this.ComboBoxLevels.TabIndex = 16;
            this.ComboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLevels_SelectedIndexChanged);
            // 
            // ComboBoxMajor
            // 
            this.ComboBoxMajor.AutoResize = false;
            this.ComboBoxMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxMajor.Depth = 0;
            this.ComboBoxMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxMajor.DropDownHeight = 174;
            this.ComboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMajor.DropDownWidth = 121;
            this.ComboBoxMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxMajor.FormattingEnabled = true;
            this.ComboBoxMajor.IntegralHeight = false;
            this.ComboBoxMajor.ItemHeight = 43;
            this.ComboBoxMajor.Location = new System.Drawing.Point(10, 154);
            this.ComboBoxMajor.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxMajor.MaxDropDownItems = 4;
            this.ComboBoxMajor.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxMajor.Name = "ComboBoxMajor";
            this.ComboBoxMajor.Size = new System.Drawing.Size(190, 49);
            this.ComboBoxMajor.StartIndex = 0;
            this.ComboBoxMajor.TabIndex = 17;
            this.ComboBoxMajor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMajor_SelectedIndexChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(212, 21);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 18;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // updatelevelcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.ComboBoxMajor);
            this.Controls.Add(this.ComboBoxLevels);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ButUpdate);
            this.Controls.Add(this.TextUpdatedName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "updatelevelcontrol";
            this.Size = new System.Drawing.Size(280, 422);
            this.Load += new System.EventHandler(this.updatelevelcontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButUpdate;
        private MaterialSkin.Controls.MaterialTextBox TextUpdatedName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxLevels;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxMajor;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
