namespace Client.BaseData
{
    partial class AddGuide
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuideName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLandFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgentLandFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeaFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgentSeaFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "导游姓名";
            // 
            // txtGuideName
            // 
            this.txtGuideName.Location = new System.Drawing.Point(106, 24);
            this.txtGuideName.Name = "txtGuideName";
            this.txtGuideName.Size = new System.Drawing.Size(239, 21);
            this.txtGuideName.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(106, 56);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(239, 21);
            this.txtTel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系电话";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(106, 88);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(239, 21);
            this.txtContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "其他联系方式";
            // 
            // txtLandFee
            // 
            this.txtLandFee.Location = new System.Drawing.Point(106, 120);
            this.txtLandFee.Name = "txtLandFee";
            this.txtLandFee.Size = new System.Drawing.Size(239, 21);
            this.txtLandFee.TabIndex = 7;
            this.txtLandFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "不出海费用";
            // 
            // txtAgentLandFee
            // 
            this.txtAgentLandFee.Location = new System.Drawing.Point(106, 152);
            this.txtAgentLandFee.Name = "txtAgentLandFee";
            this.txtAgentLandFee.Size = new System.Drawing.Size(239, 21);
            this.txtAgentLandFee.TabIndex = 9;
            this.txtAgentLandFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "不出海代理费用";
            // 
            // txtSeaFee
            // 
            this.txtSeaFee.Location = new System.Drawing.Point(106, 184);
            this.txtSeaFee.Name = "txtSeaFee";
            this.txtSeaFee.Size = new System.Drawing.Size(239, 21);
            this.txtSeaFee.TabIndex = 11;
            this.txtSeaFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "出海费用";
            // 
            // txtAgentSeaFee
            // 
            this.txtAgentSeaFee.Location = new System.Drawing.Point(106, 216);
            this.txtAgentSeaFee.Name = "txtAgentSeaFee";
            this.txtAgentSeaFee.Size = new System.Drawing.Size(239, 21);
            this.txtAgentSeaFee.TabIndex = 13;
            this.txtAgentSeaFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "出海代理费用";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(106, 248);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(239, 109);
            this.txtRemark.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "备注";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(106, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAgentSeaFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSeaFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAgentLandFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLandFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuideName);
            this.Controls.Add(this.label1);
            this.Name = "AddGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加导游";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuideName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLandFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgentLandFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeaFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgentSeaFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}