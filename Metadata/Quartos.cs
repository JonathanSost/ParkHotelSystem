using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quartos
    {
        public Quartos (int id, double preco, string tipo)
        {
            this.ID = id;
            this.Preco = preco;
            this.Tipo = tipo;
        }

        public int ID { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public string LerDadosQuarto()
        {
            return Preco + "\r\n" + Tipo + "\r\n";
        }
    }
}
