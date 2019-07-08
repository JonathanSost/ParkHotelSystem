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
    public partial class FormVendas : Form
    {
        #region Inicialização do Form
        public FormVendas()
        {
            InitializeComponent();
            cmbProdutos.ValueMember = "ID";
            cmbProdutos.DisplayMember = "NOME";
            cmbProdutos.DataSource = pbll.LerProdutos();
        
            dgvProdutosSaida.DataSource = vbll.LerVendas();
            txtIDFuncionario.Text = Parametros.FuncionarioLogado.ID.ToString();
        }

        ProdutoBLL pbll = new ProdutoBLL();
        VendaBLL vbll = new VendaBLL();
        ClienteBLL clibll = new ClienteBLL();
        MessageResponse response = new MessageResponse();
        Venda v = null;
        Produto p = null;
        double valor = 0;
        double conta = 0;
        #endregion

        #region Buttons
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                MessageBox.Show("Favor informar o ID do Cliente.");
            }
            else if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Favor informar a quantidade.");
            }
            else if (string.IsNullOrWhiteSpace(txtIDFuncionario.Text))
            {
                MessageBox.Show("Favor informar o ID do Funcionário.");
            }
            valor = pbll.TrazerPrecoProduto((int)cmbProdutos.SelectedValue) * int.Parse(txtQuantidade.Text);
            conta = clibll.TrazerContaCliente(int.Parse(txtIDCliente.Text));

            v = new Venda(int.Parse(txtIDFuncionario.Text), int.Parse(txtIDCliente.Text), DateTime.Now, int.Parse(txtQuantidade.Text), valor, (int)cmbProdutos.SelectedValue);
            p = pbll.LerPorID((int)cmbProdutos.SelectedValue);

            response = vbll.Cadastrar(v, p);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                conta += valor;
                clibll.AtualizarContaCliente(conta, int.Parse(txtIDCliente.Text));
                p.Estoque -= int.Parse(txtQuantidade.Text);
                pbll.AtualizarEstoqueProduto(p.ID, p.Estoque);
                dgvProdutosSaida.DataSource = vbll.LerVendas();
                FormCleaner.Clear(this);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir o histórico desta venda irá desfazer todas as alterações feitas por ela. Você tem certeza de que deseja prosseguir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                return;
            }

            valor = pbll.TrazerPrecoProduto((int)cmbProdutos.SelectedValue) * int.Parse(txtQuantidade.Text);
            conta = clibll.TrazerContaCliente(int.Parse(txtIDCliente.Text));
            p = pbll.LerPorID((int)cmbProdutos.SelectedValue);

            response = vbll.Excluir(v);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                conta -= valor;
                clibll.AtualizarContaCliente(conta, int.Parse(txtIDCliente.Text));
                p.Estoque += int.Parse(txtQuantidade.Text);
                pbll.AtualizarEstoqueProduto(p.ID, p.Estoque);
                dgvProdutosSaida.DataSource = vbll.LerVendas();
                FormCleaner.Clear(this);
            }
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesquisarClientes frmcli = new FormPesquisarClientes();
            frmcli.ShowDialog();
            this.Show();
            if (frmcli.ClienteSelecionado != null)
            {
                txtIDCliente.Text = frmcli.ClienteSelecionado.ID.ToString();
            }
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvProdutosSaida.DataSource = vbll.LerVendas();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
            txtQuantidade.Enabled = true;
            cmbProdutos.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormMenu(Parametros.FuncionarioLogado).Show();
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutosSaida.DataSource = vbll.LerVendasByID();
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvProdutosSaida.DataSource = vbll.LerVendasByIDDesc();
        }

        private void dgvProdutosSaida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuantidade.Enabled = false;
            cmbProdutos.Enabled = false;

            int id = (int)dgvProdutosSaida.Rows[e.RowIndex].Cells[0].Value;
            int idfuncionario = (int)dgvProdutosSaida.Rows[e.RowIndex].Cells[1].Value;
            string nomefuncionario = (string)dgvProdutosSaida.Rows[e.RowIndex].Cells[2].Value;
            int idcliente = (int)dgvProdutosSaida.Rows[e.RowIndex].Cells[3].Value;
            string nomecliente = (string)dgvProdutosSaida.Rows[e.RowIndex].Cells[4].Value;
            DateTime datadesaida = (DateTime)dgvProdutosSaida.Rows[e.RowIndex].Cells[5].Value;
            int quantidade = (int)dgvProdutosSaida.Rows[e.RowIndex].Cells[6].Value;
            double valor = (double)dgvProdutosSaida.Rows[e.RowIndex].Cells[7].Value;
            int idproduto = (int)dgvProdutosSaida.Rows[e.RowIndex].Cells[8].Value;
            string nomeproduto = (string)dgvProdutosSaida.Rows[e.RowIndex].Cells[9].Value;

            v = new Venda(id, idfuncionario, idcliente, datadesaida, quantidade, valor, idproduto);

            txtIDCliente.Text = idcliente.ToString();
            cmbProdutos.SelectedValue = pbll.TrazerPorNome(nomeproduto);
            txtQuantidade.Text = quantidade.ToString();
            txtIDFuncionario.Text = idfuncionario.ToString();
        }
        #endregion

        #region KeyUp
        private void FormVendas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnVoltar.PerformClick();
            }
        }
        #endregion

        #region Componente Changed
        private void txtIDFuncionario_TextChanged(object sender, EventArgs e)
        {
            txtIDFuncionario.Text = Parametros.FuncionarioLogado.ID.ToString();
        }
        #endregion
    }
}
