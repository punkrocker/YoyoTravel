using Client.Utils;
using Common;
using Model;
using Model.CallResult;
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
    public partial class AddHotelPictures : Form
    {
        public string Pics = "";
        private List<string> picNames = new List<string>();
        private const int picSize = 75;
        private const int rowCount = 8;
        private const int maxPic = 23;
        public AddHotelPictures(string pics)
        {
            InitializeComponent();
            Pics = pics;
            if (!Pics.Equals(string.Empty))
            {
                picNames = AppUtils.JsonDeserialize<List<string>>(Pics);
                //for (int i = 1; i <= picNames.Count; i++)
                for (int i = picNames.Count; i > 0; i--)
                {
                    string file = picNames[i - 1];
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    Stream picSteam = WebCall.GetPic(file);
                    pic.Image = Image.FromStream(picSteam);
                    picSteam.Close();
                    pic.Size = new Size(picSize, picSize);
                    pic.Left = 5 + i % rowCount * picSize + i % rowCount * 5;
                    pic.Top = 5 + i / rowCount * picSize + i / rowCount * 5;
                    this.Controls.Add(pic);
                }
            }
            btnAdd.Image = Properties.Resources.pic_add;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Count() + picNames.Count > maxPic)
                {
                    ClientUtils.WarningCode("TOO_MANY_PICTURES");
                    return;
                }
                foreach (string file in openFileDialog.FileNames)
                {
                    var result = AppUtils.JsonDeserialize<WebResult>(WebCall.UploadFile(file));
                    if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                    {
                        picNames.Add(result.Message);
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(file);
                        pic.Size = new Size(picSize, picSize);
                        pic.Left = 5 + picNames.Count % rowCount * picSize + picNames.Count % rowCount * 5;
                        pic.Top = 5 + picNames.Count / rowCount * picSize + picNames.Count / rowCount * 5;
                        this.Controls.Add(pic);
                    }
                    else
                    {
                        ClientUtils.WarningCode(result.Message);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Pics = AppUtils.JsonSerializer(this.picNames);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
