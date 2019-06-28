using Metadata;
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
    public partial class FormInfoFuncionario : Form
    {
        public FormInfoFuncionario(Funcionario Funci)
        {
            InitializeComponent();
        }

        private void FormInfoFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormMenu(Parametros.FuncionarioLogado).Show();
            }
        }
    }
}
