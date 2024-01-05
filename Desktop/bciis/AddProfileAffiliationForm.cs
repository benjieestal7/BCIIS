using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bciis.Core;
using bciis.Dal;

namespace bciis
{
    public partial class AddProfileAffiliationForm : Form
    {
        public static bool IsCancelled = true;
        int Selected_Profile_ID_Number = 0;
        int Selected_AffiliationID = 0;
        string Selected_YearsInMembership = string.Empty;
        int Selected_IsActive = 0;
        string Selected_Position = string.Empty;
        int Selected_ID = 0;

        public AddProfileAffiliationForm(int ID, int Profile_ID_Number, int AffiliationID, string YearsInMembership, int IsActive, string Position)
        {
            InitializeComponent();
            Selected_ID = ID;
            Selected_Profile_ID_Number = Profile_ID_Number;
            Selected_AffiliationID = AffiliationID;
            Selected_YearsInMembership = YearsInMembership;
            Selected_IsActive = IsActive;
            Selected_Position = Position;
        }

        private void ManageAddAffiliationForm_Load(object sender, EventArgs e)
        {
            IsCancelled = true;
            chkyes.Checked = true;
            if (!bwGetAffiliation.IsBusy) {
                bwGetAffiliation.RunWorkerAsync();
            }
        }

        DataTable dataAffliation = new DataTable();
        private void bwGetAffiliation_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowLoading("Loading... ");
            dataAffliation = Affiliation.GetAffiliationAllData();
            bwGetAffiliation.CancelAsync();
        }

        private void bwGetAffiliation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Affiliation.GetAffiliationAllDataIsSuccessfull)
            {
                this.cmbAffliation.Properties.DataSource = dataAffliation;
                this.cmbAffliation.Properties.DisplayMember = "affiliation_name";
                this.cmbAffliation.Properties.ValueMember = "id";
                cmbAffliation.EditValue = null;

                Selected_Profile_ID_Number = Selected_Profile_ID_Number;
                cmbAffliation.EditValue = Selected_AffiliationID;
                txtYrsMembership.Text = Selected_YearsInMembership;
                chkyes.Checked = Selected_IsActive == 1 ? true : false;
                cmbposition.Text = Selected_Position;
                HideLoading();
            }
            else
            {
                HideLoading();
                MsgBox.Error("Error getting affiliation from database!\nPlease check your connection and try again!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void bwAddProfileAffiliation_DoWork(object sender, DoWorkEventArgs e)
        {
            int saveSuccessful = 0;
            try
            {
                int Is_Active = chkyes.Checked ? 1 : 0;
                saveSuccessful = Profile.AddProfileAffiliationChecklistAllData(Selected_ID,Selected_Profile_ID_Number, Convert.ToInt32(cmbAffliation.EditValue), Is_Active, cmbposition.Text, txtYrsMembership.Text) ? 1 : 0;

            }
            catch (FormatException ex)
            {
                // Log or handle the exception here, and provide helpful error messages to the user.
                // For example, you can display a message box or set an error label on the form.
            }

            bwAddProfileAffiliation.CancelAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAffliation.Text) || string.Equals(cmbAffliation.Text, "Affiliation"))
            {
                MsgBox.Error("Selecting Affiliation is required to save data.");
                cmbAffliation.Focus();
            }
            else if (string.IsNullOrEmpty(txtYrsMembership.Text))
            {
                MsgBox.Error("Years of Membership is required to save data.");
                txtYrsMembership.Focus();
            }
            else
            {
                 SaveProfile();
            }
        }

        int bwSaveProfileAffiliationMaxRetries = 0;
        private void SaveProfile()
        {
            IsCancelled = false;
            bwSaveProfileAffiliationMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Saving data...");
            if (!bwAddProfileAffiliation.IsBusy)
            {
                bwAddProfileAffiliation.RunWorkerAsync();
            }
       }

        private void bwAddProfileAffiliation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSaveProfileAffiliationMaxRetries--;
            if (Profile.AddProfileAffiliationChecklistAllDataIsSuccessfull)
            {
                HideLoading();
                MsgBox.Information("Saved!");
                this.Close();
            }
            else
            {
                if (bwSaveProfileAffiliationMaxRetries > 0)
                    bwAddProfileAffiliation.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error saving data! Please check your connection and try again!\n\n" + Profile.AddProfileAffiliationChecklistAllDataErrorMessage);
                    this.Close();
                }
            }
        }
        
    }
}
