using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuartosDAL : IEntityCRUD<Quartos>
    {
        public string Atualizar(Quartos item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Quartos item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Quartos item)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into produtos (nome, descricao, precound, estoque) values (@nome, @descricao, @precound, @estoque)";
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

            return "";
        }

        public Quartos LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Quartos> LerTodos()
        {
            throw new NotImplementedException();
        }

        public bool VerificarExistenciaQuarto(int idquarto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from quartos where id = @id";
            command.Parameters.AddWithValue("@id", idquarto);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                return reader.Read();
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return false;
        }
    }
}
