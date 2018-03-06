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
    public partial class AddDriver : Form
    {
        private bool isModify = false;
        private DriverDto selectedDriver;

        public AddDriver()
        {
            InitializeComponent();
        }

        public AddDriver(DriverDto driver)
        {
            InitializeComponent();
            txtName.Text = driver.DriverName;
            txtTel.Text = driver.Tel;
            txtContact.Text = driver.Contact;
            txtBigCar.Text = driver.BigCarFee.ToString();
            txtSmallCar.Text = driver.SmallCarFee.ToString();
            txtAgentBigCar.Text = driver.AgentBigCarFee.ToString();
            txtAgentBigCarPick.Text = driver.AgentBigCarPickAirportFee.ToString();
            txtAgentBigCarSend.Text = driver.AgentBigCarSendAirportFee.ToString();
            txtBigCarPick.Text = driver.BigCarPickAirportFee.ToString();
            txtBigCarSend.Text = driver.BigCarSendAirportFee.ToString();
            txtAgentSmallCar.Text = driver.AgentSmallCarFee.ToString();
            txtAgentSmallCarPick.Text = driver.AgentSmallCarPickAirportFee.ToString();
            txtAgentSmallCarSend.Text = driver.AgentSmallCarSendAirportFee.ToString();
            txtSmallCarPick.Text = driver.SmallCarPickAirportFee.ToString();
            txtSmallCarSend.Text = driver.SmallCarSendAirportFee.ToString();
            txtRemark.Text = driver.Remark;
            selectedDriver = driver;
            isModify = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtName, "EMPTY_DRIVER_NAME") ||
                  !ClientUtils.CheckEmpty(txtBigCar, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentBigCar, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtSmallCar, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentSmallCar, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtBigCarPick, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentBigCarPick, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtSmallCarPick, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentSmallCarPick, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtBigCarSend, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentBigCarSend, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtSmallCarSend, "EMPTY_FEE") ||
                  !ClientUtils.CheckEmpty(txtAgentSmallCarSend, "EMPTY_FEE"))
                return;
            int driverID = isModify ? selectedDriver.DriverID : 0;
            DriverDto param = new DriverDto
            {
                DriverID = driverID,
                DriverName = txtName.Text,
                Tel = txtTel.Text,
                Contact = txtContact.Text,
                BigCarFee = Convert.ToSingle(txtBigCar.Text),
                SmallCarFee = Convert.ToSingle(txtSmallCar.Text),
                AgentBigCarFee = Convert.ToSingle(txtAgentBigCar.Text),
                AgentBigCarPickAirportFee = Convert.ToSingle(txtAgentBigCarPick.Text),
                AgentBigCarSendAirportFee = Convert.ToSingle(txtAgentBigCarSend.Text),
                BigCarPickAirportFee = Convert.ToSingle(txtBigCarPick.Text),
                BigCarSendAirportFee = Convert.ToSingle(txtBigCarSend.Text),
                AgentSmallCarFee = Convert.ToSingle(txtAgentSmallCar.Text),
                AgentSmallCarPickAirportFee = Convert.ToSingle(txtAgentSmallCarPick.Text),
                AgentSmallCarSendAirportFee = Convert.ToSingle(txtAgentSmallCarSend.Text),
                SmallCarPickAirportFee = Convert.ToSingle(txtSmallCarPick.Text),
                SmallCarSendAirportFee = Convert.ToSingle(txtSmallCarSend.Text),
                Remark = txtRemark.Text
            };
            string strResult = WebCall.PostMethod<DriverDto>(isModify ? WebCall.ModifyDrivers: WebCall.AddDrivers, param);
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
