using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VendasBLL
    {
        VendasDAL dal = new VendasDAL();
        List<string> erros = new List<string>();

        public string Cadastrar(Vendas ven)
        {
            if (ven.Quantidade < 1)
            {
                erros.Add("Quantidade Requisitada Inválida.");
            }
            if (ven.DataDeVenda != DateTime.Now)
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
                return builder.ToString();
            }
            return dal.Inserir(ven);
        }

        public string Atualizar(Vendas venda)
        {
            return dal.Atualizar(venda);
        }

        public string Excluir(Vendas venda)
        {
            return dal.Excluir(venda);
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
