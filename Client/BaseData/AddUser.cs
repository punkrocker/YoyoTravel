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
    public partial class AddUser : Form
    {
        List<T_Roles> roles;
        bool isModify = false;
        UserDto user;

        public AddUser()
        {
            InitializeComponent();
            GetRoles();
        }

        public AddUser(UserDto selectUser)
        {
            InitializeComponent();
            GetRoles();
            isModify = true;
            chkEnable.Visible = true;
            user = selectUser;
            txtName.Text = user.UserName;
            txtName.Enabled = false;
            txtLoginName.Text = user.LoginName;
            txtLoginName.Enabled = false;
            cbxRole.Text = user.RoleName;
            chkEnable.Checked = user.isEnable;
        }

        private void GetRoles()
        {
            RolesResult result = WebCall.GetMethod<RolesResult>(WebCall.GetRoles, null);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                roles = result.Data;
                foreach (T_Roles role in roles)
                    cbxRole.Items.Add(role.RoleName);
            }
            else
            {
                ClientUtils.WarningCode(result.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtName, "EMPTY_NAME") || 
                !ClientUtils.CheckEmpty(txtLoginName, "EMPTY_LOGIN_NAME") ||
                !ClientUtils.CheckEmpty(cbxRole, "EMPTY_ROLE"))
                return;
            int id = isModify ? user.UserID : 0;
            UserDto param = new UserDto
            {
                UserID = id,
                UserName = txtName.Text,
                LoginName = txtLoginName.Text,
                RoleID = roles[cbxRole.SelectedIndex].RoleID,
                isEnable = chkEnable.Checked
            };

            string strResult = WebCall.PostMethod<UserDto>(isModify?WebCall.ModifyUser:WebCall.AddUser, param);
            WebResult result = AppUtils.JsonDeserialize<WebResult>(strResult);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                ClientUtils.WarningCode(Travel.Client.Lang.LangBase.GetString(isModify? "MODIFY_SUCCESS" : "ADD_USER_SUCCESS") + result.Message);
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
