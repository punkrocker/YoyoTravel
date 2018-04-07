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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel.Client.Lang;
using Travel.Client.Utils;

namespace Client
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false;
        public FrmMain frmParent = null;

        public FrmLogin(FrmMain parent)
        {
            InitializeComponent();
            //WebCall.LoadUrl();
            frmParent = parent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPara para = new LoginPara()
            {
                Username = txtUser.Text,
                Password = AppUtils.SHA1Hash(txtPwd.Text)
            };
            string str_result = WebCall.PostMethod<LoginPara>(WebCall.Login, para);
            LoginResult result = AppUtils.JsonDeserialize<LoginResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                Configure.UserID = result.Data.UserID;
                Configure.UserName = result.Data.UserName;
                Configure.Functions = result.Data.Functions;
                isLogined = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(LangBase.GetString(result.Message));
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isLogined)
                Application.Exit();
            else if (Configure.UserID != -1)
            {
                //if (Configure.Functions.Count == 0)
                //{
                //    MessageBox.Show(LangBase.GetString("NO_ANY_AUTH"));
                //    this.isLogined = false;
                //    Application.Exit();
                //}
                //else
                //{
                    frmParent.checkFunctions();
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var result = AppUtils.JsonDeserialize<WebResult>(WebCall.UploadFile(openFileDialog.FileName));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {

                }
                else
                {
                    ClientUtils.WarningCode(result.Message);
                }
            }
        }
    }
}
