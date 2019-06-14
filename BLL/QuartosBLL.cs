using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuartosBLL
    {
        private QuartosDAL dal = new QuartosDAL();
        public string Cadastrar (Quartos qua)
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
    }
}
