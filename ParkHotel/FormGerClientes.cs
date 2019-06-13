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
    public partial class FormGerClientes : Form
    {
        public FormGerClientes()
        {
            InitializeComponent();
        }

        ClientesBLL bll = new ClientesBLL();

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
            dataGridView1.DataSource = bll.LerTodos();
        }
    }
}
