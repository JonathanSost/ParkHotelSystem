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
    public partial class FormClientes : Form
    {
        #region Inicialização do Form
        ClienteBLL clibll = new ClienteBLL();
        CidadeBLL cidbll = new CidadeBLL();
        EstadoBLL estbll = new EstadoBLL();
        Cliente c = null;
        MessageResponse response = new MessageResponse();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientes();
            dgvClientes.Columns["Email"].HeaderText = "E-Mail";
            dgvClientes.Columns["Telefone2"].HeaderText = "Celular";

            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "ID";
            cmbEstado.DataSource = estbll.LerTodos();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "ID";
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);

        }
        #endregion

        #region Buttons
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            c = new Cliente(txtNome.Text, msktxtCPF.Text, msktxtRG.Text,
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, msktxtCEP.Text, (int)cmbEstado.SelectedValue,
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, 0, false);

            response = clibll.Cadastrar(c);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                dgvClientes.DataSource = clibll.LerClientes();
                FormCleaner.Clear(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            c = new Cliente(int.Parse(txtID.Text), txtNome.Text, msktxtCPF.Text, msktxtRG.Text,
                msktxtTelefone.Text, msktxtCelular.Text, txtEmail.Text, msktxtCEP.Text, (int)cmbEstado.SelectedValue,
                (int)cmbCidade.SelectedValue, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, false);

            response = clibll.Atualizar(c);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvClientes.DataSource = clibll.LerClientes();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID do cliente deve ser informado.");
                return;
            }
            c.ID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            response = clibll.Excluir(c);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                dgvClientes.DataSource = clibll.LerClientes();
                FormCleaner.Clear(this);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
            menu.Show();
        }

        private void picbRefresh_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientes();
        }

        private void picbClear_Click(object sender, EventArgs e)
        {
            FormCleaner.Clear(this);
        }

        private void lnkOrderByID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientesByID();
        }

        private void lnkOrderByIDDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientesByIDDesc();
        }

        private void lnkOrderByName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientesByName();
        }

        private void lnkOrderByNameDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvClientes.DataSource = clibll.LerClientesByNameDesc();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = (int)dgvClientes.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvClientes.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dgvClientes.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dgvClientes.Rows[e.RowIndex].Cells[3].Value;
            string telefone1 = (string)dgvClientes.Rows[e.RowIndex].Cells[4].Value;
            string telefone2 = (string)dgvClientes.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dgvClientes.Rows[e.RowIndex].Cells[6].Value;
            int estado = estbll.LerPorCliente((string)dgvClientes.Rows[e.RowIndex].Cells[7].Value);
            int cidade = cidbll.LerPorCliente((string)dgvClientes.Rows[e.RowIndex].Cells[8].Value);
            string rua = (string)dgvClientes.Rows[e.RowIndex].Cells[9].Value;
            string bairro = (string)dgvClientes.Rows[e.RowIndex].Cells[10].Value;
            string numero = (string)dgvClientes.Rows[e.RowIndex].Cells[11].Value;
            string cep = (string)dgvClientes.Rows[e.RowIndex].Cells[12].Value;
            string complemento = (string)dgvClientes.Rows[e.RowIndex].Cells[13].Value;

            cmbEstado.SelectedValue = estado;
            cmbCidade.SelectedValue = cidade;

            c = new Cliente(nome, cpf, rg, telefone1, telefone2, email, cep, (int)cmbEstado.SelectedValue, (int)cmbCidade.SelectedValue, rua, bairro, numero, complemento);

            txtID.Text = id.ToString();
            txtNome.Text = nome;
            msktxtCPF.Text = cpf;
            msktxtRG.Text = rg;
            msktxtTelefone.Text = telefone1;
            msktxtCelular.Text = telefone2;
            txtEmail.Text = email;
            msktxtCEP.Text = cep;
            txtRua.Text = rua;
            txtBairro.Text = bairro;
            txtNumero.Text = numero;
            txtComplemento.Text = complemento;
        }
        #endregion

        #region Componente Changed
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DataSource = cidbll.LerPorEstado((int)cmbEstado.SelectedValue);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 70;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 70;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.MaxLength = 50;
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            txtRua.MaxLength = 70;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 5;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.MaxLength = 70;
        }

        private void msktxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCPF.Text.Length == 11)
            {
                msktxtRG.Focus();
            }
        }

        private void msktxtRG_TextChanged(object sender, EventArgs e)
        {
            if (msktxtRG.Text.Length == 7)
            {
                msktxtTelefone.Focus();
            }
        }

        private void msktxtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (msktxtTelefone.Text.Length == 11)
            {
                msktxtCelular.Focus();
            }
        }

        private void msktxtCelular_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCelular.Text.Length == 11)
            {
                txtEmail.Focus();
            }
        }

        private void msktxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCEP.Text.Length == 8)
            {
                txtBairro.Focus();
            }
        }

        private void msktxtCPF_Click(object sender, EventArgs e)
        {
            msktxtCPF.SelectionStart = msktxtCPF.Text.Length;
            if (msktxtCPF.Text.Length >= 10)
            {
                msktxtCPF.SelectionStart = msktxtCPF.Text.Length + 3;
            }
            else if (msktxtCPF.Text.Length >= 7)
            {
                msktxtCPF.SelectionStart = msktxtCPF.Text.Length + 2;
            }
            else if (msktxtCPF.Text.Length >= 4)
            {
                msktxtCPF.SelectionStart = msktxtCPF.Text.Length + 1;
            }
        }

        private void msktxtRG_Click(object sender, EventArgs e)
        {
            msktxtRG.SelectionStart = msktxtRG.Text.Length;
            if (msktxtRG.Text.Length >= 5)
            {
                msktxtRG.SelectionStart = msktxtRG.Text.Length + 2;
            }
            else if (msktxtRG.Text.Length >= 2)
            {
                msktxtRG.SelectionStart = msktxtRG.Text.Length + 1;
            }
        }
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

        private void btnPesquisarPorEstado_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorEstado((int)cmbEstado.SelectedValue);
        }

        private void btnPesquisarPorCidade_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorCidade((int)cmbCidade.SelectedValue);
        }

        private void btnPesquisarPorCEP_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clibll.PesquisarPorCEP(msktxtCEP.Text);
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

        #region KeyDown
        private void FormClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FormMenu menu = new FormMenu(Parametros.FuncionarioLogado);
                menu.Show();
            }
        }
        #endregion
    }
}
