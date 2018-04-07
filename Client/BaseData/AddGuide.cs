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
    public partial class AddGuide : Form
    {
        private bool isModify = false;
        private GuideDto selectedGuide = null;
        private int? supplierID = 0;

        public AddGuide()
        {
            InitializeComponent();
        }

        public AddGuide(int? _supplierID)
        {
            InitializeComponent();
            supplierID = _supplierID;
        }

        public AddGuide(GuideDto guide)
        {
            InitializeComponent();
            selectedGuide = guide;
            txtGuideName.Text = guide.GuideName;
            txtGuideName.Enabled = false;
            txtTel.Text = guide.Tel;
            txtContact.Text = guide.Contact;
            txtLandFee.Text = guide.LandFee.ToString();
            txtSeaFee.Text = guide.SeaFee.ToString();
            txtAgentLandFee.Text = guide.AgentLandFee.ToString();
            txtAgentSeaFee.Text = guide.AgentSeaFee.ToString();
            txtRemark.Text = guide.Remark;
            supplierID = guide.SupplierID;
            isModify = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtGuideName, "EMPTY_GUIDE_NAME") ||
                  !ClientUtils.CheckEmpty(txtLandFee, "EMPTY_LAND_FEE") ||
                  !ClientUtils.CheckEmpty(txtSeaFee, "EMPTY_SEA_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentLandFee, "EMPTY_AGENT_LAND_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentSeaFee, "EMPTY_AGENT_SEA_FEE"))
                return;
            int guideID = selectedGuide == null ? 0 : selectedGuide.GuideID;
            GuideDto param = new GuideDto
            {
                GuideID = guideID,
                GuideName = txtGuideName.Text,
                Tel = txtTel.Text,
                Contact = txtContact.Text,
                LandFee = Convert.ToSingle(txtLandFee.Text),
                AgentLandFee = Convert.ToSingle(txtAgentLandFee.Text),
                SeaFee = Convert.ToSingle(txtSeaFee.Text),
                AgentSeaFee = Convert.ToSingle(txtAgentSeaFee.Text),
                Remark = txtRemark.Text,
                SupplierID = supplierID
            };
            string strResult = WebCall.PostMethod<GuideDto>(isModify ? WebCall.ModifyGuides: WebCall.AddGuides, param);
            WebResult result = AppUtils.JsonDeserialize<WebResult>(strResult);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                ClientUtils.WarningCode(Travel.Client.Lang.LangBase.GetString(isModify ? "MODIFY_SUCCESS" : "ADD_SUCCESS") + result.Message);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ClientUtils.WarningCode(result.Message);
            }
        }

        private void checkNumber(object sender, KeyPressEventArgs e)
        {
            ClientUtils.CheckIntegerInput(sender, e);
        }
    }
}
