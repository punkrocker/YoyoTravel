namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbBase = new System.Windows.Forms.TabPage();
            this.tbBusiness = new System.Windows.Forms.TabPage();
            this.tbDispatch = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbBase);
            this.tabMain.Controls.Add(this.tbBusiness);
            this.tabMain.Controls.Add(this.tbDispatch);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1061, 547);
            this.tabMain.TabIndex = 0;
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(4, 22);
            this.tbBase.Name = "tbBase";
            this.tbBase.Padding = new System.Windows.Forms.Padding(3);
            this.tbBase.Size = new System.Drawing.Size(1053, 521);
            this.tbBase.TabIndex = 0;
            this.tbBase.Text = "基本设置";
            this.tbBase.UseVisualStyleBackColor = true;
            // 
            // tbBusiness
            // 
            this.tbBusiness.Location = new System.Drawing.Point(4, 22);
            this.tbBusiness.Name = "tbBusiness";
            this.tbBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusiness.Size = new System.Drawing.Size(1053, 521);
            this.tbBusiness.TabIndex = 1;
            this.tbBusiness.Text = "业务操作";
            this.tbBusiness.UseVisualStyleBackColor = true;
            // 
            // tbDispatch
            // 
            this.tbDispatch.Location = new System.Drawing.Point(4, 22);
            this.tbDispatch.Name = "tbDispatch";
            this.tbDispatch.Size = new System.Drawing.Size(1053, 521);
            this.tbDispatch.TabIndex = 2;
            this.tbDispatch.Text = "调度操作";
            this.tbDispatch.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 547);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoyo旅游处理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbBase;
        private System.Windows.Forms.TabPage tbBusiness;
        private System.Windows.Forms.TabPage tbDispatch;
    }
}

