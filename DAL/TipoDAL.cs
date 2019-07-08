using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoDAL
    {
        #region Atualizar
        public MessageResponse Atualizar(Tipo tipo)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            MessageResponse response = new MessageResponse();

            command.CommandText = "update tipos set tipostring = @tipostring where id = @id";
            command.Parameters.AddWithValue("@tipostring", tipo.NomeTipo);
            command.Parameters.AddWithValue("@id", tipo.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Banco de dados indisponível, favor contatar o suporte.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }

            response.Success = true;
            response.Message = "Tipo de quarto atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Tipo tipo)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            MessageResponse response = new MessageResponse();

            command.CommandText = "delete from tipos where id = @id";
            command.Parameters.AddWithValue("@id", tipo.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Banco de dados indisponível, favor contatar o suporte.";
                return response;
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            response.Success = true;
            response.Message = "Tipo deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Tipo tipo)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            MessageResponse response = new MessageResponse();

            command.CommandText = "insert into tipos (tipostring) values (@tipostring)";
            command.Parameters.AddWithValue("@tipostring", tipo.NomeTipo);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Banco de dados indisponível, favor contatar o suporte.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }

            response.Success = true;
            response.Message = "Tipo cadastrado com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Tipo LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from tipos where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Tipo tipo = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string tipostring = Convert.ToString(reader["TIPOSTRING"]);

                    tipo = new Tipo(id, tipostring);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return tipo;
        }
        #endregion

        #region Ler Todos
        public List<Tipo> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from tipos";

            command.Connection = connection;

            List<Tipo> tipos = new List<Tipo>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string tipostring = Convert.ToString(reader["TIPOSTRING"]);

                    Tipo tipo = new Tipo(id, tipostring);
                    tipos.Add(tipo);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }

            return tipos;
        }
        #endregion

        #region Ler Por Nome
        public int LerPorNome(string nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select id from tipos where tipostring = @tipostring";
            command.Parameters.AddWithValue("@tipostring", nome);
            command.Connection = connection;

            int tid = -1;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    tid = id;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return tid;
        }
        #endregion

        #region Pesquisar Por Tipo
        public List<Tipo> PesquisarPorTipo(string tipo)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from tipos where tipostring like @tipostring";
            command.Parameters.AddWithValue("@tipostring", "%" + tipo + "%");

            command.Connection = connection;

            List<Tipo> tipos = new List<Tipo>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string tipostring = Convert.ToString(reader["TIPOSTRING"]);

                    Tipo Tipo = new Tipo(id, tipostring);
                    tipos.Add(Tipo);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }

            return tipos;
        }
        #endregion
    }
}
