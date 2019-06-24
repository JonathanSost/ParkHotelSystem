﻿using DAL;
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

        List<string> erros = new List<string>();

        public string Cadastrar(Reservas res)
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
                return builder.ToString();
            }
            return dal.Inserir(res);
        }

        public string Atualizar(Reservas reserva)
        {
            return dal.Atualizar(reserva);
        }

        public string Excluir(Reservas reserva)
        {
            return dal.Excluir(reserva);
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