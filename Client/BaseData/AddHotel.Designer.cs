namespace Client.BaseData
{
    partial class AddHotel
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgentFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOtherPic = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(358, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(35, 106);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(162, 21);
            this.txtFee.TabIndex = 12;
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(35, 42);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(363, 21);
            this.txtHotelName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "每日单价";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "别墅名称";
            // 
            // txtAgentFee
            // 
            this.txtAgentFee.Location = new System.Drawing.Point(236, 106);
            this.txtAgentFee.Name = "txtAgentFee";
            this.txtAgentFee.Size = new System.Drawing.Size(162, 21);
            this.txtAgentFee.TabIndex = 17;
            this.txtAgentFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentFee_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "代理单价";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(37, 246);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(162, 177);
            this.txtDesc.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "别墅说明";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(236, 246);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(162, 177);
            this.txtRemark.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "代理说明";
            // 
            // btnPic
            // 
            this.btnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPic.Location = new System.Drawing.Point(425, 59);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(166, 148);
            this.btnPic.TabIndex = 23;
            this.btnPic.Text = "+";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "封面图片";
            // 
            // btnOtherPic
            // 
            this.btnOtherPic.Location = new System.Drawing.Point(425, 246);
            this.btnOtherPic.Name = "btnOtherPic";
            this.btnOtherPic.Size = new System.Drawing.Size(166, 113);
            this.btnOtherPic.TabIndex = 24;
            this.btnOtherPic.Text = "添加其他图片";
            this.btnOtherPic.UseVisualStyleBackColor = true;
            this.btnOtherPic.Click += new System.EventHandler(this.btnOtherPic_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(35, 186);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(363, 21);
            this.txtLocation.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "别墅位置";
            // 
            // txtRoomCount
            // 
            this.txtRoomCount.Location = new System.Drawing.Point(425, 402);
            this.txtRoomCount.Name = "txtRoomCount";
            this.txtRoomCount.Size = new System.Drawing.Size(162, 21);
            this.txtRoomCount.TabIndex = 28;
            this.txtRoomCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomCount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "房间数量";
            // 
            // AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 522);
            this.Controls.Add(this.txtRoomCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOtherPic);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAgentFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加住宿信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgentFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOtherPic;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomCount;
        private System.Windows.Forms.Label label7;
    }
}