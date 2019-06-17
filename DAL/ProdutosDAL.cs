using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutosDAL : IEntityCRUD<Produtos>
    {
        #region Atualizar
        public string Atualizar(Produtos produto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update produtos set nome = @nome, descricao = @descricao, precound = @precound, estoque = @estoque where id = @id";
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
        #endregion

        #region Excluir
        public string Excluir(Produtos produto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from produtos where id = @id";
            command.Parameters.AddWithValue("@id", produto.ID);

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

            return "Produto deletado do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public string Inserir(Produtos produto)
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
        #endregion

        #region Ler Por ID
        public Produtos LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from produtos where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Produtos p = null;

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
                    string descricao = Convert.ToString(reader["DESCRICAO"]);
                    int estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    double precound = Convert.ToDouble(reader["PRECOUND"]);

                    p = new Produtos(id, nome, descricao, estoque, precound);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return p;
        }
        #endregion

        #region Ler Todos
        public List<Produtos> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from produtos";
            command.Connection = connection;

            List<Produtos> produtos = new List<Produtos>();

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
                    string descricao = Convert.ToString(reader["DESCRICAO"]);
                    int estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    double precound = Convert.ToDouble(reader["PRECOUND"]);

                    Produtos produto = new Produtos(id, nome, descricao, estoque, precound);
                    produtos.Add(produto);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return produtos;
        }
        #endregion
    }
}
