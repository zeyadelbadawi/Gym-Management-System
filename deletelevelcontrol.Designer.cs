namespace new_project1
{
    partial class deletelevelcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletelevelcontrol));
            this.ButDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxDeleteLevel = new MaterialSkin.Controls.MaterialComboBox();
            this.btnrefresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ButDelete
            // 
            this.ButDelete.AutoSize = false;
            this.ButDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButDelete.Depth = 0;
            this.ButDelete.HighEmphasis = true;
            this.ButDelete.Icon = null;
            this.ButDelete.Location = new System.Drawing.Point(44, 92);
            this.ButDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButDelete.Size = new System.Drawing.Size(118, 29);
            this.ButDelete.TabIndex = 19;
            this.ButDelete.Text = "Delete";
            this.ButDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButDelete.UseAccentColor = false;
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 13);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Select Class Name ";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ComboBoxDeleteLevel
            // 
            this.ComboBoxDeleteLevel.AutoResize = false;
            this.ComboBoxDeleteLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxDeleteLevel.Depth = 0;
            this.ComboBoxDeleteLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxDeleteLevel.DropDownHeight = 174;
            this.ComboBoxDeleteLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDeleteLevel.DropDownWidth = 121;
            this.ComboBoxDeleteLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxDeleteLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxDeleteLevel.FormattingEnabled = true;
            this.ComboBoxDeleteLevel.IntegralHeight = false;
            this.ComboBoxDeleteLevel.ItemHeight = 43;
            this.ComboBoxDeleteLevel.Location = new System.Drawing.Point(13, 45);
            this.ComboBoxDeleteLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxDeleteLevel.MaxDropDownItems = 4;
            this.ComboBoxDeleteLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxDeleteLevel.Name = "ComboBoxDeleteLevel";
            this.ComboBoxDeleteLevel.Size = new System.Drawing.Size(176, 49);
            this.ComboBoxDeleteLevel.StartIndex = 0;
            this.ComboBoxDeleteLevel.TabIndex = 20;
            this.ComboBoxDeleteLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeleteLevel_SelectedIndexChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = false;
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrefresh.Depth = 0;
            this.btnrefresh.HighEmphasis = true;
            this.btnrefresh.Icon = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Icon")));
            this.btnrefresh.Location = new System.Drawing.Point(193, 45);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrefresh.Size = new System.Drawing.Size(36, 29);
            this.btnrefresh.TabIndex = 21;
            this.btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrefresh.UseAccentColor = false;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // deletelevelcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.ComboBoxDeleteLevel);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "deletelevelcontrol";
            this.Size = new System.Drawing.Size(280, 362);
            this.Load += new System.EventHandler(this.deletelevelcontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButDelete;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxDeleteLevel;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
    }
}
