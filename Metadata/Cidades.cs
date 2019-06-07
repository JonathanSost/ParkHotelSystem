using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cidades
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Estados Estado { get; set; }

        public Cidades(int id, string nome, Estados estado)
        {
            this.ID = id;
            this.Nome = nome;
            this.Estado = estado;
        }
    }
}
