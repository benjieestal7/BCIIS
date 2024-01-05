namespace bciis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.bwLogin = new System.ComponentModel.BackgroundWorker();
            this.pbxDocumentImage = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblWarning = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.capslock_label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.hideBtn = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDocumentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(158, 381);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsername.Size = new System.Drawing.Size(198, 24);
            this.txtUsername.TabIndex = 316;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(159, 411);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(165, 24);
            this.txtPassword.TabIndex = 318;
            // 
            // bwLogin
            // 
            this.bwLogin.WorkerSupportsCancellation = true;
            this.bwLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLogin_DoWork);
            this.bwLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLogin_RunWorkerCompleted);
            // 
            // pbxDocumentImage
            // 
            this.pbxDocumentImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxDocumentImage.Image")));
            this.pbxDocumentImage.Location = new System.Drawing.Point(37, 120);
            this.pbxDocumentImage.Name = "pbxDocumentImage";
            this.pbxDocumentImage.Size = new System.Drawing.Size(302, 242);
            this.pbxDocumentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDocumentImage.TabIndex = 323;
            this.pbxDocumentImage.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(40, 517);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(294, 36);
            this.labelControl5.TabIndex = 337;
            this.labelControl5.Text = "Developed and Maintained by \r\nBohol Integrated Cacao Research \r\nand Enterprise De" +
    "velopment (ICaRED) Center";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWarning.Location = new System.Drawing.Point(68, 442);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 333;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(357, 33);
            this.labelControl3.TabIndex = 335;
            this.labelControl3.Text = "Bohol Cacao Industry ";
            // 
            // labelControl4
            // 
            this.labelControl4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(68, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(234, 23);
            this.labelControl4.TabIndex = 336;
            this.labelControl4.Text = "Information System";
            // 
            // capslock_label
            // 
            this.capslock_label.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capslock_label.Location = new System.Drawing.Point(159, 450);
            this.capslock_label.Name = "capslock_label";
            this.capslock_label.Size = new System.Drawing.Size(105, 12);
            this.capslock_label.TabIndex = 334;
            this.capslock_label.Text = "CAPS LOCK IS ON";
            this.capslock_label.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(17, 411);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 17);
            this.labelControl6.TabIndex = 332;
            this.labelControl6.Text = "Password:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(17, 386);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 17);
            this.labelControl7.TabIndex = 331;
            this.labelControl7.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.Appearance.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(159, 468);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 23);
            this.btnLogin.TabIndex = 329;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // showBtn
            // 
            this.showBtn.AllowFocus = false;
            this.showBtn.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Appearance.Options.UseFont = true;
            this.showBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.showBtn.Location = new System.Drawing.Point(329, 411);
            this.showBtn.Name = "showBtn";
            this.showBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.showBtn.Size = new System.Drawing.Size(27, 23);
            this.showBtn.TabIndex = 328;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.AllowFocus = false;
            this.hideBtn.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBtn.Appearance.Options.UseFont = true;
            this.hideBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.hideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideBtn.Image = ((System.Drawing.Image)(resources.GetObject("hideBtn.Image")));
            this.hideBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.hideBtn.Location = new System.Drawing.Point(329, 411);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.hideBtn.Size = new System.Drawing.Size(27, 23);
            this.hideBtn.TabIndex = 326;
            this.hideBtn.Visible = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(378, 562);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.capslock_label);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.pbxDocumentImage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDocumentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.ComponentModel.BackgroundWorker bwLogin;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.PictureBox pbxDocumentImage;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblWarning;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl capslock_label;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.SimpleButton hideBtn;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}