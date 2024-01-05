namespace bciis
{
    partial class ManageOccupationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOccupationForm));
            this.tsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.gbDetails = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtOccupation = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsAdd = new DevExpress.XtraBars.BarButtonItem();
            this.tsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bwSave = new System.ComponentModel.BackgroundWorker();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bwGetOccupation = new System.ComponentModel.BackgroundWorker();
            this.occupation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtOccupation = new DevExpress.XtraGrid.GridControl();
            this.gvOccupation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNoData = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager3 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::bciis.WaitForm1), true, true);
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOccupation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOccupation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOccupation)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRefresh
            // 
            this.tsRefresh.Caption = "Refresh";
            this.tsRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Glyph")));
            this.tsRefresh.Id = 3;
            this.tsRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.LargeGlyph")));
            this.tsRefresh.Name = "tsRefresh";
            // 
            // gbDetails
            // 
            this.gbDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDetails.Appearance.Options.UseFont = true;
            this.gbDetails.Controls.Add(this.btnCancel);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Controls.Add(this.txtOccupation);
            this.gbDetails.Controls.Add(this.labelControl1);
            this.gbDetails.Location = new System.Drawing.Point(3, 31);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(203, 158);
            this.gbDetails.TabIndex = 350;
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
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(11, 48);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOccupation.Properties.Appearance.Options.UseFont = true;
            this.txtOccupation.Size = new System.Drawing.Size(181, 24);
            this.txtOccupation.TabIndex = 345;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(11, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 12);
            this.labelControl1.TabIndex = 344;
            this.labelControl1.Text = "Occupation*";
            // 
            // tsDelete
            // 
            this.tsDelete.Caption = "Delete";
            this.tsDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.Glyph")));
            this.tsDelete.Id = 2;
            this.tsDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.LargeGlyph")));
            this.tsDelete.Name = "tsDelete";
            // 
            // tsResetPassword
            // 
            this.tsResetPassword.Caption = "Reset Password";
            this.tsResetPassword.Glyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.Glyph")));
            this.tsResetPassword.Id = 4;
            this.tsResetPassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.LargeGlyph")));
            this.tsResetPassword.Name = "tsResetPassword";
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
            this.barDockControlTop.Size = new System.Drawing.Size(573, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 203);
            this.barDockControlBottom.Size = new System.Drawing.Size(573, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 203);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(573, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 203);
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
            // bwSave
            // 
            this.bwSave.WorkerSupportsCancellation = true;
            this.bwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSave_DoWork);
            this.bwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSave_RunWorkerCompleted);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(65, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 354;
            this.btnRefresh.ToolTip = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 352;
            this.btnAdd.Text = "c";
            this.btnAdd.ToolTip = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(33, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 23);
            this.btnEdit.TabIndex = 353;
            this.btnEdit.Text = "c";
            this.btnEdit.ToolTip = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Reset Password";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
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
            this.barDockControl1.Size = new System.Drawing.Size(573, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 203);
            this.barDockControl2.Size = new System.Drawing.Size(573, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 203);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(573, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 203);
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
            // bwGetOccupation
            // 
            this.bwGetOccupation.WorkerSupportsCancellation = true;
            this.bwGetOccupation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetOccupation_DoWork);
            this.bwGetOccupation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetOccupation_RunWorkerCompleted);
            // 
            // occupation_name
            // 
            this.occupation_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.occupation_name.AppearanceCell.Options.UseFont = true;
            this.occupation_name.AppearanceCell.Options.UseTextOptions = true;
            this.occupation_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.occupation_name.AppearanceHeader.Options.UseTextOptions = true;
            this.occupation_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.occupation_name.Caption = "Occupation";
            this.occupation_name.FieldName = "occupation_name";
            this.occupation_name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.occupation_name.Name = "occupation_name";
            this.occupation_name.Visible = true;
            this.occupation_name.VisibleIndex = 0;
            this.occupation_name.Width = 125;
            // 
            // dtOccupation
            // 
            this.dtOccupation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOccupation.Location = new System.Drawing.Point(212, 3);
            this.dtOccupation.MainView = this.gvOccupation;
            this.dtOccupation.Name = "dtOccupation";
            this.dtOccupation.Size = new System.Drawing.Size(358, 186);
            this.dtOccupation.TabIndex = 366;
            this.dtOccupation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOccupation});
            // 
            // gvOccupation
            // 
            this.gvOccupation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.occupation_name});
            this.gvOccupation.GridControl = this.dtOccupation;
            this.gvOccupation.Name = "gvOccupation";
            this.gvOccupation.OptionsBehavior.Editable = false;
            this.gvOccupation.OptionsFind.AlwaysVisible = true;
            this.gvOccupation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvOccupation.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvOccupation.OptionsView.RowAutoHeight = true;
            this.gvOccupation.OptionsView.ShowGroupPanel = false;
            this.gvOccupation.OptionsView.ShowIndicator = false;
            this.gvOccupation.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOccupation_FocusedRowChanged);
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
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(345, 103);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(109, 17);
            this.lblNoData.TabIndex = 377;
            this.lblNoData.Text = "No data to display";
            // 
            // bwLoadData
            // 
            this.bwLoadData.WorkerSupportsCancellation = true;
            // 
            // ManageOccupationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 203);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dtOccupation);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageOccupationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Occupation";
            this.Load += new System.EventHandler(this.ManageOccupationForm_Load);
            this.Shown += new System.EventHandler(this.ManageOccupationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOccupation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOccupation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOccupation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem tsRefresh;
        private DevExpress.XtraEditors.GroupControl gbDetails;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtOccupation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem tsDelete;
        private DevExpress.XtraBars.BarButtonItem tsResetPassword;
        private DevExpress.XtraBars.BarManager barManagerGrid;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraBars.BarButtonItem tsAdd;
        private DevExpress.XtraBars.BarButtonItem tsEdit;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private System.ComponentModel.BackgroundWorker bwSave;
        private DevExpress.XtraGrid.GridControl dtOccupation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOccupation;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn occupation_name;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.ComponentModel.BackgroundWorker bwGetOccupation;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl lblNoData;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private System.ComponentModel.BackgroundWorker bwLoadData;

    }
}