
namespace SSIP.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.showPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.forgotPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.forgotpass_panel = new System.Windows.Forms.Panel();
            this.forgotPassword1 = new SSIP.UserformControls.ForgotPassword();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.forgotpass_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_pwd.BorderRadius = 3;
            this.tb_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pwd.DefaultText = "";
            this.tb_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pwd.DisabledState.Parent = this.tb_pwd;
            this.tb_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pwd.FocusedState.Parent = this.tb_pwd;
            this.tb_pwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tb_pwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pwd.HoverState.Parent = this.tb_pwd;
            this.tb_pwd.Location = new System.Drawing.Point(497, 217);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_pwd.PlaceholderText = "Enter your password..";
            this.tb_pwd.SelectedText = "";
            this.tb_pwd.ShadowDecoration.Parent = this.tb_pwd;
            this.tb_pwd.Size = new System.Drawing.Size(226, 37);
            this.tb_pwd.TabIndex = 2;
            // 
            // tb_uname
            // 
            this.tb_uname.BackColor = System.Drawing.Color.Transparent;
            this.tb_uname.BorderRadius = 5;
            this.tb_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_uname.DefaultText = "";
            this.tb_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.DisabledState.Parent = this.tb_uname;
            this.tb_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.FocusedState.Parent = this.tb_uname;
            this.tb_uname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tb_uname.ForeColor = System.Drawing.Color.Black;
            this.tb_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.HoverState.Parent = this.tb_uname;
            this.tb_uname.Location = new System.Drawing.Point(497, 140);
            this.tb_uname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.PasswordChar = '\0';
            this.tb_uname.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_uname.PlaceholderText = "Enter your username..";
            this.tb_uname.SelectedText = "";
            this.tb_uname.ShadowDecoration.Parent = this.tb_uname;
            this.tb_uname.Size = new System.Drawing.Size(226, 37);
            this.tb_uname.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 4;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.DisabledState.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.Green;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.IndicateFocus = true;
            this.btn_login.Location = new System.Drawing.Point(563, 294);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(115, 34);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log-in";
            this.btn_login.UseTransparentBackground = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_login_KeyDown);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.BackColor = System.Drawing.Color.Transparent;
            this.showPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPassword.CheckedState.BorderRadius = 0;
            this.showPassword.CheckedState.BorderThickness = 0;
            this.showPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.showPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPassword.Location = new System.Drawing.Point(540, 261);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(154, 24);
            this.showPassword.TabIndex = 3;
            this.showPassword.Text = "Show Password";
            this.showPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.UncheckedState.BorderRadius = 0;
            this.showPassword.UncheckedState.BorderThickness = 0;
            this.showPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // forgotPassword
            // 
            this.forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.forgotPassword.Location = new System.Drawing.Point(566, 334);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(112, 18);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // forgotpass_panel
            // 
            this.forgotpass_panel.Controls.Add(this.forgotPassword1);
            this.forgotpass_panel.Location = new System.Drawing.Point(754, 384);
            this.forgotpass_panel.Name = "forgotpass_panel";
            this.forgotpass_panel.Size = new System.Drawing.Size(51, 32);
            this.forgotpass_panel.TabIndex = 12;
            this.forgotpass_panel.Visible = false;
            // 
            // forgotPassword1
            // 
            this.forgotPassword1.BackColor = System.Drawing.Color.White;
            this.forgotPassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgotPassword1.BackgroundImage")));
            this.forgotPassword1.code = "code";
            this.forgotPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPassword1.Location = new System.Drawing.Point(0, 0);
            this.forgotPassword1.Name = "forgotPassword1";
            this.forgotPassword1.Size = new System.Drawing.Size(51, 32);
            this.forgotPassword1.TabIndex = 11;
            this.forgotPassword1.username = "username";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 254);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(331, 31);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Welcome to RFB Management ";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2HtmlLabel4);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 475);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(98, 291);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(207, 31);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = "Information System";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(774, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 34);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(497, 107);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 26);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Username";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(497, 184);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(85, 26);
            this.guna2HtmlLabel3.TabIndex = 16;
            this.guna2HtmlLabel3.Text = "Password";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 475);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.forgotpass_panel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSIP";
            this.forgotpass_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_pwd;
        private Guna.UI2.WinForms.Guna2TextBox tb_uname;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2CheckBox showPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel forgotPassword;
        private UserformControls.ForgotPassword forgotPassword1;
        private System.Windows.Forms.Panel forgotpass_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}