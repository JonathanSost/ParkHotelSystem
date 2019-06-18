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
        ClientesBLL clibll = new ClientesBLL();
        CidadesBLL cidbll = new CidadesBLL();
        EstadosBLL estbll = new EstadosBLL();
        Clientes c = null;

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
            int idEstado = (int)cmbEstado.SelectedValue;

            c = new Clientes(txtNome.Text, msktxtCPF.Text, msktxtRG.Text, 
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, txtCEP.Text, (int)cmbEstado.SelectedValue, 
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text);

            clibll.Cadastrar(c);

            FormCleaner.Clear(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clibll.Atualizar(c);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Cliente deve ser informado.");
                return;
            }
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            dataGridView1.DataSource = clibll.LerTodos();

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
        }
    }
}
