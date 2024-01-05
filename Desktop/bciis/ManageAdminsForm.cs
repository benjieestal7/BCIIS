using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using bciis.Dal;
using bciis.Core;

namespace bciis
{
    public partial class ManageAdminsForm : DevExpress.XtraEditors.XtraForm
    {
        public ManageAdminsForm()
        {
            InitializeComponent();
        }

        DataTable dataAdmins = new DataTable();
        int bwGetAdminsMaxRetries = 0;

        private void ViewData()
        {
            if (!bwGetAdmins.IsBusy)
            {
                bwGetAdminsMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Loading Admins...");
                bwGetAdmins.RunWorkerAsync();
            }
        }

        private void bwGetAdmins_DoWork(object sender, DoWorkEventArgs e)
        {
            dataAdmins = Admins.GetAdminsAllData();
            bwGetAdmins.CancelAsync();
        }

        private void bwGetAdmins_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGetAdminsMaxRetries--;
            if (Admins.GetAdminsAllDataIsSuccessfull)
            {
                HideLoading();
                if (dataAdmins != null && dataAdmins.Rows.Count > 0)
                {
                    dtAdmins.DataSource = dataAdmins;
                    lblNoData.Visible = false;
                    ToggleRefeshGrid();
                }
                else
                    lblNoData.Visible = true;
            }
            else
            {
                if (bwGetAdminsMaxRetries > 0)
                    bwGetAdmins.RunWorkerAsync();
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
                txtUsername.Text = gvAdmins.GetRowCellValue(gvAdmins.FocusedRowHandle, "username").ToString();
                txtPasscode.Text = gvAdmins.GetRowCellValue(gvAdmins.FocusedRowHandle, "passcode").ToString();
                txtFulname.Text = gvAdmins.GetRowCellValue(gvAdmins.FocusedRowHandle, "fullname").ToString();
                cmbSex.EditValue = gvAdmins.GetRowCellValue(gvAdmins.FocusedRowHandle, "gender").ToString();
            }
            catch { EmptyInputs(); }
        }

        private void EmptyInputs()
        {
            txtUsername.Text = string.Empty;
            txtFulname.Text = string.Empty;
            txtPasscode.Text = string.Empty;
            cmbSex.EditValue = null;
        }


        private void ObjectControl(bool left, bool right)
        {
            dtAdmins.Enabled = right;
            btnAdd.Enabled = right;
            btnEdit.Enabled = right;
            btnRefresh.Enabled = right;
            btnResetPassword.Enabled = right;
            gbDetails.Enabled = left;
        }

        private void ManageAdminsForm_Load(object sender, EventArgs e)
        {
            this.Text = PublicVariables.ProjectName + " - Admin Management";
        }

        private void ManageAdminsForm_Shown(object sender, EventArgs e)
        {
            bwGetAdminsMaxRetries = PublicVariables.RequestMaxRetries;
            ShowLoading("Loading admins...");
            bwGetAdmins.RunWorkerAsync();
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
                    splashScreenManager2.ShowWaitForm();
                }
                splashScreenManager2.SetWaitFormDescription(message);
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
                splashScreenManager2.CloseWaitForm();
            }
            catch { }
            ObjectControl(false, true);
        }

        private void gvAdmins_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ToggleRefeshGrid();
        }

        bool isAdding = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            btnSave.Text = "Add";
            EmptyInputs();
            ObjectControl(true, false);
        }

        int selectedAdminId = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtFulname.Text) && !string.IsNullOrEmpty(cmbSex.Text))
            {

                selectedAdminId = isAdding ? 0 : Convert.ToInt32(gvAdmins.GetRowCellValue(gvAdmins.FocusedRowHandle, "id"));
                bwSaveMaxRetries = PublicVariables.RequestMaxRetries;
                ShowLoading("Saving data...");
                bwSave.RunWorkerAsync();
            }
            else
                MsgBox.Warning("Please fill all the required fields.");
        }

        int bwSaveMaxRetries = 0;
        private void bwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            Admins.SaveAdmin(selectedAdminId, txtFulname.Text, cmbSex.Text, txtUsername.Text, txtPasscode.Text);
            bwSave.CancelAsync();
        }

        private void bwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSaveMaxRetries--;
            if (Admins.SaveAdminIsSuccessfull)
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
                    MsgBox.Error("Error saving data! Please check your connection and try again!\n\n" + Admins.SaveAdminErrorMessage);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ToggleRefeshGrid();
            ObjectControl(false, true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!bwGetAdmins.IsBusy)
            {
                bwGetAdmins.RunWorkerAsync();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvAdmins.SelectedRowsCount > 0)
            {
                isAdding = false;
                btnSave.Text = "Save";
                ObjectControl(true, false);
            }
        }
    }
}