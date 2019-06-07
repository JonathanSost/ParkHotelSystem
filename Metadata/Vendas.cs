using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Vendas
    {
        public Vendas(DateTime dataDevenda, int quantidade)
        {
            this.DataDeVenda = dataDevenda;
            this.Quantidade = quantidade;
        }

        public DateTime DataDeVenda { get; set; }
        public int Quantidade { get; set; }
    }
}
