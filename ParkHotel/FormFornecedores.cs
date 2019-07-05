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
    public partial class FormFornecedores : Form
    {
        #region Inicialização do Form
        FornecedorBLL forbll = new FornecedorBLL();
        Fornecedor f = null;

        public FormFornecedores()
        {
            InitializeComponent();
            dgvFornecedores.DataSource = forbll.LerTodos();
        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(Registro.NOVO_REGISTRO, txtNomeEmpresa.Text,
                msktxtCNPJ.Text, txtNome.Text, msktxtTelefone.Text, txtEmail.Text);

            MessageResponse response = forbll.Cadastrar(fornecedor);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                dgvFornecedores.DataSource = forbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            f = new Fornecedor(int.Parse(txtID.Text), txtNomeEmpresa.Text, msktxtCNPJ.Text, txtNome.Text, msktxtTelefone.Text, txtEmail.Text);

            MessageResponse response = new MessageResponse();
            response = forbll.Atualizar(f);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvFornecedores.DataSource = forbll.LerTodos();
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do fornecedor deve ser informado.");
                return;
            }
            f.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageResponse response = new MessageResponse();
            response = forbll.Excluir(f);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                forbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void FormFornecedores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
                menu.Show();
            }
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = forbll.LerTodos();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvFornecedores.Rows[e.RowIndex].Cells[0].Value;
            string nomeEmpresa = (string)dgvFornecedores.Rows[e.RowIndex].Cells[1].Value;
            string cnpj = (string)dgvFornecedores.Rows[e.RowIndex].Cells[2].Value;
            string nome = (string)dgvFornecedores.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dgvFornecedores.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dgvFornecedores.Rows[e.RowIndex].Cells[5].Value;

            txtID.Text = id.ToString();
            txtNomeEmpresa.Text = nomeEmpresa;
            msktxtCNPJ.Text = cnpj;
            txtNome.Text = nome;
            msktxtTelefone.Text = telefone;
            txtEmail.Text = email;
        }
        #endregion

        #region Componente Changed
        private void txtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            txtNomeEmpresa.MaxLength = 60;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 70;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 70;
        }

        private void msktxtCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCNPJ.Text.Length == 14)
            {
                txtNome.Focus();
            }
        }

        private void msktxtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (msktxtTelefone.Text.Length == 11)
            {
                txtEmail.Focus();
            }
        }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorNomeEmpresa_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = forbll.PesquisarPorNomeEmpresa(txtNomeEmpresa.Text);
        }

        private void PesquisarPorCNPJ_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = forbll.PesquisarPorCNPJ(msktxtCNPJ.Text);
        }

        private void btnPesquisarPorNomeContato_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = forbll.PesquisarPorNome(txtNome.Text);
        }
        #endregion

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvFornecedores.Rows[e.RowIndex].Cells[0].Value;
            string nomeempresa = (string)dgvFornecedores.Rows[e.RowIndex].Cells[1].Value;
            string cnpj = (string)dgvFornecedores.Rows[e.RowIndex].Cells[2].Value;
            string nome = (string)dgvFornecedores.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dgvFornecedores.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dgvFornecedores.Rows[e.RowIndex].Cells[5].Value;

            f = new Fornecedor(nomeempresa, cnpj, nome, telefone, email);

            txtID.Text = id.ToString();
            txtNomeEmpresa.Text = nome;
            msktxtCNPJ.Text = cnpj;
            txtNome.Text = nome;
            msktxtTelefone.Text = telefone;
            txtEmail.Text = email;

        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
