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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        FuncionarioBLL bll = new FuncionarioBLL();

        #region Buttons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            //{
            //    MessageBox.Show("Usuário e senha devem ser informados!");
            //    return;
            //}
            //Funcionario fun = bll.FuncionarioExiste(txtUsuario.Text, txtSenha.Text);
            //if (fun != null)
            //{
            //    Parametros.FuncionarioLogado = fun;
            //    this.Hide();
            //    new FormMenu().Show();
            //    return;
            //}
            //MessageBox.Show("Usuário ou senha incorretos!");

            this.Hide();
            new FormMenu().Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Componente_Changed
        private void cbVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
                return;
            }
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 40;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.MaxLength = 20;
        }
        #endregion

        #region KeyUp
        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();
            }
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
