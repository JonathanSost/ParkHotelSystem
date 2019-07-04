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
    public partial class FormCriarTipo : Form
    {
        public FormCriarTipo(FormQuartos formquartos)
        {
            InitializeComponent();
            formQuartos = formquartos;
        }

        private FormQuartos formQuartos { get; set; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
