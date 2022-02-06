
namespace SSIP.AccessControls
{
    partial class SecurityForm
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
            this.btn_access = new Guna.UI2.WinForms.Guna2Button();
            this.tb_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_access
            // 
            this.btn_access.BackColor = System.Drawing.Color.Transparent;
            this.btn_access.BorderRadius = 4;
            this.btn_access.CheckedState.Parent = this.btn_access;
            this.btn_access.CustomImages.Parent = this.btn_access;
            this.btn_access.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_access.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_access.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_access.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_access.DisabledState.Parent = this.btn_access;
            this.btn_access.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_access.ForeColor = System.Drawing.Color.White;
            this.btn_access.HoverState.Parent = this.btn_access;
            this.btn_access.IndicateFocus = true;
            this.btn_access.Location = new System.Drawing.Point(170, 225);
            this.btn_access.Name = "btn_access";
            this.btn_access.ShadowDecoration.Parent = this.btn_access;
            this.btn_access.Size = new System.Drawing.Size(123, 43);
            this.btn_access.TabIndex = 0;
            this.btn_access.Text = "ACCESS";
            this.btn_access.UseTransparentBackground = true;
            this.btn_access.Click += new System.EventHandler(this.btn_access_Click);
            // 
            // tb_uname
            // 
            this.tb_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_uname.DefaultText = "";
            this.tb_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.DisabledState.Parent = this.tb_uname;
            this.tb_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.FocusedState.Parent = this.tb_uname;
            this.tb_uname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_uname.ForeColor = System.Drawing.Color.Black;
            this.tb_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.HoverState.Parent = this.tb_uname;
            this.tb_uname.Location = new System.Drawing.Point(130, 104);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.PasswordChar = '\0';
            this.tb_uname.PlaceholderText = "Username";
            this.tb_uname.SelectedText = "";
            this.tb_uname.ShadowDecoration.Parent = this.tb_uname;
            this.tb_uname.Size = new System.Drawing.Size(200, 36);
            this.tb_uname.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_password.DefaultText = "";
            this.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.DisabledState.Parent = this.tb_password;
            this.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.FocusedState.Parent = this.tb_password;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.HoverState.Parent = this.tb_password;
            this.tb_password.Location = new System.Drawing.Point(130, 146);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.SelectedText = "";
            this.tb_password.ShadowDecoration.Parent = this.tb_password;
            this.tb_password.Size = new System.Drawing.Size(200, 36);
            this.tb_password.TabIndex = 1;
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.tb_uname);
            this.login_panel.Controls.Add(this.tb_password);
            this.login_panel.Controls.Add(this.btn_access);
            this.login_panel.Location = new System.Drawing.Point(160, 69);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(461, 348);
            this.login_panel.TabIndex = 2;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_panel_Paint);
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.login_panel);
            this.Name = "SecurityForm";
            this.Size = new System.Drawing.Size(764, 472);
            this.login_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_access;
        private Guna.UI2.WinForms.Guna2TextBox tb_uname;
        private Guna.UI2.WinForms.Guna2TextBox tb_password;
        private System.Windows.Forms.Panel login_panel;
    }
}
