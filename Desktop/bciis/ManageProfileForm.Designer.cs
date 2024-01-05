namespace bciis
{
    partial class ManageProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProfileForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblManagePrifile = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.bwGetProfile = new System.ComponentModel.BackgroundWorker();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvProfile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barangay_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.civil_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.educational_attainment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.no_of_household_members = new DevExpress.XtraGrid.Columns.GridColumn();
            this.annual_farm_income = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name_of_business = new DevExpress.XtraGrid.Columns.GridColumn();
            this.business_addrress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.year_business_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contact_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.business_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.business_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.initial_investment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ave_annual_gross_income = new DevExpress.XtraGrid.Columns.GridColumn();
            this.no_of_employees_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.profile_type_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.regular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.casual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.others = new DevExpress.XtraGrid.Columns.GridColumn();
            this.municipal_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.province_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.province_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.municipal_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.occupation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.true_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtProfile = new DevExpress.XtraGrid.GridControl();
            this.chkprocessor = new DevExpress.XtraEditors.CheckEdit();
            this.chkfarmer = new DevExpress.XtraEditors.CheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlData = new DevExpress.XtraEditors.PanelControl();
            this.xtraTab = new DevExpress.XtraTab.XtraTabControl();
            this.profile = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.lblAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBarangay = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMunicipality = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProvince = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPurok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAttainment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCivilStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnnualIncome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoOfHousehold = new DevExpress.XtraEditors.TextEdit();
            this.cmbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblAgee = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbOccupation = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.additional_information = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmbBusinesstype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbbusinessStat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtcasual = new DevExpress.XtraEditors.TextEdit();
            this.txtcontractual = new DevExpress.XtraEditors.TextEdit();
            this.txtothers = new DevExpress.XtraEditors.TextEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.txtregular = new DevExpress.XtraEditors.TextEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtAveAnnualGross = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtinitInvest = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtbusinessStart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtbusinessname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.txtaddress = new DevExpress.XtraEditors.TextEdit();
            this.txtcontact = new DevExpress.XtraEditors.TextEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.affiliate = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteAffiliaton = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditProfileAffliation = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefreshAffliation = new DevExpress.XtraEditors.SimpleButton();
            this.lblNoDataAffliation = new DevExpress.XtraEditors.LabelControl();
            this.dtAffiliate = new DevExpress.XtraGrid.GridControl();
            this.gvAffiliate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.affiliation_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.affiliation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.years_in_membership = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_active_true = new DevExpress.XtraGrid.Columns.GridColumn();
            this.affiliation_checklist_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddProfileAffliation = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::bciis.WaitForm1), true, true);
            this.lblNoData = new DevExpress.XtraEditors.LabelControl();
            this.bwGetProfileAffiliation = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bwSaveProfile = new System.ComponentModel.BackgroundWorker();
            this.bwSaveProfileChecklist = new System.ComponentModel.BackgroundWorker();
            this.bwGetProvince = new System.ComponentModel.BackgroundWorker();
            this.bwGetMunicipality = new System.ComponentModel.BackgroundWorker();
            this.bwGetBarangay = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteProfile = new System.ComponentModel.BackgroundWorker();
            this.bwGetOccupation = new System.ComponentModel.BackgroundWorker();
            this.bwGetProfileOccupation = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteAffiliation = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkprocessor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkfarmer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).BeginInit();
            this.xtraTab.SuspendLayout();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBarangay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMunicipality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAttainment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCivilStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnnualIncome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfHousehold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOccupation.Properties)).BeginInit();
            this.additional_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBusinesstype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbusinessStat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcasual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontractual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtothers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAveAnnualGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinitInvest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusinessStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusinessname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontact.Properties)).BeginInit();
            this.affiliate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAffiliate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAffiliate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.lblManagePrifile);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(975, 46);
            this.panelControl1.TabIndex = 584;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(761, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnRefresh.TabIndex = 525;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTip = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblManagePrifile
            // 
            this.lblManagePrifile.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblManagePrifile.Location = new System.Drawing.Point(12, 5);
            this.lblManagePrifile.Name = "lblManagePrifile";
            this.lblManagePrifile.Size = new System.Drawing.Size(117, 30);
            this.lblManagePrifile.TabIndex = 316;
            this.lblManagePrifile.Text = "Profile Survey";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(832, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 523;
            this.btnAdd.Text = "Add";
            this.btnAdd.ToolTip = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(904, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 23);
            this.btnEdit.TabIndex = 524;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTip = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bwGetProfile
            // 
            this.bwGetProfile.WorkerSupportsCancellation = true;
            this.bwGetProfile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetProfile_DoWork);
            this.bwGetProfile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetProfile_RunWorkerCompleted);
            // 
            // name
            // 
            this.name.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.name.AppearanceHeader.Options.UseFont = true;
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 129;
            // 
            // id
            // 
            this.id.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.id.AppearanceHeader.Options.UseFont = true;
            this.id.AppearanceHeader.Options.UseTextOptions = true;
            this.id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Width = 252;
            // 
            // gvProfile
            // 
            this.gvProfile.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvProfile.Appearance.FocusedRow.Options.UseFont = true;
            this.gvProfile.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvProfile.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProfile.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvProfile.Appearance.SelectedRow.Options.UseFont = true;
            this.gvProfile.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.barangay_name,
            this.age,
            this.gender,
            this.civil_status,
            this.educational_attainment,
            this.no_of_household_members,
            this.annual_farm_income,
            this.name_of_business,
            this.business_addrress,
            this.year_business_start,
            this.contact_no,
            this.business_status,
            this.business_type,
            this.initial_investment,
            this.ave_annual_gross_income,
            this.no_of_employees_id,
            this.profile_type_name,
            this.purok,
            this.regular,
            this.casual,
            this.contractual,
            this.others,
            this.municipal_name,
            this.province_name,
            this.province_id,
            this.municipal_id,
            this.occupation_name,
            this.true_date,
            this.id_number});
            this.gvProfile.GridControl = this.dtProfile;
            this.gvProfile.Name = "gvProfile";
            this.gvProfile.OptionsBehavior.Editable = false;
            this.gvProfile.OptionsFind.AlwaysVisible = true;
            this.gvProfile.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProfile.OptionsView.RowAutoHeight = true;
            this.gvProfile.OptionsView.ShowGroupPanel = false;
            this.gvProfile.OptionsView.ShowIndicator = false;
            this.gvProfile.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvProfile.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvProfile_RowCellStyle);
            this.gvProfile.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvProfile_RowStyle);
            this.gvProfile.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvProfile_FocusedRowChanged);
            // 
            // barangay_name
            // 
            this.barangay_name.Caption = "Barangay";
            this.barangay_name.FieldName = "barangay_name";
            this.barangay_name.Name = "barangay_name";
            this.barangay_name.Visible = true;
            this.barangay_name.VisibleIndex = 4;
            this.barangay_name.Width = 67;
            // 
            // age
            // 
            this.age.Caption = "Age";
            this.age.FieldName = "age";
            this.age.Name = "age";
            // 
            // gender
            // 
            this.gender.Caption = "Gender";
            this.gender.FieldName = "gender";
            this.gender.Name = "gender";
            this.gender.Visible = true;
            this.gender.VisibleIndex = 2;
            this.gender.Width = 61;
            // 
            // civil_status
            // 
            this.civil_status.Caption = "Civil Status";
            this.civil_status.FieldName = "civil_status";
            this.civil_status.Name = "civil_status";
            // 
            // educational_attainment
            // 
            this.educational_attainment.Caption = "Educational Attainment";
            this.educational_attainment.FieldName = "educational_attainment";
            this.educational_attainment.Name = "educational_attainment";
            // 
            // no_of_household_members
            // 
            this.no_of_household_members.Caption = "No. of Household";
            this.no_of_household_members.FieldName = "no_of_household_members";
            this.no_of_household_members.Name = "no_of_household_members";
            // 
            // annual_farm_income
            // 
            this.annual_farm_income.Caption = "Annual Farm Income";
            this.annual_farm_income.FieldName = "annual_farm_income";
            this.annual_farm_income.Name = "annual_farm_income";
            // 
            // name_of_business
            // 
            this.name_of_business.Caption = "Name of Business";
            this.name_of_business.FieldName = "name_of_business";
            this.name_of_business.Name = "name_of_business";
            // 
            // business_addrress
            // 
            this.business_addrress.Caption = "Business Address";
            this.business_addrress.FieldName = "business_address";
            this.business_addrress.Name = "business_addrress";
            // 
            // year_business_start
            // 
            this.year_business_start.Caption = "Year Business Start";
            this.year_business_start.FieldName = "year_business_start";
            this.year_business_start.Name = "year_business_start";
            // 
            // contact_no
            // 
            this.contact_no.Caption = "Contact No.";
            this.contact_no.FieldName = "contact_no";
            this.contact_no.Name = "contact_no";
            // 
            // business_status
            // 
            this.business_status.Caption = "Business Status";
            this.business_status.FieldName = "business_status";
            this.business_status.Name = "business_status";
            // 
            // business_type
            // 
            this.business_type.Caption = "Business Type";
            this.business_type.FieldName = "business_type";
            this.business_type.Name = "business_type";
            // 
            // initial_investment
            // 
            this.initial_investment.Caption = "Initial Investment";
            this.initial_investment.FieldName = "initial_investment";
            this.initial_investment.Name = "initial_investment";
            // 
            // ave_annual_gross_income
            // 
            this.ave_annual_gross_income.Caption = "Average Annual Gross Income";
            this.ave_annual_gross_income.FieldName = "ave_annual_gross_income";
            this.ave_annual_gross_income.Name = "ave_annual_gross_income";
            // 
            // no_of_employees_id
            // 
            this.no_of_employees_id.Caption = "No. of Employees ";
            this.no_of_employees_id.FieldName = "no_of_employees_id";
            this.no_of_employees_id.Name = "no_of_employees_id";
            // 
            // profile_type_name
            // 
            this.profile_type_name.Caption = "Profile Type";
            this.profile_type_name.FieldName = "profile_type_name";
            this.profile_type_name.Name = "profile_type_name";
            this.profile_type_name.Visible = true;
            this.profile_type_name.VisibleIndex = 7;
            this.profile_type_name.Width = 109;
            // 
            // purok
            // 
            this.purok.Caption = "Purok";
            this.purok.FieldName = "purok";
            this.purok.Name = "purok";
            this.purok.Visible = true;
            this.purok.VisibleIndex = 3;
            this.purok.Width = 62;
            // 
            // regular
            // 
            this.regular.Caption = "Regular";
            this.regular.FieldName = "regular";
            this.regular.Name = "regular";
            // 
            // casual
            // 
            this.casual.Caption = "Casual";
            this.casual.FieldName = "casual";
            this.casual.Name = "casual";
            // 
            // contractual
            // 
            this.contractual.Caption = "Contractual";
            this.contractual.FieldName = "contractual";
            this.contractual.Name = "contractual";
            // 
            // others
            // 
            this.others.Caption = "Others";
            this.others.FieldName = "others";
            this.others.Name = "others";
            // 
            // municipal_name
            // 
            this.municipal_name.Caption = "Municipal";
            this.municipal_name.FieldName = "municipal_name";
            this.municipal_name.Name = "municipal_name";
            this.municipal_name.Visible = true;
            this.municipal_name.VisibleIndex = 5;
            this.municipal_name.Width = 87;
            // 
            // province_name
            // 
            this.province_name.Caption = "Province";
            this.province_name.FieldName = "province_name";
            this.province_name.Name = "province_name";
            this.province_name.Visible = true;
            this.province_name.VisibleIndex = 6;
            this.province_name.Width = 56;
            // 
            // province_id
            // 
            this.province_id.Caption = "province_id";
            this.province_id.FieldName = "province_id";
            this.province_id.Name = "province_id";
            // 
            // municipal_id
            // 
            this.municipal_id.Caption = "municipal_id";
            this.municipal_id.FieldName = "municipal_id";
            this.municipal_id.Name = "municipal_id";
            // 
            // occupation_name
            // 
            this.occupation_name.Caption = "occupation_name";
            this.occupation_name.FieldName = "occupation_name";
            this.occupation_name.Name = "occupation_name";
            // 
            // true_date
            // 
            this.true_date.Caption = "Date Added/Updated";
            this.true_date.FieldName = "true_date";
            this.true_date.Name = "true_date";
            this.true_date.Visible = true;
            this.true_date.VisibleIndex = 0;
            this.true_date.Width = 141;
            // 
            // id_number
            // 
            this.id_number.Caption = "ID No.";
            this.id_number.FieldName = "id_number";
            this.id_number.Name = "id_number";
            this.id_number.Width = 49;
            // 
            // dtProfile
            // 
            this.dtProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtProfile.Location = new System.Drawing.Point(0, 52);
            this.dtProfile.MainView = this.gvProfile;
            this.dtProfile.Name = "dtProfile";
            this.dtProfile.Size = new System.Drawing.Size(975, 226);
            this.dtProfile.TabIndex = 583;
            this.dtProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProfile});
            // 
            // chkprocessor
            // 
            this.chkprocessor.Location = new System.Drawing.Point(77, 300);
            this.chkprocessor.Name = "chkprocessor";
            this.chkprocessor.Properties.Caption = "Processor";
            this.chkprocessor.Size = new System.Drawing.Size(71, 19);
            this.chkprocessor.TabIndex = 682;
            this.chkprocessor.CheckedChanged += new System.EventHandler(this.chkprocessor_CheckedChanged);
            // 
            // chkfarmer
            // 
            this.chkfarmer.Location = new System.Drawing.Point(9, 300);
            this.chkfarmer.Name = "chkfarmer";
            this.chkfarmer.Properties.Caption = "Farmer";
            this.chkfarmer.Size = new System.Drawing.Size(62, 19);
            this.chkfarmer.TabIndex = 681;
            this.chkfarmer.CheckedChanged += new System.EventHandler(this.chkfarmer_CheckedChanged);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // pnlData
            // 
            this.pnlData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnlData.Appearance.Options.UseFont = true;
            this.pnlData.Controls.Add(this.xtraTab);
            this.pnlData.Location = new System.Drawing.Point(0, 325);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(975, 309);
            this.pnlData.TabIndex = 585;
            // 
            // xtraTab
            // 
            this.xtraTab.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTab.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTab.Location = new System.Drawing.Point(2, 2);
            this.xtraTab.Name = "xtraTab";
            this.xtraTab.SelectedTabPage = this.profile;
            this.xtraTab.Size = new System.Drawing.Size(971, 450);
            this.xtraTab.TabIndex = 2;
            this.xtraTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.profile,
            this.additional_information,
            this.affiliate});
            // 
            // profile
            // 
            this.profile.Controls.Add(this.panelControl2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(969, 425);
            this.profile.Text = "Profile";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panelControl2.Appearance.Options.UseFont = true;
            this.panelControl2.Controls.Add(this.labelControl27);
            this.panelControl2.Controls.Add(this.lblAge);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl22);
            this.panelControl2.Controls.Add(this.labelControl21);
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.labelControl20);
            this.panelControl2.Controls.Add(this.cmbBarangay);
            this.panelControl2.Controls.Add(this.cmbMunicipality);
            this.panelControl2.Controls.Add(this.cmbProvince);
            this.panelControl2.Controls.Add(this.txtPurok);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.cmbAttainment);
            this.panelControl2.Controls.Add(this.cmbCivilStatus);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.txtAnnualIncome);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtNoOfHousehold);
            this.panelControl2.Controls.Add(this.cmbSex);
            this.panelControl2.Controls.Add(this.lblAgee);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtFName);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.cmbOccupation);
            this.panelControl2.Location = new System.Drawing.Point(7, 6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(953, 213);
            this.panelControl2.TabIndex = 585;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl27.Location = new System.Drawing.Point(374, 130);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(54, 13);
            this.labelControl27.TabIndex = 734;
            this.labelControl27.Text = "Occupation";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(23, 96);
            this.lblAge.Name = "lblAge";
            this.lblAge.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblAge.Size = new System.Drawing.Size(114, 20);
            this.lblAge.TabIndex = 679;
            this.lblAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblAge_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Location = new System.Drawing.Point(909, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 12);
            this.labelControl7.TabIndex = 678;
            this.labelControl7.Text = "Purok";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl22.Location = new System.Drawing.Point(763, 28);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(38, 12);
            this.labelControl22.TabIndex = 676;
            this.labelControl22.Text = "Barangay";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl21.Location = new System.Drawing.Point(580, 28);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(70, 12);
            this.labelControl21.TabIndex = 675;
            this.labelControl21.Text = "Municipality / City";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl18.Location = new System.Drawing.Point(445, 29);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(33, 12);
            this.labelControl18.TabIndex = 674;
            this.labelControl18.Text = "Province";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl20.Location = new System.Drawing.Point(377, 27);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(45, 13);
            this.labelControl20.TabIndex = 673;
            this.labelControl20.Text = "Address*";
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.Location = new System.Drawing.Point(669, 42);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarangay.Properties.Appearance.Options.UseFont = true;
            this.cmbBarangay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBarangay.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbBarangay.Properties.NullText = "Barangay";
            this.cmbBarangay.Properties.View = this.gridView6;
            this.cmbBarangay.Size = new System.Drawing.Size(135, 20);
            this.cmbBarangay.TabIndex = 672;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Barangay Id";
            this.gridColumn6.FieldName = "barangay_id";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Barangay Name";
            this.gridColumn7.FieldName = "barangay_name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // cmbMunicipality
            // 
            this.cmbMunicipality.EditValue = "Municipality";
            this.cmbMunicipality.Location = new System.Drawing.Point(498, 42);
            this.cmbMunicipality.Name = "cmbMunicipality";
            this.cmbMunicipality.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipality.Properties.Appearance.Options.UseFont = true;
            this.cmbMunicipality.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMunicipality.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbMunicipality.Properties.NullText = "Municipality";
            this.cmbMunicipality.Properties.View = this.gridView7;
            this.cmbMunicipality.Size = new System.Drawing.Size(157, 20);
            this.cmbMunicipality.TabIndex = 671;
            this.cmbMunicipality.EditValueChanged += new System.EventHandler(this.cmbMunicipality_EditValueChanged);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Municipal Id";
            this.gridColumn8.FieldName = "municipal_id";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Municipality Name";
            this.gridColumn9.FieldName = "municipal_name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "District Id";
            this.gridColumn10.FieldName = "district_id";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Province Id";
            this.gridColumn11.FieldName = "province_id";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // cmbProvince
            // 
            this.cmbProvince.EditValue = "Select Province";
            this.cmbProvince.Location = new System.Drawing.Point(375, 42);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvince.Properties.Appearance.Options.UseFont = true;
            this.cmbProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProvince.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbProvince.Properties.NullText = "Province";
            this.cmbProvince.Properties.View = this.gridView8;
            this.cmbProvince.Size = new System.Drawing.Size(105, 20);
            this.cmbProvince.TabIndex = 670;
            this.cmbProvince.EditValueChanged += new System.EventHandler(this.cmbProvince_EditValueChanged);
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "id";
            this.gridColumn12.FieldName = "id";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Province Name";
            this.gridColumn13.FieldName = "province_name";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // txtPurok
            // 
            this.txtPurok.Location = new System.Drawing.Point(826, 43);
            this.txtPurok.Name = "txtPurok";
            this.txtPurok.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurok.Properties.Appearance.Options.UseFont = true;
            this.txtPurok.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPurok.Size = new System.Drawing.Size(106, 20);
            this.txtPurok.TabIndex = 677;
            this.txtPurok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurok_KeyPress);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.Location = new System.Drawing.Point(374, 75);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 13);
            this.labelControl13.TabIndex = 658;
            this.labelControl13.Text = "Civil Status*";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl14.Location = new System.Drawing.Point(23, 130);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(156, 13);
            this.labelControl14.TabIndex = 657;
            this.labelControl14.Text = "Highest Educational Attainment*";
            // 
            // cmbAttainment
            // 
            this.cmbAttainment.EditValue = "Educational Attainment";
            this.cmbAttainment.Location = new System.Drawing.Point(24, 149);
            this.cmbAttainment.Name = "cmbAttainment";
            this.cmbAttainment.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAttainment.Properties.Appearance.Options.UseFont = true;
            this.cmbAttainment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAttainment.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbAttainment.Properties.Items.AddRange(new object[] {
            "None",
            "Elementary",
            "High School Undergraduate",
            "High School Degree",
            "College Undergraduate",
            "Associate Degree",
            "Bachelor\'s Degree",
            "Master\'s Degree",
            "Professional Degree",
            "Doctorate"});
            this.cmbAttainment.Properties.PopupSizeable = true;
            this.cmbAttainment.Size = new System.Drawing.Size(308, 20);
            this.cmbAttainment.TabIndex = 16;
            // 
            // cmbCivilStatus
            // 
            this.cmbCivilStatus.EditValue = "Civil Status";
            this.cmbCivilStatus.Location = new System.Drawing.Point(374, 94);
            this.cmbCivilStatus.Name = "cmbCivilStatus";
            this.cmbCivilStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCivilStatus.Properties.Appearance.Options.UseFont = true;
            this.cmbCivilStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCivilStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbCivilStatus.Properties.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Annulled",
            "Separated",
            "Divorced",
            "Widowed",
            "Widower"});
            this.cmbCivilStatus.Properties.PopupSizeable = true;
            this.cmbCivilStatus.Size = new System.Drawing.Size(107, 20);
            this.cmbCivilStatus.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl12.Location = new System.Drawing.Point(669, 74);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 13);
            this.labelControl12.TabIndex = 654;
            this.labelControl12.Text = "Annual Income";
            // 
            // txtAnnualIncome
            // 
            this.txtAnnualIncome.EditValue = "0.00";
            this.txtAnnualIncome.Location = new System.Drawing.Point(669, 93);
            this.txtAnnualIncome.Name = "txtAnnualIncome";
            this.txtAnnualIncome.Size = new System.Drawing.Size(135, 20);
            this.txtAnnualIncome.TabIndex = 15;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl9.Location = new System.Drawing.Point(498, 77);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(132, 13);
            this.labelControl9.TabIndex = 652;
            this.labelControl9.Text = "No. of Houshold Members *";
            // 
            // txtNoOfHousehold
            // 
            this.txtNoOfHousehold.Location = new System.Drawing.Point(498, 94);
            this.txtNoOfHousehold.Name = "txtNoOfHousehold";
            this.txtNoOfHousehold.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoOfHousehold.Size = new System.Drawing.Size(157, 20);
            this.txtNoOfHousehold.TabIndex = 14;
            this.txtNoOfHousehold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfHousehold_KeyPress);
            // 
            // cmbSex
            // 
            this.cmbSex.EditValue = "Sex";
            this.cmbSex.Location = new System.Drawing.Point(174, 94);
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
            this.cmbSex.Size = new System.Drawing.Size(158, 20);
            this.cmbSex.TabIndex = 12;
            // 
            // lblAgee
            // 
            this.lblAgee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAgee.Location = new System.Drawing.Point(25, 77);
            this.lblAgee.Name = "lblAgee";
            this.lblAgee.Size = new System.Drawing.Size(28, 13);
            this.lblAgee.TabIndex = 642;
            this.lblAgee.Text = "Age *";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(174, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 641;
            this.labelControl2.Text = "Sex *";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(24, 43);
            this.txtFName.Name = "txtFName";
            this.txtFName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFName.Size = new System.Drawing.Size(310, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Location = new System.Drawing.Point(26, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 630;
            this.labelControl4.Text = "Name *";
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.EditValue = "Occupation";
            this.cmbOccupation.Location = new System.Drawing.Point(374, 149);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOccupation.Properties.Appearance.Options.UseFont = true;
            this.cmbOccupation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOccupation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbOccupation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbOccupation.Size = new System.Drawing.Size(430, 20);
            this.cmbOccupation.TabIndex = 735;
            // 
            // additional_information
            // 
            this.additional_information.Controls.Add(this.panelControl3);
            this.additional_information.Name = "additional_information";
            this.additional_information.Size = new System.Drawing.Size(969, 425);
            this.additional_information.Text = "Additional Info";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panelControl3.Appearance.Options.UseFont = true;
            this.panelControl3.Controls.Add(this.groupControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(969, 428);
            this.panelControl3.TabIndex = 588;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.cmbBusinesstype);
            this.groupControl2.Controls.Add(this.cmbbusinessStat);
            this.groupControl2.Controls.Add(this.txtcasual);
            this.groupControl2.Controls.Add(this.txtcontractual);
            this.groupControl2.Controls.Add(this.txtothers);
            this.groupControl2.Controls.Add(this.labelControl39);
            this.groupControl2.Controls.Add(this.labelControl38);
            this.groupControl2.Controls.Add(this.labelControl37);
            this.groupControl2.Controls.Add(this.txtregular);
            this.groupControl2.Controls.Add(this.labelControl35);
            this.groupControl2.Controls.Add(this.labelControl36);
            this.groupControl2.Controls.Add(this.txtAveAnnualGross);
            this.groupControl2.Controls.Add(this.labelControl31);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.txtinitInvest);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtbusinessStart);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl32);
            this.groupControl2.Controls.Add(this.txtbusinessname);
            this.groupControl2.Controls.Add(this.labelControl33);
            this.groupControl2.Controls.Add(this.txtaddress);
            this.groupControl2.Controls.Add(this.txtcontact);
            this.groupControl2.Controls.Add(this.labelControl34);
            this.groupControl2.Location = new System.Drawing.Point(9, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(951, 226);
            this.groupControl2.TabIndex = 731;
            this.groupControl2.Text = "Business Profile";
            // 
            // cmbBusinesstype
            // 
            this.cmbBusinesstype.EditValue = "Business Type";
            this.cmbBusinesstype.Location = new System.Drawing.Point(369, 97);
            this.cmbBusinesstype.Name = "cmbBusinesstype";
            this.cmbBusinesstype.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusinesstype.Properties.Appearance.Options.UseFont = true;
            this.cmbBusinesstype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBusinesstype.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbBusinesstype.Properties.Items.AddRange(new object[] {
            "Sole proprietorship",
            "General partnership",
            "Corporation",
            "Cooperative",
            "Association"});
            this.cmbBusinesstype.Properties.PopupSizeable = true;
            this.cmbBusinesstype.Size = new System.Drawing.Size(180, 20);
            this.cmbBusinesstype.TabIndex = 731;
            // 
            // cmbbusinessStat
            // 
            this.cmbbusinessStat.Location = new System.Drawing.Point(519, 56);
            this.cmbbusinessStat.Name = "cmbbusinessStat";
            this.cmbbusinessStat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbusinessStat.Properties.Appearance.Options.UseFont = true;
            this.cmbbusinessStat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbusinessStat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbbusinessStat.Properties.Items.AddRange(new object[] {
            "Newly established",
            "Inherited"});
            this.cmbbusinessStat.Properties.PopupSizeable = true;
            this.cmbbusinessStat.Size = new System.Drawing.Size(180, 20);
            this.cmbbusinessStat.TabIndex = 730;
            // 
            // txtcasual
            // 
            this.txtcasual.Location = new System.Drawing.Point(753, 112);
            this.txtcasual.Name = "txtcasual";
            this.txtcasual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcasual.Size = new System.Drawing.Size(48, 20);
            this.txtcasual.TabIndex = 729;
            this.txtcasual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcasual_KeyPress);
            // 
            // txtcontractual
            // 
            this.txtcontractual.Location = new System.Drawing.Point(806, 75);
            this.txtcontractual.Name = "txtcontractual";
            this.txtcontractual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontractual.Size = new System.Drawing.Size(48, 20);
            this.txtcontractual.TabIndex = 728;
            this.txtcontractual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontractual_KeyPress);
            // 
            // txtothers
            // 
            this.txtothers.Location = new System.Drawing.Point(807, 112);
            this.txtothers.Name = "txtothers";
            this.txtothers.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtothers.Size = new System.Drawing.Size(47, 20);
            this.txtothers.TabIndex = 727;
            this.txtothers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtothers_KeyPress);
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl39.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl39.Location = new System.Drawing.Point(807, 94);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(83, 12);
            this.labelControl39.TabIndex = 726;
            this.labelControl39.Text = "Others, please specify";
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl38.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl38.Location = new System.Drawing.Point(807, 57);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(47, 12);
            this.labelControl38.TabIndex = 725;
            this.labelControl38.Text = "Contractual";
            // 
            // labelControl37
            // 
            this.labelControl37.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl37.Location = new System.Drawing.Point(753, 94);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(28, 12);
            this.labelControl37.TabIndex = 724;
            this.labelControl37.Text = "Casual";
            // 
            // txtregular
            // 
            this.txtregular.Location = new System.Drawing.Point(753, 75);
            this.txtregular.Name = "txtregular";
            this.txtregular.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtregular.Size = new System.Drawing.Size(48, 20);
            this.txtregular.TabIndex = 723;
            this.txtregular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtregular_KeyPress);
            // 
            // labelControl35
            // 
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic);
            this.labelControl35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl35.Location = new System.Drawing.Point(753, 57);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(30, 12);
            this.labelControl35.TabIndex = 722;
            this.labelControl35.Text = "Regular";
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl36.Location = new System.Drawing.Point(751, 38);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(113, 13);
            this.labelControl36.TabIndex = 721;
            this.labelControl36.Text = "Number of Employees *";
            // 
            // txtAveAnnualGross
            // 
            this.txtAveAnnualGross.EditValue = "0.00";
            this.txtAveAnnualGross.Location = new System.Drawing.Point(469, 145);
            this.txtAveAnnualGross.Name = "txtAveAnnualGross";
            this.txtAveAnnualGross.Size = new System.Drawing.Size(94, 20);
            this.txtAveAnnualGross.TabIndex = 720;
            this.txtAveAnnualGross.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAveAnnualGross_KeyPress);
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl31.Location = new System.Drawing.Point(469, 128);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(263, 13);
            this.labelControl31.TabIndex = 719;
            this.labelControl31.Text = "Average Annual Gross Income (last 5 years) in Pesos *";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl17.Location = new System.Drawing.Point(369, 128);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(93, 13);
            this.labelControl17.TabIndex = 718;
            this.labelControl17.Text = "Initial Investment *";
            // 
            // txtinitInvest
            // 
            this.txtinitInvest.EditValue = "0.00";
            this.txtinitInvest.Location = new System.Drawing.Point(369, 145);
            this.txtinitInvest.Name = "txtinitInvest";
            this.txtinitInvest.Size = new System.Drawing.Size(94, 20);
            this.txtinitInvest.TabIndex = 717;
            this.txtinitInvest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinitInvest_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl10.Location = new System.Drawing.Point(371, 82);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(87, 13);
            this.labelControl10.TabIndex = 716;
            this.labelControl10.Text = "Type of Business*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(519, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 13);
            this.labelControl5.TabIndex = 714;
            this.labelControl5.Text = "Status of Business*";
            // 
            // txtbusinessStart
            // 
            this.txtbusinessStart.EditValue = "Business Status";
            this.txtbusinessStart.Location = new System.Drawing.Point(369, 56);
            this.txtbusinessStart.Name = "txtbusinessStart";
            this.txtbusinessStart.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusinessStart.Size = new System.Drawing.Size(126, 20);
            this.txtbusinessStart.TabIndex = 711;
            this.txtbusinessStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusinessStart_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(369, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 13);
            this.labelControl3.TabIndex = 712;
            this.labelControl3.Text = "Year Business Start *";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl32.Location = new System.Drawing.Point(32, 82);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(48, 13);
            this.labelControl32.TabIndex = 708;
            this.labelControl32.Text = "Address *";
            // 
            // txtbusinessname
            // 
            this.txtbusinessname.Location = new System.Drawing.Point(32, 56);
            this.txtbusinessname.Name = "txtbusinessname";
            this.txtbusinessname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusinessname.Size = new System.Drawing.Size(316, 20);
            this.txtbusinessname.TabIndex = 705;
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl33.Location = new System.Drawing.Point(34, 41);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(112, 13);
            this.labelControl33.TabIndex = 709;
            this.labelControl33.Text = "Name of the Business *";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(32, 97);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtaddress.Size = new System.Drawing.Size(316, 20);
            this.txtaddress.TabIndex = 706;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(32, 145);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontact.Size = new System.Drawing.Size(226, 20);
            this.txtcontact.TabIndex = 707;
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress);
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl34.Location = new System.Drawing.Point(34, 128);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(87, 13);
            this.labelControl34.TabIndex = 710;
            this.labelControl34.Text = "Contact Number *";
            // 
            // affiliate
            // 
            this.affiliate.Controls.Add(this.panelControl4);
            this.affiliate.Name = "affiliate";
            this.affiliate.Size = new System.Drawing.Size(969, 425);
            this.affiliate.Text = "Affiliation";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panelControl4.Appearance.Options.UseFont = true;
            this.panelControl4.Controls.Add(this.btnDeleteAffiliaton);
            this.panelControl4.Controls.Add(this.btnEditProfileAffliation);
            this.panelControl4.Controls.Add(this.btnRefreshAffliation);
            this.panelControl4.Controls.Add(this.lblNoDataAffliation);
            this.panelControl4.Controls.Add(this.dtAffiliate);
            this.panelControl4.Controls.Add(this.btnAddProfileAffliation);
            this.panelControl4.Location = new System.Drawing.Point(9, 18);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(947, 202);
            this.panelControl4.TabIndex = 691;
            // 
            // btnDeleteAffiliaton
            // 
            this.btnDeleteAffiliaton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAffiliaton.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAffiliaton.Image")));
            this.btnDeleteAffiliaton.Location = new System.Drawing.Point(223, 22);
            this.btnDeleteAffiliaton.Name = "btnDeleteAffiliaton";
            this.btnDeleteAffiliaton.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteAffiliaton.TabIndex = 692;
            this.btnDeleteAffiliaton.Text = "Delete Affiliation";
            this.btnDeleteAffiliaton.ToolTip = "Delete Affiliation";
            this.btnDeleteAffiliaton.Click += new System.EventHandler(this.btnDeleteAffiliaton_Click);
            // 
            // btnEditProfileAffliation
            // 
            this.btnEditProfileAffliation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfileAffliation.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProfileAffliation.Image")));
            this.btnEditProfileAffliation.Location = new System.Drawing.Point(121, 22);
            this.btnEditProfileAffliation.Name = "btnEditProfileAffliation";
            this.btnEditProfileAffliation.Size = new System.Drawing.Size(96, 23);
            this.btnEditProfileAffliation.TabIndex = 691;
            this.btnEditProfileAffliation.Text = "Edit Affiliation";
            this.btnEditProfileAffliation.ToolTip = "Edit Affiliation";
            this.btnEditProfileAffliation.Click += new System.EventHandler(this.btnEditProfileAffliation_Click);
            // 
            // btnRefreshAffliation
            // 
            this.btnRefreshAffliation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshAffliation.AutoWidthInLayoutControl = true;
            this.btnRefreshAffliation.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshAffliation.Image")));
            this.btnRefreshAffliation.Location = new System.Drawing.Point(339, 22);
            this.btnRefreshAffliation.Name = "btnRefreshAffliation";
            this.btnRefreshAffliation.Size = new System.Drawing.Size(78, 23);
            this.btnRefreshAffliation.TabIndex = 690;
            this.btnRefreshAffliation.Text = "Refresh";
            this.btnRefreshAffliation.ToolTip = "Refresh";
            this.btnRefreshAffliation.Click += new System.EventHandler(this.btnRefreshAffliation_Click);
            // 
            // lblNoDataAffliation
            // 
            this.lblNoDataAffliation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoDataAffliation.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNoDataAffliation.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDataAffliation.Location = new System.Drawing.Point(393, 106);
            this.lblNoDataAffliation.Name = "lblNoDataAffliation";
            this.lblNoDataAffliation.Size = new System.Drawing.Size(109, 17);
            this.lblNoDataAffliation.TabIndex = 689;
            this.lblNoDataAffliation.Text = "No data to display";
            // 
            // dtAffiliate
            // 
            this.dtAffiliate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtAffiliate.Location = new System.Drawing.Point(18, 51);
            this.dtAffiliate.MainView = this.gvAffiliate;
            this.dtAffiliate.Name = "dtAffiliate";
            this.dtAffiliate.Size = new System.Drawing.Size(908, 116);
            this.dtAffiliate.TabIndex = 593;
            this.dtAffiliate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAffiliate});
            // 
            // gvAffiliate
            // 
            this.gvAffiliate.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvAffiliate.Appearance.FocusedRow.Options.UseFont = true;
            this.gvAffiliate.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvAffiliate.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAffiliate.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvAffiliate.Appearance.SelectedRow.Options.UseFont = true;
            this.gvAffiliate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.affiliation_id,
            this.affiliation_name,
            this.years_in_membership,
            this.is_active,
            this.position,
            this.is_active_true,
            this.affiliation_checklist_id});
            this.gvAffiliate.GridControl = this.dtAffiliate;
            this.gvAffiliate.Name = "gvAffiliate";
            this.gvAffiliate.OptionsBehavior.Editable = false;
            this.gvAffiliate.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAffiliate.OptionsView.RowAutoHeight = true;
            this.gvAffiliate.OptionsView.ShowGroupPanel = false;
            this.gvAffiliate.OptionsView.ShowIndicator = false;
            // 
            // affiliation_id
            // 
            this.affiliation_id.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.affiliation_id.AppearanceHeader.Options.UseFont = true;
            this.affiliation_id.AppearanceHeader.Options.UseTextOptions = true;
            this.affiliation_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.affiliation_id.Caption = "Affiliation ID";
            this.affiliation_id.FieldName = "affiliation_name";
            this.affiliation_id.Name = "affiliation_id";
            this.affiliation_id.Width = 157;
            // 
            // affiliation_name
            // 
            this.affiliation_name.Caption = "Affiliation Name";
            this.affiliation_name.FieldName = "affiliation_name";
            this.affiliation_name.Name = "affiliation_name";
            this.affiliation_name.Visible = true;
            this.affiliation_name.VisibleIndex = 0;
            // 
            // years_in_membership
            // 
            this.years_in_membership.Caption = "Years in Membership";
            this.years_in_membership.FieldName = "years_in_membership";
            this.years_in_membership.Name = "years_in_membership";
            this.years_in_membership.Visible = true;
            this.years_in_membership.VisibleIndex = 1;
            // 
            // is_active
            // 
            this.is_active.Caption = "Active";
            this.is_active.FieldName = "active";
            this.is_active.Name = "is_active";
            // 
            // position
            // 
            this.position.Caption = "Position";
            this.position.FieldName = "position";
            this.position.Name = "position";
            this.position.Visible = true;
            this.position.VisibleIndex = 3;
            // 
            // is_active_true
            // 
            this.is_active_true.Caption = "Active";
            this.is_active_true.FieldName = "is_active_true";
            this.is_active_true.Name = "is_active_true";
            this.is_active_true.Visible = true;
            this.is_active_true.VisibleIndex = 2;
            // 
            // affiliation_checklist_id
            // 
            this.affiliation_checklist_id.Caption = "affiliation_checklist_id";
            this.affiliation_checklist_id.FieldName = "id";
            this.affiliation_checklist_id.Name = "affiliation_checklist_id";
            // 
            // btnAddProfileAffliation
            // 
            this.btnAddProfileAffliation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProfileAffliation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProfileAffliation.Image")));
            this.btnAddProfileAffliation.Location = new System.Drawing.Point(21, 22);
            this.btnAddProfileAffliation.Name = "btnAddProfileAffliation";
            this.btnAddProfileAffliation.Size = new System.Drawing.Size(96, 23);
            this.btnAddProfileAffliation.TabIndex = 592;
            this.btnAddProfileAffliation.Text = "Add Affiliation";
            this.btnAddProfileAffliation.ToolTip = "Add Affiliation";
            this.btnAddProfileAffliation.Click += new System.EventHandler(this.btnAddProfileAffliation_Click);
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(436, 163);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(109, 17);
            this.lblNoData.TabIndex = 687;
            this.lblNoData.Text = "No data to display";
            // 
            // bwGetProfileAffiliation
            // 
            this.bwGetProfileAffiliation.WorkerSupportsCancellation = true;
            this.bwGetProfileAffiliation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetProfileAffiliation_DoWork);
            this.bwGetProfileAffiliation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetProfileAffiliation_RunWorkerCompleted);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(812, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 734;
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(893, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 735;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ToolTip = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bwSaveProfile
            // 
            this.bwSaveProfile.WorkerSupportsCancellation = true;
            this.bwSaveProfile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveProfile_DoWork);
            this.bwSaveProfile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveProfile_RunWorkerCompleted);
            // 
            // bwSaveProfileChecklist
            // 
            this.bwSaveProfileChecklist.WorkerSupportsCancellation = true;
            this.bwSaveProfileChecklist.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveProfileChecklist_DoWork);
            this.bwSaveProfileChecklist.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveProfileChecklist_RunWorkerCompleted);
            // 
            // bwGetProvince
            // 
            this.bwGetProvince.WorkerSupportsCancellation = true;
            this.bwGetProvince.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetProvince_DoWork);
            this.bwGetProvince.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetProvince_RunWorkerCompleted);
            // 
            // bwGetMunicipality
            // 
            this.bwGetMunicipality.WorkerSupportsCancellation = true;
            this.bwGetMunicipality.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetMunicipality_DoWork);
            this.bwGetMunicipality.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetMunicipality_RunWorkerCompleted);
            // 
            // bwGetBarangay
            // 
            this.bwGetBarangay.WorkerSupportsCancellation = true;
            this.bwGetBarangay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetBarangay_DoWork);
            this.bwGetBarangay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetBarangay_RunWorkerCompleted);
            // 
            // bwDeleteProfile
            // 
            this.bwDeleteProfile.WorkerSupportsCancellation = true;
            this.bwDeleteProfile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteProfile_DoWork);
            this.bwDeleteProfile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteProfile_RunWorkerCompleted);
            // 
            // bwGetOccupation
            // 
            this.bwGetOccupation.WorkerSupportsCancellation = true;
            this.bwGetOccupation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetOccupation_DoWork);
            this.bwGetOccupation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetOccupation_RunWorkerCompleted);
            // 
            // bwGetProfileOccupation
            // 
            this.bwGetProfileOccupation.WorkerSupportsCancellation = true;
            this.bwGetProfileOccupation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetProfileOccupation_DoWork);
            this.bwGetProfileOccupation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetProfileOccupation_RunWorkerCompleted);
            // 
            // bwDeleteAffiliation
            // 
            this.bwDeleteAffiliation.WorkerSupportsCancellation = true;
            this.bwDeleteAffiliation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteAffiliation_DoWork);
            this.bwDeleteAffiliation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteAffiliation_RunWorkerCompleted);
            // 
            // ManageProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 581);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.chkprocessor);
            this.Controls.Add(this.chkfarmer);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.dtProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Management";
            this.Load += new System.EventHandler(this.ManageProfileForm_Load);
            this.Shown += new System.EventHandler(this.ManageProfileForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkprocessor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkfarmer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).EndInit();
            this.xtraTab.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBarangay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMunicipality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAttainment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCivilStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnnualIncome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfHousehold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOccupation.Properties)).EndInit();
            this.additional_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBusinesstype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbusinessStat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcasual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontractual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtothers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAveAnnualGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinitInvest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusinessStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusinessname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontact.Properties)).EndInit();
            this.affiliate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAffiliate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAffiliate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblManagePrifile;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.ComponentModel.BackgroundWorker bwGetProfile;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProfile;
        private DevExpress.XtraGrid.GridControl dtProfile;
        private DevExpress.XtraEditors.CheckEdit chkprocessor;
        private DevExpress.XtraEditors.CheckEdit chkfarmer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.PanelControl pnlData;
        private DevExpress.XtraTab.XtraTabControl xtraTab;
        private DevExpress.XtraTab.XtraTabPage profile;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBarangay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMunicipality;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProvince;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.TextEdit txtPurok;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAttainment;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCivilStatus;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtAnnualIncome;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNoOfHousehold;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSex;
        private DevExpress.XtraEditors.LabelControl lblAgee;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabPage additional_information;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtcasual;
        private DevExpress.XtraEditors.TextEdit txtcontractual;
        private DevExpress.XtraEditors.TextEdit txtothers;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.TextEdit txtregular;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.TextEdit txtAveAnnualGross;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtinitInvest;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtbusinessStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit txtbusinessname;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.TextEdit txtaddress;
        private DevExpress.XtraEditors.TextEdit txtcontact;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraGrid.Columns.GridColumn gender;
        private DevExpress.XtraGrid.Columns.GridColumn barangay_name;
        private DevExpress.XtraGrid.Columns.GridColumn municipal_name;
        private DevExpress.XtraGrid.Columns.GridColumn province_name;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl lblNoData;
        private DevExpress.XtraGrid.Columns.GridColumn age;
        private DevExpress.XtraGrid.Columns.GridColumn civil_status;
        private DevExpress.XtraGrid.Columns.GridColumn educational_attainment;
        private DevExpress.XtraGrid.Columns.GridColumn no_of_household_members;
        private DevExpress.XtraGrid.Columns.GridColumn annual_farm_income;
        private DevExpress.XtraGrid.Columns.GridColumn name_of_business;
        private DevExpress.XtraGrid.Columns.GridColumn business_addrress;
        private DevExpress.XtraGrid.Columns.GridColumn year_business_start;
        private DevExpress.XtraGrid.Columns.GridColumn contact_no;
        private DevExpress.XtraGrid.Columns.GridColumn business_status;
        private DevExpress.XtraGrid.Columns.GridColumn business_type;
        private DevExpress.XtraGrid.Columns.GridColumn initial_investment;
        private DevExpress.XtraGrid.Columns.GridColumn ave_annual_gross_income;
        private DevExpress.XtraGrid.Columns.GridColumn no_of_employees_id;
        private DevExpress.XtraGrid.Columns.GridColumn profile_type_name;
        private DevExpress.XtraGrid.Columns.GridColumn purok;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBusinesstype;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbusinessStat;
        private DevExpress.XtraEditors.TextEdit lblAge;
        private System.ComponentModel.BackgroundWorker bwGetProfileAffiliation;
        private DevExpress.XtraTab.XtraTabPage affiliate;
        private DevExpress.XtraEditors.LabelControl lblNoDataAffliation;
        private DevExpress.XtraGrid.GridControl dtAffiliate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAffiliate;
        private DevExpress.XtraGrid.Columns.GridColumn affiliation_id;
        private DevExpress.XtraGrid.Columns.GridColumn affiliation_name;
        private DevExpress.XtraGrid.Columns.GridColumn years_in_membership;
        private DevExpress.XtraGrid.Columns.GridColumn is_active;
        private DevExpress.XtraGrid.Columns.GridColumn position;
        private DevExpress.XtraEditors.SimpleButton btnAddProfileAffliation;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.ComponentModel.BackgroundWorker bwSaveProfile;
        private System.ComponentModel.BackgroundWorker bwSaveProfileChecklist;
        private System.ComponentModel.BackgroundWorker bwGetProvince;
        private System.ComponentModel.BackgroundWorker bwGetMunicipality;
        private System.ComponentModel.BackgroundWorker bwGetBarangay;
        private DevExpress.XtraGrid.Columns.GridColumn province_id;
        private DevExpress.XtraGrid.Columns.GridColumn municipal_id;
        private DevExpress.XtraGrid.Columns.GridColumn regular;
        private DevExpress.XtraGrid.Columns.GridColumn casual;
        private DevExpress.XtraGrid.Columns.GridColumn contractual;
        private DevExpress.XtraGrid.Columns.GridColumn others;
        private System.ComponentModel.BackgroundWorker bwDeleteProfile;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private System.ComponentModel.BackgroundWorker bwGetOccupation;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbOccupation;
        private System.ComponentModel.BackgroundWorker bwGetProfileOccupation;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn occupation_name;
        private DevExpress.XtraGrid.Columns.GridColumn true_date;
        private DevExpress.XtraGrid.Columns.GridColumn is_active_true;
        private DevExpress.XtraGrid.Columns.GridColumn id_number;
        public DevExpress.XtraEditors.SimpleButton btnRefreshAffliation;
        private DevExpress.XtraEditors.SimpleButton btnEditProfileAffliation;
        private DevExpress.XtraGrid.Columns.GridColumn affiliation_checklist_id;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAffiliaton;
        private System.ComponentModel.BackgroundWorker bwDeleteAffiliation;

    }
}