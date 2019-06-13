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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        FormGerProdutos produtos = new FormGerProdutos();
        FormGerClientes clientes = new FormGerClientes();
        FormGerFornecedores fornecedores = new FormGerFornecedores();
        FormGerQuartos quartos = new FormGerQuartos();
        FormRegClientes regClientes = new FormRegClientes();
        FormRegFornecedores regFornecedores = new FormRegFornecedores();
        FormRegProdutos regProdutos = new FormRegProdutos();
        FormRegQuartos regQuartos = new FormRegQuartos();
        FormLogin login = new FormLogin();

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            produtos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            fornecedores.Show();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            this.Hide();
            quartos.Show();
        }

        private void btnRegProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            regProdutos.Show();
        }

        private void btnRegClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            regClientes.Show();
        }

        private void btnRegFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            regFornecedores.Show();
        }

        private void btnRegQuartos_Click(object sender, EventArgs e)
        {
            this.Hide();
            regQuartos.Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
