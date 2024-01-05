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
    public partial class ManageOccupationForm : DevExpress.XtraEditors.XtraForm
    {
        public ManageOccupationForm()
        {
            InitializeComponent();
        }

        DataTable dataOccupation = new DataTable();
        int bwGetOccupationsMaxRetries = 0;

        private void ViewData()
        {
            if (!bwGetOccupation.IsBusy)
            {
                bwGetOccupationsMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Loading Occupations...");
                bwGetOccupation.RunWorkerAsync();
            }
        }
        private void gvOccupation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ToggleRefeshGrid();
        }

        private void ManageOccupationForm_Load(object sender, EventArgs e)
        {
            this.Text = PublicVariables.ProjectName + " - Occupation Management";
        }

        private void bwGetOccupation_DoWork(object sender, DoWorkEventArgs e)
        {
            dataOccupation = Occupation.GetOccupationAllData();
            bwGetOccupation.CancelAsync();
        }

        private void bwGetOccupation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetOccupationMaxRetries--;
            if (Occupation.GetOccupationAllDataIsSuccessfull)
            {
                HideLoading();
                if (dataOccupation != null && dataOccupation.Rows.Count > 0)
                {
                    dtOccupation.DataSource = dataOccupation;
                    lblNoData.Visible = false;
                    ToggleRefeshGrid();
                }
                else
                    lblNoData.Visible = true;
            }
            else
            {
                if (bwGetOccupationMaxRetries > 0)
                    bwGetOccupation.RunWorkerAsync();
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
                txtOccupation.Text = gvOccupation.GetRowCellValue(gvOccupation.FocusedRowHandle, "occupation_name").ToString();
            }
            catch { EmptyInputs(); }
        }

        private void EmptyInputs()
        {
            txtOccupation.Text = string.Empty;
        }


        private void ObjectControl(bool left, bool right)
        {
            dtOccupation.Enabled = right;
            btnAdd.Enabled = right;
            btnEdit.Enabled = right;
            btnRefresh.Enabled = right;
            gbDetails.Enabled = left;
        }

        private void ManageOccupationForm_Shown(object sender, EventArgs e)
        {
            bwGetOccupationMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Loading Occupations...");
            bwGetOccupation.RunWorkerAsync();
        }

        bool loadingIsAlreadyShowing = false;
        private int bwGetOccupationMaxRetries;
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
                    splashScreenManager3.ShowWaitForm();
                }
                splashScreenManager3.SetWaitFormDescription(message);
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
                splashScreenManager3.CloseWaitForm();
            }
            catch { }
            ObjectControl(false, true);
        }

        int selectedOccupationId = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(txtOccupation.Text))
            {

                selectedOccupationId = isAdding ? 0 : Convert.ToInt32(gvOccupation.GetRowCellValue(gvOccupation.FocusedRowHandle, "id"));
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
            Occupation.SaveOccupation(selectedOccupationId, txtOccupation.Text);
            bwSave.CancelAsync();
        }

        private void bwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        bwSaveMaxRetries--;
            if (Occupation.SaveOccupationIsSuccessfull)
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
                    MsgBox.Error("Error saving data! Please check your connection and try again!\n\n" + Occupation.SaveOccupationErrorMessage);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!bwGetOccupation.IsBusy)
            {
                bwGetOccupation.RunWorkerAsync();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvOccupation.SelectedRowsCount > 0)
            {
                ToggleRefeshGrid();
                isAdding = false;
                btnSave.Text = "Save";
                ObjectControl(true, false);
            }
        }
        }
    }