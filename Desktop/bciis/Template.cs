using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AICSS
{
    public partial class Template : DevExpress.XtraEditors.XtraForm
    {
        public Template()
        {
            InitializeComponent();
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



        private void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          //pbxDocumentImage.Load()
            try
            {
                //SelectedID = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "id"));
            }
            catch { }
        }

        private void gv_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gv.FocusedRowHandle;
                    var focusRowView = (DataRowView)gv.GetFocusedRow();
                    popupMenuGrid.ShowPopup(barManagerGrid, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void Template_Load(object sender, EventArgs e)
        {

        }
    }
}