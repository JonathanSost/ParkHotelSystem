using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produto
    {
        public Produto(int id, string nome, string descricao, int estoque, double preco)
        {
            this.ID = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque;
            this.Preco = preco;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public string LerDadosProduto()
        {
            return Nome + "\r\n" + Descricao + "\r\n" + Preco + "\r\n";
        }
    }
}
