using Client.BaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            new FrmLogin(this).ShowDialog();
            initWindows();
        }

        private void initWindows()
        {
            BaseDataMain b = new BaseDataMain();
            tbBase.Controls.Add(b);
            b.Show();
        }

        public void checkFunctions()
        {
        }
    }
}
