using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {

        ProdutoDAL dal = new ProdutoDAL();
        MessageResponse response = new MessageResponse();

        public MessageResponse Cadastrar (Produto pro)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(pro.Nome))
            {
                erros.Add("Nome do Produto deve ser informado.");
            }
            else
            {
                pro.Nome = pro.Nome.Trim();
                if (pro.Nome.Length < 2 || pro.Nome.Length > 70)
                {
                    erros.Add("Nome do Produto deve conter entre 2 e 70 caracteres.");
                }
            }
            if (pro.Estoque <= 0)
            {
                erros.Add("Quantidade de Estoque inválida.");
            }
            if (string.IsNullOrWhiteSpace(pro.Descricao))
            {
                erros.Add("Descrição do Produto deve ser informada.");
            }
            else
            {
                pro.Descricao = pro.Descricao.Trim();
                if (pro.Descricao.Length < 2 || pro.Descricao.Length > 80)
                {
                    erros.Add("Descrição do Produto deve conter entre 2 e 80 caracteres.");
                }
            }
            if (pro.Preco < 0)
            {
                erros.Add("Valor inexistente.");
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
            return dal.Inserir(pro);

            
        }

        public MessageResponse Atualizar(Produto produto)
        {
            response = dal.Atualizar(produto);
            response.Message = "Produto atualizado com sucesso!";
            return response;
        }

        public MessageResponse Excluir(Produto produto)
        {
            response = dal.Excluir(produto);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }

       

        public Produto LerPorID(int id)
        {
            return dal.LerPorID(id);
        }

        public List<Produto> LerTodos()
        {
            return dal.LerTodos();
        }
    }
}
