namespace bciis
{
    partial class AddProfileAffiliationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProfileAffiliationForm));
            this.pnlData = new DevExpress.XtraEditors.PanelControl();
            this.cmbAffliation = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbposition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkyes = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelyearsmembership = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtYrsMembership = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bwGetAffiliation = new System.ComponentModel.BackgroundWorker();
            this.bwAddProfileAffiliation = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::bciis.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAffliation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbposition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkyes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYrsMembership.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnlData.Appearance.Options.UseFont = true;
            this.pnlData.Controls.Add(this.cmbAffliation);
            this.pnlData.Controls.Add(this.btnCancel);
            this.pnlData.Controls.Add(this.btnSave);
            this.pnlData.Controls.Add(this.cmbposition);
            this.pnlData.Controls.Add(this.chkyes);
            this.pnlData.Controls.Add(this.labelControl6);
            this.pnlData.Controls.Add(this.labelyearsmembership);
            this.pnlData.Controls.Add(this.labelControl3);
            this.pnlData.Controls.Add(this.txtYrsMembership);
            this.pnlData.Controls.Add(this.labelControl4);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(0, -1);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(354, 164);
            this.pnlData.TabIndex = 583;
            // 
            // cmbAffliation
            // 
            this.cmbAffliation.EditValue = "Affiliation";
            this.cmbAffliation.Location = new System.Drawing.Point(10, 39);
            this.cmbAffliation.Name = "cmbAffliation";
            this.cmbAffliation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAffliation.Properties.Appearance.Options.UseFont = true;
            this.cmbAffliation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAffliation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbAffliation.Properties.NullText = "Affiliation";
            this.cmbAffliation.Properties.View = this.gridView8;
            this.cmbAffliation.Size = new System.Drawing.Size(327, 20);
            this.cmbAffliation.TabIndex = 684;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.gridColumn13});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Affiliation Name";
            this.gridColumn13.FieldName = "affiliation_name";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(262, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 683;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(182, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 682;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbposition
            // 
            this.cmbposition.EditValue = "";
            this.cmbposition.Location = new System.Drawing.Point(188, 81);
            this.cmbposition.Name = "cmbposition";
            this.cmbposition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbposition.Properties.Appearance.Options.UseFont = true;
            this.cmbposition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbposition.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbposition.Properties.Items.AddRange(new object[] {
            "Member",
            "Officer"});
            this.cmbposition.Properties.PopupSizeable = true;
            this.cmbposition.Size = new System.Drawing.Size(150, 20);
            this.cmbposition.TabIndex = 681;
            // 
            // chkyes
            // 
            this.chkyes.Location = new System.Drawing.Point(134, 82);
            this.chkyes.Name = "chkyes";
            this.chkyes.Properties.Caption = "Yes";
            this.chkyes.Size = new System.Drawing.Size(48, 19);
            this.chkyes.TabIndex = 679;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Location = new System.Drawing.Point(188, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 637;
            this.labelControl6.Text = "Position *";
            // 
            // labelyearsmembership
            // 
            this.labelyearsmembership.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelyearsmembership.Location = new System.Drawing.Point(10, 67);
            this.labelyearsmembership.Name = "labelyearsmembership";
            this.labelyearsmembership.Size = new System.Drawing.Size(107, 13);
            this.labelyearsmembership.TabIndex = 629;
            this.labelyearsmembership.Text = "Years in Membership *";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(12, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 13);
            this.labelControl3.TabIndex = 630;
            this.labelControl3.Text = "Name of Organization *";
            // 
            // txtYrsMembership
            // 
            this.txtYrsMembership.Location = new System.Drawing.Point(10, 82);
            this.txtYrsMembership.Name = "txtYrsMembership";
            this.txtYrsMembership.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYrsMembership.Size = new System.Drawing.Size(98, 20);
            this.txtYrsMembership.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Location = new System.Drawing.Point(134, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 631;
            this.labelControl4.Text = "Active *";
            // 
            // bwGetAffiliation
            // 
            this.bwGetAffiliation.WorkerSupportsCancellation = true;
            this.bwGetAffiliation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetAffiliation_DoWork);
            this.bwGetAffiliation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetAffiliation_RunWorkerCompleted);
            // 
            // bwAddProfileAffiliation
            // 
            this.bwAddProfileAffiliation.WorkerSupportsCancellation = true;
            this.bwAddProfileAffiliation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddProfileAffiliation_DoWork);
            this.bwAddProfileAffiliation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddProfileAffiliation_RunWorkerCompleted);
            // 
            // AddProfileAffiliationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 163);
            this.Controls.Add(this.pnlData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProfileAffiliationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Affiliation";
            this.Load += new System.EventHandler(this.ManageAddAffiliationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAffliation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbposition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkyes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYrsMembership.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlData;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelyearsmembership;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtYrsMembership;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbposition;
        private DevExpress.XtraEditors.CheckEdit chkyes;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAffliation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.ComponentModel.BackgroundWorker bwGetAffiliation;
        private System.ComponentModel.BackgroundWorker bwAddProfileAffiliation;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}