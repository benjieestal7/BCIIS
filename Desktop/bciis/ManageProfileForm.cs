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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace bciis
{
    public partial class ManageProfileForm : DevExpress.XtraEditors.XtraForm
    {
        public ManageProfileForm()
        {
            InitializeComponent();
          //  gvProfile.RowCellStyle += gvProfile_RowCellStyle;
        }

        DataTable dataProfile = new DataTable();
        int bwGetProfileMaxRetries = 0;

        
        DataTable dataAffiliationChecklist = new DataTable();
        int bwGetAffiliationChecklistMaxRetries = 0;

        private void ManageProfileForm_Load(object sender, EventArgs e)
        {
            this.Text = PublicVariables.ProjectName;
            additional_information.PageEnabled = false;
            xtraTab.TabPages[1].PageVisible = false;
            profile.PageEnabled = false;
            xtraTab.TabPages[0].PageVisible = true;
            affiliate.PageEnabled = false;
            xtraTab.TabPages[2].PageVisible = false;
            chkfarmer.Checked = true;
            gvProfile.RefreshData();
        }

        private void chkfarmer_CheckedChanged(object sender, EventArgs e)
        {
            profile.PageEnabled = chkfarmer.Checked ? true : false;
            xtraTab.TabPages[0].PageVisible = chkfarmer.Checked ? true : false;

            if (chkprocessor.Checked)
            {
                profile.PageEnabled = true;
                xtraTab.TabPages[0].PageVisible = true;
                additional_information.PageEnabled = true;
                xtraTab.TabPages[1].PageVisible = true;
            }
        }

        private void chkprocessor_CheckedChanged(object sender, EventArgs e)
        {
            profile.PageEnabled = chkprocessor.Checked ? true : false;
            xtraTab.TabPages[0].PageVisible = chkprocessor.Checked ? true : false;
            additional_information.PageEnabled = chkprocessor.Checked ? true : false;
            xtraTab.TabPages[1].PageVisible = chkprocessor.Checked ? true : false;


            if (chkfarmer.Checked) {
                profile.PageEnabled = true;
                xtraTab.TabPages[0].PageVisible = true;
            }

        }

        //// Method to apply row colors based on checkbox states
        //private void ApplyRowColors()
        //{
        //    GridView gridView = gvProfile; // Replace gridView1 with your DevExpress GridView control

        //    for (int rowIndex = 0; rowIndex < gridView.DataRowCount; rowIndex++)
        //    {
        //        // Get the checkboxes' states for the current row
        //        bool isGreenChecked = chkfarmer.Checked;
        //        bool isRedChecked = chkprocessor.Checked;

        //        // Get the current row handle
        //        int rowHandle = gridView.GetRowHandle(rowIndex);

        //        // Apply row colors based on checkbox states
        //        if (isGreenChecked && isRedChecked)
        //        {
        //            gridView.Appearance.Row.BackColor = Color.Blue;
        //        }
        //        else if (isGreenChecked)
        //        {
        //            gridView.Appearance.Row.BackColor = Color.Green;
        //        }
        //        else if (isRedChecked)
        //        {
        //            gridView.Appearance.Row.BackColor = Color.Red;
        //        }
        //        else
        //        {
        //            // If neither checkbox is checked, use the default row color
        //            //gridView.Appearance.ResetRowAppearance(rowHandle);
        //        }
        //    }
        //}

        private void bwGetProfile_DoWork(object sender, DoWorkEventArgs e)
        {
        
            dataProfile = Profile.GetProfileAllData();
            bwGetProfile.CancelAsync();
           
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
            ObjectControl(false, true);
        }

        private void HideLoading_2()
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

        private void ObjectControl(bool left, bool right)
        {
            dtProfile.Enabled = right;
            btnAdd.Enabled = right;
            chkfarmer.Enabled = left;
            chkprocessor.Enabled = left;
            xtraTab.Enabled = left;
            btnSave.Enabled = left;
            btnCancel.Enabled = left;
            btnEdit.Enabled = right;
            btnRefresh.Enabled = right;
        }

        private void ObjectControl2(bool left, bool right)
        {
            dtProfile.Enabled = left;
            btnAdd.Enabled = left;
            chkfarmer.Enabled = right;
            chkprocessor.Enabled = right;
        }

        private void bwGetProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetProfileMaxRetries--;
            if (Profile.GetProfileAllDataIsSuccessfull)
            {
                
                if (dataProfile != null && dataProfile.Rows.Count > 0)
                {
                    dtProfile.DataSource = dataProfile;
                    lblNoData.Visible = false;

                     gvProfile.SortInfo.ClearAndAddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
                        new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gvProfile.Columns["true_date"], DevExpress.Data.ColumnSortOrder.Ascending)
                     });
                }
                else
                {
                    lblNoData.Visible = true;
                }

                //
                //
                if (!bwGetProvince.IsBusy) {
                    bwGetProvince.RunWorkerAsync();
                }
            }
            else
            {
                if (bwGetProfileMaxRetries > 0)
                    bwGetProfile.RunWorkerAsync();
                else
                {
                 //   HideLoading();
                    MsgBox.Error("Error loading data! Please check your connection and try again!");
                }
            }
        }
        int provincialId = 0;
        int municipalId = 0;
        int barangayId = 0;
        private void ToggleRefeshGrid()
        {
        

            try
            {
                txtFName.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "name").ToString();

                provincialId = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "province_id"));
                cmbProvince.EditValue = provincialId;
                municipalId = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "municipal_id"));
                cmbMunicipality.EditValue = municipalId;
                barangayId = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "barangay_id"));
                cmbBarangay.EditValue = barangayId;

                txtPurok.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "purok").ToString();
                lblAge.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "age").ToString();

                string profileType = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "profile_type_name").ToString();
                chkfarmer.Checked = ((profileType == "Farmer, Processor") || (profileType == "Farmer")) ? true : false; ;
                chkprocessor.Checked = ((profileType == "Farmer, Processor") || (profileType == "Processor")) ? true : false; ;

                cmbSex.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "gender").ToString();
                cmbCivilStatus.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "civil_status").ToString();
                txtNoOfHousehold.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "no_of_household_members").ToString();
                txtAnnualIncome.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "annual_farm_income").ToString();
                cmbAttainment.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "educational_attainment").ToString();
                txtbusinessname.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "name_of_business").ToString();
                txtaddress.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "business_address").ToString();
                txtcontact.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "contact_no").ToString();
                cmbbusinessStat.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "business_status").ToString();
                txtbusinessStart.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "year_business_start").ToString();
                cmbBusinesstype.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "business_type").ToString();
                txtinitInvest.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "initial_investment").ToString();
                txtAveAnnualGross.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "ave_annual_gross_income").ToString();
                txtregular.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "regular").ToString();
                txtcasual.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "casual").ToString();
                txtcontractual.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "contractual").ToString();
                txtothers.Text = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "others").ToString();
                Profile_ID = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "id").ToString());

                xtraTab.SelectedTabPageIndex = 0;



                //////////////////////////////////////////////////////   

                string OccupationChecklist = gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "occupation_name").ToString();
                try
                {
                    string separator = ",";
                    cmbOccupation.Properties.SeparatorChar = separator[0]; // SeparatorChar expects a char, not a string

                    // Check if the occupation_name is present in the CheckedComboBoxEdit items
                    if (!string.IsNullOrEmpty(OccupationChecklist))
                    {
                        string[] occupationNames = OccupationChecklist.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

                        // Get the data source of the CheckedComboBoxEdit
                        CheckedListBoxItemCollection items = cmbOccupation.Properties.Items;

                        // Uncheck all items in the CheckedComboBoxEdit
                        for (int i = 0; i < items.Count; i++)
                        {
                            items[i].CheckState = CheckState.Unchecked;
                        }

                        // Check the items based on occupation names
                        foreach (string occupationName in occupationNames)
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (items[i].Value.ToString() == occupationName)
                                {
                                    items[i].CheckState = CheckState.Checked;
                                    break; // Break the loop once the item is found and checked
                                }
                            }
                        }
                    }
                }
                catch { }



                ///////////////////////////////////////////////////////////


                //if (Profile.GetProfileAffiliationChecklistEmptyResult == false)
                //{
                //    gvAffiliate.GridControl.DataSource = null;
                //}

                //if (!bwGetProfileAffiliation.IsBusy) {
                //    bwGetProfileAffiliation.RunWorkerAsync();
                //}
            }
            catch { EmptyInputs(); }
        }

        private void EmptyInputs()
        {
            txtFName.Text = string.Empty;
            txtFName.Text = string.Empty;
            lblAge.Text = string.Empty;
            cmbProvince.Text = string.Empty;
            cmbMunicipality.Text = string.Empty;
            cmbBarangay.Text = string.Empty;
            cmbProvince.Text = string.Empty;
            cmbOccupation.SetEditValue(null);

            txtPurok.Text = string.Empty;
            lblAge.Text = string.Empty;
            cmbSex.Text = string.Empty;
            cmbCivilStatus.Text = string.Empty;
            txtNoOfHousehold.Text = string.Empty;
            txtAnnualIncome.Text = string.Empty;
            cmbAttainment.Text = string.Empty;
            txtbusinessname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtcontact.Text = "0";
            cmbbusinessStat.Text = string.Empty;
            txtbusinessStart.Text = "0";
            cmbBusinesstype.Text = string.Empty;
            txtinitInvest.Text = "0";
            txtAveAnnualGross.Text = "0";
            txtregular.Text = "0";
            txtcasual.Text = "0";
            txtcontractual.Text = "0";
            txtothers.Text = "0";
            chkfarmer.Checked = false;
            chkprocessor.Checked = false;
            affiliate.PageEnabled = false;
            xtraTab.TabPages[2].PageVisible = false;
        }

        private void ManageProfileForm_Shown(object sender, EventArgs e)
        {
            bwGetProfileMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Loading profiles...");
            bwGetProfile.RunWorkerAsync();
          
        }

        bool isAdding = false;
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            isAdding = true;
            EmptyInputs();
            btnSave.Text = "Save";
            ObjectControl(true, false);
        
        }

  
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowLoading("Loading ...");
            affiliate.PageEnabled = true;
            xtraTab.TabPages[2].PageVisible = true;
            if (gvProfile.SelectedRowsCount > 0)
            {
               // ToggleRefeshGrid();

                if (!bwGetProfileAffiliation.IsBusy) {
                    bwGetProfileAffiliation.RunWorkerAsync();
                }

                isAdding = false;
                btnSave.Text = "Update";
                ObjectControl(true, false);
            }
     
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        
        private void gvProfile_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ToggleRefeshGrid();
        }
        
       

        int Profile_ID = 0;
        private void gvAffiliate_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ToggleRefeshGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ToggleRefeshGrid();
            ObjectControl(false, true);
            btnSave.Text = "Save";
            
        
        }

        int selectedProfileId = 0;
        private void btnSave_Click(object sender, EventArgs e)
            {
                if (chkfarmer.Checked && !chkprocessor.Checked)
                {                 
                        if (string.IsNullOrEmpty(txtFName.Text))
                        {
                            MsgBox.Error("Name is required to save data.");
                            txtFName.Focus();
                        }
                        else if (string.IsNullOrEmpty(lblAge.Text))
                        {
                            MsgBox.Error("Age is required to save data.");
                            lblAge.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbSex.Text) || string.Equals(cmbSex.Text, "Sex"))
                        {
                            MsgBox.Error("Selecting Gender is required to save data.");
                            cmbSex.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbAttainment.Text) || string.Equals(cmbAttainment.Text, "Educational Attainment"))
                        {
                            MsgBox.Error("Selecting Educational Attainment is required to save data.");
                            cmbAttainment.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbOccupation.Text) || string.Equals(cmbOccupation.Text, "Occupation"))
                        {
                            MsgBox.Error("Selecting Occupation is required to save data.");
                            cmbOccupation.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbProvince.Text) || string.Equals(cmbProvince.Text, "-- Select Province --"))
                        {
                            MsgBox.Error("Selecting Province is required to save data.");
                            cmbProvince.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbMunicipality.Text) || string.Equals(cmbMunicipality.Text, "Municipality"))
                        {
                            MsgBox.Error("Selecting Municipality is required to save data.");
                            cmbMunicipality.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbBarangay.Text) || string.Equals(cmbBarangay.Text, "Barangay"))
                        {
                            MsgBox.Error("Selecting Barangay is required to save data.");
                            cmbBarangay.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbCivilStatus.Text) || string.Equals(cmbCivilStatus.Text, "Civil Status"))
                        {
                            MsgBox.Error("Selecting Civil Status is required to save data.");
                            cmbCivilStatus.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtNoOfHousehold.Text))
                        {
                            MsgBox.Error("No. of Household is required is required to save data.");
                            txtNoOfHousehold.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtAnnualIncome.Text))
                        {
                            MsgBox.Error("Annual Income is required is required to save data.");
                            txtNoOfHousehold.Focus();
                        }
                        
                        else
                        {
                            affiliate.PageEnabled = true;
                            xtraTab.TabPages[2].PageVisible = true;
                            SaveProfile(); 
                        }
                }

                else if ((chkprocessor.Checked && chkfarmer.Checked) || chkprocessor.Checked)
                {
                        if (string.IsNullOrEmpty(txtFName.Text))
                        {
                            MsgBox.Error("Name is required to save data.");
                            txtFName.Focus();
                        }
                        else if (string.IsNullOrEmpty(lblAge.Text))
                        {
                            MsgBox.Error("Age is required to save data.");
                            lblAge.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbSex.Text) || string.Equals(cmbSex.Text, "Sex"))
                        {
                            MsgBox.Error("Selecting Gender is required to save data.");
                            cmbSex.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbAttainment.Text) || string.Equals(cmbAttainment.Text, "Educational Attainment"))
                        {
                            MsgBox.Error("Selecting Educational Attainment is required to save data.");
                            cmbAttainment.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbOccupation.Text) || string.Equals(cmbOccupation.Text, "Occupation"))
                        {
                            MsgBox.Error("Selecting Occupation is required to save data.");
                            cmbOccupation.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbProvince.Text) || string.Equals(cmbProvince.Text, "-- Select Province --"))
                        {
                            MsgBox.Error("Selecting Province is required to save data.");
                            cmbProvince.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbMunicipality.Text) || string.Equals(cmbMunicipality.Text, "Municipality"))
                        {
                            MsgBox.Error("Selecting Municipality is required to save data.");
                            cmbMunicipality.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbBarangay.Text) || string.Equals(cmbBarangay.Text, "Barangay"))
                        {
                            MsgBox.Error("Selecting Barangay is required to save data.");
                            cmbBarangay.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbCivilStatus.Text) || string.Equals(cmbCivilStatus.Text, "Civil Status"))
                        {
                            MsgBox.Error("Selecting Civil Status is required to save data.");
                            cmbCivilStatus.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtNoOfHousehold.Text))
                        {
                            MsgBox.Error("No. of Household is required is required to save data.");
                            txtNoOfHousehold.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtAnnualIncome.Text))
                        {
                            MsgBox.Error("Annual Income is required is required to save data.");
                            txtNoOfHousehold.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtbusinessname.Text))
                        {
                            MsgBox.Error("Name of Business is required is required to save data.");
                            txtbusinessname.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtaddress.Text))
                        {
                            MsgBox.Error("Address is required is required to save data.");
                            txtaddress.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtcontact.Text))
                        {
                            MsgBox.Error("Contact Info is required is required to save data.");
                            txtcontact.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtbusinessStart.Text))
                        {
                            MsgBox.Error("Year Business Started is required is required to save data.");
                            txtbusinessStart.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbbusinessStat.Text) || string.Equals(cmbbusinessStat.Text, "Business Status"))
                        {
                            MsgBox.Error("Selecting Business Status is required to save data.");
                            cmbbusinessStat.Focus();
                        }
                        else if (string.IsNullOrEmpty(cmbBusinesstype.Text) || string.Equals(cmbBusinesstype.Text, "Business Type"))
                        {
                            MsgBox.Error("Selecting Business Type is required to save data.");
                            cmbBusinesstype.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtinitInvest.Text))
                        {
                            MsgBox.Error("Initial Investment is required is required to save data.");
                            txtinitInvest.Focus();
                        }
                        else if (string.IsNullOrEmpty(txtAveAnnualGross.Text))
                        {
                            MsgBox.Error("Average Annual Gross Income is required is required to save data.");
                            txtAveAnnualGross.Focus();
                        }
                       
                        else
                        {
                            affiliate.PageEnabled = true;
                            xtraTab.TabPages[2].PageVisible = true;
                            SaveProfile();
                        }
           }
        }
        
        private void SaveProfile() { 
         selectedProfileId = isAdding ? 0 : Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "id"));

         if (!isAdding) // EDIT
         {
             // DELETE TANAN
             if (!bwDeleteProfile.IsBusy)
             {
                 bwDeleteProfile.RunWorkerAsync();
             }
         }

         else
         {
             bwSaveProfileMaxRetries = PublicVariables.RequestMaxRetries;
             ShowLoading("Saving data...");
             if (!bwSaveProfile.IsBusy)
             {
                 bwSaveProfile.RunWorkerAsync();
             }
         }
        }

        int bwSaveProfileMaxRetries = 0;
        string OccupationData = string.Empty;
        string[] OccupationDataArray;
        int OccupationId = 0;
        private void bwSaveProfile_DoWork(object sender, DoWorkEventArgs e)
        {
            int saveSuccessful = 0;
            try
            {
                int age = Convert.ToInt32(lblAge.Text);
                int householdCount = Convert.ToInt32(txtNoOfHousehold.Text);
                int contactNumber = Convert.ToInt32(txtcontact.Text);
                int businessStartYear = Convert.ToInt32(txtbusinessStart.Text);
                decimal initInvestment = Convert.ToDecimal(txtinitInvest.Text);
                decimal aveAnnualGross = Convert.ToDecimal(txtAveAnnualGross.Text);
                int regularCount = Convert.ToInt32(txtregular.Text);
                int casualCount = Convert.ToInt32(txtcasual.Text);
                int contractualCount = Convert.ToInt32(txtcontractual.Text);
                int othersCount = Convert.ToInt32(txtothers.Text);

                saveSuccessful = Profile.SaveProfileFarmerProcessor(txtFName.Text, Convert.ToInt32(cmbBarangay.EditValue), age, cmbSex.Text, cmbCivilStatus.Text, cmbAttainment.Text, householdCount, txtAnnualIncome.Text, txtbusinessname.Text, txtaddress.Text, contactNumber, businessStartYear, cmbbusinessStat.Text, cmbBusinesstype.Text, initInvestment, aveAnnualGross, txtPurok.Text, regularCount, casualCount, contractualCount, othersCount) ? 1 : 0;

                if (saveSuccessful == 1)
                {
                    OccupationData = cmbOccupation.EditValue.ToString();
                    OccupationDataArray = OccupationData.Split(',');

                    try
                    {
                        for (int i = 0; i < OccupationDataArray.Length; i++)
                        {
                            OccupationId = Convert.ToInt32(OccupationDataArray[i]);
                            Profile.AddProfileOccupationChecklistAllData(Profile.profileId, OccupationId);
                        }
                    }
                    catch
                    {
                        // MsgBox.Error("No Occupation is selected!");
                    }
                }

                }
            
            catch (FormatException ex)
            {
                // Log or handle the exception here, and provide helpful error messages to the user.
                // For example, you can display a message box or set an error label on the form.
            }

           


           
            bwSaveProfile.CancelAsync();

        }

        public static bool SaveSuccess = false;
        private void bwSaveProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSaveProfileMaxRetries--;
            if (Profile.SaveProfileFarmerProcessorIsSuccessfull)
            {
             
                HideLoading();


                // Determine how many times to loop based on which CheckEdits are checked
                int loopCount = 0;
                if (chkfarmer.Checked) loopCount += 1;
                if (chkprocessor.Checked) loopCount += 1;

                // Loop through the specified number of times and execute the background worker
                for (int i = 0; i < loopCount; i++)
                {
                    if (chkfarmer.Checked && i == 0)
                    {
                        // If chkfarmer is checked and this is the first loop, execute the background worker with value 1
                        ProfileTypeId = 1;
                        Profile.SaveProfileTypeChecklist(Profile.profileId, ProfileTypeId);
                    }
                    else if (chkprocessor.Checked && i == loopCount - 1)
                    {
                        // If chkprocessor is checked and this is the last loop, execute the background worker with value 2
                        ProfileTypeId = 2;
                        Profile.SaveProfileTypeChecklist(Profile.profileId, ProfileTypeId);
                    }
                }

                MsgBox.Information("Saved!");

                if (!bwGetProfile.IsBusy) { bwGetProfile.RunWorkerAsync(); }
                //  this.Close();
            }
            else
            {
                if (bwSaveProfileMaxRetries > 0)
                    bwSaveProfile.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error saving data! Please check your connection and try again!\n\n" + Profile.SaveProfileFarmerProcessorErrorMessage);
                }
            }

            if (isAdding)
            {
                ObjectControl(true, false);
            }

        }

        #region Variables
        string SaveName = string.Empty;
        int SaveBarangayId = 0;
        int SaveAge = 0;
        string SaveSex = string.Empty;
        string SaveCivilStatus = string.Empty;
        string SaveEducationalAttainment = string.Empty;
        int SaveNumberOfHouseholdMembers = 0;
        int SaveAnnualFarmIncome = 0;
        string SaveNameOfBusiness = string.Empty;
        string SaveBusinessAddress = string.Empty;
        int SaveYearBusinessStart = 0;
        int SaveContactNumber = 0;
        string SaveBusinessStatus = string.Empty;
        string SaveBusinessType= string.Empty;
        int SaveInitialInvestment = 0;
        int SaveAverageAnnualGrossIncome = 0;
        string SavePurok = string.Empty;
        int SaveRegular = 0;
        int SaveCasual = 0;
        int SaveContractual = 0;
        int SaveOthers = 0;
        #endregion

        private void SaveProfileFP()
        {
            SaveName = txtFName.Text;
            SaveAge = Convert.ToInt32(lblAge.Text);
            SaveSex = cmbSex.Text;
            SaveCivilStatus = cmbCivilStatus.Text;
            SaveEducationalAttainment = cmbAttainment.Text;
            SaveNumberOfHouseholdMembers = Convert.ToInt32(txtNoOfHousehold.Text);
            SaveAnnualFarmIncome = Convert.ToInt32(txtAnnualIncome.Text);;
            SaveNameOfBusiness = txtbusinessname.Text;
            SaveBusinessAddress = txtaddress.Text;
            SaveYearBusinessStart = Convert.ToInt32(txtbusinessStart.Text);
            SaveContactNumber = Convert.ToInt32(txtcontact.Text);
            SaveBusinessStatus = cmbbusinessStat.Text;
            SaveBusinessType = cmbBusinesstype.Text;
            SaveInitialInvestment =  Convert.ToInt32(txtinitInvest.Text);
            SaveAverageAnnualGrossIncome = Convert.ToInt32(txtAveAnnualGross.Text);
            SavePurok = txtPurok.Text;
            SaveRegular = Convert.ToInt32(txtregular.Text);
            SaveCasual = Convert.ToInt32(txtcasual.Text);
            SaveContractual = Convert.ToInt32(txtcontractual.Text);
            SaveOthers = Convert.ToInt32(txtothers.Text);
        }

        int ProfileTypeId = 0;
        private void bwSaveProfileChecklist_DoWork(object sender, DoWorkEventArgs e)
        {
            int saveProfileCheckListSuccessful = Profile.SaveProfileTypeChecklist(Profile.profileId, ProfileTypeId) ? 1 : 0;
            bwSaveProfileChecklist.CancelAsync();
        }

        DataTable dataProvince = new DataTable();
        private void bwGetProvince_DoWork(object sender, DoWorkEventArgs e)
        {
            dataProvince = Address.GetProvinceData();
            bwGetProvince.CancelAsync();
        }

        private void bwGetProvince_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Address.GetProvinceDataIsSuccessfull)
            {
                this.cmbProvince.Properties.DataSource = dataProvince;
                this.cmbProvince.Properties.DisplayMember = "province_name";
                this.cmbProvince.Properties.ValueMember = "id";
                cmbProvince.EditValue = null;

                if (!bwGetMunicipality.IsBusy)
                {
                    bwGetMunicipality.RunWorkerAsync();
                }
            }
            else
            {
                MsgBox.Error("Error getting province from database!\nPlease check your connection and try again!");
                this.Close();
            }
        }

        DataTable MunicipalDataViewItems = new DataTable();
        private void bwGetMunicipality_DoWork(object sender, DoWorkEventArgs e)
        {
            MunicipalDataViewItems = Address.GetMunicipalityData();
            bwGetMunicipality.CancelAsync();
        }

        private void bwGetMunicipality_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetBarangay.RunWorkerAsync();
            ChangeMunicipality();
        }

        DataTable mode2_filtered = new DataTable();
        private void ChangeMunicipality()
        {
            mode2_filtered.Clear();
            TableFilter(provincialId, "province_id", MunicipalDataViewItems, out mode2_filtered);

            if (mode2_filtered != null)
            {
                if (mode2_filtered.Rows.Count > 0)
                {
                    this.cmbMunicipality.Properties.DataSource = mode2_filtered;
                    this.cmbMunicipality.Properties.DisplayMember = "municipal_name";
                    this.cmbMunicipality.Properties.ValueMember = "id";
                }
            }
        }

        private void TableFilter(int IdTobeSorted, string column_name, DataTable table_to_be_filtered, out DataTable filtered_table)
        {
            DataView barDataView = new DataView(table_to_be_filtered);
            string column_name2 = "[" + column_name + "] = {0}";
            barDataView.RowFilter = string.Format(column_name2, IdTobeSorted.ToString());
            filtered_table = barDataView.ToTable();
        }
        DataTable BarangayDataViewItems = new DataTable();
        private void bwGetBarangay_DoWork(object sender, DoWorkEventArgs e)
        {
            BarangayDataViewItems = Address.GetBarangayData();
            bwGetBarangay.CancelAsync();
        }

        private void bwGetBarangay_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChangeBarangay();
            if (!bwGetOccupation.IsBusy) {
                bwGetOccupation.RunWorkerAsync();
            }
        }

        DataTable mode3_filtered = new DataTable();
        private void ChangeBarangay()
        {
            mode3_filtered.Clear();

            TableFilter(municipalId, "municipal_id", BarangayDataViewItems, out mode3_filtered);

            if (mode3_filtered != null)
            {
                if (mode3_filtered.Rows.Count > 0)
                {
                    this.cmbBarangay.Properties.DataSource = mode3_filtered;
                    this.cmbBarangay.Properties.DisplayMember = "barangay_name";
                    this.cmbBarangay.Properties.ValueMember = "id";
                }
            }
        }

        int municipalityIdForSearch = 0;
        private void cmbMunicipality_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cmbMunicipality.Text.Equals(cmbMunicipality.Properties.NullText))
                {
                    municipalId = Convert.ToInt32(cmbMunicipality.EditValue);
                    ChangeBarangay();

                    cmbBarangay.EditValue = null;
                }
                else
                    cmbBarangay.Properties.DataSource = null;
            }
            catch { }
        }

        private void cmbProvince_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cmbProvince.Text.Equals(cmbProvince.Properties.NullText))
                {
                    provincialId = Convert.ToInt32(cmbProvince.EditValue);
                    ChangeMunicipality();

                    cmbMunicipality.EditValue = null;
                    cmbBarangay.Properties.DataSource = null;
                }
                else
                {
                    cmbMunicipality.Properties.DataSource = null;
                    cmbBarangay.Properties.DataSource = null;
                }
            }
            catch { }
        }

        private void bwSaveProfileChecklist_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          //  AddProfileAffiliationForm mp = new AddProfileAffiliationForm(1);
          //  mp.ShowDialog();
        }

   
        private void lblAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtNoOfHousehold_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtPurok_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtbusinessStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtinitInvest_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtAveAnnualGross_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtregular_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtcasual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtcontractual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtothers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void bwDeleteProfile_DoWork(object sender, DoWorkEventArgs e)
        {
            Profile.DeleteProfileFarmerProcessor(selectedProfileId);
            bwDeleteProfile.CancelAsync();
        }

        private void bwDeleteProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSaveProfileMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Saving data...");
            if (!bwSaveProfile.IsBusy)
            {
                bwSaveProfile.RunWorkerAsync();
            }
        }

        DataTable dataOccupationChecklist = new DataTable();
        private void bwGetOccupation_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dataOccupationChecklist = Occupation.GetOccupationAllData();
                // Do not cancel the background worker here. Let it complete its task.
            }
            catch { }
        }

        private void bwGetOccupation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event is triggered when the first background worker completes its task.

            // Check if the dataOccupationChecklist contains rows
            if (dataOccupationChecklist.Rows.Count > 0)
            {
                // Store the checked items' values before repopulating the CheckedComboBoxEdit
                List<int> checkedItems = new List<int>();
                foreach (CheckedListBoxItem item in cmbOccupation.Properties.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                    {
                        int itemValue = Convert.ToInt32(item.Value);
                        checkedItems.Add(itemValue);
                    }
                }

                // Populate the CheckComboBox with dataOccupationChecklist DataTable
                this.cmbOccupation.Properties.DataSource = dataOccupationChecklist;
                this.cmbOccupation.Properties.DisplayMember = "occupation_name";
                this.cmbOccupation.Properties.ValueMember = "id";
           

                // After setting up the data source, run the second background worker to fetch the profile occupation data.
                if (!bwGetProfileOccupation.IsBusy)
                {
                    bwGetProfileOccupation.RunWorkerAsync();
                }
            }
            else
            {
                MsgBox.Error("No occupation data found!");
                this.Close();
            }

        }

        DataTable dataProfileOccupationChecklist = new DataTable();
        private void bwGetProfileOccupation_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dataProfileOccupationChecklist = Profile.GetProfileOccupationChecklistAllData(Profile_ID);        
            }
            catch { }
        }

        string separator = ","; // You can change the separator to any character you prefe
  
        private void bwGetProfileOccupation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                string separator = ",";
                cmbOccupation.Properties.SeparatorChar = separator[0]; // SeparatorChar expects a char, not a string

                cmbOccupation.SetEditValue(ConvertDataTableToString(dataProfileOccupationChecklist, separator));
            }
            catch { }
  
            HideLoading(); 
            btnRefresh.PerformClick();
            
            if (isAdding)
            {
                ObjectControl(true, false);
            }
        }

        private static string ConvertDataTableToString(DataTable dataTable, string separator)
        {
            StringBuilder sb = new StringBuilder();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sb.Append(item.ToString());
                        sb.Append(separator);
                    }

                    // Remove the last separator after each item
                    sb.Length -= separator.Length;
                    sb.Append(","); // Add a comma after each row (instead of a new line)
                }
            }

            return sb.ToString();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ToggleRefeshGrid();
        }

        private void bwGetProfileAffiliation_DoWork(object sender, DoWorkEventArgs e)
        {
          
            try
            {
                int ID_Number = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "id_number").ToString());
                dataAffiliationChecklist = Profile.GetProfileAffiliationChecklistAllData(ID_Number);
                bwGetProfileAffiliation.CancelAsync();
            }
            catch { }
        }

        private void bwGetProfileAffiliation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetAffiliationChecklistMaxRetries--;
            if (Profile.GetProfileAffiliationChecklistAllDataIsSuccessfull)
            {
                HideLoading_2();
                if (dataAffiliationChecklist != null && dataAffiliationChecklist.Rows.Count > 0)
                {
                    dtAffiliate.DataSource = dataAffiliationChecklist;
                    lblNoDataAffliation.Visible = false;
                }
                else
                {
                    dtAffiliate.DataSource = null;
                    lblNoDataAffliation.Visible = true;
                }
            }
            else
            {
                if (bwGetAffiliationChecklistMaxRetries > 0)
                    bwGetProfileAffiliation.RunWorkerAsync();
                else
                {
                    HideLoading_2();
                    MsgBox.Error("Error loading data! Please check your connection and try again!");
                }
            }


            dtProfile.Enabled = false; // 


            if (isAdding)
            {
                ObjectControl(true, false);
            }
        }

        private void btnAddProfileAffliation_Click(object sender, EventArgs e)
        {
            int Profile_ID_Number = 0;
            if (gvProfile.SelectedRowsCount > 0)
            {
                Profile_ID_Number = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "id_number").ToString());
            }

            // For the ID on the Affiliate
            int AffiliationID = 0;
            string YearsInMembership = string.Empty;
            int IsActive = 1;
            string Position = string.Empty;

            AddProfileAffiliationForm mp = new AddProfileAffiliationForm(0, Profile_ID_Number, AffiliationID, YearsInMembership, IsActive, Position);
            mp.ShowDialog();

            if (!AddProfileAffiliationForm.IsCancelled)
            {
                btnRefreshAffliation.PerformClick();
            }

        }

        private void btnRefreshAffliation_Click(object sender, EventArgs e)
        {
            if (!bwGetProfileAffiliation.IsBusy) {
                bwGetProfileAffiliation.RunWorkerAsync();
            }
        }

        private void btnEditProfileAffliation_Click(object sender, EventArgs e)
        {
            int Profile_ID_Number = 0;
            int AffiliationID = 0;
            string YearsInMembership = string.Empty;
            int IsActive = 1;
            string Position = string.Empty;
            int Affiliation_Checklist_ID = 0;
            if (gvProfile.SelectedRowsCount > 0)
            {
                Profile_ID_Number = Convert.ToInt32(gvProfile.GetRowCellValue(gvProfile.FocusedRowHandle, "id_number").ToString());
            }

            if (gvAffiliate.SelectedRowsCount > 0)
            {
                // For the ID on the Affiliate
                Affiliation_Checklist_ID = Convert.ToInt32(gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "affiliation_checklist_id").ToString());
                AffiliationID = Convert.ToInt32(gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "affiliation_id").ToString());
                YearsInMembership = gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "years_in_membership").ToString();
                IsActive = Convert.ToInt32(gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "is_active").ToString());
                Position = gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "position").ToString();
        
            }

            AddProfileAffiliationForm mp = new AddProfileAffiliationForm(Affiliation_Checklist_ID, Profile_ID_Number, AffiliationID, YearsInMembership, IsActive, Position);
            mp.ShowDialog();

            if (!AddProfileAffiliationForm.IsCancelled)
            {
                btnRefreshAffliation.PerformClick();
            }
        }

   

        private void gvProfile_RowStyle(object sender, RowStyleEventArgs e)
        {
            try {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0) {
                    string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["profile_type_name"]);
                    
                    if (status.Equals("Farmer")){
                        e.Appearance.BackColor = Color.FromArgb(150, 92, 184, 92); // Green
                    }
                    else if (status.Equals("Processor"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, 237, 51, 44); // Red
                    }
                    else if (status.Equals("Farmer, Processor"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 0); // Yellow
                    }
                }
            }
            catch { }
        }

        private void gvProfile_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["profile_type_name"]);

                    if (status.Equals("Farmer"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, 92, 184, 92);
                    }
                    else if (status.Equals("Processor"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, 237, 51, 44);
                    }
                    else if (status.Equals("Farmer, Processor"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 0); // Yellow
                    }
                }
            }
            catch { }
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the pressed key is a control key or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Discard the key event
                e.Handled = true;
            }
        }

        int Affiliation_ID = 0;
        private void btnDeleteAffiliaton_Click(object sender, EventArgs e)
        {
            if (gvAffiliate.SelectedRowsCount > 0)
            {
                Affiliation_ID = Convert.ToInt32(gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "affiliation_checklist_id").ToString());
                String Affliation_Name = gvAffiliate.GetRowCellValue(gvAffiliate.FocusedRowHandle, "affiliation_name").ToString();
                MsgBox.Question("Do you want to delete, " + Affliation_Name + "?");
                if (MsgBox.IsYes)
                {
                    if (!bwDeleteAffiliation.IsBusy)
                    {
                        ShowLoading("Deleting data in the database...");
                        bwDeleteAffiliation.RunWorkerAsync();
                    }
                }
            }
            
        }

        private void bwDeleteAffiliation_DoWork(object sender, DoWorkEventArgs e)
        {
            Affiliation.DeleteAffiliation(Affiliation_ID);
            bwDeleteAffiliation.CancelAsync();
        }

        int bwDeleteProfileMaxRetries = 0;
        private void bwDeleteAffiliation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwDeleteProfileMaxRetries--;
            if (Affiliation.DeleteAffiliationIsSuccessfull)
            {
                HideLoading();
                MsgBox.Information("Affiliation has been deleted.");
                ObjectControl(true, false);
                btnRefreshAffliation.PerformClick();
            }
            else
            {
                if (bwDeleteProfileMaxRetries > 0)
                    bwDeleteAffiliation.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error deleting affiliation from database!\nPlease check your connection and try again!");
                }
            }
      
        }

     

         
        }
}