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

        public string Cadastrar (Quarto qua)
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
                return builder.ToString();
            }
            return dal.Inserir(qua);
        }

        public string Atualizar(Quarto quarto)
        {
            return dal.Atualizar(quarto);
        }

        public string Excluir(Quarto quarto)
        {
            return dal.Excluir(quarto);
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
