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
        List<string> erros = new List<string>();
        QuartoDAL dal = new QuartoDAL();
        MessageResponse response = new MessageResponse();

        #region Cadastrar
        public MessageResponse Cadastrar (Quarto quarto)
        {
            if (quarto.Preco < 0)
            {
                erros.Add("Preço do quarto inválido.");
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

        #region Ler Quartos
        public List<QuartoViewModel> LerQuartos()
        {
            return dal.LerQuartos();
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

        #region Verificar Existência do Quarto
        public bool VerificarExistenciaQuarto(int idquarto)
        {
            return dal.VerificarExistenciaQuarto(idquarto);
        }
        #endregion

        #region Pesquisar Por Preços Menores
        public List<QuartoViewModel> PesquisarPorPrecosMenores(double Preco)
        {
            return dal.PesquisarPorPrecosMenores(Preco);
        }
        #endregion

        #region Pesquisar Preços Iguais
        public List<QuartoViewModel> PesquisarPorPrecosIguais(double Preco)
        {
            return dal.PesquisarPorPrecosIguais(Preco);
        }
        #endregion

        #region Pesquisar Por Preços Maiores
        public List<QuartoViewModel> PesquisarPorPrecosMaiores(double Preco)
        {
            return dal.PesquisarPorPrecosMaiores(Preco);
        }
        #endregion

        #region Pesquisar Por Tipo
        public List<QuartoViewModel> PesquisarPorTipo(int Tipo)
        {
            return dal.PesquisarPorTipo(Tipo);
        }
        #endregion

        #region Pesquisar Por Disponíveis
        public List<QuartoViewModel> PesquisarPorDisponiveis(bool Disponivel)
        {
            return dal.PesquisarPorDisponiveis(Disponivel);
        }
        #endregion
    }
}
