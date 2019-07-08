using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoBLL
    {
        TipoDAL dal = new TipoDAL();
        MessageResponse response = new MessageResponse();
        #region Atualizar
        public MessageResponse Atualizar(Tipo tipo)
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(tipo.NomeTipo))
            {
                erros.Add("Tipo deve ser informado");
            }
            else if (tipo.NomeTipo.Length > 30)
            {
                erros.Add("Nome do tipo deve conter até 30 caracteres.");
            }
            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            response = dal.Inserir(tipo);
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Tipo tipo)
        {
            return dal.Excluir(tipo);
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Tipo tipo)
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(tipo.NomeTipo))
            {
                erros.Add("Tipo deve ser informado");
            }
            else if (tipo.NomeTipo.Length > 30)
            {
                erros.Add("Nome do tipo deve conter até 30 caracteres.");
            }
            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            response = dal.Inserir(tipo);
            return response;
        }
        #endregion

        #region Ler Por ID
        public Tipo LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        public List<Tipo> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion

        #region Ler Por Nome
        public int LerPorNome(string nome)
        {
            return dal.LerPorNome(nome);
        }
        #endregion

        #region Pesquisar Por Tipo
        public List<Tipo> PesquisarPorTipo(string tipo)
        {
            return dal.PesquisarPorTipo(tipo);
        }
        #endregion
    }
}
