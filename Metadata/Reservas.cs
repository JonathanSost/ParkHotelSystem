using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Reservas
    {
        //int id, int idQuarto, int idCliente, DateTime diaReserva, DateTime diaQueSai

        public Reservas(int id, int idquarto, int idcliente, DateTime diareserva, DateTime diaquesai )
        {
            this.ID = id;
            this.IDQuarto = idquarto;
            this.IDCliente = idcliente;
            this.DiaReserva = diareserva;
            this.DiaQueSai = diaquesai;
        }

        public int ID { get; set; }
        public int IDQuarto { get; set; }
        public int IDCliente { get; set; }
        public DateTime DiaReserva { get; set; }
        public DateTime DiaQueSai { get; set; }
    }
}
