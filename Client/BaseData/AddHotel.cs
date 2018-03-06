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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel.Client.Utils;

namespace Client.BaseData
{
    public partial class AddHotel : Form
    {
        public HotelDto hotel;
        private string pic = "";
        private string otherPics = "";
        public AddHotel()
        {
            InitializeComponent();
        }

        public AddHotel(HotelDto hotelDto)
        {
            InitializeComponent();
            hotel = hotelDto;
            txtHotelName.Text = hotel.HouseName;
            txtFee.Text = hotel.Fee.ToString();
            txtAgentFee.Text = hotel.AgentFee.ToString();
            txtRemark.Text = hotel.Remark;
            txtDesc.Text = hotel.Description;
            pic = AppUtils.ToString(hotel.CoverPic);
            if (!pic.Equals(string.Empty))
            {
                Stream picSteam = WebCall.GetPic(pic);
                btnPic.BackgroundImage = Image.FromStream(picSteam);
                picSteam.Close();
            }
            otherPics = hotel.Pics.ToString();
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientUtils.CheckIntegerInput(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtHotelName, "EMPTY_HOTEL_NAME") || !ClientUtils.CheckEmpty(txtFee, "EMPTY_FEE"))
                return;
            hotel = new HotelDto 
            {
                HouseName = txtHotelName.Text,
                Fee = Convert.ToSingle(txtFee.Text),
                AgentFee = Convert.ToSingle(txtAgentFee.Text),
                CoverPic = pic,
                Description = txtDesc.Text,
                Remark = txtRemark.Text,
                Pics = otherPics,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtAgentFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientUtils.CheckIntegerInput(sender, e);
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var result = AppUtils.JsonDeserialize<WebResult>(WebCall.UploadFile(openFileDialog.FileName));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    pic = result.Message;
                    btnPic.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    ClientUtils.WarningCode(result.Message);
                }
            }
        }

        private void btnOtherPic_Click(object sender, EventArgs e)
        {
            AddHotelPictures addHotelPictures = new AddHotelPictures(otherPics);
            if (addHotelPictures.ShowDialog() == DialogResult.OK)
                otherPics = addHotelPictures.Pics;
        }
    }
}
