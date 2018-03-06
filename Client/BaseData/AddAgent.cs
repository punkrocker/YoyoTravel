using Client.Utils;
using Common;
using Model;
using Model.CallResult;
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
using Travel.Client.Utils;

namespace Client.BaseData
{
    public partial class AddAgent : Form
    {
        List<UserDto> busniessUsers;
        bool isModify = false;
        AgentDto agent;

        public AddAgent()
        {
            InitializeComponent();
            GetBusiness();
        }

        public AddAgent(AgentDto selectedAgent)
        {
            InitializeComponent();
            GetBusiness();

            agent = selectedAgent;
            isModify = true;

            txtAgentName.Text = selectedAgent.AgentName;
            txtLoginName.Text = selectedAgent.LoginName;
            txtTel.Text = selectedAgent.Tel;
            cbxBusiness.Text = selectedAgent.ParentName;
            txtRemark.Text = selectedAgent.Remark;
            chkEnable.Checked = selectedAgent.isEnable;

            txtAgentName.Enabled = false;
            txtLoginName.Enabled = false;
            chkEnable.Visible = true;
        }

        private void GetBusiness()
        {
            var users = WebCall.GetMethod<List<UserDto>>(WebCall.GetUsers, null);
            busniessUsers = users;
            foreach (UserDto user in busniessUsers)
                cbxBusiness.Items.Add(user.UserName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtAgentName, "EMPTY_NAME") ||
                !ClientUtils.CheckEmpty(txtLoginName, "EMPTY_LOGIN_NAME") ||
                !ClientUtils.CheckEmpty(cbxBusiness, "EMPTY_BUSINESS"))
                return;
            int id = isModify ? agent.AgentID: 0;
            AgentDto param = new AgentDto
            {
                AgentID = id,
                AgentName = txtAgentName.Text,
                LoginName = txtLoginName.Text,
                Tel = txtTel.Text,
                Remark = txtRemark.Text,
                ParentID = busniessUsers[cbxBusiness.SelectedIndex].UserID,
                isEnable = chkEnable.Checked
            };
            string strResult = WebCall.PostMethod<AgentDto>(isModify ? WebCall.ModifyAgent: WebCall.AddAgent, param);
            WebResult result = AppUtils.JsonDeserialize<WebResult>(strResult);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                ClientUtils.WarningCode(Travel.Client.Lang.LangBase.GetString(isModify ? "MODIFY_USER_SUCCESS" : "ADD_USER_SUCCESS") + result.Message);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ClientUtils.WarningCode(result.Message);
            }
        }
    }
}
