using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Venda
    {
        public Venda(int idvenda, int idfuncionario, int idcliente, DateTime dataDevenda, int quantidade, double valor, int produto)
        {
            this.IDVenda = idvenda;
            this.IdFuncionario = idfuncionario;
            this.IdCliente = idcliente;
            this.DataDeVenda = dataDevenda;
            this.Quantidade = quantidade;
            this.Valor = valor;
            this.Produto = produto;
        }

        public Venda(int idfuncionario, int idcliente, DateTime dataDevenda, int quantidade, double valor, int produto)
        {
            this.IdFuncionario = idfuncionario;
            this.IdCliente = idcliente;
            this.DataDeVenda = dataDevenda;
            this.Quantidade = quantidade;
            this.Valor = valor;
            this.Produto = produto;
        }

        public int IDVenda { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataDeVenda { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public int Produto { get; set; }
    }
}
