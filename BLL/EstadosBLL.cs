using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstadosBLL
    {
        EstadoDAL dal = new EstadoDAL();
        public List<Estado> LerTodos()
        {
            return dal.LerTodos();
        }
    }
}
