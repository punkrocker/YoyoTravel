﻿namespace Client.BaseData
{
    partial class VipManage
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
            this.dgVIP = new System.Windows.Forms.DataGridView();
            this.split = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUsers
            // 
            this.dgVIP.AllowUserToAddRows = false;
            this.dgVIP.AllowUserToDeleteRows = false;
            this.dgVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVIP.Location = new System.Drawing.Point(0, 0);
            this.dgVIP.Name = "dgUsers";
            this.dgVIP.ReadOnly = true;
            this.dgVIP.RowTemplate.Height = 23;
            this.dgVIP.Size = new System.Drawing.Size(959, 471);
            this.dgVIP.TabIndex = 0;
            this.dgVIP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellDoubleClick);
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
            this.split.Panel2.Controls.Add(this.dgVIP);
            this.split.Size = new System.Drawing.Size(959, 515);
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
            // VipManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 515);
            this.Controls.Add(this.split);
            this.Name = "VipManage";
            this.Text = "VipManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).EndInit();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVIP;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button btnAdd;
    }
}