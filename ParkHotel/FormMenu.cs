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
        #region Inicialização do Form
        public FormMenu(Funcionario Funci)
        {
            InitializeComponent();
            lblNomeFuncionario.Text = "Bem-Vindo,";
            lnkFuncionarioLogado.Text = Parametros.FuncionarioLogado.Nome;
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm");
        }
        #endregion

        #region Buttons
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

        private void FormMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormLogin().Show();
            }
            else if (e.KeyCode == Keys.F1)
            {
                IButtonControl i = null;
                i = lnkProdutos;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                IButtonControl i = null;
                i = lnkClientes;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                IButtonControl i = null;
                i = lnkFornecedores;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                IButtonControl i = null;
                i = lnkQuartos;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                IButtonControl i = null;
                i = lnkFuncionarios;
                i.PerformClick();
            }
        }

        private void lnkProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormProdutos().Show();
        }

        private void lnkClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormClientes().Show();
        }

        private void lnkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormFornecedores().Show();
        }

        private void lnkQuartos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormQuartos().Show();
        }

        private void lnkFuncionarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormFuncionarios().Show();
        }
        #endregion

        #region Relógio
        private void Relogio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm");
        }
        #endregion
    }
}
