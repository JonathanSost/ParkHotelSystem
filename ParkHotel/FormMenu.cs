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
            lnkFuncionarioLogado.Text = Funci.LerPrimeiroNome();
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm");
            if (Funci.EhADM)
            {
                this.Size = new Size(452, 504);
                lnkFuncionarios.Visible = true;
                lbl5.Visible = true;
                lblHora.Location = new Point(5, 469);
                btnLogoff.Location = new Point(301, 442);
            }
            else
            {
                this.Size = new Size(452, 456);
                lnkFuncionarios.Visible = false;
                lbl5.Visible = false;
                lblHora.Location = new Point(5, 416);
                btnLogoff.Location = new Point(301, 389);
            }
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

        private void lnkProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormProdutos().Show();
        }

        private void lnkClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormClientes().Show();
        }

        private void lnkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormFornecedores().Show();
        }

        private void lnkQuartos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormQuartos().Show();
        }

        private void lnkReservas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormReservas().Show();
        }

        private void lnkVendas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormVendas().Show();
        }

        private void lnkFuncionarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormFuncionarios().Show();
        }

        private void lnkFuncionarioLogado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormInfoFuncionario(Parametros.FuncionarioLogado).Show();
        }

        private void lnkHistórico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormHistórico().Show();
        }
        #endregion

        #region Relógio
        private void Relogio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm");
        }
        #endregion

        #region KeyDown
        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormLogin().Show();
                return;
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
                i = lnkReservas;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                IButtonControl i = null;
                i = lnkVendas;
                i.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                IButtonControl i = null;
                i = lnkFuncionarios;
                i.PerformClick();
            }
        }
        #endregion
    }
}
