namespace new_project1
{
    partial class deletecoursecontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletecoursecontrol));
            this.ButDeleteSubject = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxSubject = new MaterialSkin.Controls.MaterialComboBox();
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ButDeleteSubject
            // 
            this.ButDeleteSubject.AutoSize = false;
            this.ButDeleteSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDeleteSubject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButDeleteSubject.Depth = 0;
            this.ButDeleteSubject.HighEmphasis = true;
            this.ButDeleteSubject.Icon = null;
            this.ButDeleteSubject.Location = new System.Drawing.Point(43, 102);
            this.ButDeleteSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButDeleteSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButDeleteSubject.Name = "ButDeleteSubject";
            this.ButDeleteSubject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButDeleteSubject.Size = new System.Drawing.Size(128, 38);
            this.ButDeleteSubject.TabIndex = 3;
            this.ButDeleteSubject.Text = "Delete Section";
            this.ButDeleteSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButDeleteSubject.UseAccentColor = false;
            this.ButDeleteSubject.UseVisualStyleBackColor = true;
            this.ButDeleteSubject.Click += new System.EventHandler(this.ButDeleteSubject_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(11, 18);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Section Name";
            // 
            // ComboBoxSubject
            // 
            this.ComboBoxSubject.AutoResize = false;
            this.ComboBoxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSubject.Depth = 0;
            this.ComboBoxSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSubject.DropDownHeight = 174;
            this.ComboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubject.DropDownWidth = 121;
            this.ComboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSubject.FormattingEnabled = true;
            this.ComboBoxSubject.IntegralHeight = false;
            this.ComboBoxSubject.ItemHeight = 43;
            this.ComboBoxSubject.Location = new System.Drawing.Point(14, 44);
            this.ComboBoxSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxSubject.MaxDropDownItems = 4;
            this.ComboBoxSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSubject.Name = "ComboBoxSubject";
            this.ComboBoxSubject.Size = new System.Drawing.Size(218, 49);
            this.ComboBoxSubject.StartIndex = 0;
            this.ComboBoxSubject.TabIndex = 25;
            this.ComboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubject_SelectedIndexChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(248, 44);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 26;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // deletecoursecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.ComboBoxSubject);
            this.Controls.Add(this.ButDeleteSubject);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "deletecoursecontrol";
            this.Size = new System.Drawing.Size(311, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButDeleteSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSubject;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
