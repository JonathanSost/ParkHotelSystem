using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservasBLL
    {
        ReservasDAL dal = new ReservasDAL();
        List<string> erros = new List<string>();

        public string Cadastrar(Reservas res)
        {
            if (res.DiaReserva == res.DiaQueSai)
            {
                erros.Add("Você deve ficar no mínimo 1 dia no Hotel Santo Soninho.");
            }
            QuartosDAL quartos = new QuartosDAL();
            if (!quartos.VerificarExistenciaQuarto(res.IDQuarto))
            {
                erros.Add("Quarto Inexistente");
            }
            ClienteDAL clientes = new ClienteDAL();
            if (!clientes.VerificarExistenciaCliente(res.IDCliente))
            {
                erros.Add("Cliente Inexistente.");
            }

            if (erros.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < erros.Count; i++)
                {
                    //Environment.NewLine
                    builder.AppendLine(erros[i]);
                }
                return builder.ToString();
            }
            return dal.Inserir(res);
        }
        
       
        
    }
}
