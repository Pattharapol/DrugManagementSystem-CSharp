namespace DrugManagementSystem.UI.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTest = new DevExpress.XtraEditors.LabelControl();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(396, 218);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "เข้าสู่ระบบ";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(238, -2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(75, 285);
            this.separatorControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(309, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 25);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ชื่อผู้ใช้งาน";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(311, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 25);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "รหัสผ่าน";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(67, 34);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(197, 229);
            this.pictureEdit1.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(307, 52);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(267, 44);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(309, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(267, 44);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblTest
            // 
            this.lblTest.Location = new System.Drawing.Point(283, 269);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(65, 25);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "รหัสผ่าน";
            this.lblTest.Visible = false;
            // 
            // pbSetting
            // 
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(283, 227);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(51, 36);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetting.TabIndex = 7;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 301);
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู่ระบบ";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private DevExpress.XtraEditors.LabelControl lblTest;
        private System.Windows.Forms.PictureBox pbSetting;
    }
}