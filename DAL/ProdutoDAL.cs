using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL 
    {
        MessageResponse response = new MessageResponse();

        #region Atualizar
        public MessageResponse Atualizar(Produto produto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update produtos set nome = @nome, descricao = @descricao, precound = @precound, estoque = @estoque, idfornecedor = @idfornecedor where id = @id";
            command.Parameters.AddWithValue("@id", produto.ID);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);
            command.Parameters.AddWithValue("@idfornecedor", produto.IdFornecedor);

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
            response.Message =  "Produto atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Produto produto)
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
            response.Message = "Produto deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Produto produto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into produtos (nome, descricao, precound, estoque, idfornecedor) values (@nome, @descricao, @precound, @estoque, @idfornecedor)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);
            command.Parameters.AddWithValue("@idfornecedor", produto.IdFornecedor);

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
            response.Message = "Produto cadastrado no sistema com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Produto LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from produtos where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Produto p = null;

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
                    int idfornecedor = Convert.ToInt32(reader["IDFORNECEDOR"]);
                    string nomefornecedor = Convert.ToString(reader["NOMEFORNECEDOR"]);

                    p = new Produto(id, nome, descricao, estoque, precound, idfornecedor);
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
        public List<Produto> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', 
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresa'
                                  from produtos inner join fornecedores f on p.idfornecedor = f.id";
            command.Connection = connection;

            List<Produto> produtos = new List<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string descricao = Convert.ToString(reader["DESCRICAO"]);
                    int estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    double precound = Convert.ToDouble(reader["PRECOUND"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFORNECEDOR"]);

                    Produto produto = new Produto(id, nome, descricao, estoque, precound, idfornecedor);
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

        #region Verificar Existência do Produto
        public bool VerificarExistenciaProduto(int idProduto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from produtos where id = @id";
            command.Parameters.AddWithValue("@id", idProduto);
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

        public List<Produto> PesquisarPorNomeProduto(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', 
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresa' 
                                  from produtos inner join fornecedores f on p.idfornecedor = f.id where Nome = @Nome";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            command.Connection = connection;

            List<Produto> produtos = new List<Produto>();

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
                    double precound = Convert.ToDouble(reader["PRECOUND"]);
                    int estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFORNECEDOR"]);

                    //clientes.Add(cli);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return produtos;
        }
    }
}
