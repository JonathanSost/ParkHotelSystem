using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstadoDAL : IEntityCRUD<Estado>
    {
        #region Atualizar
        public string Atualizar(Estado estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update estados set nome = @nome, sigla = @sigla where id = @id";
            command.Parameters.AddWithValue("@nome", estado.Nome);
            command.Parameters.AddWithValue("@sigla", estado.Sigla);
            command.Parameters.AddWithValue("@id", estado.ID);

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

            return "Estado atualizado com sucesso!";
        }
        #endregion

        #region Excluir
        public string Excluir(Estado estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from estados where id = @id";
            command.Parameters.AddWithValue("@id", estado.ID);

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

            return "Estado deletado do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public string Inserir(Estado estado)
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
        #endregion

        #region Ler Por ID
        public Estado LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Estado est = new Estado(0, "", "");

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
                    Estado estado = new Estado(id, sigla, nome);
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
        #endregion

        #region Ler Todos
        public List<Estado> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados";
            command.Connection = connection;

            List<Estado> estados = new List<Estado>();

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
                    Estado estado = new Estado(id, sigla, nome);
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
        #endregion

        #region Verificar Existência de Estado
        public bool VerificarExistenciaEstado(int idEstado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from estados where id = @id";
            command.Parameters.AddWithValue("@id", idEstado);
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
        #endregion
    }
}
