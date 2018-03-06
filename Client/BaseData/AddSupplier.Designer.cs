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
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitSupplier = new System.Windows.Forms.SplitContainer();
            this.dgTravelService = new System.Windows.Forms.DataGridView();
            this.dgHotel = new System.Windows.Forms.DataGridView();
            this.addSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colHotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHotelRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSupplier)).BeginInit();
            this.splitSupplier.Panel1.SuspendLayout();
            this.splitSupplier.Panel2.SuspendLayout();
            this.splitSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTravelService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSupplierBindingSource)).BeginInit();
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
            this.pnlMainInfo.Size = new System.Drawing.Size(967, 85);
            this.pnlMainInfo.TabIndex = 4;
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
            // splitSupplier
            // 
            this.splitSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSupplier.Location = new System.Drawing.Point(0, 85);
            this.splitSupplier.Name = "splitSupplier";
            this.splitSupplier.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSupplier.Panel1
            // 
            this.splitSupplier.Panel1.Controls.Add(this.dgTravelService);
            // 
            // splitSupplier.Panel2
            // 
            this.splitSupplier.Panel2.Controls.Add(this.dgHotel);
            this.splitSupplier.Size = new System.Drawing.Size(967, 469);
            this.splitSupplier.SplitterDistance = 222;
            this.splitSupplier.TabIndex = 5;
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
            this.dgTravelService.Location = new System.Drawing.Point(0, 0);
            this.dgTravelService.Name = "dgTravelService";
            this.dgTravelService.ReadOnly = true;
            this.dgTravelService.RowTemplate.Height = 23;
            this.dgTravelService.Size = new System.Drawing.Size(967, 222);
            this.dgTravelService.TabIndex = 0;
            this.dgTravelService.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTravelService_CellDoubleClick);
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
            this.dgHotel.Location = new System.Drawing.Point(0, 0);
            this.dgHotel.Name = "dgHotel";
            this.dgHotel.ReadOnly = true;
            this.dgHotel.RowTemplate.Height = 23;
            this.dgHotel.Size = new System.Drawing.Size(967, 243);
            this.dgHotel.TabIndex = 1;
            this.dgHotel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHotel_CellDoubleClick);
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
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 554);
            this.Controls.Add(this.splitSupplier);
            this.Controls.Add(this.pnlMainInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加供应商";
            this.pnlMainInfo.ResumeLayout(false);
            this.pnlMainInfo.PerformLayout();
            this.splitSupplier.Panel1.ResumeLayout(false);
            this.splitSupplier.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSupplier)).EndInit();
            this.splitSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTravelService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Panel pnlMainInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitSupplier;
        private System.Windows.Forms.DataGridView dgTravelService;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView dgHotel;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource addSupplierBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colHotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPics;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHotelRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}