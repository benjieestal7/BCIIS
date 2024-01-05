using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;
using bciis.Dal;
using bciis.Core;

namespace bciis
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            defaultLookAndFeel.LookAndFeel.SkinName = Properties.Settings.Default.LookAndFeel;
        }

        public static bool UserLogOut = false;

        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //reset if neccessary
            //Properties.Settings.Default.Reset();

            // create update folder if none
            if (!Directory.Exists(PublicVariables.DefaultDirectory + "/" + PublicVariables.UpdateFolder))
                Directory.CreateDirectory(PublicVariables.DefaultDirectory + "/" + PublicVariables.UpdateFolder);

            this.Text = PublicVariables.ProjectName;
            txtUsername.Text = Properties.Settings.Default.LastUser;
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                txtPassword.Focus();
                txtPassword.Select();
                txtPassword.SelectAll();
            }

            if (IsProcessOpen())
            {
                MsgBox.Warning("Program already running!");
                Application.Exit();
            }
        }

        private bool IsProcessOpen()
        {
            int programCount = 0;
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.ToString().Equals("bciis"))
                    programCount++;
            }
            return programCount > 1 ? true : false;
        }

     
        int bwLoginMaxRetries = 0;
        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            PublicVariables.UsersData = Admins.GetUsersAllData(txtUsername.Text, txtPassword.Text);
            bwLogin.CancelAsync();
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoginMaxRetries--;
            if (Admins.GetUsersAllDataIsSuccessfull)
            {
                HideLoading();
                if (PublicVariables.UsersData != null && PublicVariables.UsersData.Rows.Count > 0)
                {
                    PublicVariables.UserId = Convert.ToInt32(PublicVariables.UsersData.Rows[0]["id"]);
                    PublicVariables.ServerDate = Convert.ToDateTime(PublicVariables.UsersData.Rows[0]["server_date"]);
                    PublicVariables.UserName = txtUsername.Text;
                    PublicVariables.UserPassword = txtPassword.Text;
                    txtPassword.Text = string.Empty;
                    // save setting
                    Properties.Settings.Default.LastUser = txtUsername.Text;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    MainFormRedesigned m = new MainFormRedesigned();
                    m.ShowDialog();

                    if (UserLogOut)
                        this.Show();
                    else
                        this.Close();
                }
                else
                    MsgBox.Warning("Invalid login credentials!");
            }
            else
            {
                if (bwLoginMaxRetries > 0)
                    bwLogin.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error loading data. Please check your connection and try again.");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                bwLoginMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Authenticating...");
                if (!bwLogin.IsBusy)
                {
                    bwLogin.RunWorkerAsync();
                }
            }
            else
                MsgBox.Warning("Invalid login!");
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            showBtn.Visible = false;
            hideBtn.Visible = true;
            txtPassword.Properties.UseSystemPasswordChar = false;
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("https://makasa-laboratory.github.io/misu-bilar-campus/");
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            hideBtn.Visible = false;
            showBtn.Visible = true;
            txtPassword.Properties.UseSystemPasswordChar = true;
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
            }
        }
    }
}