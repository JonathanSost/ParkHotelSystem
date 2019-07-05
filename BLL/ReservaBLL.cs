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

        #region Cadastrar
        public MessageResponse Cadastrar(Reserva reserva)
        {
            if (reserva.CheckIn == reserva.CheckOut)
            {
                erros.Add("Você deve ficar no mínimo 1 dia no Hotel Santo Soninho.");
            }
            QuartoDAL quartos = new QuartoDAL();
            if (!quartos.VerificarExistenciaQuarto(reserva.IDQuarto))
            {
                erros.Add("Quarto Inexistente");
            }
            ClienteDAL clientes = new ClienteDAL();
            if (!clientes.VerificarExistenciaCliente(reserva.IDCliente))
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
            return dal.Checkin(reserva);
        }
        #endregion

        #region Atualizar
        public MessageResponse Atualizar(Reserva reserva)
        {
            if (!dal.VerificarExistenciaReserva(reserva.ID))
            {
                response.Success = false;
                response.Message = "Reserva inexistente!";
                return response;
            }

            if (reserva.CheckIn == reserva.CheckOut)
            {
                erros.Add("Você deve ficar no mínimo 1 dia no Hotel Santo Soninho.");
            }
            QuartoDAL quartos = new QuartoDAL();
            if (!quartos.VerificarExistenciaQuarto(reserva.IDQuarto))
            {
                erros.Add("Quarto Inexistente");
            }
            ClienteDAL clientes = new ClienteDAL();
            if (!clientes.VerificarExistenciaCliente(reserva.IDCliente))
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

            return dal.Checkin(reserva);
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Reserva reserva)
        {
            if (!dal.VerificarExistenciaReserva(reserva.ID))
            {
                response.Success = false;
                response.Message = "Reserva inexistente!";
                return response;
            }
            response = dal.Excluir(reserva);
            return response;
        }
        #endregion

        #region Ler Por ID
        public Reserva LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        public List<Reserva> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion

        #region Realizar Check-Out Automático
        public void RealizarCheckoutAutomatico()
        {
            dal.RealizarCheckoutAutomatico();
        }
        #endregion
    }
}
