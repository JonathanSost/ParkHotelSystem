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
    public partial class FormClientes : Form
    {
        ClienteBLL clibll = new ClienteBLL();
        CidadeBLL cidbll = new CidadeBLL();
        EstadoBLL estbll = new EstadoBLL();
        Cliente c = null;

        public FormClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = clibll.LerTodos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            string telefone1 = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            string telefone2 = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            string cep = (string)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
            string estado = (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
            string cidade = (string)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
            string rua = (string)dataGridView1.Rows[e.RowIndex].Cells[10].Value;
            string bairro = (string)dataGridView1.Rows[e.RowIndex].Cells[12].Value;
            string numero = (string)dataGridView1.Rows[e.RowIndex].Cells[13].Value;
            string complemento = (string)dataGridView1.Rows[e.RowIndex].Cells[14].Value;

            txtID.Text = id.ToString();
            txtNome.Text = nome;
            msktxtCPF.Text = cpf;
            msktxtRG.Text = rg;
            msktxtTelefone.Text = telefone1;
            msktxtCelular.Text = telefone2;
            txtEmail.Text = email;
            txtCEP.Text = cep;
            cmbEstado.Text = estado.ToString();
            cmbCidade.Text = cidade.ToString();
            txtRua.Text = rua;
            txtBairro.Text = bairro;
            txtNumero.Text = numero;
            txtComplemento.Text = complemento;
        }

        private void FormClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            c = new Cliente(txtNome.Text, msktxtCPF.Text, msktxtRG.Text, 
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, txtCEP.Text, (int)cmbEstado.SelectedValue, 
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text);

            MessageBox.Show(clibll.Cadastrar(c));
            if (clibll.ValidarCliente(c))
            {
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clibll.Atualizar(c);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do cliente deve ser informado.");
                return;
            }
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            
            clibll.Excluir(int.Parse(txtID.Text));
            MessageBox.Show("Excluido com sucesso!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clibll.LerClientes();

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
        }

        
    }
}
