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
        public FormReservas()
        {
            InitializeComponent();
            
        }
        ReservaBLL resbll = new ReservaBLL();
        Reserva r = null;

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            //r = new Reserva(int.Parse(txtID.Text), int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text), dtpCheckin.Value, dtpCheckout.Value);


            //MessageResponse response = resbll.Cadastrar(r);
            //MessageBox.Show(response.Message);

            //if (response.Success)
            //{
            //    dgvReservas.DataSource = resbll.LerTodos();
            //    FormCleaner.Clear(this);
            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do Quarto deve ser informado.");
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
                dgvReservas.DataSource = resbll.LerTodos();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            r = new Reserva(int.Parse(txtID.Text), int.Parse(txtIDQuarto.Text), int.Parse(txtIDCliente.Text), dtpCheckin.Value, dtpCheckout.Value);
            MessageResponse response = new MessageResponse();
            response = resbll.Atualizar(r);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvReservas.DataSource = resbll.LerTodos();
            }
        }

        private void btnPesquisarQuartos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPesquisarQuartos(this).ShowDialog();
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPesquisarClientes(this).ShowDialog();
        }

        private void FormReservas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormMenu(Parametros.FuncionarioLogado).Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }
    }
}
