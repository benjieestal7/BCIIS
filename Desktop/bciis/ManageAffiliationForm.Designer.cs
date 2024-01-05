namespace bciis
{
    partial class ManageAffiliationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAffiliationForm));
            this.lblNoData = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.gbDetails = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAffiliation = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvAffiliation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.affiliation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtAffiliation = new DevExpress.XtraGrid.GridControl();
            this.bwGetAffiliation = new System.ComponentModel.BackgroundWorker();
            this.bwSave = new System.ComponentModel.BackgroundWorker();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tsAdd = new DevExpress.XtraBars.BarButtonItem();
            this.tsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.tsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::bciis.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAffiliation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAffiliation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAffiliation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(461, 103);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(109, 17);
            this.lblNoData.TabIndex = 383;
            this.lblNoData.Text = "No data to display";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem2,
            this.barButtonItem1,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(774, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 192);
            this.barDockControl2.Size = new System.Drawing.Size(774, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 192);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(774, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 192);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Add";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 0;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Edit";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyphDisabled")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Reset Password";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // gbDetails
            // 
            this.gbDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDetails.Appearance.Options.UseFont = true;
            this.gbDetails.Controls.Add(this.btnCancel);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Controls.Add(this.txtAffiliation);
            this.gbDetails.Controls.Add(this.labelControl1);
            this.gbDetails.Location = new System.Drawing.Point(3, 32);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(304, 158);
            this.gbDetails.TabIndex = 378;
            this.gbDetails.Text = "Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(92, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 357;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 356;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAffiliation
            // 
            this.txtAffiliation.Location = new System.Drawing.Point(11, 48);
            this.txtAffiliation.Name = "txtAffiliation";
            this.txtAffiliation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAffiliation.Properties.Appearance.Options.UseFont = true;
            this.txtAffiliation.Size = new System.Drawing.Size(288, 24);
            this.txtAffiliation.TabIndex = 345;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(11, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 12);
            this.labelControl1.TabIndex = 344;
            this.labelControl1.Text = "Affiliation*";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // id
            // 
            this.id.AppearanceCell.Options.UseTextOptions = true;
            this.id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.AppearanceHeader.Options.UseTextOptions = true;
            this.id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // gvAffiliation
            // 
            this.gvAffiliation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.affiliation_name});
            this.gvAffiliation.GridControl = this.dtAffiliation;
            this.gvAffiliation.Name = "gvAffiliation";
            this.gvAffiliation.OptionsBehavior.Editable = false;
            this.gvAffiliation.OptionsFind.AlwaysVisible = true;
            this.gvAffiliation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAffiliation.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvAffiliation.OptionsView.RowAutoHeight = true;
            this.gvAffiliation.OptionsView.ShowGroupPanel = false;
            this.gvAffiliation.OptionsView.ShowIndicator = false;
            this.gvAffiliation.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAffiliation_FocusedRowChanged);
            // 
            // affiliation_name
            // 
            this.affiliation_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.affiliation_name.AppearanceCell.Options.UseFont = true;
            this.affiliation_name.AppearanceCell.Options.UseTextOptions = true;
            this.affiliation_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.affiliation_name.AppearanceHeader.Options.UseTextOptions = true;
            this.affiliation_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.affiliation_name.Caption = "Affiliation";
            this.affiliation_name.FieldName = "affiliation_name";
            this.affiliation_name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.affiliation_name.Name = "affiliation_name";
            this.affiliation_name.Visible = true;
            this.affiliation_name.VisibleIndex = 0;
            this.affiliation_name.Width = 125;
            // 
            // dtAffiliation
            // 
            this.dtAffiliation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAffiliation.Location = new System.Drawing.Point(313, 2);
            this.dtAffiliation.MainView = this.gvAffiliation;
            this.dtAffiliation.Name = "dtAffiliation";
            this.dtAffiliation.Size = new System.Drawing.Size(458, 186);
            this.dtAffiliation.TabIndex = 382;
            this.dtAffiliation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAffiliation});
            // 
            // bwGetAffiliation
            // 
            this.bwGetAffiliation.WorkerSupportsCancellation = true;
            this.bwGetAffiliation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetAffiliation_DoWork);
            this.bwGetAffiliation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetAffiliation_RunWorkerCompleted);
            // 
            // bwSave
            // 
            this.bwSave.WorkerSupportsCancellation = true;
            this.bwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSave_DoWork);
            this.bwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSave_RunWorkerCompleted);
            // 
            // popupMenuGrid
            // 
            this.popupMenuGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tsAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsResetPassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsRefresh, true)});
            this.popupMenuGrid.Manager = this.barManagerGrid;
            this.popupMenuGrid.Name = "popupMenuGrid";
            // 
            // tsAdd
            // 
            this.tsAdd.Caption = "Add";
            this.tsAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("tsAdd.Glyph")));
            this.tsAdd.Id = 0;
            this.tsAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsAdd.LargeGlyph")));
            this.tsAdd.Name = "tsAdd";
            // 
            // tsEdit
            // 
            this.tsEdit.Caption = "Edit";
            this.tsEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsEdit.Glyph")));
            this.tsEdit.Id = 1;
            this.tsEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsEdit.LargeGlyph")));
            this.tsEdit.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("tsEdit.LargeGlyphDisabled")));
            this.tsEdit.Name = "tsEdit";
            // 
            // tsResetPassword
            // 
            this.tsResetPassword.Caption = "Reset Password";
            this.tsResetPassword.Glyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.Glyph")));
            this.tsResetPassword.Id = 4;
            this.tsResetPassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.LargeGlyph")));
            this.tsResetPassword.Name = "tsResetPassword";
            // 
            // tsRefresh
            // 
            this.tsRefresh.Caption = "Refresh";
            this.tsRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Glyph")));
            this.tsRefresh.Id = 3;
            this.tsRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.LargeGlyph")));
            this.tsRefresh.Name = "tsRefresh";
            // 
            // barManagerGrid
            // 
            this.barManagerGrid.DockControls.Add(this.barDockControlTop);
            this.barManagerGrid.DockControls.Add(this.barDockControlBottom);
            this.barManagerGrid.DockControls.Add(this.barDockControlLeft);
            this.barManagerGrid.DockControls.Add(this.barDockControlRight);
            this.barManagerGrid.Form = this;
            this.barManagerGrid.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsAdd,
            this.tsEdit,
            this.tsDelete,
            this.tsRefresh,
            this.tsResetPassword});
            this.barManagerGrid.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(774, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 192);
            this.barDockControlBottom.Size = new System.Drawing.Size(774, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 192);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(774, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 192);
            // 
            // tsDelete
            // 
            this.tsDelete.Caption = "Delete";
            this.tsDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.Glyph")));
            this.tsDelete.Id = 2;
            this.tsDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.LargeGlyph")));
            this.tsDelete.Name = "tsDelete";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(65, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 381;
            this.btnRefresh.ToolTip = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 379;
            this.btnAdd.Text = "c";
            this.btnAdd.ToolTip = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(33, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 23);
            this.btnEdit.TabIndex = 380;
            this.btnEdit.Text = "c";
            this.btnEdit.ToolTip = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ManageAffiliationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 192);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.dtAffiliation);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageAffiliationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Affiliation";
            this.Load += new System.EventHandler(this.ManageAffiliationForm_Load);
            this.Shown += new System.EventHandler(this.ManageAffiliationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAffiliation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAffiliation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAffiliation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNoData;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.GroupControl gbDetails;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAffiliation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtAffiliation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAffiliation;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn affiliation_name;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.ComponentModel.BackgroundWorker bwGetAffiliation;
        private System.ComponentModel.BackgroundWorker bwSave;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private DevExpress.XtraBars.BarButtonItem tsAdd;
        private DevExpress.XtraBars.BarButtonItem tsEdit;
        private DevExpress.XtraBars.BarButtonItem tsResetPassword;
        private DevExpress.XtraBars.BarButtonItem tsRefresh;
        private DevExpress.XtraBars.BarManager barManagerGrid;
        private DevExpress.XtraBars.BarButtonItem tsDelete;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}