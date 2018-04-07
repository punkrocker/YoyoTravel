namespace Client.BaseData
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.pnlMainInfo = new System.Windows.Forms.Panel();
            this.btnAddGuide = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnAddVIP = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.addSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSupplierDetails = new System.Windows.Forms.TabControl();
            this.tbPageService = new System.Windows.Forms.TabPage();
            this.tbPageHotel = new System.Windows.Forms.TabPage();
            this.dgTravelService = new System.Windows.Forms.DataGridView();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdultFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgentAdultFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgentChildFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHotel = new System.Windows.Forms.DataGridView();
            this.colHotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHotelRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPageVIP = new System.Windows.Forms.TabPage();
            this.tbPageDriver = new System.Windows.Forms.TabPage();
            this.tbPageGuide = new System.Windows.Forms.TabPage();
            this.dgVIP = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDrivers = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSupplierBindingSource)).BeginInit();
            this.tbSupplierDetails.SuspendLayout();
            this.tbPageService.SuspendLayout();
            this.tbPageHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTravelService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotel)).BeginInit();
            this.tbPageVIP.SuspendLayout();
            this.tbPageDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "供应商名称SupplierName";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(174, 16);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(426, 21);
            this.txtSupplierName.TabIndex = 5;
            // 
            // pnlMainInfo
            // 
            this.pnlMainInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainInfo.Controls.Add(this.btnAddGuide);
            this.pnlMainInfo.Controls.Add(this.btnAddDriver);
            this.pnlMainInfo.Controls.Add(this.btnAddVIP);
            this.pnlMainInfo.Controls.Add(this.txtContact);
            this.pnlMainInfo.Controls.Add(this.label2);
            this.pnlMainInfo.Controls.Add(this.btnAddHotel);
            this.pnlMainInfo.Controls.Add(this.btnAddService);
            this.pnlMainInfo.Controls.Add(this.btnSave);
            this.pnlMainInfo.Controls.Add(this.txtSupplierName);
            this.pnlMainInfo.Controls.Add(this.label1);
            this.pnlMainInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMainInfo.Name = "pnlMainInfo";
            this.pnlMainInfo.Size = new System.Drawing.Size(967, 115);
            this.pnlMainInfo.TabIndex = 4;
            // 
            // btnAddGuide
            // 
            this.btnAddGuide.Location = new System.Drawing.Point(852, 80);
            this.btnAddGuide.Name = "btnAddGuide";
            this.btnAddGuide.Size = new System.Drawing.Size(102, 23);
            this.btnAddGuide.TabIndex = 15;
            this.btnAddGuide.Text = "添加导游信息";
            this.btnAddGuide.UseVisualStyleBackColor = true;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(852, 47);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(102, 23);
            this.btnAddDriver.TabIndex = 14;
            this.btnAddDriver.Text = "添加司机信息";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnAddVIP
            // 
            this.btnAddVIP.Location = new System.Drawing.Point(727, 47);
            this.btnAddVIP.Name = "btnAddVIP";
            this.btnAddVIP.Size = new System.Drawing.Size(119, 23);
            this.btnAddVIP.TabIndex = 13;
            this.btnAddVIP.Text = "添加VIP服务";
            this.btnAddVIP.UseVisualStyleBackColor = true;
            this.btnAddVIP.Click += new System.EventHandler(this.btnAddVIP_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(174, 52);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(426, 21);
            this.txtContact.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "联系方式Contact";
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Location = new System.Drawing.Point(852, 14);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(102, 23);
            this.btnAddHotel.TabIndex = 10;
            this.btnAddHotel.Text = "添加住宿信息";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(727, 14);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(119, 23);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "添加旅游项目";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(606, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSupplierDetails
            // 
            this.tbSupplierDetails.Controls.Add(this.tbPageService);
            this.tbSupplierDetails.Controls.Add(this.tbPageHotel);
            this.tbSupplierDetails.Controls.Add(this.tbPageVIP);
            this.tbSupplierDetails.Controls.Add(this.tbPageDriver);
            this.tbSupplierDetails.Controls.Add(this.tbPageGuide);
            this.tbSupplierDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSupplierDetails.Location = new System.Drawing.Point(0, 115);
            this.tbSupplierDetails.Name = "tbSupplierDetails";
            this.tbSupplierDetails.SelectedIndex = 0;
            this.tbSupplierDetails.Size = new System.Drawing.Size(967, 439);
            this.tbSupplierDetails.TabIndex = 6;
            // 
            // tbPageService
            // 
            this.tbPageService.Controls.Add(this.dgTravelService);
            this.tbPageService.Location = new System.Drawing.Point(4, 22);
            this.tbPageService.Name = "tbPageService";
            this.tbPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageService.Size = new System.Drawing.Size(959, 413);
            this.tbPageService.TabIndex = 0;
            this.tbPageService.Text = "旅游项目";
            this.tbPageService.UseVisualStyleBackColor = true;
            // 
            // tbPageHotel
            // 
            this.tbPageHotel.Controls.Add(this.dgHotel);
            this.tbPageHotel.Location = new System.Drawing.Point(4, 22);
            this.tbPageHotel.Name = "tbPageHotel";
            this.tbPageHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageHotel.Size = new System.Drawing.Size(959, 413);
            this.tbPageHotel.TabIndex = 1;
            this.tbPageHotel.Text = "别墅住宿";
            this.tbPageHotel.UseVisualStyleBackColor = true;
            // 
            // dgTravelService
            // 
            this.dgTravelService.AllowUserToAddRows = false;
            this.dgTravelService.AllowUserToDeleteRows = false;
            this.dgTravelService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTravelService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceName,
            this.colAdultFee,
            this.colChildFee,
            this.colTypeName,
            this.colID,
            this.colSupplierID,
            this.colAgentAdultFee,
            this.colAgentChildFee,
            this.colTypeID,
            this.colPic,
            this.colDesc,
            this.colRemark});
            this.dgTravelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTravelService.Location = new System.Drawing.Point(3, 3);
            this.dgTravelService.Name = "dgTravelService";
            this.dgTravelService.ReadOnly = true;
            this.dgTravelService.RowTemplate.Height = 23;
            this.dgTravelService.Size = new System.Drawing.Size(953, 407);
            this.dgTravelService.TabIndex = 1;
            // 
            // colServiceName
            // 
            this.colServiceName.DataPropertyName = "ProjectName";
            this.colServiceName.HeaderText = "服务项目名称";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            this.colServiceName.Width = 150;
            // 
            // colAdultFee
            // 
            this.colAdultFee.DataPropertyName = "AdultFee";
            this.colAdultFee.HeaderText = "成人收费";
            this.colAdultFee.Name = "colAdultFee";
            this.colAdultFee.ReadOnly = true;
            // 
            // colChildFee
            // 
            this.colChildFee.DataPropertyName = "ChildFee";
            this.colChildFee.HeaderText = "儿童收费";
            this.colChildFee.Name = "colChildFee";
            this.colChildFee.ReadOnly = true;
            // 
            // colTypeName
            // 
            this.colTypeName.DataPropertyName = "ProjectTypeName";
            this.colTypeName.HeaderText = "类型名称";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ProjectID";
            this.colID.HeaderText = "项目编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colSupplierID
            // 
            this.colSupplierID.DataPropertyName = "SupplierID";
            this.colSupplierID.HeaderText = "供应商编号";
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.ReadOnly = true;
            this.colSupplierID.Visible = false;
            // 
            // colAgentAdultFee
            // 
            this.colAgentAdultFee.DataPropertyName = "AgentAdultFee";
            this.colAgentAdultFee.HeaderText = "代理成人收费";
            this.colAgentAdultFee.Name = "colAgentAdultFee";
            this.colAgentAdultFee.ReadOnly = true;
            // 
            // colAgentChildFee
            // 
            this.colAgentChildFee.DataPropertyName = "AgentChildFee";
            this.colAgentChildFee.HeaderText = "代理儿童收费";
            this.colAgentChildFee.Name = "colAgentChildFee";
            this.colAgentChildFee.ReadOnly = true;
            // 
            // colTypeID
            // 
            this.colTypeID.DataPropertyName = "ProjectTypeID";
            this.colTypeID.HeaderText = "类型编号";
            this.colTypeID.Name = "colTypeID";
            this.colTypeID.ReadOnly = true;
            this.colTypeID.Visible = false;
            // 
            // colPic
            // 
            this.colPic.DataPropertyName = "CoverPic";
            this.colPic.HeaderText = "封面图片路径";
            this.colPic.Name = "colPic";
            this.colPic.ReadOnly = true;
            this.colPic.Visible = false;
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "Description";
            this.colDesc.HeaderText = "详细说明";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // dgHotel
            // 
            this.dgHotel.AllowUserToAddRows = false;
            this.dgHotel.AllowUserToDeleteRows = false;
            this.dgHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHotelName,
            this.Column1,
            this.Column2,
            this.colFee,
            this.colAgentFee,
            this.colCover,
            this.colPics,
            this.colHotelRemark,
            this.colDescription});
            this.dgHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHotel.Location = new System.Drawing.Point(3, 3);
            this.dgHotel.Name = "dgHotel";
            this.dgHotel.ReadOnly = true;
            this.dgHotel.RowTemplate.Height = 23;
            this.dgHotel.Size = new System.Drawing.Size(953, 407);
            this.dgHotel.TabIndex = 2;
            // 
            // colHotelName
            // 
            this.colHotelName.DataPropertyName = "HouseName";
            this.colHotelName.HeaderText = "别墅名称";
            this.colHotelName.Name = "colHotelName";
            this.colHotelName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HouseID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SupplierID";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // colFee
            // 
            this.colFee.DataPropertyName = "Fee";
            this.colFee.HeaderText = "每日单价";
            this.colFee.Name = "colFee";
            this.colFee.ReadOnly = true;
            // 
            // colAgentFee
            // 
            this.colAgentFee.DataPropertyName = "AgentFee";
            this.colAgentFee.HeaderText = "代理单价";
            this.colAgentFee.Name = "colAgentFee";
            this.colAgentFee.ReadOnly = true;
            // 
            // colCover
            // 
            this.colCover.DataPropertyName = "CoverPic";
            this.colCover.HeaderText = "封面图片";
            this.colCover.Name = "colCover";
            this.colCover.ReadOnly = true;
            this.colCover.Visible = false;
            // 
            // colPics
            // 
            this.colPics.DataPropertyName = "Pics";
            this.colPics.HeaderText = "详情图片";
            this.colPics.Name = "colPics";
            this.colPics.ReadOnly = true;
            this.colPics.Visible = false;
            // 
            // colHotelRemark
            // 
            this.colHotelRemark.DataPropertyName = "Remark";
            this.colHotelRemark.HeaderText = "代理商说明";
            this.colHotelRemark.Name = "colHotelRemark";
            this.colHotelRemark.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "别墅说明";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // tbPageVIP
            // 
            this.tbPageVIP.Controls.Add(this.dgVIP);
            this.tbPageVIP.Location = new System.Drawing.Point(4, 22);
            this.tbPageVIP.Name = "tbPageVIP";
            this.tbPageVIP.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageVIP.Size = new System.Drawing.Size(959, 413);
            this.tbPageVIP.TabIndex = 2;
            this.tbPageVIP.Text = "VIP服务";
            this.tbPageVIP.UseVisualStyleBackColor = true;
            // 
            // tbPageDriver
            // 
            this.tbPageDriver.Controls.Add(this.dgDrivers);
            this.tbPageDriver.Location = new System.Drawing.Point(4, 22);
            this.tbPageDriver.Name = "tbPageDriver";
            this.tbPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDriver.Size = new System.Drawing.Size(959, 413);
            this.tbPageDriver.TabIndex = 3;
            this.tbPageDriver.Text = "司机服务";
            this.tbPageDriver.UseVisualStyleBackColor = true;
            // 
            // tbPageGuide
            // 
            this.tbPageGuide.Location = new System.Drawing.Point(4, 22);
            this.tbPageGuide.Name = "tbPageGuide";
            this.tbPageGuide.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageGuide.Size = new System.Drawing.Size(959, 413);
            this.tbPageGuide.TabIndex = 4;
            this.tbPageGuide.Text = "导游服务";
            this.tbPageGuide.UseVisualStyleBackColor = true;
            // 
            // dgVIP
            // 
            this.dgVIP.AllowUserToAddRows = false;
            this.dgVIP.AllowUserToDeleteRows = false;
            this.dgVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dgVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVIP.Location = new System.Drawing.Point(3, 3);
            this.dgVIP.Name = "dgVIP";
            this.dgVIP.ReadOnly = true;
            this.dgVIP.RowTemplate.Height = 23;
            this.dgVIP.Size = new System.Drawing.Size(953, 407);
            this.dgVIP.TabIndex = 1;
            this.dgVIP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVIP_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SupplierID";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // dgDrivers
            // 
            this.dgDrivers.AllowUserToAddRows = false;
            this.dgDrivers.AllowUserToDeleteRows = false;
            this.dgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDrivers.Location = new System.Drawing.Point(3, 3);
            this.dgDrivers.Name = "dgDrivers";
            this.dgDrivers.ReadOnly = true;
            this.dgDrivers.RowHeadersWidth = 100;
            this.dgDrivers.RowTemplate.Height = 23;
            this.dgDrivers.Size = new System.Drawing.Size(953, 407);
            this.dgDrivers.TabIndex = 1;
            this.dgDrivers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDrivers_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SupplierID";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 554);
            this.Controls.Add(this.tbSupplierDetails);
            this.Controls.Add(this.pnlMainInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加供应商";
            this.pnlMainInfo.ResumeLayout(false);
            this.pnlMainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSupplierBindingSource)).EndInit();
            this.tbSupplierDetails.ResumeLayout(false);
            this.tbPageService.ResumeLayout(false);
            this.tbPageHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTravelService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotel)).EndInit();
            this.tbPageVIP.ResumeLayout(false);
            this.tbPageDriver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Panel pnlMainInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource addSupplierBindingSource;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnAddVIP;
        private System.Windows.Forms.Button btnAddGuide;
        private System.Windows.Forms.TabControl tbSupplierDetails;
        private System.Windows.Forms.TabPage tbPageService;
        private System.Windows.Forms.DataGridView dgTravelService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdultFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentAdultFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentChildFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.TabPage tbPageHotel;
        private System.Windows.Forms.DataGridView dgHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPics;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHotelRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.TabPage tbPageVIP;
        private System.Windows.Forms.TabPage tbPageDriver;
        private System.Windows.Forms.TabPage tbPageGuide;
        private System.Windows.Forms.DataGridView dgVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}