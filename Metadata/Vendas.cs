using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Vendas
    {
        public Vendas(int idfuncionario, int idcliente, DateTime dataDevenda, int quantidade)
        {
            this.IdFuncionario = idfuncionario;
            this.IdCliente = idcliente;
            this.DataDeVenda = dataDevenda;
            this.Quantidade = quantidade;
        }

        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataDeVenda { get; set; }
        public int Quantidade { get; set; }
    }
}
