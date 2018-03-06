namespace Client.BaseData
{
    partial class AddDriver
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAgentBigCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBigCar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgentSmallCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmallCar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgentBigCarPick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBigCarPick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgentSmallCarPick = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSmallCarPick = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAgentBigCarSend = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBigCarSend = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAgentSmallCarSend = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSmallCarSend = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "司机姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(79, 64);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(167, 21);
            this.txtTel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "电话";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(335, 64);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(167, 21);
            this.txtContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "其他联系方式";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(80, 319);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(422, 105);
            this.txtRemark.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "备注";
            // 
            // txtAgentBigCar
            // 
            this.txtAgentBigCar.Location = new System.Drawing.Point(335, 99);
            this.txtAgentBigCar.Name = "txtAgentBigCar";
            this.txtAgentBigCar.Size = new System.Drawing.Size(167, 21);
            this.txtAgentBigCar.TabIndex = 35;
            this.txtAgentBigCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "代理大车包车";
            // 
            // txtBigCar
            // 
            this.txtBigCar.Location = new System.Drawing.Point(80, 99);
            this.txtBigCar.Name = "txtBigCar";
            this.txtBigCar.Size = new System.Drawing.Size(167, 21);
            this.txtBigCar.TabIndex = 33;
            this.txtBigCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 32;
            this.label5.Tag = "";
            this.label5.Text = "大车包车";
            // 
            // txtAgentSmallCar
            // 
            this.txtAgentSmallCar.Location = new System.Drawing.Point(335, 134);
            this.txtAgentSmallCar.Name = "txtAgentSmallCar";
            this.txtAgentSmallCar.Size = new System.Drawing.Size(167, 21);
            this.txtAgentSmallCar.TabIndex = 39;
            this.txtAgentSmallCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "代理小车包车";
            // 
            // txtSmallCar
            // 
            this.txtSmallCar.Location = new System.Drawing.Point(80, 134);
            this.txtSmallCar.Name = "txtSmallCar";
            this.txtSmallCar.Size = new System.Drawing.Size(167, 21);
            this.txtSmallCar.TabIndex = 37;
            this.txtSmallCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "小车包车";
            // 
            // txtAgentBigCarPick
            // 
            this.txtAgentBigCarPick.Location = new System.Drawing.Point(335, 169);
            this.txtAgentBigCarPick.Name = "txtAgentBigCarPick";
            this.txtAgentBigCarPick.Size = new System.Drawing.Size(167, 21);
            this.txtAgentBigCarPick.TabIndex = 43;
            this.txtAgentBigCarPick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "代理大车接机";
            // 
            // txtBigCarPick
            // 
            this.txtBigCarPick.Location = new System.Drawing.Point(80, 169);
            this.txtBigCarPick.Name = "txtBigCarPick";
            this.txtBigCarPick.Size = new System.Drawing.Size(167, 21);
            this.txtBigCarPick.TabIndex = 41;
            this.txtBigCarPick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "大车接机";
            // 
            // txtAgentSmallCarPick
            // 
            this.txtAgentSmallCarPick.Location = new System.Drawing.Point(335, 204);
            this.txtAgentSmallCarPick.Name = "txtAgentSmallCarPick";
            this.txtAgentSmallCarPick.Size = new System.Drawing.Size(167, 21);
            this.txtAgentSmallCarPick.TabIndex = 47;
            this.txtAgentSmallCarPick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "代理小车接机";
            // 
            // txtSmallCarPick
            // 
            this.txtSmallCarPick.Location = new System.Drawing.Point(79, 204);
            this.txtSmallCarPick.Name = "txtSmallCarPick";
            this.txtSmallCarPick.Size = new System.Drawing.Size(167, 21);
            this.txtSmallCarPick.TabIndex = 45;
            this.txtSmallCarPick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "小车接机";
            // 
            // txtAgentBigCarSend
            // 
            this.txtAgentBigCarSend.Location = new System.Drawing.Point(335, 239);
            this.txtAgentBigCarSend.Name = "txtAgentBigCarSend";
            this.txtAgentBigCarSend.Size = new System.Drawing.Size(167, 21);
            this.txtAgentBigCarSend.TabIndex = 51;
            this.txtAgentBigCarSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "代理大车送机";
            // 
            // txtBigCarSend
            // 
            this.txtBigCarSend.Location = new System.Drawing.Point(80, 239);
            this.txtBigCarSend.Name = "txtBigCarSend";
            this.txtBigCarSend.Size = new System.Drawing.Size(167, 21);
            this.txtBigCarSend.TabIndex = 49;
            this.txtBigCarSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "大车送机";
            // 
            // txtAgentSmallCarSend
            // 
            this.txtAgentSmallCarSend.Location = new System.Drawing.Point(335, 274);
            this.txtAgentSmallCarSend.Name = "txtAgentSmallCarSend";
            this.txtAgentSmallCarSend.Size = new System.Drawing.Size(167, 21);
            this.txtAgentSmallCarSend.TabIndex = 55;
            this.txtAgentSmallCarSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 54;
            this.label14.Text = "代理小车送机";
            // 
            // txtSmallCarSend
            // 
            this.txtSmallCarSend.Location = new System.Drawing.Point(80, 274);
            this.txtSmallCarSend.Name = "txtSmallCarSend";
            this.txtSmallCarSend.Size = new System.Drawing.Size(167, 21);
            this.txtSmallCarSend.TabIndex = 53;
            this.txtSmallCarSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 52;
            this.label15.Text = "小车送机";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(124, 450);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 56;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(312, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 498);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAgentSmallCarSend);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSmallCarSend);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAgentBigCarSend);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBigCarSend);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAgentSmallCarPick);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSmallCarPick);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAgentBigCarPick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBigCarPick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAgentSmallCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSmallCar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAgentBigCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBigCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddDriver";
            this.Text = "添加司机";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAgentBigCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBigCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgentSmallCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSmallCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgentBigCarPick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBigCarPick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgentSmallCarPick;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSmallCarPick;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAgentBigCarSend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBigCarSend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAgentSmallCarSend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSmallCarSend;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}