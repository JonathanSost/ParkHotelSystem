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
        #region Atualizar
        public MessageResponse Atualizar(Tipo tipo)
        {
            return dal.Atualizar(tipo);
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
            return dal.Inserir(tipo);
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

        #region Pesquisar Por Tipo
        public List<Tipo> PesquisarPorTipo(string tipo)
        {
            return dal.PesquisarPorTipo(tipo);
        }
        #endregion
    }
}
