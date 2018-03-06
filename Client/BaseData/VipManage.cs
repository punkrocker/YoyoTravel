using Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel.Client.Lang;
using Travel.Client.Utils;

namespace Client.BaseData
{
    public partial class VipManage : Form
    {
        List<VIPDto> vips = new List<VIPDto>();
        public VipManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            GetAllVipServices();
        }

        private void GetAllVipServices()
        {
            vips = WebCall.GetMethod<List<VIPDto>>(WebCall.GetVips, null);
            dgVIP.DataSource = vips;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddVip().ShowDialog() == DialogResult.OK)
                GetAllVipServices();
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ModifyVip();
        }

        private void ModifyVip()
        {
            if (dgVIP.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_VIP"));
                return;
            }
            else
            {
                int rowIndex = dgVIP.SelectedCells[0].RowIndex;
                AddVip fmodify = new AddVip(vips[rowIndex]);
                if (fmodify.ShowDialog() == DialogResult.OK)
                    GetAllVipServices();
            }
        }
    }
}
