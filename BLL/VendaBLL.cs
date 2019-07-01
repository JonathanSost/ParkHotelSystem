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

        public MessageResponse Cadastrar(Vendas ven)
        {
            if (ven.Quantidade < 1)
            {
                erros.Add("Quantidade Requisitada Inválida.");
            }
            if (ven.DataDeVenda.ToString("dd/MM/yyyy - HH:mm") != DateTime.Now.ToString("dd/MM/yyyy - HH:mm"))
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
            return dal.Inserir(ven);
        }

        public MessageResponse Atualizar(Vendas venda)
        {
            response = dal.Atualizar(venda);
            response.Message = "Produto atualizado com sucesso!";
            return response;
        }

        public MessageResponse Excluir(Vendas venda)
        {
            response = dal.Excluir(venda);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }

        public Vendas LerPorID(int id)
        {
            return dal.LerPorID(id);
        }

        public List<Vendas> LerTodos()
        {
            return dal.LerTodos();
        }
    }
}
