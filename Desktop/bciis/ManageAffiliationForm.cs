using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using bciis.Core;
using bciis.Dal;

namespace bciis
{
    public partial class ManageAffiliationForm : DevExpress.XtraEditors.XtraForm
    {
        public ManageAffiliationForm()
        {
            InitializeComponent();
        }

        DataTable dataAffiliation = new DataTable();
        int bwGetAffiliationsMaxRetries = 0;

        private void ViewData()
        {
            if (!bwGetAffiliation.IsBusy)
            {
                bwGetAffiliationsMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Loading Affiliations...");
                bwGetAffiliation.RunWorkerAsync();
            }
        }

        private void ManageAffiliationForm_Load(object sender, EventArgs e)
        {
            this.Text = PublicVariables.ProjectName + " - Affiliation Management";
            ToggleRefeshGrid();
        }

        private void bwGetAffiliation_DoWork(object sender, DoWorkEventArgs e)
        {
            dataAffiliation = Affiliation.GetAffiliationAllData();
            bwGetAffiliation.CancelAsync();
        }

        private void gvAffiliation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ToggleRefeshGrid();
        }

        private void bwGetAffiliation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetAffiliationMaxRetries--;
            if (Affiliation.GetAffiliationAllDataIsSuccessfull)
            {
                HideLoading();
                if (dataAffiliation != null && dataAffiliation.Rows.Count > 0)
                {
                    dtAffiliation.DataSource = dataAffiliation;
                    lblNoData.Visible = false;
                    ToggleRefeshGrid();
                }
                else
                    lblNoData.Visible = true;
            }
            else
            {
                if (bwGetAffiliationMaxRetries > 0)
                    bwGetAffiliation.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error loading data! Please check your connection and try again!");
                }
            }
        }

        private void ToggleRefeshGrid()
        {
            try
            {
                txtAffiliation.Text = gvAffiliation.GetRowCellValue(gvAffiliation.FocusedRowHandle, "affiliation_name").ToString();
            }
            catch { EmptyInputs(); }
        }

        private void EmptyInputs()
        {
            txtAffiliation.Text = string.Empty;
        }


        private void ObjectControl(bool left, bool right)
        {
            dtAffiliation.Enabled = right;
            btnAdd.Enabled = right;
            btnEdit.Enabled = right;
            btnRefresh.Enabled = right;
            gbDetails.Enabled = left;
        }

        bool loadingIsAlreadyShowing = false;
        private int bwGetAffiliationMaxRetries;
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

        int selectedAffiliationId = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAffiliation.Text))
            {

                selectedAffiliationId = isAdding ? 0 : Convert.ToInt32(gvAffiliation.GetRowCellValue(gvAffiliation.FocusedRowHandle, "id"));
                bwSaveMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Saving data...");
                bwSave.RunWorkerAsync();
            }
            else
                MsgBox.Warning("Please fill all the required fields.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ToggleRefeshGrid();
            ObjectControl(false, true);
        }

        int bwSaveMaxRetries = 0;
        private void bwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            Affiliation.SaveAffiliation(selectedAffiliationId, txtAffiliation.Text);
            bwSave.CancelAsync();  
        }

        private void bwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSaveMaxRetries--;
            if (Affiliation.SaveAffiliationIsSuccessfull)
            {
                HideLoading();
                MsgBox.Information("Saved!");
                ViewData();
            }
            else
            {
                if (bwSaveMaxRetries > 0)
                    bwSave.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MsgBox.Error("Error saving data! Please check your connection and try again!\n\n" + Affiliation.SaveAffiliationErrorMessage);
                }
            }
        }

        bool isAdding = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            btnSave.Text = "Add";
            EmptyInputs();
            ObjectControl(true, false);
        }

        private void ManageAffiliationForm_Shown(object sender, EventArgs e)
        {
            bwGetAffiliationsMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Loading Affiliations...");
            bwGetAffiliation.RunWorkerAsync();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!bwGetAffiliation.IsBusy)
            {
                bwGetAffiliation.RunWorkerAsync();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvAffiliation.SelectedRowsCount > 0)
            {
                isAdding = false;
                btnSave.Text = "Save";
                ObjectControl(true, false);
            }
        }

        }
    }

