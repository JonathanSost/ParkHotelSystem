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
    public partial class FormCriarTipo : Form
    {
        #region Inicialização do Form
        public FormCriarTipo(FormQuartos formquartos)
        {
            InitializeComponent();
            formQuartos = formquartos;
            dgvTipos.DataSource = tbll.LerTodos();
        }

        private FormQuartos formQuartos { get; set; }
        TipoBLL tbll = new TipoBLL();
        Tipo t = null;
        #endregion

        #region Buttons
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            tbll.Inserir(new Tipo(txtTipo.Text));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbll.Excluir(t);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbll.Atualizar(t);
        }

        private void dgvTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvTipos.Rows[e.RowIndex].Cells[0].Value;
            string tipo = (string)dgvTipos.Rows[e.RowIndex].Cells[1].Value;

            t = new Tipo(tipo);

            txtID.Text = id.ToString();
            txtTipo.Text = tipo;
        }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorTipo_Click(object sender, EventArgs e)
        {
            tbll.PesquisarPorTipo(txtTipo.Text);
        }
        #endregion
    }
}
