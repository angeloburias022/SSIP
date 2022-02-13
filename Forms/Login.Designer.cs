
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
            this.tb_pwd.Location = new System.Drawing.Point(136, 213);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb_pwd.PlaceholderText = "Password";
            this.tb_pwd.SelectedText = "";
            this.tb_pwd.ShadowDecoration.Parent = this.tb_pwd;
            this.tb_pwd.Size = new System.Drawing.Size(252, 45);
            this.tb_pwd.TabIndex = 7;
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
            this.tb_uname.Location = new System.Drawing.Point(136, 149);
            this.tb_uname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.PasswordChar = '\0';
            this.tb_uname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb_uname.PlaceholderText = "Username";
            this.tb_uname.SelectedText = "";
            this.tb_uname.ShadowDecoration.Parent = this.tb_uname;
            this.tb_uname.Size = new System.Drawing.Size(252, 45);
            this.tb_uname.TabIndex = 8;
            // 
            // btn_login
            // 
            this.btn_login.Animated = true;
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 26;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.DisabledState.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.IndicateFocus = true;
            this.btn_login.Location = new System.Drawing.Point(188, 308);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(153, 54);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseTransparentBackground = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 475);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.btn_login);
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_pwd;
        private Guna.UI2.WinForms.Guna2TextBox tb_uname;
        private Guna.UI2.WinForms.Guna2Button btn_login;
    }
}