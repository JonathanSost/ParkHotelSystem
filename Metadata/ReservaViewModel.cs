using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ReservaViewModel
    {
        public int ID { get; set; }
        public int IDQuarto { get; set; }
        public string TipoQuarto { get; set; }
        public int IDCliente { get; set; }
        public string NomeCliente{ get; set; }
        public int IDFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
