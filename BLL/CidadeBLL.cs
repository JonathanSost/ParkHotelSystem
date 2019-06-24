using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CidadeBLL
    {
        CidadeDAL dal = new CidadeDAL();

        public string Atualizar(Cidade cidade)
        {
            return dal.Atualizar(cidade);
        }

        public string Excluir(Cidade cidade)
        {
            return dal.Excluir(cidade);
        }

        public string Inserir(Cidade cidade)
        {
            return dal.Inserir(cidade);
        }

        public Cidade LerPorID(int id)
        {
            return dal.LerPorID(id);
        }

        public List<Cidade> LerTodos()
        {
            return dal.LerTodos();
        }

        public List<Cidade> LerParecidos(Cidade cidade)
        {
            return dal.LerParecidos(cidade);
        }

        public bool VerificarExistenciaCidade(int idCidade)
        {
            return dal.VerificarExistenciaCidade(idCidade);
        }

        public List<Cidade> LerPorEstado(int idestado)
        {
            return dal.LerPorEstado(idestado);
        }
    }
}
