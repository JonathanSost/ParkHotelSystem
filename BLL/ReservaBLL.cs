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
        QuartoBLL qbll = new QuartoBLL();


        #region Cadastrar
        public MessageResponse Cadastrar(Reserva reserva)
        {
            ClienteBLL clibll = new ClienteBLL();
            if (clibll.ChecarAtivos(reserva.IDCliente))
            {
                erros.Add("A reserva não pôde ser concluída pois o cliente em questão já está em uma reserva.");
            }

            else if (qbll.ChecarDisponiveis(reserva.IDQuarto))
            {
                erros.Add("Quarto indisponivel.");
            }
            else
            {
                if (reserva.CheckIn.Day == reserva.CheckOut.Day)
                {
                    erros.Add("Você deve ficar no mínimo 1 dia no Hotel Santo Soninho.");
                }
                else if (reserva.CheckIn.Day > reserva.CheckOut.Day)
                {
                    erros.Add("Data de Saída inválida.");
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

        #region Ler Reservas
        public List<ReservaViewModel> LerReservas()
        {
            return dal.LerReservas();
        }
        #endregion

        #region Ler Reservas (Order By ID)
        public List<ReservaViewModel> LerReservasByID()
        {
            return dal.LerReservasByID();
        }
        #endregion

        #region Ler Reservas (Order By ID Desc)
        public List<ReservaViewModel> LerReservasByIDDesc()
        {
            return dal.LerReservasByIDDesc();
        }
        #endregion

        #region LerReservasExpiradas
        public List<ReservaViewModel> LerReservasExpiradas(DateTime agora)
        {
            return dal.LerReservasExpiradas(agora);
        }
        #endregion

        #region Checar Reservas Expiradas
        public bool ChecarReservasExpiradas(DateTime agora)
        {
            return dal.ChecarReservasExpiradas(agora);
        }
        #endregion

        #region Realizar Check-Out Automático
        public void RealizarCheckoutAutomatico()
        {
            dal.RealizarCheckoutAutomatico();
        }
        #endregion

        #region Realizar Check-In
        public void RealizarCheckin(int idquarto, int idcliente)
        {
            dal.RealizarCheckin(idquarto, idcliente);
        }
        #endregion

        #region Realizar Check-Out
        public MessageResponse RealizarCheckOut(int idquarto, int idcliente)
        {
            return dal.RealizarCheckOut(idquarto, idcliente);
        }
        #endregion
    }
}
