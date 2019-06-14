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
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Estados est = new Estados(0, "", "");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string sigla = Convert.ToString(reader["SIGLA"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    Estados estado = new Estados(id, sigla, nome);
                    est = estado;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return est;
        }

        public List<Estados> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados";
            command.Connection = connection;

            List<Estados> estados = new List<Estados>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string sigla = Convert.ToString(reader["SIGLA"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    Estados estado = new Estados(id, sigla, nome);
                    estados.Add(estado);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return estados;
        }

        public bool VerificarExistenciaEstado(string estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados where nome = @nome";
            command.Parameters.AddWithValue("@nome", estado);
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
