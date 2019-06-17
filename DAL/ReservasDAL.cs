using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservasDAL : IEntityCRUD<Reservas>
    {
        public string Atualizar(Reservas reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update quartos set  where id = @id";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Produto atualizado com sucesso!";
        }

        public string Excluir(Reservas item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Reservas item)
        {
            throw new NotImplementedException();
        }

        public Reservas LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservas> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
