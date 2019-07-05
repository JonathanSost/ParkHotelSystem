using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkHotel
{
    public partial class FormCheckOutAutomatico : Form
    {
        public FormCheckOutAutomatico()
        {
            InitializeComponent();
        }

        ReservaBLL bll = new ReservaBLL();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 12 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
            {
                //bll.RealizarCheckoutAutomatico();
                MessageBox.Show("aaaaaaaaaaaaaa");
            }
            else if (DateTime.Now.Hour == 14 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
            {
                //bll.RealizarCheckoutAutomatico();
            }
        }

        private void FormCheckOutAutomatico_Load(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Start();
        }
    }
}
