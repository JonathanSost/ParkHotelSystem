using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuartoBLL
    {
        private QuartoDAL dal = new QuartoDAL();
        MessageResponse response = new MessageResponse();

        public MessageResponse Cadastrar (Quarto qua)
        {
            
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(qua.Tipo))
            {
                erros.Add("Tipo do Quarto deve ser informado.");
            }
            if (!qua.QuartoDisponivel)
            {
                erros.Add("Quarto Indisponível");
            }

            if (!dal.VerificarExistenciaQuarto(qua.ID))
            {
                erros.Add("Quarto Inexistente!");
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
            return dal.Inserir(qua);
        }

        public MessageResponse Atualizar(Quarto quarto)
        {
            response = dal.Atualizar(quarto);
            response.Message = "Produto atualizado com sucesso!";
            return response;
        }

        public MessageResponse Excluir(Quarto quarto)
        {
            response = dal.Excluir(quarto);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }

        public Quarto LerPorID(int id)
        {
            return dal.LerPorID(id);
        }

        public List<Quarto> LerTodos()
        {
            return dal.LerTodos();
        }
    }
}
