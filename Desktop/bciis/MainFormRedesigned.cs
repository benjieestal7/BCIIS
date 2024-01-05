using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars.Helpers;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using bciis.Core;

namespace bciis
{
    public partial class MainFormRedesigned : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }

        public MainFormRedesigned()
        {
            InitializeComponent();
            FormInitialization();
        }

        private void FormInitialization()
        {
            defaultLookAndFeel.LookAndFeel.SkinName = Properties.Settings.Default.LookAndFeel;
        }

        private void btnSoftwareUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SoftwareUpdater fto = new SoftwareUpdater();
            //fto.AutoUpdate = false;
            //fto.ShowDialog();
        }

        private void btnDeveloperLevel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UploadLatestSoftwareVersionRedesigned fto = new UploadLatestSoftwareVersionRedesigned();
            //fto.ShowDialog();
        }

        private void btnSystemInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
         //   MsgBox.Information("This software is not for sale!\n\nDeveloped and maintained by\nBohol Information Communication Technology Office - BICTO\n\nContact No.: 412-0204\nWebsite: www.bictuinnovation.com\n\nCopyright @ 2017 - 2019");
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm.UserLogOut = true;
            this.Close();
        }

  
        private void btnUsersChat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MsgBox.Information("Functionality is not yet implemented.\nThank you for your understanding.");

            //UsersChatForm c = new UsersChatForm();
            //c.ShowDialog();
        }

        private void btnThemeDevExpressStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            Properties.Settings.Default.LookAndFeel = "DevExpress Style";
            Properties.Settings.Default.Save();
        }

        private void btnThemeDevExpressDarkStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Dark Style";
            Properties.Settings.Default.LookAndFeel = "DevExpress Dark Style";
            Properties.Settings.Default.Save();
        }

        private void btnThemeVS2010_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "VS2010";
            Properties.Settings.Default.LookAndFeel = "VS2010";
            Properties.Settings.Default.Save();
        }

        private void btnThemeSevenClassic_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Seven Classic";
            Properties.Settings.Default.LookAndFeel = "Seven Classic";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2010Blue_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            Properties.Settings.Default.LookAndFeel = "Office 2010 Blue";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2010Black_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Black";
            Properties.Settings.Default.LookAndFeel = "Office 2010 Black";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2010Silver_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Silver";
            Properties.Settings.Default.LookAndFeel = "Office 2010 Silver";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2013_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
            Properties.Settings.Default.LookAndFeel = "Office 2013";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2013DarkGray_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            Properties.Settings.Default.LookAndFeel = "Office 2013 Dark Gray";
            Properties.Settings.Default.Save();
        }

        private void btnThemeOffice2013LightGray_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013 Light Gray";
            Properties.Settings.Default.LookAndFeel = "Office 2013 Light Gray";
            Properties.Settings.Default.Save();
        }

        private void btnThemeDarkroom_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Darkroom";
            Properties.Settings.Default.LookAndFeel = "Darkroom";
            Properties.Settings.Default.Save();
        }


        private void btnThemeMetropolis_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Metropolis";
            Properties.Settings.Default.LookAndFeel = "Metropolis";
            Properties.Settings.Default.Save();
        }

        private void btnThemeMetropolisDark_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel.LookAndFeel.SkinName = "Metropolis Dark";
            Properties.Settings.Default.LookAndFeel = "Metropolis Dark";
            Properties.Settings.Default.Save();
        }

        private void MainFormRedesigned_Load(object sender, EventArgs e)
        {
            this.Text = PublicVariables.ProjectName; 
            serverDateTime = PublicVariables.ServerDate;
            mainTimer.Start();
        }

        private void btnAdminsManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            ManageAdminsForm fto = new ManageAdminsForm();
            fto.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ManageOccupationForm fto = new ManageOccupationForm();
            fto.ShowDialog();
        }

        private void btnAffiliationManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            ManageAffiliationForm fto = new ManageAffiliationForm();
            fto.ShowDialog();
        }

        private void btnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://makasa-laboratory.github.io/misu-bilar-campus/");
        }

        private void btnProfileSurvey_ItemClick(object sender, ItemClickEventArgs e)
        {
            ManageProfileForm mp = new ManageProfileForm();
            mp.ShowDialog();
        }

        private long counterTimer = 0;
        private DateTime serverDateTime = new DateTime();
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                counterTimer++;
                DateTime runningDateTime = serverDateTime.AddSeconds(counterTimer);
          
                txtServer.Caption = "Server: "+PublicVariables.APIBaseURL;
                txtUser.Caption = "Current User: " + PublicVariables.UserName;
                txtServerDateTime.Caption = "Server Date & Time: " + runningDateTime.ToLongDateString() + " | " + runningDateTime.ToLongTimeString();
                txtDatabaseUsed.Caption = "Database: bisublar_bciis_live";
               
            }
            catch (Exception ex)
            {
               
            }
        }

    }
}