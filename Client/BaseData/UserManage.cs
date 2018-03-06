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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            GetAllUsers();
        }

        private void GetAllUsers()
        {
            var users = WebCall.GetMethod<List<UserDto>>(WebCall.GetUsers, null);
            dgUsers.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddUser().ShowDialog() == DialogResult.OK)
                GetAllUsers();
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ModifyUser();
        }

        private void ModifyUser()
        {
            if (dgUsers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgUsers.SelectedCells[0].RowIndex;
                UserDto user = new UserDto 
                {
                    UserID = Convert.ToInt16(dgUsers.Rows[rowIndex].Cells["colID"].Value),
                    UserName = dgUsers.Rows[rowIndex].Cells["colName"].Value.ToString(),
                    LoginName = dgUsers.Rows[rowIndex].Cells["colLoginName"].Value.ToString(),
                    RoleName = dgUsers.Rows[rowIndex].Cells["colRoleName"].Value.ToString(),
                    isEnable = Convert.ToBoolean(dgUsers.Rows[rowIndex].Cells["colStatusName"].Value)
                };

                AddUser fmodify = new AddUser(user);
                if (fmodify.ShowDialog() == DialogResult.OK)
                    GetAllUsers();
            }
        }
    }
}
