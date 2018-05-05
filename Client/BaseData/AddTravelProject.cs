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
using System.Web;
using System.Windows.Forms;
using Travel.Client.Utils;

namespace Client.BaseData
{
    public partial class AddTravelProject : Form
    {
        public TravelProjectDto travelProject;
        List<T_TravelProjectTypes> projectTypes;
        private string pic = "";

        public AddTravelProject()
        {
            InitializeComponent();
            GetProjectTypes();
        }

        public AddTravelProject(TravelProjectDto modifyTravelProject)
        {
            InitializeComponent();
            GetProjectTypes();
            travelProject = new TravelProjectDto
            {
                SupplierID = modifyTravelProject.SupplierID,
                ProjectID = modifyTravelProject.ProjectID
            };
            txtProjectName.Text = modifyTravelProject.ProjectName;
            txtAdultFee.Text = modifyTravelProject.AdultFee.ToString();
            txtChildFee.Text = modifyTravelProject.ChildFee.ToString();
            txtAgentAdult.Text = modifyTravelProject.AgentAdultFee.ToString();
            txtAgentChild.Text = modifyTravelProject.AgentChildFee.ToString();
            txtRemark.Text = modifyTravelProject.Remark;
            txtDesc.Text = modifyTravelProject.Description;
            cbxType.Text = modifyTravelProject.ProjectTypeName;
            if (modifyTravelProject.CoverPic!=null && !modifyTravelProject.CoverPic.ToString().Equals(string.Empty))
            {
                Stream picStream = WebCall.GetPic(modifyTravelProject.CoverPic);
                if (picStream != null)
                {
                    btnPic.BackgroundImage = Image.FromStream(picStream);
                    picStream.Close();
                }
                pic = modifyTravelProject.CoverPic;
            }
        }

        private void GetProjectTypes()
        {
            projectTypes = WebCall.GetMethod<List<T_TravelProjectTypes>>(WebCall.GetTravelProjectTypes, null);
            foreach (T_TravelProjectTypes projectType in projectTypes)
                cbxType.Items.Add(projectType.ProjectTypeName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClientUtils.CheckEmpty(txtProjectName, "EMPTY_PROJECT_NAME") || 
                !ClientUtils.CheckEmpty(txtAdultFee, "EMPTY_ADULT_FEE") || 
                !ClientUtils.CheckEmpty(txtChildFee, "EMPTY_CHILD_FEE") ||
                !ClientUtils.CheckEmpty(txtAgentAdult, "EMPTY_AGENT_ADULT_FEE") ||
                !ClientUtils.CheckEmpty(txtAgentChild, "EMPTY_AGENT_CHILD_FEE") ||
                !ClientUtils.CheckEmpty(cbxType, "EMPTY_PROJECT_TYPE"))
                return;
            travelProject = new TravelProjectDto
            {
                ProjectName = txtProjectName.Text,
                AdultFee = Convert.ToSingle(txtAdultFee.Text),
                ChildFee = Convert.ToSingle(txtChildFee.Text),
                AgentAdultFee = Convert.ToSingle(txtAgentAdult.Text),
                AgentChildFee = Convert.ToSingle(txtAgentChild.Text),
                Description = txtDesc.Text,
                Remark = txtRemark.Text,
                ProjectTypeID = projectTypes[cbxType.SelectedIndex].ProjectTypeID,
                ProjectTypeName = projectTypes[cbxType.SelectedIndex].ProjectTypeName,
                CoverPic = pic
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkNumber(object sender, KeyPressEventArgs e)
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
    }
}
