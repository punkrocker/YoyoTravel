namespace Client.BaseData
{
    partial class BaseDataMain
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
            this.split = new System.Windows.Forms.SplitContainer();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split.IsSplitterFixed = true;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.btnFunction);
            this.split.Panel1.Controls.Add(this.btnUser);
            this.split.Panel1.Controls.Add(this.btnVIP);
            this.split.Panel1.Controls.Add(this.btnDriver);
            this.split.Panel1.Controls.Add(this.btnGuide);
            this.split.Panel1.Controls.Add(this.btnSupplier);
            this.split.Panel1MinSize = 64;
            this.split.Size = new System.Drawing.Size(1025, 544);
            this.split.SplitterDistance = 64;
            this.split.TabIndex = 0;
            // 
            // btnFunction
            // 
            this.btnFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFunction.Location = new System.Drawing.Point(320, 0);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(64, 62);
            this.btnFunction.TabIndex = 6;
            this.btnFunction.Text = "权限 Auth";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Visible = false;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser.Location = new System.Drawing.Point(256, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(64, 62);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "用户 User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVIP.Location = new System.Drawing.Point(192, 0);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(64, 62);
            this.btnVIP.TabIndex = 4;
            this.btnVIP.Text = "VIP";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Visible = false;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDriver.Location = new System.Drawing.Point(128, 0);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(64, 62);
            this.btnDriver.TabIndex = 3;
            this.btnDriver.Text = "司机Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Visible = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuide.Location = new System.Drawing.Point(64, 0);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(64, 62);
            this.btnGuide.TabIndex = 2;
            this.btnGuide.Text = "导游Guide";
            this.btnGuide.UseVisualStyleBackColor = true;
            this.btnGuide.Visible = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSupplier.Location = new System.Drawing.Point(0, 0);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(64, 62);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "供应商Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // BaseDataMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.split);
            this.Name = "BaseDataMain";
            this.Text = "BaseDataMain";
            this.split.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnSupplier;
    }
}