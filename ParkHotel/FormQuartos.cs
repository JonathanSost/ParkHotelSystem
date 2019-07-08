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
        TipoBLL tbll = new TipoBLL();
        Quarto q = null;
        public FormQuartos()
        {
            InitializeComponent();
        }

        private void FormQuartos_Load(object sender, EventArgs e)
        {
            cmbTipo.DisplayMember = "NomeTipo";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = tbll.LerTodos();
            dgvQuartos.DataSource = qbll.LerQuartos();
        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Favor informar o preço do quarto.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(cmbTipo.Text))
            {
                MessageBox.Show("Favor informar o tipo do quarto.");
                return;
            }
            q = new Quarto(double.Parse(txtPreco.Text), (int)cmbTipo.SelectedValue, true);

            MessageResponse response = qbll.Cadastrar(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvQuartos.DataSource = qbll.LerQuartos();
                FormCleaner.Clear(this);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Favor informar o ID da reserva.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Favor informar o preço da reserva.");
                return;
            }
            q = new Quarto(int.Parse(txtID.Text), double.Parse(txtPreco.Text), (int)cmbTipo.SelectedValue, chkDisponivel.Checked);

            MessageResponse response = qbll.Atualizar(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvQuartos.DataSource = qbll.LerQuartos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do quarto deve ser informado.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Favor informar o preço da reserva.");
                return;
            }
            
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o quarto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            q = new Quarto(int.Parse(txtID.Text), double.Parse(txtPreco.Text), (int)cmbTipo.SelectedValue, chkDisponivel.Checked);

            MessageResponse response = qbll.Excluir(q);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                qbll.LerQuartos();
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

        private void btnCriarTipo_Click(object sender, EventArgs e)
        {
            new FormCriarTipo(this).ShowDialog();
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvQuartos.DataSource = qbll.LerQuartosByID();
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvQuartos.DataSource = qbll.LerQuartosByIDDesc();
        }

        private void lnkOrderByPreco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvQuartos.DataSource = qbll.LerQuartosByPreco();
        }

        private void lnkOrderByPrecoDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvQuartos.DataSource = qbll.LerQuartosByPrecoDesc();
        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvQuartos.Rows[e.RowIndex].Cells[0].Value;
            double preco = qbll.TrazerPrecoPorID(id);
            int tipo = tbll.LerPorNome((string)dgvQuartos.Rows[e.RowIndex].Cells[2].Value);
            bool disponivel = (bool)dgvQuartos.Rows[e.RowIndex].Cells[3].Value;

            cmbTipo.SelectedValue = tipo;

            q = new Quarto(id, preco, (int)cmbTipo.SelectedValue, disponivel);

            txtID.Text = id.ToString();
            txtPreco.Text = preco.ToString();
            chkDisponivel.Checked = disponivel;
        }
        #endregion

        #region Componente Changed
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            txtPreco.MaxLength = 10;
        }
        #endregion
    }
}
