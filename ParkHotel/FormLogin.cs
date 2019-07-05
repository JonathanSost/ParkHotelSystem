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
        #region Inicialização do Form
        FuncionarioBLL bll = new FuncionarioBLL();
        Funcionario fun = new Funcionario();
        DialogResult result = new DialogResult();

        //select * from sys.objects where type_desc = 'UNIQUE_CONSTRAINT'
        //ALTER TABLE FORNECEDORES DROP CONSTRAINT UQ__FORNECED__AA57D6B42ECEC601
        //CONSTRAINT UNIQUE_FUN_EMAIL UNIQUE (EMAIL)
        //alter table vendas add constraint FK_VENDA_PRODUTO foreign key (produto) references produtos

        DateTime HorarioAtual = DateTime.Now;

        //if ((HorarioAtual.Hour == 6) && (HorarioAtual.Minute == 30))
        //{
        //    // Chame aqui o seu método
        //}

        public FormLogin()
        {
            InitializeComponent();

            FormCheckOutAutomatico formchk = new FormCheckOutAutomatico();
            formchk.Show();
            formchk.Hide();
            txtUsuario.Text = "altairobama@outlook.com";
            txtSenha.Text = "altair123";

            //txtUsuario.Text = "vinikk03@gmail.com";
            //txtSenha.Text = "vini1234";

            if (!bll.VerificarExistenciaFuncionarioA())
            {
                lnkCadastrarAdmin.Visible = true;
            }
        }
        #endregion

        #region Buttons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                result = MessageBox.Show("Usuário e senha devem ser informados!", "Erro!", MessageBoxButtons.OK);
                return;
            }
            
            fun = bll.Logar(txtUsuario.Text, txtSenha.Text);

            if (fun != null && fun.Ativo)
            {
                Parametros.FuncionarioLogado = fun;
                this.Hide();
                new FormMenu(Parametros.FuncionarioLogado).Show();
                return;
            }
            else if (!fun.Ativo)
            {
                result = MessageBox.Show("Você não possui acesso ao servidor.", "Erro!", MessageBoxButtons.OK);
                return;
            }
            result = MessageBox.Show("Usuário ou senha incorretos!", "Erro!", MessageBoxButtons.OK);
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

        private void lnkCadastrarAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFuncionarios().Show();
        }
    }
}
