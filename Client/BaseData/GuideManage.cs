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
    public partial class GuideManage : Form
    {
        private List<GuideDto> guides = new List<GuideDto>();
        public GuideManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            GetAllGuides();
        }

        private void GetAllGuides()
        {
            guides = WebCall.GetMethod<List<GuideDto>>(WebCall.GetGuides, null);
            dgGuides.DataSource = guides;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddGuide().ShowDialog() == DialogResult.OK)
                GetAllGuides();
        }

        private void dgGuides_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            modifyGuide();
        }

        private void modifyGuide()
        {
            if (dgGuides.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_GUIDE"));
                return;
            }
            else
            {
                int rowIndex = dgGuides.SelectedCells[0].RowIndex;
                GuideDto travelProject = guides[rowIndex];
                AddGuide modifyTravelProject = new AddGuide(travelProject);
                if (modifyTravelProject.ShowDialog() == DialogResult.OK)
                    GetAllGuides();
            }
        }
    }
}
