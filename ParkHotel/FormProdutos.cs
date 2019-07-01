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
    public partial class FormProdutos : Form
    {
        #region Inicialização do Form
        ProdutoBLL pbll = new ProdutoBLL();
        Produto p = null;

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            p = new Produto(txtNome.Text, txtDescricao.Text, int.Parse(txtEstoque.Text), double.Parse(txtPreco.Text), int.Parse(txtIDFornecedor.Text));

            MessageResponse response = pbll.Cadastrar(p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvProdutos.DataSource = pbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            p = new Produto(txtNome.Text, txtDescricao.Text, int.Parse(txtEstoque.Text), double.Parse(txtPreco.Text), int.Parse(txtIDFornecedor.Text));

            MessageResponse response = pbll.Cadastrar(p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvProdutos.DataSource = pbll.LerTodos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do Produto deve ser informado.");
                return;
            }
            p.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageResponse response = new MessageResponse();
            response = pbll.Excluir(p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                pbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnPesquisarFornecedores_Click(object sender, EventArgs e)
        {
            FormPesquisarFornecedores frm = new FormPesquisarFornecedores(this);
            frm.ShowDialog();
            if (frm.FornecedorSelecionado != null)
            {
                txtIDFornecedor.Text = frm.FornecedorSelecionado.ID.ToString();
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void FormProdutos_KeyUp(object sender, KeyEventArgs e)
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
            dgvProdutos.DataSource = pbll.LerTodos();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }
        #endregion

        #region Componente Changed
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 70;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.MaxLength = 80;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            txtPreco.MaxLength = 10;
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
            txtEstoque.MaxLength = 4;
        }
        #endregion

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }
    }
}
