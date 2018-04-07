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
    public partial class AddVip : Form
    {
        private bool isModify = false;
        private VIPDto vip = null;
        private int supplierID = 0;

        public AddVip()
        {
            InitializeComponent();
        }

        public AddVip(int _supplierID)
        {
            InitializeComponent();
            supplierID = _supplierID;
        }

        public AddVip(VIPDto selectedVip)
        {
            InitializeComponent();
            isModify = true;
            vip = selectedVip;
            txtName.Text = vip.ServerName;
            txtTel.Text = vip.Tel;
            txtContact.Text = vip.Contact;
            txtRemark.Text = vip.Remark;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtName, "EMPTY_VIP_NAME"))
                return;
            int id = isModify ? vip.ServerID: 0;
            VIPDto param = new VIPDto 
            {
                ServerID = id,
                SupplierID = supplierID,
                ServerName = txtName.Text,
                Contact = txtContact.Text,
                Tel = txtTel.Text,
                Remark = txtRemark.Text,
            };
            string strResult = WebCall.PostMethod<VIPDto>(isModify ? WebCall.ModifyVips : WebCall.AddVips, param);
            WebResult result = AppUtils.JsonDeserialize<WebResult>(strResult);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                ClientUtils.WarningCode(Travel.Client.Lang.LangBase.GetString(isModify ? "MODIFY_VIP_SUCCESS" : "ADD_VIP_SUCCESS") + result.Message);
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
