using BLL;
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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            cmbProdutos.ValueMember = "ID";
            cmbProdutos.DisplayMember = "NOME";
            cmbProdutos.DataSource = pbll.LerProdutos();
        }

        ProdutoBLL pbll = new ProdutoBLL();
    }
}
