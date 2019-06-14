using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedoresDAL : IEntityCRUD<Fornecedores>
    {
        public string Atualizar(Fornecedores fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update fornecedores set nomeempresa = @nomeempresa, cnpj = @cnpj, " +
                "nome = @nome, telefone = @telefone, email = @email where id = @id";
            command.Parameters.AddWithValue("@nomeempresa", fornecedor.NomeEmpresa);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@email", fornecedor.Email);

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

            return "Fornecedor atualizado com sucesso!";
        }

        public string Excluir(Fornecedores fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", fornecedor.ID);

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

            return "Cidade deletada do sistema com sucesso!";
        }

        public string Inserir(Fornecedores fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into administradores (nomeempresa, cnpj, nome, telefone, email) values (@nomeempresa, @cnpj, @nome, @telefone, @email)";
            command.Parameters.AddWithValue("@nomeempresa", fornecedor.NomeEmpresa);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@email", fornecedor.Email);

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

        public Fornecedores LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Fornecedores f = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    f = new Fornecedores(id, nomeempresa, cnpj, nome, telefone, email);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return f;
        }

        public List<Fornecedores> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores";
            command.Connection = connection;

            List<Fornecedores> fornecedores = new List<Fornecedores>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedores fornecedor = new Fornecedores(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
    }
}
