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
    public partial class FormFuncionarios : Form
    {
        #region Inicialização do Form
        CidadeBLL cidbll = new CidadeBLL();
        EstadoBLL estbll = new EstadoBLL();
        FuncionarioBLL funbll = new FuncionarioBLL();
        Funcionario f = null;

        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);

            dataGridView1.DataSource = funbll.LerTodos();
        }
        #endregion

        private void FormFuncionarios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
        }

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool Admin;
            if (chkAdministrador.Checked)
            {
                Admin = true;
            }
            else
            {
                Admin = false;
            }
            MessageBox.Show(funbll.Cadastrar(new Funcionario(Registro.NOVO_REGISTRO, txtNome.Text, msktxtCPF.Text, 
                msktxtRG.Text, msktxtTelefone.Text, txtEmail.Text, txtSenha.Text, Admin)));
            FormCleaner.Clear(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(funbll.Atualizar(f));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                return;
            }

            funbll.Excluir(f);
            MessageBox.Show("Excluido com sucesso!");
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }
        #endregion

        #region Componente Changed
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
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

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 5;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.MaxLength = 70;
        }
        #endregion
    }
}
