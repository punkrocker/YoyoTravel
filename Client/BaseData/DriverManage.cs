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
    public partial class DriverManage : Form
    {
        List<DriverDto> drivers = new List<DriverDto>();
        public DriverManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            GetAllDrivers();
        }

        private void GetAllDrivers()
        {
            drivers = WebCall.GetMethod<List<DriverDto>>(WebCall.GetDrivers, null);
            dgDrivers.DataSource = drivers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddDriver().ShowDialog() == DialogResult.OK)
                GetAllDrivers();
        }

        private void dgDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            modifyDriver();
        }

        private void modifyDriver()
        {
            if (dgDrivers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_DRIVER"));
                return;
            }
            else
            {
                int rowIndex = dgDrivers.SelectedCells[0].RowIndex;
                DriverDto driver  = drivers[rowIndex];
                AddDriver modifyTravelProject = new AddDriver(driver);
                if (modifyTravelProject.ShowDialog() == DialogResult.OK)
                    GetAllDrivers();
            }
        }
    }
}
