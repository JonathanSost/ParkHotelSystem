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
    public partial class FormGerClientes : Form
    {
        ClientesBLL bll = new ClientesBLL();

        public FormGerClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = bll.LerTodos();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
