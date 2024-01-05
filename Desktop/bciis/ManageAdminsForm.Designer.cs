namespace bciis
{
    partial class ManageAdminsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdminsForm));
            this.lblNoData = new DevExpress.XtraEditors.LabelControl();
            this.btnResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.gbDetails = new DevExpress.XtraEditors.GroupControl();
            this.txtPasscode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtFulname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.bwSave = new System.ComponentModel.BackgroundWorker();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManagerGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.tsAdd = new DevExpress.XtraBars.BarButtonItem();
            this.tsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bwGetAdmins = new System.ComponentModel.BackgroundWorker();
            this.gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.passcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtAdmins = new DevExpress.XtraGrid.GridControl();
            this.gvAdmins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bwResetPassword = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::bciis.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasscode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFulname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(343, 164);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(109, 17);
            this.lblNoData.TabIndex = 349;
            this.lblNoData.Text = "No data to display";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.Image")));
            this.btnResetPassword.Location = new System.Drawing.Point(68, 7);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(25, 23);
            this.btnResetPassword.TabIndex = 2;
            this.btnResetPassword.Text = "c";
            this.btnResetPassword.ToolTip = "Reset Password";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(99, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.ToolTip = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(7, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "c";
            this.btnAdd.ToolTip = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(38, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "c";
            this.btnEdit.ToolTip = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDetails.Appearance.Options.UseFont = true;
            this.gbDetails.Controls.Add(this.txtPasscode);
            this.gbDetails.Controls.Add(this.labelControl4);
            this.gbDetails.Controls.Add(this.labelControl3);
            this.gbDetails.Controls.Add(this.cmbSex);
            this.gbDetails.Controls.Add(this.btnCancel);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Controls.Add(this.txtFulname);
            this.gbDetails.Controls.Add(this.labelControl2);
            this.gbDetails.Controls.Add(this.txtUsername);
            this.gbDetails.Controls.Add(this.labelControl1);
            this.gbDetails.Location = new System.Drawing.Point(7, 36);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(203, 259);
            this.gbDetails.TabIndex = 5;
            this.gbDetails.Text = "Details";
            // 
            // txtPasscode
            // 
            this.txtPasscode.Location = new System.Drawing.Point(11, 97);
            this.txtPasscode.Name = "txtPasscode";
            this.txtPasscode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPasscode.Properties.Appearance.Options.UseFont = true;
            this.txtPasscode.Properties.UseSystemPasswordChar = true;
            this.txtPasscode.Size = new System.Drawing.Size(181, 24);
            this.txtPasscode.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Location = new System.Drawing.Point(11, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 12);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Passcode *";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(11, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 12);
            this.labelControl3.TabIndex = 643;
            this.labelControl3.Text = "Gender *";
            // 
            // cmbSex
            // 
            this.cmbSex.EditValue = "";
            this.cmbSex.Location = new System.Drawing.Point(11, 195);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.Properties.Appearance.Options.UseFont = true;
            this.cmbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSex.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbSex.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Properties.PopupSizeable = true;
            this.cmbSex.Size = new System.Drawing.Size(181, 20);
            this.cmbSex.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(92, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(11, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFulname
            // 
            this.txtFulname.Location = new System.Drawing.Point(11, 148);
            this.txtFulname.Name = "txtFulname";
            this.txtFulname.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFulname.Properties.Appearance.Options.UseFont = true;
            this.txtFulname.Size = new System.Drawing.Size(181, 24);
            this.txtFulname.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(11, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 12);
            this.labelControl2.TabIndex = 346;
            this.labelControl2.Text = "Fulname *";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(11, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(181, 24);
            this.txtUsername.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(11, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 12);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username *";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(579, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 307);
            this.barDockControlBottom.Size = new System.Drawing.Size(579, 0);
            // 
            // bwSave
            // 
            this.bwSave.WorkerSupportsCancellation = true;
            this.bwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSave_DoWork);
            this.bwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSave_RunWorkerCompleted);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(579, 0);
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
            // tsDelete
            // 
            this.tsDelete.Caption = "Delete";
            this.tsDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.Glyph")));
            this.tsDelete.Id = 2;
            this.tsDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.LargeGlyph")));
            this.tsDelete.Name = "tsDelete";
            // 
            // tsRefresh
            // 
            this.tsRefresh.Caption = "Refresh";
            this.tsRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Glyph")));
            this.tsRefresh.Id = 3;
            this.tsRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsRefresh.LargeGlyph")));
            this.tsRefresh.Name = "tsRefresh";
            // 
            // tsResetPassword
            // 
            this.tsResetPassword.Caption = "Reset Password";
            this.tsResetPassword.Glyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.Glyph")));
            this.tsResetPassword.Id = 4;
            this.tsResetPassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsResetPassword.LargeGlyph")));
            this.tsResetPassword.Name = "tsResetPassword";
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
            // bwGetAdmins
            // 
            this.bwGetAdmins.WorkerSupportsCancellation = true;
            this.bwGetAdmins.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetAdmins_DoWork);
            this.bwGetAdmins.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetAdmins_RunWorkerCompleted);
            // 
            // gender
            // 
            this.gender.AppearanceCell.Options.UseTextOptions = true;
            this.gender.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gender.AppearanceHeader.Options.UseTextOptions = true;
            this.gender.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gender.Caption = "Gender";
            this.gender.FieldName = "gender";
            this.gender.MaxWidth = 70;
            this.gender.MinWidth = 70;
            this.gender.Name = "gender";
            this.gender.Visible = true;
            this.gender.VisibleIndex = 2;
            this.gender.Width = 70;
            // 
            // fullname
            // 
            this.fullname.AppearanceCell.Options.UseTextOptions = true;
            this.fullname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fullname.AppearanceHeader.Options.UseTextOptions = true;
            this.fullname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fullname.Caption = "Fullname";
            this.fullname.FieldName = "fullname";
            this.fullname.MaxWidth = 150;
            this.fullname.MinWidth = 150;
            this.fullname.Name = "fullname";
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 1;
            this.fullname.Width = 150;
            // 
            // passcode
            // 
            this.passcode.AppearanceCell.Options.UseTextOptions = true;
            this.passcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passcode.AppearanceHeader.Options.UseTextOptions = true;
            this.passcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passcode.Caption = "Passcode";
            this.passcode.FieldName = "passcode";
            this.passcode.Name = "passcode";
            // 
            // dtAdmins
            // 
            this.dtAdmins.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAdmins.Location = new System.Drawing.Point(216, 7);
            this.dtAdmins.MainView = this.gvAdmins;
            this.dtAdmins.Name = "dtAdmins";
            this.dtAdmins.Size = new System.Drawing.Size(358, 288);
            this.dtAdmins.TabIndex = 343;
            this.dtAdmins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdmins});
            // 
            // gvAdmins
            // 
            this.gvAdmins.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.username,
            this.passcode,
            this.fullname,
            this.gender});
            this.gvAdmins.GridControl = this.dtAdmins;
            this.gvAdmins.Name = "gvAdmins";
            this.gvAdmins.OptionsBehavior.Editable = false;
            this.gvAdmins.OptionsFind.AlwaysVisible = true;
            this.gvAdmins.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAdmins.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvAdmins.OptionsView.RowAutoHeight = true;
            this.gvAdmins.OptionsView.ShowGroupPanel = false;
            this.gvAdmins.OptionsView.ShowIndicator = false;
            this.gvAdmins.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAdmins_FocusedRowChanged);
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
            // username
            // 
            this.username.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.username.AppearanceCell.Options.UseFont = true;
            this.username.AppearanceCell.Options.UseTextOptions = true;
            this.username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.username.AppearanceHeader.Options.UseTextOptions = true;
            this.username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.username.Caption = "Username";
            this.username.FieldName = "username";
            this.username.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 0;
            this.username.Width = 125;
            // 
            // bwResetPassword
            // 
            this.bwResetPassword.WorkerSupportsCancellation = true;
            // 
            // ManageAdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 307);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.dtAdmins);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageAdminsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Admins";
            this.Load += new System.EventHandler(this.ManageAdminsForm_Load);
            this.Shown += new System.EventHandler(this.ManageAdminsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasscode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFulname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNoData;
        private DevExpress.XtraEditors.SimpleButton btnResetPassword;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.GroupControl gbDetails;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSex;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtFulname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private System.ComponentModel.BackgroundWorker bwSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManagerGrid;
        private DevExpress.XtraGrid.GridControl dtAdmins;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdmins;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn passcode;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn gender;
        private DevExpress.XtraBars.BarButtonItem tsAdd;
        private DevExpress.XtraBars.BarButtonItem tsEdit;
        private DevExpress.XtraBars.BarButtonItem tsDelete;
        private DevExpress.XtraBars.BarButtonItem tsRefresh;
        private DevExpress.XtraBars.BarButtonItem tsResetPassword;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private System.ComponentModel.BackgroundWorker bwGetAdmins;
        private System.ComponentModel.BackgroundWorker bwResetPassword;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.TextEdit txtPasscode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
    }
}