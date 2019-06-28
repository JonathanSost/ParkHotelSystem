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
    public partial class FormInfoFuncionario : Form
    {
        CidadeBLL cidbll = new CidadeBLL();
        EstadoBLL estbll = new EstadoBLL();
        FuncionarioBLL funbll = new FuncionarioBLL();
        public FormInfoFuncionario(Funcionario Funci)
        {
            InitializeComponent();

            #region Visible / Text
            lblNome.Text = Parametros.FuncionarioLogado.Nome;
            lblCPF.Text = "CPF: " + Parametros.FuncionarioLogado.CPF;
            lblRG.Text = "RG: " + Parametros.FuncionarioLogado.RG;
            lblCEP.Text = "CEP: " + Parametros.FuncionarioLogado.CEP;
            lblTelefone.Text = "Telefone: " + Parametros.FuncionarioLogado.Telefone;

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DataSource = cidbll.LerTodos();
            cmbEstado.SelectedValue = Parametros.FuncionarioLogado.Estado;
            cmbCidade.SelectedValue = Parametros.FuncionarioLogado.Cidade;

            lblNumero.Text = "Número: " + Parametros.FuncionarioLogado.Numero;
            lblRua.Text = "Rua: " + Parametros.FuncionarioLogado.Rua;
            lblBairro.Text = "Bairro: " + Parametros.FuncionarioLogado.Bairro;
            lblEmail.Text = "E-mail: " + Parametros.FuncionarioLogado.Email;
            lblSenha.Text = "Senha: " + Parametros.FuncionarioLogado.Senha;
            #endregion
        }

        #region Buttons
        private void FormInfoFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormMenu(Parametros.FuncionarioLogado).Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormMenu(Parametros.FuncionarioLogado).Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region Visible / Text
            lblCPF.Visible = false;
            lblRG.Visible = false;
            lblCEP.Visible = false;
            lblTelefone.Visible = false;
            lblNumero.Visible = false;
            cmbCidade.Enabled = true;
            cmbEstado.Enabled = true;
            lblRua.Visible = false;
            lblBairro.Visible = false;
            lblEmail.Visible = false;
            lblSenha.Visible = false;
            btnEditar.Visible = false;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            lblNome.Visible = false;

            txtNome.Visible = true;
            msktxtCPF.Visible = true;
            msktxtRG.Visible = true;
            msktxtCEP.Visible = true;
            msktxtTelefone.Visible = true;
            txtNumero.Visible = true;
            txtRua.Visible = true;
            txtBairro.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;

            txtNome.Text = lblNome.Text;
            msktxtCPF.Text = Parametros.FuncionarioLogado.CPF;
            msktxtRG.Text = Parametros.FuncionarioLogado.RG;
            msktxtCEP.Text = Parametros.FuncionarioLogado.CEP;
            msktxtTelefone.Text = Parametros.FuncionarioLogado.Telefone;
            txtNumero.Text = Parametros.FuncionarioLogado.Numero;
            txtRua.Text = Parametros.FuncionarioLogado.Rua;
            txtBairro.Text = Parametros.FuncionarioLogado.Bairro;
            txtEmail.Text = Parametros.FuncionarioLogado.Email;
            txtSenha.Text = Parametros.FuncionarioLogado.Senha;

            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
            cmbCidade.SelectedValue = Parametros.FuncionarioLogado.Cidade;
            #endregion
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario(Parametros.FuncionarioLogado.ID, txtNome.Text, msktxtCPF.Text, msktxtRG.Text, 
                msktxtTelefone.Text, txtEmail.Text, txtSenha.Text, Parametros.FuncionarioLogado.EhADM, 
                (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, msktxtCEP.Text, txtBairro.Text, txtRua.Text, 
                txtNumero.Text, Parametros.FuncionarioLogado.Complemento);
            funbll.Atualizar(fun);
            Parametros.FuncionarioLogado = fun;

            #region Visible / Text
            lblCPF.Visible = true;
            lblRG.Visible = true;
            lblCEP.Visible = true;
            lblTelefone.Visible = true;
            lblNumero.Visible = true;
            cmbCidade.Enabled = false;
            cmbEstado.Enabled = false;
            lblRua.Visible = true;
            lblBairro.Visible = true;
            lblEmail.Visible = true;
            lblSenha.Visible = true;
            btnEditar.Visible = true;
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblNome.Visible = true;

            txtNome.Visible = false;
            msktxtCPF.Visible = false;
            msktxtRG.Visible = false;
            msktxtCEP.Visible = false;
            msktxtTelefone.Visible = false;
            txtNumero.Visible = false;
            txtRua.Visible = false;
            txtBairro.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;

            lblNome.Text = fun.Nome;
            lblCPF.Text = "CPF: " + fun.CPF;
            lblRG.Text = "RG: " + fun.RG;
            lblCEP.Text = "CEP: " + fun.CEP;
            lblTelefone.Text = "Telefone: " + fun.Telefone;

            cmbEstado.DataSource = estbll.LerTodos();
            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerTodos();
            cmbEstado.SelectedValue = fun.Estado;
            cmbCidade.SelectedValue = fun.Cidade;

            lblNumero.Text = "Número: " + fun.Numero;
            lblRua.Text = "Rua: " + fun.Rua;
            lblBairro.Text = "Bairro: " + fun.Bairro;
            lblEmail.Text = "E-mail: " + fun.Email;
            lblSenha.Text = "Senha: " + fun.Senha;
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCPF.Visible = true;
            lblRG.Visible = true;
            lblCEP.Visible = true;
            lblTelefone.Visible = true;
            lblNumero.Visible = true;
            cmbCidade.Enabled = false;
            cmbEstado.Enabled = false;
            lblRua.Visible = true;
            lblBairro.Visible = true;
            lblEmail.Visible = true;
            lblSenha.Visible = true;
            btnEditar.Visible = true;
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblNome.Visible = true;

            txtNome.Visible = false;
            msktxtCPF.Visible = false;
            msktxtRG.Visible = false;
            msktxtCEP.Visible = false;
            msktxtTelefone.Visible = false;
            txtNumero.Visible = false;
            txtRua.Visible = false;
            txtBairro.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DataSource = cidbll.LerTodos();
            cmbEstado.SelectedValue = Parametros.FuncionarioLogado.Estado;
            cmbCidade.SelectedValue = Parametros.FuncionarioLogado.Cidade;
        }
        #endregion

        #region Componente Changed
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
            txtRua.Clear();
            txtBairro.Clear();
        }
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 5;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 70;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 40;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.MaxLength = 25;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.MaxLength = 50;
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            txtRua.MaxLength = 70;
        }
        #endregion

        
    }
}
