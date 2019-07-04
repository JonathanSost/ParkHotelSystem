using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VendaBLL
    {
        VendaDAL dal = new VendaDAL();
        MessageResponse response = new MessageResponse();
        List<string> erros = new List<string>();

        #region Cadatrar
        public MessageResponse Cadastrar(Venda venda)
        {
            if (venda.Quantidade < 1)
            {
                erros.Add("Quantidade Requisitada Inválida.");
            }
            if (venda.DataDeVenda.ToString("dd/MM/yyyy - HH:mm") != DateTime.Now.ToString("dd/MM/yyyy - HH:mm"))
            {
                erros.Add("Você está a frente do seu tempo.");
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
            return dal.Inserir(venda);
        }
        #endregion

        #region Atualizar
        public MessageResponse Atualizar(Venda venda)
        {
            if (!dal.VerificarExistenciaVenda(venda.IDVenda))
            {
                response.Success = false;
                response.Message = "Venda inexistente";
                return response;
            }

            if (venda.Quantidade < 1)
            {
                erros.Add("Quantidade Requisitada Inválida.");
            }
            if (venda.DataDeVenda.ToString("dd/MM/yyyy - HH:mm") != DateTime.Now.ToString("dd/MM/yyyy - HH:mm"))
            {
                erros.Add("Você está a frente do seu tempo.");
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
            return dal.Inserir(venda);
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Venda venda)
        {
            if (!dal.VerificarExistenciaVenda(venda.IDVenda))
            {
                response.Success = false;
                response.Message = "Venda inexistente!";
                return response;
            }
            response = dal.Excluir(venda);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Venda LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        public List<Venda> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion
    }
}
