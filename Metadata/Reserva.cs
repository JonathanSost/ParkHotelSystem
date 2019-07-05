using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Reserva
    {
        public Reserva()
        {

        }

        public Reserva(int id, int idquarto, int idcliente, DateTime checkin, DateTime checkout)
        {
            this.ID = id;
            this.IDQuarto = idquarto;
            this.IDCliente = idcliente;
            this.CheckIn = checkin;
            this.CheckOut = checkout;
        }

        public int ID { get; set; }
        public int IDQuarto { get; set; }
        public int IDCliente { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
