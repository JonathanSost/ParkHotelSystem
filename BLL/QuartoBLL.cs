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

        #region Cadastrar
        public MessageResponse Cadastrar (Quarto quarto)
        {
            List<string> erros = new List<string>();

            if (quarto.Preco < 0)
            {
                erros.Add("Preço do quarto inválido.");
            }
            if (string.IsNullOrWhiteSpace(quarto.Tipo))
            {
                erros.Add("Tipo do Quarto deve ser informado.");
            }
            if (!quarto.QuartoDisponivel)
            {
                erros.Add("Quarto Indisponível");
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
            return dal.Inserir(quarto);
        }
        #endregion

        #region Atualizar
        public MessageResponse Atualizar(Quarto quarto)
        {
            List<string> erros = new List<string>();

            if (dal.VerificarExistenciaQuarto(quarto.ID))
            {
                response.Success = false;
                response.Message = "Quarto inexistente!";
                return response;
            }

            if (quarto.Preco < 0)
            {
                erros.Add("Preço do quarto inválido.");
            }
            if (string.IsNullOrWhiteSpace(quarto.Tipo))
            {
                erros.Add("Tipo do Quarto deve ser informado.");
            }
            if (!quarto.QuartoDisponivel)
            {
                erros.Add("Quarto Indisponível");
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
            return dal.Inserir(quarto);
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Quarto quarto)
        {
            if (dal.VerificarExistenciaQuarto(quarto.ID))
            {
                response.Success = false;
                response.Message = "Quarto inexistente!";
                return response;
            }
            response = dal.Excluir(quarto);
            return response;
        }
        #endregion

        #region Ler Por ID
        public Quarto LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        public List<Quarto> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion
    }
}
