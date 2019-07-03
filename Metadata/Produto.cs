using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(string nome, string descricao, int estoque, double preco, int idfornecedor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque;
            this.Preco = preco;
            this.IdFornecedor = idfornecedor;
        }

        public Produto(int id, string nome, string descricao, int estoque, double preco, int idfornecedor)
        {
            this.ID = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque;
            this.Preco = preco;
            this.IdFornecedor = idfornecedor;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }
        public int IdFornecedor { get; set; }
    }
}
