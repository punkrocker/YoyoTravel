using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Utils
{
    public class ClientUtils
    {
        public static void ResolveForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
        }

        internal static bool CheckEmpty(TextBox tx, String errorMsgCode)
        {
            if (tx.Text.Trim().Equals(String.Empty))
            {
                Warning(Travel.Client.Lang.LangBase.GetString(errorMsgCode));
                tx.Focus();
                return false;
            }
            return true;
        }

        internal static bool CheckEmpty(ComboBox cb, String errorMsgCode)
        {
            if (cb.Text.Trim().Equals(String.Empty) || cb.SelectedIndex == -1)
            {
                Warning(Travel.Client.Lang.LangBase.GetString(errorMsgCode));
                return false;
            }
            return true;
        }

        public static void Warning(String msg)
        {
            MessageBox.Show(msg);
        }

        public static void WarningCode(String code)
        {
            String msg = Travel.Client.Lang.LangBase.GetString(code);
            if (msg.Equals(string.Empty))
                Warning(code);
            else
                Warning(msg);
        }

        public static void CheckIntegerInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                    e.Handled = true;
            }
        }
    }
}
