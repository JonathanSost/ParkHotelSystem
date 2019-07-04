using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quarto
    {
        public Quarto()
        {

        }

        public Quarto (int id, double preco, int tipo, bool quartodisponivel)
        {
            this.ID = id;
            this.Preco = preco;
            this.Tipo = tipo;
            this.QuartoDisponivel = quartodisponivel;
        }

        public Quarto(double preco, int tipo, bool quartodisponivel)
        {
            this.Preco = preco;
            this.Tipo = tipo;
            this.QuartoDisponivel = quartodisponivel;
        }

        public int ID { get; set; }
        public double Preco { get; set; }
        public int Tipo { get; set; }
        public bool QuartoDisponivel { get; set; }
    }
}
