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
    public partial class FormPesquisarFornecedores : Form
    {
        #region Inicialização do Form
        FornecedorBLL forbll = new FornecedorBLL();
        public FormPesquisarFornecedores()
        {
            InitializeComponent();
            dgvFornecedores.DataSource = forbll.LerTodos();
        }

        public Fornecedor FornecedorSelecionado { get; set; }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorNomeEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeEmpresa.Text))
            {
                MessageBox.Show("Favor, informar o nome da empresa.");
                return;
            }
            forbll.PesquisarPorNomeEmpresa(txtNomeEmpresa.Text);
        }

        private void PesquisarPorCNPJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(msktxtCNPJ.Text))
            {
                MessageBox.Show("Favor, informar o CNPJ da empresa");
                return;
            }
            forbll.PesquisarPorCNPJ(msktxtCNPJ.Text);
        }

        private void btnPesquisarPorNomeContato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Favor, informar o nome do contato");
                return;
            }
            forbll.PesquisarPorNome(txtNome.Text);
        }
        #endregion

        #region Buttons
        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            this.FornecedorSelecionado = new Fornecedor()
            {
                ID = (int)dgvFornecedores.Rows[e.RowIndex].Cells[0].Value
            };

            this.Close();
        }
        #endregion

        #region KeyUp
        private void FormPesquisarFornecedores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormProdutos().Show();
            }
        }
        #endregion
    }
}
