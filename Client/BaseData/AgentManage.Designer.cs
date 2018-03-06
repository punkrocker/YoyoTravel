namespace Client.BaseData
{
    partial class AgentManage
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
            this.dgAgents = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.split = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAgents
            // 
            this.dgAgents.AllowUserToAddRows = false;
            this.dgAgents.AllowUserToDeleteRows = false;
            this.dgAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colLoginName,
            this.colTel,
            this.colParentID,
            this.colParentName,
            this.colStatus,
            this.colStatusName,
            this.colPassword,
            this.colRemark});
            this.dgAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAgents.Location = new System.Drawing.Point(0, 0);
            this.dgAgents.Name = "dgAgents";
            this.dgAgents.ReadOnly = true;
            this.dgAgents.RowTemplate.Height = 23;
            this.dgAgents.Size = new System.Drawing.Size(685, 451);
            this.dgAgents.TabIndex = 0;
            this.dgAgents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgents_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "AgentID";
            this.colID.HeaderText = "代理编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "AgentName";
            this.colName.HeaderText = "代理名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLoginName
            // 
            this.colLoginName.DataPropertyName = "LoginName";
            this.colLoginName.HeaderText = "登录名";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.DataPropertyName = "Tel";
            this.colTel.HeaderText = "联系电话";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // colParentID
            // 
            this.colParentID.DataPropertyName = "ParentID";
            this.colParentID.HeaderText = "业务编号";
            this.colParentID.Name = "colParentID";
            this.colParentID.ReadOnly = true;
            this.colParentID.Visible = false;
            // 
            // colParentName
            // 
            this.colParentName.DataPropertyName = "ParentName";
            this.colParentName.HeaderText = "业务人员姓名";
            this.colParentName.Name = "colParentName";
            this.colParentName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "状态";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // colStatusName
            // 
            this.colStatusName.DataPropertyName = "isEnable";
            this.colStatusName.FalseValue = "False";
            this.colStatusName.HeaderText = "当前可用";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.ReadOnly = true;
            this.colStatusName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatusName.TrueValue = "True";
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "Password";
            this.colPassword.HeaderText = "密码";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Visible = false;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split.IsSplitterFixed = true;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.btnAdd);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.dgAgents);
            this.split.Size = new System.Drawing.Size(685, 495);
            this.split.SplitterDistance = 40;
            this.split.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新建New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AgentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.Controls.Add(this.split);
            this.Name = "AgentManage";
            this.Text = "AgentManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgAgents)).EndInit();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgents;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}