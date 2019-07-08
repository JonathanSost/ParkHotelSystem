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
    public partial class FormPesquisarClientes : Form
    {
        #region Inicialização do Form
        public FormPesquisarClientes()
        {
            InitializeComponent();
            dgvClientes.DataSource = clibll.LerClientes();
        }

        ClienteBLL clibll = new ClienteBLL();
        public Cliente ClienteSelecionado { get; set; }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorNome_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorNome(txtNome.Text);
        }

        private void btnPesquisarPorCPF_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorCPF(msktxtCPF.Text);
        }

        private void btnPesquisarPorRG_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorRG(msktxtRG.Text);
        }

        private void btnPesquisarPorCEP_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorCEP(msktxtCEP.Text);
        }

        private void btnPesquisarPorEstado_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorEstado((int)cmbEstado.SelectedValue);
        }

        private void btnPesquisarPorCidade_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorCidade((int)cmbCidade.SelectedValue);
        }

        private void btnPesquisarPorBairro_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorBairro(txtBairro.Text);
        }

        private void btnPesquisarPorRua_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorRua(txtRua.Text);
        }
        #endregion

        #region KeyUp
        private void FormPesquisarClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new FormReservas().Show();
            }
        }
        #endregion

        #region Buttons
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            this.ClienteSelecionado = new Cliente()
            {
                ID = (int)dgvClientes.Rows[e.RowIndex].Cells[0].Value
            };
            this.Close();
        }
        #endregion
    }
}
