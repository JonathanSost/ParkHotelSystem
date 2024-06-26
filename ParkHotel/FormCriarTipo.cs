﻿using BLL;
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
        MessageResponse response = new MessageResponse();
        #endregion

        #region Buttons
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            response = tbll.Inserir(new Tipo(txtTipo.Text));
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                FormCleaner.Clear(this);
                dgvTipos.DataSource = tbll.LerTodos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            response = tbll.Excluir(t);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                FormCleaner.Clear(this);
                dgvTipos.DataSource = tbll.LerTodos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            response = tbll.Atualizar(t);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvTipos.DataSource = tbll.LerTodos();
            }
        }

        private void dgvTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvTipos.Rows[e.RowIndex].Cells[0].Value;
            string tipo = (string)dgvTipos.Rows[e.RowIndex].Cells[1].Value;

            t = new Tipo(id, tipo);

            txtID.Text = id.ToString();
            txtTipo.Text = tipo;
        }
        #endregion

        #region Pesquisar
        private void btnPesquisarPorTipo_Click(object sender, EventArgs e)
        {
            dgvTipos.DataSource = tbll.PesquisarPorTipo(txtTipo.Text);
        }
        #endregion

        private void FormCriarTipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
