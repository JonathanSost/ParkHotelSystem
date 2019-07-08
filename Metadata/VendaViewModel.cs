using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class VendaViewModel
    {
        public int IDVenda { get; set; }
        public int IDFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public int IDCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataDeVenda { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public int IDProduto { get; set; }
        public string NomeProduto { get; set; }
    }
}
