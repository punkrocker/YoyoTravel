using Common;
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
    public partial class ServiceSupplierManage : Form
    {
        public ServiceSupplierManage()
        {
            InitializeComponent();
            Client.Utils.ClientUtils.ResolveForm(this);
            this.GetAllSuppliers();
        }

        private void GetAllSuppliers()
        {
            var suppliers = WebCall.GetMethod<List<Supplier>>(WebCall.GetAllSupplier, null);
            dgSuppliers.DataSource = suppliers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            if (addSupplier.ShowDialog() == DialogResult.OK)
                GetAllSuppliers();
        }

        private void dgSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ModifySupplier();
        }

        private void ModifySupplier()
        {
            if (dgSuppliers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_SUPPLIER"));
                return;
            }
            else
            {
                int rowIndex = dgSuppliers.SelectedCells[0].RowIndex;
                Supplier supplier = new Supplier
                {
                    SupplierID = Convert.ToInt16(dgSuppliers.Rows[rowIndex].Cells["colID"].Value),
                    SupplierName = dgSuppliers.Rows[rowIndex].Cells["colName"].Value.ToString(),
                    Contact = Convert.ToString(dgSuppliers.Rows[rowIndex].Cells["colContact"].Value)
                };
                
                AddSupplier fmodify = new AddSupplier(supplier);
                fmodify.ShowDialog();
                GetAllSuppliers();
            }
        }
    }
}
