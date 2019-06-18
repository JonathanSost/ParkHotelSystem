using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CidadeDAL : IEntityCRUD<Cidades>
    {
        #region Atualizar
        public string Atualizar(Cidades cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update cidades set nome = @nome where id = @id";
            command.Parameters.AddWithValue("@nome", cidade.Nome);
            command.Parameters.AddWithValue("@id", cidade.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK"))
                {
                    return "Estado inválido!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Cidade atualizada com sucesso!";
        }
        #endregion

        #region Excluir
        public string Excluir(Cidades cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from cidades where id = @id";
            command.Parameters.AddWithValue("@id", cidade.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK"))
                {
                    return "Estado inválido!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Cidade deletada do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public string Inserir(Cidades cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into cidades (nome, estado) values (@nome, @estado)";
            command.Parameters.AddWithValue("@nome", cidade.Nome);
            command.Parameters.AddWithValue("@estado", cidade.Estado.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK"))
                {
                    return "Estado inválido!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Cidade cadastrada com sucesso!";
        }
        #endregion

        #region Ler Por ID
        public Cidades LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Cidades c = new Cidades(0, "", new Estado(0, "", ""));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nome = Convert.ToString(reader["NOME"]);
                    Cidades cidade = new Cidades(id, nome, new Estado((int)reader["ESTADO"], "", ""));
                    c = cidade;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return c;
        }
        #endregion

        #region Ler Todos
        public List<Cidades> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades";
            command.Connection = connection;

            List<Cidades> cidades = new List<Cidades>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nome = Convert.ToString(reader["NOME"]);
                    Cidades cidade = new Cidades(id, nome, new Estado((int)reader["ESTADO"], "", ""));
                    cidades.Add(cidade);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return cidades;
        }
        #endregion

        #region Ler Parecidos
        public List<Cidades> LerParecidos(Cidades cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades where nome like '%@nome%'";
            command.Parameters.AddWithValue("@nome", cidade.Nome);
            command.Connection = connection;

            List<Cidades> cidades = new List<Cidades>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nome = Convert.ToString(reader["NOME"]);
                    cidades.Add(cidade);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return cidades;
        }
        #endregion

        #region Verificar Existência da Cidade
        public bool VerificarExistenciaCidade(int idCidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades where id = @id";
            command.Parameters.AddWithValue("@id", idCidade);
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

        #region Ler Por Estado
        public List<Cidades> LerPorEstado(int idestado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades c inner join estados e on c.estado = e.id where e.id = @id";
            command.Parameters.AddWithValue("@id", idestado);

            command.Connection = connection;

            List<Cidades> cidades = new List<Cidades>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nome = Convert.ToString(reader["NOME"]);
                    Cidades cidade = new Cidades(id, nome, new Estado((int)reader["ESTADO"], "", ""));
                    cidades.Add(cidade);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return cidades;
        }
        #endregion
    }
}
