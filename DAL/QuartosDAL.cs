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
        public string Atualizar(Quartos quarto)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Quartos quarto)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Quartos quarto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into produtos (preco, tipo, disponivel) values (@preco, @tipo, @disponivel)";
            command.Parameters.AddWithValue("@preco", quarto.Preco);
            command.Parameters.AddWithValue("@tipo", quarto.Tipo);
            command.Parameters.AddWithValue("@disponivel", quarto.QuartoDisponivel);

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
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from quartos where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Quartos q = new Quartos(0, 0, "");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    double preco = Convert.ToDouble(reader["PRECO"]);
                    string tipo = Convert.ToString(reader["TIPO"]);
                    q = new Quartos(id, preco, tipo);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return q;
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
