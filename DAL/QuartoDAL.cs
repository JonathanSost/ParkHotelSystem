using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class QuartoDAL 
    {
        MessageResponse response = new MessageResponse();
        #region Atualizar
        public MessageResponse Atualizar(Quarto quarto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update quartos set preco = @preco, tipo = @tipo, disponivel = @disponivel where id = @id";
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
            response.Message = "Quarto atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Quarto quarto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from quartos where id = @id";
            command.Parameters.AddWithValue("@id", quarto.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
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
            response.Message = "Quarto deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Quarto quarto)
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
            response.Message = "Quarto cadastrado no sistema com sucesso!";
            return response;
        }
        #endregion

        public List<QuartoViewModel> LerQuartos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select q.id 'IDQuarto', q.preco 'PreçoQuarto', t.tipostring 'TipoQuarto', 
                                    q.disponivel 'Disponivel' from quartos inner join tipos t on q.tipo = t.id";

            command.Connection = connection;

            List<QuartoViewModel> quartos = new List<QuartoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDQuarto"]);

                    double preco = Convert.ToDouble(reader["PreçoQuarto"]);
                    string tipoquarto = Convert.ToString(reader["TipoQuarto"]);
                    bool disponivel = Convert.ToBoolean(reader["Disponivel"]);

                    QuartoViewModel quarto = new QuartoViewModel()
                    {
                        ID = id,
                        Preco = preco,
                        Tipo = tipoquarto,
                        Disponivel = disponivel
                    };
                    quartos.Add(quarto);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return quartos;
        }

        #region Ler Por ID
        public Quarto LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from quartos where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Quarto q = null;

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
                    bool disponivel = Convert.ToBoolean(reader["DISPONIVEL"]);
                    q = new Quarto(id, preco, tipo, disponivel);
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
        #endregion

        #region Ler Todos
        public List<Quarto> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from quartos";
            command.Connection = connection;

            List<Quarto> quartos = new List<Quarto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    double preco = Convert.ToDouble(reader["PRECO"]);
                    string tipo = Convert.ToString(reader["TIPO"]);
                    bool disponivel = Convert.ToBoolean(reader["DISPONIVEL"]);
                    Quarto quarto = new Quarto(id, preco, tipo, disponivel);
                    quartos.Add(quarto);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return quartos;
        }
        #endregion

        #region Verificar Existência do Quarto
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
        #endregion
    }
}
