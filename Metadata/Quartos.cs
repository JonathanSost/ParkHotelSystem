using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quartos
    {
        public Quartos (int id, double preco, string tipo, bool quartodisponivel)
        {
            this.ID = id;
            this.Preco = preco;
            this.Tipo = tipo;
            this.QuartoDisponivel = quartodisponivel;
        }

        public int ID { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public bool QuartoDisponivel { get; set; }
    }
}
