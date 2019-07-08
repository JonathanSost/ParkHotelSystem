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
        MessageResponse response = new MessageResponse();
        int estoque;

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutos();
        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDFornecedor.Text))
            {
                MessageBox.Show("ID do Fornecedor deve ser informado.");
                return;
            }

            p = new Produto(txtNome.Text, txtDescricao.Text, int.Parse(txtEstoque.Text), double.Parse(txtPreco.Text), int.Parse(txtIDFornecedor.Text), "Entrada", DateTime.Now);


            MessageResponse response = pbll.Cadastrar(p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvProdutos.DataSource = pbll.LerProdutos();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            p = new Produto(int.Parse(txtID.Text), txtNome.Text, txtDescricao.Text, int.Parse(txtEstoque.Text), double.Parse(txtPreco.Text), int.Parse(txtIDFornecedor.Text), "Entrada", dateTimePicker1.Value);

            MessageResponse response = pbll.Atualizar(p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvProdutos.DataSource = pbll.LerProdutos();
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
                dgvProdutos.DataSource = pbll.LerProdutos();
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
            dgvProdutos.DataSource = pbll.LerProdutos();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByID();
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByIDDesc();
        }

        private void lnkOrderByName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByName();
        }

        private void lnkOrderByNameDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByNameDesc();
        }

        private void lnkOrderByPreco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByPreco();
        }

        private void lnkOrderByPrecoDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByPrecoDesc();
        }

        private void lnkOrderByEstoque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByEstoque();
        }

        private void lnkOrderByEstoqueDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutos.DataSource = pbll.LerProdutosByEstoqueDesc();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvProdutos.Rows[e.RowIndex].Cells[0].Value;
            string nomeproduto = (string)dgvProdutos.Rows[e.RowIndex].Cells[1].Value;
            string descricao = (string)dgvProdutos.Rows[e.RowIndex].Cells[2].Value;
            int estoque = (int)dgvProdutos.Rows[e.RowIndex].Cells[3].Value;
            double preco = (double)dgvProdutos.Rows[e.RowIndex].Cells[4].Value;
            int idfornecedor = (int)dgvProdutos.Rows[e.RowIndex].Cells[5].Value;
            string nomefornecedor = (string)dgvProdutos.Rows[e.RowIndex].Cells[6].Value;
            string status = (string)dgvProdutos.Rows[e.RowIndex].Cells[7].Value;
            DateTime datadetransferencia = (DateTime)(dgvProdutos.Rows[e.RowIndex].Cells[8].Value);

            p = new Produto(nomeproduto, descricao, estoque, preco, idfornecedor, status, datadetransferencia);

            txtID.Text = id.ToString();
            txtNome.Text = nomeproduto;
            txtDescricao.Text = descricao;
            txtPreco.Text = preco.ToString();
            txtEstoque.Text = estoque.ToString();
            txtIDFornecedor.Text = idfornecedor.ToString();
            dateTimePicker1.Value = datadetransferencia;
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Favor informar o ID do Produto.");
                return;
            }
            txtDescricao.Enabled = false;
            txtNome.Enabled = false;
            txtPreco.Enabled = false;
            btnPesquisarFornecedores.Visible = false;
            btnPesquisarPorDescricao.Visible = false;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnPesquisarPorEstoquesIguais.Visible = false;
            btnPesquisarPorEstoquesMaiores.Visible = false;
            btnPesquisarPorEstoquesMenores.Visible = false;
            btnPesquisarPorNomeProduto.Visible = false;
            btnPesquisarPorPreçosIguais.Visible = false;
            btnPesquisarPorPreçosMaiores.Visible = false;
            btnPesquisarPorPreçosMenores.Visible = false;
            btnAdicionarEstoque.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEstoque.Text) <= 0)
            {
                MessageBox.Show("A quantia a adicionar deve ser maior do que 0.");
                return;
            }
            txtDescricao.Enabled = true;
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            btnPesquisarFornecedores.Visible = true;
            btnPesquisarPorDescricao.Visible = true;
            btnCadastrar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
            btnPesquisarPorEstoquesIguais.Visible = true;
            btnPesquisarPorEstoquesMaiores.Visible = true;
            btnPesquisarPorEstoquesMenores.Visible = true;
            btnPesquisarPorNomeProduto.Visible = true;
            btnPesquisarPorPreçosIguais.Visible = true;
            btnPesquisarPorPreçosMaiores.Visible = true;
            btnPesquisarPorPreçosMenores.Visible = true;
            btnAdicionarEstoque.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;

            estoque = pbll.TrazerEstoqueProduto(int.Parse(txtID.Text));
            estoque += int.Parse(txtEstoque.Text);
            response = pbll.AtualizarEstoqueProduto(int.Parse(txtID.Text), estoque);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                p.Estoque = int.Parse(txtEstoque.Text);
                pbll.InserirHistorico(p);
                dgvProdutos.DataSource = pbll.LerProdutosEntrada();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            btnPesquisarFornecedores.Visible = true;
            btnPesquisarPorDescricao.Visible = true;
            btnCadastrar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
            btnPesquisarPorEstoquesIguais.Visible = true;
            btnPesquisarPorEstoquesMaiores.Visible = true;
            btnPesquisarPorEstoquesMenores.Visible = true;
            btnPesquisarPorNomeProduto.Visible = true;
            btnPesquisarPorPreçosIguais.Visible = true;
            btnPesquisarPorPreçosMaiores.Visible = true;
            btnPesquisarPorPreçosMenores.Visible = true;
            btnAdicionarEstoque.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
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

        #region Pesquisar
        private void btnPesquisarPorPreçosMenores_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorPrecosMenores(int.Parse(txtPreco.Text));
            }
        }

        private void btnPesquisarPorPreçosIguais_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorPrecosIguais(int.Parse(txtPreco.Text));
            }
        }

        private void btnPesquisarPorPreçosMaiores_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorPrecosMaiores(int.Parse(txtPreco.Text));
            }
        }

        private void btnPesquisarPorEstoquesMenores_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorEstoquesMenores(int.Parse(txtEstoque.Text));
            }
        }

        private void btnPesquisarPorEstoquesIguais_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorEstoquesIguais(int.Parse(txtEstoque.Text));
            }
        }

        private void btnPesquisarPorEstoquesMaiores_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                dgvProdutos.DataSource = pbll.PesquisarPorEstoquesMaiores(int.Parse(txtEstoque.Text));
            }
        }

        private void btnPesquisarPorDescricao_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = pbll.PesquisarPorDescricao(txtDescricao.Text);
        }

        private void btnPesquisarPorNomeProduto_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = pbll.PesquisarPorNome(txtNome.Text);
        }
        #endregion
    }
}
