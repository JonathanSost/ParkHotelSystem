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
        #region Inicialização do Form
        ClienteBLL clibll = new ClienteBLL();
        CidadeBLL cidbll = new CidadeBLL();
        EstadoBLL estbll = new EstadoBLL();
        Cliente c = null;

        public FormClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = clibll.LerClientes();
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
        #endregion

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            string telefone1 = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            string telefone2 = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            string estado = (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
            string cidade = (string)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
            string rua = (string)dataGridView1.Rows[e.RowIndex].Cells[10].Value;
            string bairro = (string)dataGridView1.Rows[e.RowIndex].Cells[11].Value;
            string numero = (string)dataGridView1.Rows[e.RowIndex].Cells[12].Value;
            string cep = (string)dataGridView1.Rows[e.RowIndex].Cells[13].Value;
            string complemento = (string)dataGridView1.Rows[e.RowIndex].Cells[14].Value;

            c = new Cliente(nome, cpf, rg, telefone1, telefone2, email, cep, (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, rua, bairro, numero, complemento);

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

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            c = new Cliente(txtNome.Text, msktxtCPF.Text, msktxtRG.Text,
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, txtCEP.Text, (int)cmbEstado.SelectedValue,
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text);

            MessageResponse response = clibll.Cadastrar(c);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                dataGridView1.DataSource = clibll.LerClientes();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            c = new Cliente(int.Parse(txtID.Text), txtNome.Text, msktxtCPF.Text, msktxtRG.Text,
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, txtCEP.Text, (int)cmbEstado.SelectedValue,
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text);
            MessageBox.Show(clibll.Atualizar(c));
            dataGridView1.DataSource = clibll.LerClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            c.ID = int.Parse(txtID.Text);
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

            MessageBox.Show(clibll.Excluir(c));
            clibll.LerClientes();
            FormCleaner.Clear(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }
        #endregion

        #region TextBox Changed
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
            txtEmail.MaxLength = 70;
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

        private void btnPesquisarPorNome_Click(object sender, EventArgs e)
        {
            clibll.PesquisarPorNome(txtNome.Text);
        }

        private void btnPesquisarPorCPF_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorRG_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorCEP_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorBairro_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorRua_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPorNumero_Click(object sender, EventArgs e)
        {

        }
    }
}
