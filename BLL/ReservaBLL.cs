using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservaBLL
    {
        ReservaDAL dal = new ReservaDAL();
        MessageResponse response = new MessageResponse();

        List<string> erros = new List<string>();

        public MessageResponse Cadastrar(Reservas res)
        {
            if (res.DiaReserva == res.DiaQueSai)
            {
                erros.Add("Você deve ficar no mínimo 1 dia no Hotel Santo Soninho.");
            }
            QuartoDAL quartos = new QuartoDAL();
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
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            return dal.Inserir(res);
        }

        public MessageResponse Atualizar(Reservas reserva)
        {
            response = dal.Atualizar(reserva);
            response.Message = "Produto atualizado com sucesso!";
            return response;
        }

        public MessageResponse Excluir(Reservas reserva)
        {
            response = dal.Excluir(reserva);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }

        public Reservas LerPorID(int id)
        {
            return dal.LerPorID(id);
        }

        public List<Reservas> LerTodos()
        {
            return dal.LerTodos();
        }
    }
}
