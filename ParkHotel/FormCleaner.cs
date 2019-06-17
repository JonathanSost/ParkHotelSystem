using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkHotel
{
    class FormCleaner
    {
        public static void Clear(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.HasChildren)
                {
                    Clear(item);
                }
                if (item is TextBoxBase)
                {
                    TextBoxBase Item = (TextBoxBase)item;
                    Item.Clear();
                }
            }
        }
    }
}
