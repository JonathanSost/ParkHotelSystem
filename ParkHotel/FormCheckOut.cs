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
    public partial class FormCheckOut : Form
    {
        #region Inicialização do Form
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void FormCheckOutAutomatico_Load(object sender, EventArgs e)
        {
            dgvClientesExpirados.DataSource = bll.LerReservasExpiradas(DateTime.Now);
        }

        TimeSpan tempodeestadia = new TimeSpan();
        MessageResponse response = new MessageResponse();
        ClienteBLL clibll = new ClienteBLL();
        QuartoBLL qbll = new QuartoBLL();
        ReservaBLL bll = new ReservaBLL();
        Reserva r = null;
        double precoestadia;
        double conta;
        #endregion

        #region Buttons
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            response = bll.RealizarCheckOut(r.IDQuarto, r.IDCliente);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                precoestadia = qbll.TrazerPrecoPorID(int.Parse(txtIDQuarto.Text));
                precoestadia *= tempodeestadia.Days;
                conta = clibll.TrazerContaCliente(int.Parse(txtIDCliente.Text));
                conta += precoestadia;
                clibll.AtualizarContaCliente(conta, int.Parse(txtIDCliente.Text));
                dgvClientesExpirados.DataSource = bll.LerReservasExpiradas(DateTime.Now);
                FormCleaner.Clear(this);
            }
            if (!bll.ChecarReservasExpiradas(DateTime.Now))
            {
                this.Close();
            }
        }

        private void btnAdiar_Click(object sender, EventArgs e)
        {
            DateTime dataprevistasaida = dtpDataPrevistaSaida.Value;
            dataprevistasaida.AddDays(1);
            bll.Atualizar(r);
            if (response.Success)
            {
                dgvClientesExpirados.DataSource = bll.LerReservasExpiradas(DateTime.Now);
                FormCleaner.Clear(this);
            }
            if (!bll.ChecarReservasExpiradas(DateTime.Now))
            {
                this.Close();
            }
        }

        private void dgvClientesExpirados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvClientesExpirados.Rows[e.RowIndex].Cells[0].Value;
            int idquarto = (int)dgvClientesExpirados.Rows[e.RowIndex].Cells[1].Value;
            string tipoquarto = (string)dgvClientesExpirados.Rows[e.RowIndex].Cells[2].Value;
            int idcliente = (int)dgvClientesExpirados.Rows[e.RowIndex].Cells[3].Value;
            string nomecliente = (string)dgvClientesExpirados.Rows[e.RowIndex].Cells[4].Value;
            int idfuncionario = (int)dgvClientesExpirados.Rows[e.RowIndex].Cells[5].Value;
            string nomefuncionario = (string)dgvClientesExpirados.Rows[e.RowIndex].Cells[6].Value;
            DateTime checkin = (DateTime)dgvClientesExpirados.Rows[e.RowIndex].Cells[7].Value;
            DateTime checkout = (DateTime)dgvClientesExpirados.Rows[e.RowIndex].Cells[8].Value;

            r = new Reserva(id, idquarto, idcliente, idfuncionario, checkin, checkout);

            txtID.Text = id.ToString();
            txtIDQuarto.Text = idquarto.ToString();
            txtTipoQuarto.Text = tipoquarto;
            txtIDCliente.Text = idcliente.ToString();
            txtNomeCliente.Text = nomecliente;
            txtIDFuncionario.Text = idfuncionario.ToString();
            txtNomeFuncionario.Text = nomefuncionario;
            dtpDataPrevistaEntrada.Value = checkin;
            dtpDataPrevistaSaida.Value = checkout;

            tempodeestadia = checkout.Subtract(checkin);
        }
        #endregion

        #region KeyDown
        private void FormCheckOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
