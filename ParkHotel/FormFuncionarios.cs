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
        MessageResponse response = new MessageResponse();

        public FormFuncionarios()
        {
            InitializeComponent();

            if (!funbll.VerificarExistenciaFuncionarioA())
            {
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
                chkAdministrador.Checked = true;
                chkAdministrador.Enabled = false;
                btnVoltar.Visible = false;
                chkAtivo.Checked = true;
                chkAtivo.Enabled = false;
                label5.Visible = false;
                lnkOrderByID.Visible = false;
                lnkOrderByIDDesc.Visible = false;
                lnkOrderByName.Visible = false;
                lnkOrderByNameDesc.Visible = false;
            }
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);

            if (!funbll.VerificarExistenciaFuncionarioA())
            {
                return;
            }

            if (Parametros.FuncionarioLogado == null)
            {
                return;
            }
            dgvFuncionarios.DataSource = funbll.LerFuncionarios(Parametros.FuncionarioLogado);
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

        #region Buttons
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            f = new Funcionario(int.Parse(txtID.Text), txtNome.Text, msktxtCPF.Text, msktxtRG.Text, msktxtTelefone.Text, txtEmail.Text, txtSenha.Text,
                chkAdministrador.Checked, (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, msktxtCEP.Text, txtBairro.Text, txtRua.Text, txtNumero.Text,
                txtComplemento.Text, chkAtivo.Checked);
            MessageResponse response = funbll.Atualizar(f);
            MessageBox.Show(response.Message);
            dgvFuncionarios.DataSource = funbll.LerFuncionarios(Parametros.FuncionarioLogado);
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do funcionário deve ser informado.");
                return;
            }
            f.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageResponse response = new MessageResponse();
            response = funbll.Excluir(f);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvFuncionarios.DataSource = funbll.LerFuncionarios(Parametros.FuncionarioLogado);
                FormCleaner.Clear(this);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            f = new Funcionario(txtNome.Text, msktxtCPF.Text, msktxtRG.Text, msktxtTelefone.Text, txtEmail.Text, txtSenha.Text,
                chkAdministrador.Checked, (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, msktxtCEP.Text, txtBairro.Text, txtRua.Text, txtNumero.Text,
                txtComplemento.Text, chkAtivo.Checked);

            if (!funbll.VerificarExistenciaFuncionarioA())
            {
                response = funbll.Cadastrar(f);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    Parametros.FuncionarioLogado = f;
                    this.Close();
                    new FormMenu(Parametros.FuncionarioLogado).Show();
                    return;
                }
            }

            response = funbll.Cadastrar(f);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                FormCleaner.Clear(this);
                chkAdministrador.Enabled = true;
                chkAtivo.Enabled = true;
                dgvFuncionarios.DataSource = funbll.LerFuncionarios(Parametros.FuncionarioLogado);
            }
        }

        private void FormFuncionarios_KeyUp(object sender, KeyEventArgs e)
        {
            if (!funbll.VerificarExistenciaFuncionarioA())
            {
                return;
            }
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

        private void chkAtivo_KeyUp(object sender, KeyEventArgs e)
        {
            if (!chkAtivo.Checked && e.KeyCode == Keys.Enter)
            {
                chkAtivo.Checked = true;
            }
            else if (chkAtivo.Checked && e.KeyCode == Keys.Enter)
            {
                chkAtivo.Checked = false;
            }
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionarios(Parametros.FuncionarioLogado);
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionariosByID(Parametros.FuncionarioLogado);
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionariosByIDDesc(Parametros.FuncionarioLogado);
        }

        private void lnkOrderByName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionariosByName(Parametros.FuncionarioLogado);
        }

        private void lnkOrderByNameDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.LerFuncionariosByNameDesc(Parametros.FuncionarioLogado);
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[5].Value;
            string senha = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[6].Value;
            bool ehadm = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[7].Value;
            bool ativo = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[8].Value;
            int estado = estbll.LerPorCliente((string)dgvFuncionarios.Rows[e.RowIndex].Cells[9].Value);
            int cidade = cidbll.LerPorCliente((string)dgvFuncionarios.Rows[e.RowIndex].Cells[10].Value);
            string rua = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[11].Value;
            string bairro = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[12].Value;
            string numero = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[13].Value;
            string cep = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[14].Value;
            string complemento = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[15].Value;

            cmbEstado.SelectedValue = estado;
            cmbCidade.SelectedValue = cidade;

            f = new Funcionario(nome, cpf, rg, telefone, email, senha, ehadm,
                (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, cep, bairro, rua, numero, complemento, true);

            txtID.Text = id.ToString();
            txtNome.Text = nome;
            msktxtCPF.Text = cpf;
            msktxtRG.Text = rg;
            msktxtTelefone.Text = telefone;
            txtEmail.Text = email;
            txtSenha.Text = senha;
            chkAdministrador.Checked = ehadm;
            chkAtivo.Checked = ativo;
            msktxtCEP.Text = cep;
            cmbEstado.Text = estado.ToString();
            cmbCidade.Text = cidade.ToString();
            txtRua.Text = rua;
            txtBairro.Text = bairro;
            txtNumero.Text = numero;
            txtComplemento.Text = complemento;
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
            if (msktxtCPF.Text.Length == 11)
            {
                msktxtRG.Focus();
            }
        }

        private void msktxtRG_TextChanged(object sender, EventArgs e)
        {
            if (msktxtRG.Text.Length == 7)
            {
                msktxtTelefone.Focus();
            }
        }

        private void msktxtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (msktxtTelefone.Text.Length == 11)
            {
                txtEmail.Focus();
            }
        }

        private void msktxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCEP.Text.Length == 8)
            {
                txtBairro.Focus();
            }
        }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorNome_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarPorNome(txtNome.Text, Parametros.FuncionarioLogado);
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
            dgvFuncionarios.DataSource = funbll.PesquisarAdmin(chkAdministrador.Checked);
        }

        private void btnPesquisarPorAtivos_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funbll.PesquisarAtivos(chkAtivo.Checked);
        }
        #endregion
    }
}
