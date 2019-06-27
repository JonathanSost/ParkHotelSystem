using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkHotel
{
    static class FormHelper
    {
        public static void FocusTextBoxesOnForm(Form f)
        {
            foreach (var item in f.Controls)
            {
                if(item is TextBoxBase)
                {
                    ((TextBoxBase)item).MouseUp += FormHelper_MouseUp;
                }
            }
        }

        private static void FormHelper_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }
    }
}
