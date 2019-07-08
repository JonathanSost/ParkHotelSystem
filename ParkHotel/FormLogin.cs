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
        ReservaBLL rbll = new ReservaBLL();
        FuncionarioBLL bll = new FuncionarioBLL();
        Funcionario fun = new Funcionario();
        DialogResult result = new DialogResult();

        //select * from sys.objects where type_desc = 'UNIQUE_CONSTRAINT'
        //ALTER TABLE FORNECEDORES DROP CONSTRAINT UQ__FORNECED__AA57D6B42ECEC601
        //CONSTRAINT UNIQUE_FUN_EMAIL UNIQUE (EMAIL)
        //alter table vendas add constraint FK_VENDA_PRODUTO foreign key (produto) references produtos

        public FormLogin()
        {
            InitializeComponent();

            txtUsuario.Text = "altairobama@outlook.com";
            txtSenha.Text = "altair123";

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
            else if (fun != null && !fun.Ativo)
            {
                result = MessageBox.Show("Você não possui acesso ao servidor.", "Erro!", MessageBoxButtons.OK);
                return;
            }
            result = MessageBox.Show("Usuário ou senha incorretos!", "Erro!", MessageBoxButtons.OK);
        }

        private void lnkCadastrarAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFuncionarios().Show();
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

        #region KeyDown
        private void chkVerSenha_KeyDown(object sender, KeyEventArgs e)
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

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();
            }
        }
        #endregion

        #region Timer
        private void tmCheckOut_Tick(object sender, EventArgs e)
        {
            FormCheckOut frm = new FormCheckOut();
            if (DateTime.Now.Minute == 00 && DateTime.Now.Second == 00 && rbll.ChecarReservasExpiradas(DateTime.Now))
            {
                frm.Hide();
                frm.Show();
            }
            else if (DateTime.Now.Minute == 30 && DateTime.Now.Second == 00 && rbll.ChecarReservasExpiradas(DateTime.Now))
            {
                frm.Hide();
                frm.Show();
            }
        }
        #endregion
    }
}
