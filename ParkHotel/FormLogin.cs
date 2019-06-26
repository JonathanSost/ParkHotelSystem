﻿using BLL;
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
        #region Inicialização do Form
        FuncionarioBLL bll = new FuncionarioBLL();

        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            //{
            //    MessageBox.Show("Usuário e senha devem ser informados!");
            //    return;
            //}
            //Funcionario fun = bll.FuncionarioExiste(txtUsuario.Text, txtSenha.Text);
            Funcionario fun = new Funcionario();
            if (fun != null)
            {
                Parametros.FuncionarioLogado = fun;
                this.Hide();
                new FormMenu(Parametros.FuncionarioLogado).Show();
                return;
            }
            MessageBox.Show("Usuário ou senha incorretos!");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Componente Changed
        private void cbVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerSenha.Checked)
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

        private void cbVerSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (!chkVerSenha.Checked && e.KeyCode == Keys.Enter)
            {
                chkVerSenha.Checked = true;
            }
            else if (chkVerSenha.Checked && e.KeyCode == Keys.Enter)
            {
                chkVerSenha.Checked = false;
            }
        }
        #endregion
    }
}
