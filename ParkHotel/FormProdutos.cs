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
        public FormProdutos()
        {
            InitializeComponent();
        }

       

        private void FormProdutos_KeyUp(object sender, KeyEventArgs e)
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
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

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
    }
}
