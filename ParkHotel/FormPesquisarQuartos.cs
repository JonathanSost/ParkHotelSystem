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
    public partial class FormPesquisarQuartos : Form
    {
        #region Inicialização do Form
        QuartoBLL qbll = new QuartoBLL();
        public FormPesquisarQuartos(FormReservas formreservas)
        {
            InitializeComponent();
            dgvQuartos.DataSource = qbll.LerQuartos();          
            formReservas = formreservas;
        }

        private FormReservas formReservas = null;
        public Quarto QuartoSelecionado { get; set; }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorPreçosMenores_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.PesquisarPorPrecosMenores(double.Parse(txtPreco.Text));
        }

        private void btnPesquisarPorPreçosIguais_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.PesquisarPorPrecosIguais(double.Parse(txtPreco.Text));
        }

        private void btnPesquisarPorPreçosMaiores_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.PesquisarPorPrecosMaiores(double.Parse(txtPreco.Text));
        }

        private void PesquisarPorTipo_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.PesquisarPorTipo((int)cmbTipos.SelectedValue);
        }

        private void btnPesquisarPorQuartosDisponíveis_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = qbll.PesquisarPorDisponiveis(chkDisponivel.Checked);
        }
        #endregion

        #region Buttons
        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            this.QuartoSelecionado = new Quarto()
            {
                ID = (int)dgvQuartos.Rows[e.RowIndex].Cells[0].Value
            };
            this.Close();
        }
        #endregion

        #region KeyUp
        private void FormPesquisarQuartos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                formReservas.Show();
            }
        }
        #endregion
    }
}
