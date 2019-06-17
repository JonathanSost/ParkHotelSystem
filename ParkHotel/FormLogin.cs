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
        public FormLogin()
        {
            InitializeComponent();
        }

        FuncionariosBLL bll = new FuncionariosBLL();
        public string Nome { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Usuário e senha devem ser informados!");
                return;
            }
            Funcionarios fun = new Funcionarios(txtUsuario.Text, txtSenha.Text);
            if (!bll.FuncionarioExiste(fun))
            {
                MessageBox.Show("Usuário ou senha incorretos!");
                return;
            }


            this.Hide();
            new FormMenu().Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
    }
}
