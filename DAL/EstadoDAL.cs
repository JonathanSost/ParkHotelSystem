using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstadoDAL : IEntityCRUD<Estados>
    {
        public string Atualizar(Estados item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Estados item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Estados estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into estados (sigla, nome) values (@sigla, @nome)";
            command.Parameters.AddWithValue("@sigla", estado.Sigla);
            command.Parameters.AddWithValue("@nome", estado.Nome);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "";
        }

        public Estados LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estados> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
