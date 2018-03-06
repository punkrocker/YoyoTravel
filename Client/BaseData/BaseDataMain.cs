using Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.BaseData
{
    public partial class BaseDataMain : Form
    {
        private Form activeForm = null;
        public BaseDataMain()
        {
            InitializeComponent();
            ClientUtils.ResolveForm(this);
        }

        private void ChangeWindow(Form frm)
        {
            split.Panel2.Controls.Clear();
            split.Panel2.Controls.Add(frm);
            activeForm = frm;
            frm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ChangeWindow(new ServiceSupplierManage());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ChangeWindow(new UserManage());
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ChangeWindow(new AgentManage());
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            ChangeWindow(new VipManage());
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            ChangeWindow(new GuideManage());
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            ChangeWindow(new DriverManage());
        }
    }
}
