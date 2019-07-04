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
    public partial class FormQuartos : Form
    {
        #region Inicialização do Form
        QuartoBLL qbll = new QuartoBLL();
        Quarto q = null;
        public FormQuartos()
        {
            InitializeComponent();

            cmbTipo.DisplayMember = "TipoString";
            cmbTipo.ValueMember = "ID";
        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            q = new Quarto(double.Parse(txtPreco.Text), txtTipo.Text, chkDisponivel.Checked);

            MessageResponse response = qbll.Cadastrar(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvQuartos.DataSource = qbll.LerTodos();
                FormCleaner.Clear(this);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            q = new Quarto(double.Parse(txtPreco.Text), txtTipo.Text, chkDisponivel.Checked);

            MessageResponse response = qbll.Atualizar(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvQuartos.DataSource = qbll.LerTodos();
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do quarto deve ser informado.");
                return;
            }
            q.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o quarto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageResponse response = new MessageResponse();
            response = qbll.Excluir(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                qbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void FormQuartos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
                menu.Show();
            }
        }

        private void chkDisponivel_KeyUp(object sender, KeyEventArgs e)
        {
            if (!chkDisponivel.Checked && e.KeyCode == Keys.Enter)
            {
                 chkDisponivel.Checked = true;
            }
            else if(chkDisponivel.Checked && e.KeyCode == Keys.Enter)
            {
                chkDisponivel.Checked = false;
            }
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.LerTodos();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }
        #endregion

        #region Componente Changed
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            txtPreco.MaxLength = 10;
        }
        #endregion

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        private void btnCriarTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
