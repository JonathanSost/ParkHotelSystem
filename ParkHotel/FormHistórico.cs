using BLL;
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
    public partial class FormHistórico : Form
    {
        #region Inicialização do Form
        public FormHistórico()
        {
            InitializeComponent();
            dgvEntradaProdutos.DataSource = pbll.LerProdutosEntrada();
            dgvProdutos.DataSource = pbll.LerProdutos();
            dgvSaidaProdutos.DataSource = vbll.LerVendas();
        }

        ProdutoBLL pbll = new ProdutoBLL();
        VendaBLL vbll = new VendaBLL();
        #endregion

        #region Buttons
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormMenu(Parametros.FuncionarioLogado).Show();
        }
        #endregion

        #region KeyDown
        private void FormHistórico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnVoltar.PerformClick();
            }
        }
        #endregion
    }
}
