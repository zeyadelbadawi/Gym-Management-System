namespace new_project1
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogincheckBox = new System.Windows.Forms.CheckBox();
            this.butLogIn = new MaterialSkin.Controls.MaterialButton();
            this.Username = new MaterialSkin.Controls.MaterialTextBox();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogincheckBox
            // 
            this.LogincheckBox.AutoSize = true;
            this.LogincheckBox.ForeColor = System.Drawing.Color.White;
            this.LogincheckBox.Location = new System.Drawing.Point(100, 415);
            this.LogincheckBox.Name = "LogincheckBox";
            this.LogincheckBox.Size = new System.Drawing.Size(159, 24);
            this.LogincheckBox.TabIndex = 4;
            this.LogincheckBox.Text = "Show password";
            this.LogincheckBox.UseVisualStyleBackColor = true;
            this.LogincheckBox.CheckedChanged += new System.EventHandler(this.LogincheckBox_CheckedChanged);
            // 
            // butLogIn
            // 
            this.butLogIn.AutoSize = false;
            this.butLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butLogIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butLogIn.Depth = 0;
            this.butLogIn.HighEmphasis = true;
            this.butLogIn.Icon = null;
            this.butLogIn.Location = new System.Drawing.Point(159, 493);
            this.butLogIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butLogIn.Size = new System.Drawing.Size(137, 45);
            this.butLogIn.TabIndex = 5;
            this.butLogIn.Text = "Log In";
            this.butLogIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butLogIn.UseAccentColor = false;
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // Username
            // 
            this.Username.AnimateReadOnly = false;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.45F);
            this.Username.LeadingIcon = null;
            this.Username.Location = new System.Drawing.Point(100, 255);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(290, 50);
            this.Username.TabIndex = 1;
            this.Username.Text = "Enter Username";
            this.Username.TrailingIcon = null;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.45F);
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(100, 339);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(290, 50);
            this.Password.TabIndex = 3;
            this.Password.Text = "Enter Password";
            this.Password.TrailingIcon = null;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(508, 791);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.butLogIn);
            this.Controls.Add(this.LogincheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox LogincheckBox;
        private MaterialSkin.Controls.MaterialButton butLogIn;
        private MaterialSkin.Controls.MaterialTextBox Username;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

