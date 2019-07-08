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

            command.CommandText = @"update produtos set nome = @nome, descricao = @descricao,
                precound = @precound, estoque = @estoque, idfornecedor = @idfornecedor, status = @status,
                datadetransferencia = @datadetransferencia where id = @id";
            command.Parameters.AddWithValue("@id", produto.ID);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);
            command.Parameters.AddWithValue("@idfornecedor", produto.IdFornecedor);
            command.Parameters.AddWithValue("@status", produto.Status);
            command.Parameters.AddWithValue("@datadetransferencia", produto.DataDeTransferencia);

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
            response.Message = "Produto atualizado com sucesso!";
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

            command.CommandText = "insert into produtos (nome, descricao, precound, estoque, idfornecedor, status, datadetransferencia) values (@nome, @descricao, @precound, @estoque, @idfornecedor, @status, @datadetransferencia)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);
            command.Parameters.AddWithValue("@idfornecedor", produto.IdFornecedor);
            command.Parameters.AddWithValue("@status", produto.Status);
            command.Parameters.AddWithValue("@datadetransferencia", produto.DataDeTransferencia);

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
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    p = new Produto(id, nome, descricao, estoque, precound, idfornecedor, status, datadetransferencia);
                }
            }
            catch(Exception ex)
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
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresa', p.status, p.datadetransferencia
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
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    Produto produto = new Produto(id, nome, descricao, estoque, precound, idfornecedor, status, datadetransferencia);
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

        #region Ler Produtos
        public List<ProdutoViewModel> LerProdutos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By ID)
        public List<ProdutoViewModel> LerProdutosByID()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.id";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By ID Desc)
        public List<ProdutoViewModel> LerProdutosByIDDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.id desc";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Name)
        public List<ProdutoViewModel> LerProdutosByName()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.nome";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Name Desc)
        public List<ProdutoViewModel> LerProdutosByNameDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.nome desc";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Preço)
        public List<ProdutoViewModel> LerProdutosByPreco()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.precound";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Preço Desc)
        public List<ProdutoViewModel> LerProdutosByPrecoDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.precound desc";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Estoque)
        public List<ProdutoViewModel> LerProdutosByEstoque()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.estoque";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Produtos (Order By Estoque Desc)
        public List<ProdutoViewModel> LerProdutosByEstoqueDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id order by p.estoque desc";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Entrada de Produtos
        public List<ProdutoViewModel> LerProdutosEntrada()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where p.status = 'Entrada'";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Ler Saída de Produtos
        public List<ProdutoViewModel> LerProdutosSaida()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where p.status = 'Saída'";

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Nome
        public List<ProdutoViewModel> PesquisarPorNome(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where p.nome like @Nome";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Descrição
        public List<ProdutoViewModel> PesquisarPorDescricao(string Descricao)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto', p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where descricao like @Descricao";

            command.Parameters.AddWithValue("@Descricao", "%" + Descricao + "%");

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Preços Menores
        public List<ProdutoViewModel> PesquisarPorPrecosMenores(double preco)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where precound < @preco";

            command.Parameters.AddWithValue("@preco", preco);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Preços Iguais
        public List<ProdutoViewModel> PesquisarPorPrecosIguais(double preco)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where precound = @preco";

            command.Parameters.AddWithValue("@preco", preco);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Preços Maiores
        public List<ProdutoViewModel> PesquisarPorPrecosMaiores(double preco)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where precound > @preco";

            command.Parameters.AddWithValue("@preco", preco);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Estoques Menores
        public List<ProdutoViewModel> PesquisarPorEstoquesMenores(int Estoque)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where estoque < @estoque";

            command.Parameters.AddWithValue("@estoque", Estoque);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Estoques Iguais
        public List<ProdutoViewModel> PesquisarPorEstoquesIguais(int Estoque)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where estoque = @estoque";

            command.Parameters.AddWithValue("@estoque", Estoque);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Pesquisar Por Estoques Maiores
        public List<ProdutoViewModel> PesquisarPorEstoquesMaiores(int Estoque)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora', p.status, p.datadetransferencia 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where estoque > @estoque";

            command.Parameters.AddWithValue("@estoque", Estoque);

            command.Connection = connection;

            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDProduto"]);

                    string nome = Convert.ToString(reader["NomeProduto"]);
                    string descricao = Convert.ToString(reader["DescricaoProduto"]);
                    double precound = Convert.ToDouble(reader["PreçoUnidade"]);
                    int estoque = Convert.ToInt32(reader["Estoque"]);
                    int idfornecedor = Convert.ToInt32(reader["IDFornecedor"]);
                    string nomefornecedor = Convert.ToString(reader["NomeEmpresaFornecedora"]);
                    string status = Convert.ToString(reader["STATUS"]);
                    DateTime datadetransferencia = Convert.ToDateTime(reader["DATADETRANSFERENCIA"]);

                    ProdutoViewModel p = new ProdutoViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        Descricao = descricao,
                        Preco = precound,
                        Estoque = estoque,
                        IdFornecedor = idfornecedor,
                        NomeEmpresaFornecedora = nomefornecedor,
                        Status = status,
                        DataDeTransferencia = datadetransferencia
                    };
                    produtos.Add(p);
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
        #endregion

        #region Trazer Preço do Produto
        public double TrazerPrecoProduto(int idproduto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select precound from produtos where id = @id";
            command.Parameters.AddWithValue("@id", idproduto);
            command.Connection = connection;

            double preco = 0;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    preco = Convert.ToDouble(reader["PRECOUND"]);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return preco;
        }
        #endregion

        #region Trazer Estoque do Produto
        public int TrazerEstoqueProduto(int idproduto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select estoque from produtos where id = @id";
            command.Parameters.AddWithValue("@id", idproduto);
            command.Connection = connection;

            int estoque = 0;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    estoque = Convert.ToInt32(reader["ESTOQUE"]);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return estoque;
        }
        #endregion

        #region Atualizar Estoque do Produto
        public MessageResponse AtualizarEstoqueProduto(int idproduto, int estoque)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command1 = new SqlCommand();
            command1.CommandText = @"update produtos set estoque = @estoque where id = @idproduto";
            command1.Parameters.AddWithValue("@idproduto", idproduto);
            command1.Parameters.AddWithValue("@estoque", estoque);
            command1.Connection = connection;

            try
            {
                connection.Open();
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Algo inesperado aconteceu.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
            response.Success = true;
            response.Message = "Estoque atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Trazer Por Nome
        public int TrazerPorNome(string nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select id from produtos where nome = @nome";
            command.Parameters.AddWithValue("@nome", nome);
            command.Connection = connection;

            int id = 0;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return id;
        }
        #endregion
    }
}
