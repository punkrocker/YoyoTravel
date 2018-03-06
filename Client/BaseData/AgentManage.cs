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
    public partial class AgentManage : Form
    {
        public AgentManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            GetAllAgents();
        }

        private void GetAllAgents()
        {
            var agents = WebCall.GetMethod<List<AgentDto>>(WebCall.GetAgents, null);
            dgAgents.DataSource = agents;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddAgent().ShowDialog() == DialogResult.OK)
                GetAllAgents();
        }

        private void dgAgents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ModifyAgent();
        }

        private void ModifyAgent()
        {
            if (dgAgents.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgAgents.SelectedCells[0].RowIndex;
                AgentDto user = new AgentDto
                {
                    AgentID = Convert.ToInt16(dgAgents.Rows[rowIndex].Cells["colID"].Value),
                    AgentName = dgAgents.Rows[rowIndex].Cells["colName"].Value.ToString(),
                    LoginName = dgAgents.Rows[rowIndex].Cells["colLoginName"].Value.ToString(),
                    Tel = dgAgents.Rows[rowIndex].Cells["colTel"].Value.ToString(),
                    Remark = dgAgents.Rows[rowIndex].Cells["colRemark"].Value.ToString(),
                    ParentName = dgAgents.Rows[rowIndex].Cells["colParentName"].Value.ToString(),
                    isEnable = Convert.ToBoolean(dgAgents.Rows[rowIndex].Cells["colStatusName"].Value)
                };

                AddAgent fmodify = new AddAgent(user);
                if (fmodify.ShowDialog() == DialogResult.OK)
                    GetAllAgents();
            }
        }
    }
}
