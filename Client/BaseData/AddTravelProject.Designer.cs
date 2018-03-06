namespace Client.BaseData
{
    partial class AddTravelProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTravelProject));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtAdultFee = new System.Windows.Forms.TextBox();
            this.txtChildFee = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAgentChild = new System.Windows.Forms.TextBox();
            this.txtAgentAdult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "成人费用";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "儿童费用";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(25, 48);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(150, 21);
            this.txtProjectName.TabIndex = 0;
            // 
            // txtAdultFee
            // 
            this.txtAdultFee.Location = new System.Drawing.Point(380, 47);
            this.txtAdultFee.Name = "txtAdultFee";
            this.txtAdultFee.Size = new System.Drawing.Size(150, 21);
            this.txtAdultFee.TabIndex = 2;
            this.txtAdultFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtChildFee
            // 
            this.txtChildFee.Location = new System.Drawing.Point(25, 128);
            this.txtChildFee.Name = "txtChildFee";
            this.txtChildFee.Size = new System.Drawing.Size(150, 21);
            this.txtChildFee.TabIndex = 4;
            this.txtChildFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAgentChild
            // 
            this.txtAgentChild.Location = new System.Drawing.Point(200, 128);
            this.txtAgentChild.Name = "txtAgentChild";
            this.txtAgentChild.Size = new System.Drawing.Size(150, 21);
            this.txtAgentChild.TabIndex = 5;
            this.txtAgentChild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtAgentAdult
            // 
            this.txtAgentAdult.Location = new System.Drawing.Point(555, 47);
            this.txtAgentAdult.Name = "txtAgentAdult";
            this.txtAgentAdult.Size = new System.Drawing.Size(150, 21);
            this.txtAgentAdult.TabIndex = 3;
            this.txtAgentAdult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "代理儿童费用";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "代理成人费用";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(200, 192);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(150, 213);
            this.txtRemark.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "备注";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(25, 192);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(150, 213);
            this.txtDesc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "详情描述";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "项目类型";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(202, 48);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(148, 20);
            this.cbxType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "封面图片";
            // 
            // btnPic
            // 
            this.btnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPic.Location = new System.Drawing.Point(380, 128);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(325, 277);
            this.btnPic.TabIndex = 18;
            this.btnPic.Text = "+";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // AddTravelProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAgentChild);
            this.Controls.Add(this.txtAgentAdult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtChildFee);
            this.Controls.Add(this.txtAdultFee);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTravelProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtAdultFee;
        private System.Windows.Forms.TextBox txtChildFee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAgentChild;
        private System.Windows.Forms.TextBox txtAgentAdult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPic;
    }
}