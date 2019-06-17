using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CidadesBLL
    {
        CidadeDAL dal = new CidadeDAL();

        public List<Cidades> LerPorEstado(int idestado)
        {
            return dal.LerPorEstado(idestado);
        }
    }
}
