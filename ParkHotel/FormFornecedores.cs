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
        FornecedorBLL forbll = new FornecedorBLL();

        public FormFornecedores()
        {
            InitializeComponent();
            dataGridView1.DataSource = forbll.LerTodos();
        }

        private void FormFornecedores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(Registro.NOVO_REGISTRO, txtNomeEmpresa.Text, txtCNPJ.Text, txtNome.Text, txtTelefone.Text, txtEmail.Text);
            forbll.Cadastrar(fornecedor);
            dataGridView1.DataSource = forbll.LerTodos();

            FormCleaner.Clear(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Excluido com sucesso!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string nomeEmpresa = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            string cnpj = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            string nome = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;

            txtID.Text = id.ToString();
            txtNomeEmpresa.Text = nomeEmpresa;
            txtCNPJ.Text = cnpj;
            txtNome.Text = nome;
            txtTelefone.Text = telefone;
            txtEmail.Text = email;
        }

        
    }
}
