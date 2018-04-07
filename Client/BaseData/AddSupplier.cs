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
using Travel.Client.Lang;
using Travel.Client.Utils;

namespace Client.BaseData
{
    public partial class AddSupplier : Form
    {
        private Supplier supplier = null;
        private bool isModify = false;
        BindingList<TravelProjectDto> travelProjects = new BindingList<TravelProjectDto>();
        BindingList<HotelDto> hotels = new BindingList<HotelDto>();

        public AddSupplier()
        {
            InitializeComponent();
            dgHotel.AutoGenerateColumns = false;
            dgTravelService.AutoGenerateColumns = false;
            dgTravelService.DataSource = travelProjects;
            dgHotel.DataSource = hotels;
        }

        public AddSupplier(Supplier _supplier)
        {
            InitializeComponent();
            supplier = _supplier;
            initInfos();
            isModify = true;
            dgHotel.AutoGenerateColumns = false;
            dgTravelService.AutoGenerateColumns = false;
        }

        private void initInfos()
        {
            txtSupplierName.Text = supplier.SupplierName;
            txtContact.Text = supplier.Contact;
            refreshData();
        }

        private void refreshData()
        {
            List<KeyValuePair<string, string>> paramlist = new List<KeyValuePair<string, string>>();
            paramlist.Add(new KeyValuePair<string, string>("supplierid", supplier.SupplierID.ToString()));
            var supplierResult = WebCall.GetMethod<SupplierResult>(WebCall.GetSupplierDetail, paramlist);
            if (supplierResult.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                travelProjects.Clear();
                foreach (TravelProjectDto tra in supplierResult.Data.travelProjects)
                    travelProjects.Add(tra);
                dgTravelService.DataSource = null;
                dgTravelService.DataSource = travelProjects;
                hotels.Clear();
                foreach (HotelDto hotel in supplierResult.Data.hotels)
                    hotels.Add(hotel);
                dgHotel.DataSource = null;
                dgHotel.DataSource = hotels;
            }
            else
            {
                ClientUtils.WarningCode(supplierResult.Message);
            }
            GetAllVipServices();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtSupplierName, "EMPTY_SUPPLIER_NAME") ||
                !ClientUtils.CheckEmpty(txtContact, "EMPTY_SUPPLIER_CONTACT"))
                return;

            if (!isModify)
            {
                SupplierPara supplierPara = new SupplierPara();
                supplierPara.supplier = new Supplier
                {
                    SupplierName = txtSupplierName.Text,
                    Contact = txtContact.Text
                };
                supplierPara.travelProjects = travelProjects.ToList();
                supplierPara.hotels = hotels.ToList();
                string str_result = WebCall.PostMethod<SupplierPara>(WebCall.AddSupplier, supplierPara);
                WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    ClientUtils.WarningCode("ADD_SUCCESS");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ClientUtils.WarningCode(result.Message);
                }
            }
            else
            {
                Supplier selectSupplier = new Supplier
                {
                    SupplierID = supplier.SupplierID,
                    SupplierName = txtSupplierName.Text,
                    Contact = txtContact.Text
                };
                string str_result = WebCall.PostMethod<Supplier>(WebCall.ModifySupplier, selectSupplier);
                WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    ClientUtils.WarningCode("MODIFY_SUCCESS");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ClientUtils.WarningCode(result.Message);
                }
            }
        }

        #region 旅游项目
        private void dgTravelService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            modifyTravelService();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddTravelProject addTravel = new AddTravelProject();
            if (addTravel.ShowDialog() == DialogResult.OK)
            {
                if (isModify)
                {
                    addTravel.travelProject.SupplierID = supplier.SupplierID;
                    string str_result = WebCall.PostMethod<TravelProjectDto>(WebCall.AddTravelService, addTravel.travelProject);
                    WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                    if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                    {
                        refreshData();
                    }
                    else
                    {
                        ClientUtils.WarningCode(result.Message);
                    }
                }
                else
                {
                    travelProjects.Add(addTravel.travelProject);
                    dgTravelService.DataSource = null;
                    dgTravelService.DataSource = travelProjects;
                }
            }
        }

        private void modifyTravelService()
        {
            if (dgTravelService.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_TRAVEL_SERVICE"));
                return;
            }
            else
            {
                int rowIndex = dgTravelService.SelectedCells[0].RowIndex;
                TravelProjectDto travelProject = travelProjects[rowIndex];
                AddTravelProject modifyTravelProject = new AddTravelProject(travelProject);
                if (isModify)
                {
                    if (modifyTravelProject.ShowDialog() == DialogResult.OK)
                    {
                        modifyTravelProject.travelProject.ProjectID = travelProject.ProjectID;
                        string str_result = WebCall.PostMethod<TravelProjectDto>(WebCall.ModifyTravelService, modifyTravelProject.travelProject);
                        WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                        if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                        {
                            travelProject.ProjectName = modifyTravelProject.travelProject.ProjectName;
                            travelProject.AdultFee = modifyTravelProject.travelProject.AdultFee;
                            travelProject.ChildFee = modifyTravelProject.travelProject.ChildFee;
                            travelProject.AgentAdultFee = modifyTravelProject.travelProject.AgentAdultFee;
                            travelProject.AgentChildFee = modifyTravelProject.travelProject.AgentChildFee;
                            travelProject.Description = modifyTravelProject.travelProject.Description;
                            travelProject.ProjectTypeID = modifyTravelProject.travelProject.ProjectTypeID;
                            travelProject.Remark = modifyTravelProject.travelProject.Remark;
                            travelProject.CoverPic = modifyTravelProject.travelProject.CoverPic;
                            dgTravelService.DataSource = null;
                            dgTravelService.DataSource = travelProjects;
                        }
                        else
                        {
                            ClientUtils.WarningCode(result.Message);
                        }
                    }
                }
                else
                {
                    if (modifyTravelProject.ShowDialog() == DialogResult.OK)
                    {
                        travelProjects.RemoveAt(rowIndex);
                        travelProjects.Add(modifyTravelProject.travelProject);
                        dgTravelService.DataSource = null;
                        dgTravelService.DataSource = travelProjects;
                    }
                }
            }
        }
        #endregion

        #region 酒店信息
        private void dgHotel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            modifyHotel();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            AddHotel addHotel = new AddHotel();
            if (addHotel.ShowDialog() == DialogResult.OK)
            {
                if (isModify)
                {
                    addHotel.hotel.SupplierID = supplier.SupplierID;
                    string str_result = WebCall.PostMethod<HotelDto>(WebCall.AddHotel, addHotel.hotel);
                    WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                    if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                    {
                        hotels.Add(addHotel.hotel);
                        dgHotel.DataSource = null;
                        dgHotel.DataSource = hotels;
                    }
                    else
                    {
                        ClientUtils.WarningCode(result.Message);
                    }
                }
                else
                {
                    hotels.Add(addHotel.hotel);
                    dgHotel.DataSource = null;
                    dgHotel.DataSource = hotels;
                }
            }
        }

        private void modifyHotel()
        {
            if (dgHotel.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_HOTEL"));
                return;
            }
            else
            {
                int rowIndex = dgHotel.SelectedCells[0].RowIndex;
                HotelDto hotel = hotels[rowIndex];
                AddHotel modifyHotel = new AddHotel(hotel);
                if (isModify)
                {
                    if (modifyHotel.ShowDialog() == DialogResult.OK)
                    {
                        modifyHotel.hotel.HouseID = hotel.HouseID;
                        string str_result = WebCall.PostMethod<HotelDto>(WebCall.ModifyHotel, modifyHotel.hotel);
                        WebResult result = AppUtils.JsonDeserialize<WebResult>(str_result);
                        if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                        {
                            hotel.HouseName = modifyHotel.hotel.HouseName;
                            hotel.Fee = modifyHotel.hotel.Fee;
                            hotel.AgentFee = modifyHotel.hotel.AgentFee;
                            hotel.CoverPic = modifyHotel.hotel.CoverPic;
                            hotel.Pics = modifyHotel.hotel.Pics;
                            hotel.Description = modifyHotel.hotel.Description;
                            hotel.Remark = modifyHotel.hotel.Remark;
                            dgHotel.DataSource = null;
                            dgHotel.DataSource = hotels;
                        }
                        else
                        {
                            ClientUtils.WarningCode(result.Message);
                        }
                    }
                }
                else
                {
                    if (modifyHotel.ShowDialog() == DialogResult.OK)
                    {
                        hotels.RemoveAt(rowIndex);
                        hotels.Add(modifyHotel.hotel);
                        dgHotel.DataSource = null;
                        dgHotel.DataSource = hotels;
                    }
                }
            }
        }
        #endregion

        #region VIP服务
        List<VIPDto> vips = new List<VIPDto>();
        private void btnAddVIP_Click(object sender, EventArgs e)
        {
            if (new AddVip().ShowDialog() == DialogResult.OK)
                GetAllVipServices();
        }

        private void GetAllVipServices()
        {
            vips = WebCall.GetMethod<List<VIPDto>>(WebCall.GetVips, null);
            dgVIP.DataSource = vips;
        }

        private void dgVIP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        #endregion


    }
}
