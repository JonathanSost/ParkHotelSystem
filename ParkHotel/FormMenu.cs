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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            lblNomeFuncionario.Text = "Bem-Vindo, ";// + Funcionarios.Nome;
            lblHora.Text = DateTime.Now.ToString("dddd, dd MMM yyyy, HH:mm");
        }

        //FormGerProdutos produtos = new FormGerProdutos();
        //FormGerClientes clientes = new FormGerClientes();
        //FormGerFornecedores fornecedores = new FormGerFornecedores();
        //FormGerQuartos quartos = new FormGerQuartos();
        //FormRegClientes regClientes = new FormRegClientes();
        //FormRegFornecedores regFornecedores = new FormRegFornecedores();
        //FormRegProdutos regProdutos = new FormRegProdutos();
        //FormRegQuartos regQuartos = new FormRegQuartos();
        //FormLogin login = new FormLogin();

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormProdutos().Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormClientes().Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFornecedores().Show();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormQuartos().Show();
        }

        private void btnGerFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFuncionarios().Show();
        }

        private void btnRegProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormProdutos().Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, dd MMM yyyy, HH:mm");
        }

        private void FormMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormLogin().Show();
            }
        }
    }
}
