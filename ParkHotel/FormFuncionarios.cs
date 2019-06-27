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
        bool Admin;

        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            Admin = false;

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);

            dgvFuncionarios.DataSource = funbll.LerFuncionarios();
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

        #region Buttons
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(funbll.Atualizar(f));
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
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
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            f = new Funcionario(Registro.NOVO_REGISTRO, txtNome.Text, msktxtCPF.Text, msktxtRG.Text, msktxtTelefone.Text, txtEmail.Text, txtSenha.Text,
                Admin, (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, msktxtCEP.Text, txtBairro.Text, txtRua.Text, txtNumero.Text,
                txtComplemento.Text);

            MessageResponse response = funbll.Cadastrar(f);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                FormCleaner.Clear(this);
                dgvFuncionarios.DataSource = funbll.LerFuncionarios();
            }
        }

        private void FormFuncionarios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
                menu.Show();
            }
        }

        private void chkAdministrador_KeyUp(object sender, KeyEventArgs e)
        {
            if (!chkAdministrador.Checked && e.KeyCode == Keys.Enter)
            {
                chkAdministrador.Checked = true;
            }
            else if (chkAdministrador.Checked && e.KeyCode == Keys.Enter)
            {
                chkAdministrador.Checked = false;
            }
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionarios();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
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

        private void msktxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCPF.Text.Length == 14)
            {
                msktxtRG.Focus();
            }
        }

        private void msktxtRG_TextChanged(object sender, EventArgs e)
        {
            if (msktxtRG.Text.Length == 9)
            {
                msktxtTelefone.Focus();
            }
        }

        private void msktxtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (msktxtTelefone.Text.Length == 14)
            {
                txtEmail.Focus();
            }
        }

        private void msktxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCEP.Text.Length == 9)
            {
                txtBairro.Focus();
            }
        }

        private void chkAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdministrador.Checked)
            {
                Admin = true;
            }
            else
            {
                Admin = false;
            }
        }
        #endregion

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFuncionarios.Columns[e.ColumnIndex].Name == "Senha" && e.Value != null)
            {
                dgvFuncionarios.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvFuncionarios.CurrentRow.Tag != null)
            {
                e.Control.Text = dgvFuncionarios.CurrentRow.Tag.ToString();
            }
        }

        #region Pesquisar
        private void btnPesquisarPorNome_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorNome(txtNome.Text);
        }

        private void btnPesquisarPorCPF_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorCPF(msktxtCPF.Text);
        }

        private void btnPesquisarPorRG_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorRG(msktxtRG.Text);
        }

        private void btnPesquisarPorEstado_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorEstado((int)cmbEstado.SelectedValue);
        }

        private void btnPesquisarPorCidade_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorCidade((int)cmbCidade.SelectedValue);
        }

        private void btnPesquisarPorCEP_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorCEP(msktxtCEP.Text);
        }

        private void btnPesquisarPorBairro_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorBairro(txtBairro.Text);
        }

        private void btnPesquisarPorRua_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorRua(txtRua.Text);
        }

        private void btnPesquisarAdmin_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarAdmin(Admin);
        }

        #endregion
    }
}
