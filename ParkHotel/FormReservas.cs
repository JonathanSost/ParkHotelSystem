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
    public partial class FormReservas : Form
    {
        #region Inicialização do Form
        public FormReservas()
        {
            InitializeComponent();
            txtIDFuncionario.Text = Parametros.FuncionarioLogado.ID.ToString();
            dgvReservas.DataSource = resbll.LerReservas();
            dtpCheckin.MinDate = DateTime.Now;
            dtpCheckout.MinDate = DateTime.Now.AddDays(1);
        }
        ReservaBLL resbll = new ReservaBLL();
        Reserva r = null;
        #endregion

        #region Buttons
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            r = new Reserva(int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text), int.Parse(txtIDFuncionario.Text), dtpCheckin.Value, dtpCheckout.Value);

            MessageResponse response = resbll.Cadastrar(r);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                resbll.RealizarCheckin(int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text));
                dgvReservas.DataSource = resbll.LerReservas();
                FormCleaner.Clear(this);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID da Reserva deve ser informada.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                MessageBox.Show("ID do Cliente deve ser informado.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtIDQuarto.Text))
            {
                MessageBox.Show("ID do Quarto deve ser informado.");
                return;
            }
            r.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir a reserva?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            MessageResponse response = new MessageResponse();
            response = resbll.Excluir(r);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                resbll.RealizarCheckOut(int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text));
                dgvReservas.DataSource = resbll.LerReservas();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            r = new Reserva(int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text), int.Parse(txtIDFuncionario.Text), dtpCheckin.Value, dtpCheckout.Value);
            MessageResponse response = new MessageResponse();
            response = resbll.Atualizar(r);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvReservas.DataSource = resbll.LerReservas();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormMenu(Parametros.FuncionarioLogado).Show();
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvReservas.DataSource = resbll.LerReservas();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvReservas.DataSource = resbll.LerReservasByID();
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvReservas.DataSource = resbll.LerReservasByIDDesc();
        }

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvReservas.Rows[e.RowIndex].Cells[0].Value;
            int idquarto = (int)dgvReservas.Rows[e.RowIndex].Cells[1].Value;
            int idcliente = (int)dgvReservas.Rows[e.RowIndex].Cells[3].Value;
            int idfuncionario = (int)dgvReservas.Rows[e.RowIndex].Cells[5].Value;
            DateTime checkin = (DateTime)dgvReservas.Rows[e.RowIndex].Cells[7].Value;
            DateTime checkout = (DateTime)dgvReservas.Rows[e.RowIndex].Cells[8].Value;

            r = new Reserva(id, idquarto, idcliente, idfuncionario, checkin, checkout);

            txtID.Text = id.ToString();
            txtIDQuarto.Text = idquarto.ToString();
            txtIDCliente.Text = idcliente.ToString();
            txtIDFuncionario.Text = idfuncionario.ToString();
            dtpCheckin.Value = checkin;
            dtpCheckout.Value = checkout;
        }
        #endregion

        #region Pesquisar
        private void btnPesquisarQuartos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesquisarQuartos frmqua = new FormPesquisarQuartos(this);
            frmqua.ShowDialog();
            this.Show();
            if (frmqua.QuartoSelecionado != null)
            {
                txtIDQuarto.Text = frmqua.QuartoSelecionado.ID.ToString();
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

        private void FormReservas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormMenu(Parametros.FuncionarioLogado).Show();
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
