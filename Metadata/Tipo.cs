using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Tipo
    {
        public Tipo(string tipo)
        {
            this.NomeTipo = tipo;
        }

        public int ID { get; set; }
        public string NomeTipo { get; set; }
    }
}
