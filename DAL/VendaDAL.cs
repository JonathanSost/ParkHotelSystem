using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendaDAL 
    {
        MessageResponse response = new MessageResponse();

        #region Atualizar
        public MessageResponse Atualizar(Venda venda)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update vendas set datadevenda = @datadevenda, funcionario = @funcionario, " +
                "cliente = @cliente, produto = @produto, quantidade = @quantidade, valor = @valor where id = @id";
            command.Parameters.AddWithValue("@datadevenda", venda.DataDeVenda);
            command.Parameters.AddWithValue("@funcionario", venda.IdCliente);
            command.Parameters.AddWithValue("@cliente", venda.IdCliente);
            command.Parameters.AddWithValue("@produto", venda.Produto);
            command.Parameters.AddWithValue("@quantidade", venda.Quantidade);
            command.Parameters.AddWithValue("@valor", venda.Valor);

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
            response.Message = "Venda atualizada com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Venda venda)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from vendas where id = @id";
            command.Parameters.AddWithValue("@id", venda.IDVenda);

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
            response.Message = "Venda deletada do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Venda venda)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into vendas (datadevenda, funcionario, cliente, produto, quantidade, valor) values " +
                "(@datadevenda, @funcionario, @cliente, @produto, @quantidade, @valor)";
            command.Parameters.AddWithValue("@datadevenda", venda.DataDeVenda);
            command.Parameters.AddWithValue("@funcionario", venda.IdFuncionario);
            command.Parameters.AddWithValue("@cliente", venda.IdCliente);
            command.Parameters.AddWithValue("@produto", venda.Produto);
            command.Parameters.AddWithValue("@quantidade", venda.Quantidade);
            command.Parameters.AddWithValue("@valor", venda.Valor);

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
            response.Message = "Venda cadastrada no sistema com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Venda LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from vendas where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Venda v = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];

                    //v = new Vendas();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return v;
        }
        #endregion

        #region Ler Todos
        public List<Venda> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from vendas";
            command.Connection = connection;

            List<Venda> vendas = new List<Venda>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];

                    //Vendas venda = new Vendas();
                    //vendas.Add(venda);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return vendas;
        }
        #endregion

        #region Verificar Existência da Venda
        public bool VerificarExistenciaVenda(int idVenda)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from vendas where id = @id";
            command.Parameters.AddWithValue("@id", idVenda);
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

        #region Ler Vendas
        public List<VendaViewModel> LerVendas()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select v.id 'IDVenda', v.funcionario 'IDFuncionario', f.nome 'NomeFuncionario', 
                                  v.cliente 'IDCliente', cli.nome 'NomeCliente', v.datadevenda 'DataDeSaída', v.quantidade 'Quantidade', 
                                  v.valor 'Valor', v.produto 'IDProduto', p.nome 'NomeProduto' from vendas v inner join funcionarios f on v.funcionario = f.id
                                  inner join clientes cli on v.cliente = cli.id inner join produtos p on v.produto = p.id";

            command.Connection = connection;

            List<VendaViewModel> vendas = new List<VendaViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDVenda"]);

                    int idfuncionario = Convert.ToInt32(reader["IDFuncionario"]);
                    string nomefuncionario = Convert.ToString(reader["NomeFuncionario"]);
                    int idcliente = Convert.ToInt32(reader["IDCliente"]);
                    string nomecliente = Convert.ToString(reader["NomeCliente"]);
                    DateTime datadesaida = Convert.ToDateTime(reader["DataDeSaída"]);
                    int quantidade = Convert.ToInt32(reader["Quantidade"]);
                    double valor = Convert.ToDouble(reader["Valor"]);
                    int idproduto = Convert.ToInt32(reader["IDProduto"]);
                    string nomeproduto = Convert.ToString(reader["NomeProduto"]);

                    VendaViewModel venda = new VendaViewModel()
                    {
                        IDVenda = id,
                        IDFuncionario = idfuncionario,
                        NomeFuncionario = nomefuncionario,
                        IDCliente = idcliente,
                        NomeCliente = nomecliente,
                        DataDeVenda = datadesaida,
                        Quantidade = quantidade,
                        Valor = valor,
                        IDProduto = idproduto,
                        NomeProduto = nomeproduto
                    };
                    vendas.Add(venda);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return vendas;
        }
        #endregion

        #region Ler Vendas (Order By ID)
        public List<VendaViewModel> LerVendasByID()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select v.id 'IDVenda', v.funcionario 'IDFuncionario', f.nome 'NomeFuncionario', 
                                  v.cliente 'IDCliente', cli.nome 'NomeCliente', v.datadevenda 'DataDeSaída', v.quantidade 'Quantidade', 
                                  v.valor 'Valor', v.produto 'IDProduto', p.nome 'NomeProduto' from vendas v inner join funcionarios f on v.funcionario = f.id
                                  inner join clientes cli on v.cliente = cli.id inner join produtos p on v.produto = p.id order by v.id";

            command.Connection = connection;

            List<VendaViewModel> vendas = new List<VendaViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDVenda"]);

                    int idfuncionario = Convert.ToInt32(reader["IDFuncionario"]);
                    string nomefuncionario = Convert.ToString(reader["NomeFuncionario"]);
                    int idcliente = Convert.ToInt32(reader["IDCliente"]);
                    string nomecliente = Convert.ToString(reader["NomeCliente"]);
                    DateTime datadesaida = Convert.ToDateTime(reader["DataDeSaída"]);
                    int quantidade = Convert.ToInt32(reader["Quantidade"]);
                    double valor = Convert.ToDouble(reader["Valor"]);
                    int idproduto = Convert.ToInt32(reader["IDProduto"]);
                    string nomeproduto = Convert.ToString(reader["NomeProduto"]);

                    VendaViewModel venda = new VendaViewModel()
                    {
                        IDVenda = id,
                        IDFuncionario = idfuncionario,
                        NomeFuncionario = nomefuncionario,
                        IDCliente = idcliente,
                        NomeCliente = nomecliente,
                        DataDeVenda = datadesaida,
                        Quantidade = quantidade,
                        Valor = valor,
                        IDProduto = idproduto,
                        NomeProduto = nomeproduto
                    };
                    vendas.Add(venda);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return vendas;
        }
        #endregion

        #region Ler Vendas (Order By ID Desc)
        public List<VendaViewModel> LerVendasByIDDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select v.id 'IDVenda', v.funcionario 'IDFuncionario', f.nome 'NomeFuncionario', 
                                  v.cliente 'IDCliente', cli.nome 'NomeCliente', v.datadevenda 'DataDeSaída', v.quantidade 'Quantidade', 
                                  v.valor 'Valor', v.produto 'IDProduto', p.nome 'NomeProduto' from vendas v inner join funcionarios f on v.funcionario = f.id
                                  inner join clientes cli on v.cliente = cli.id inner join produtos p on v.produto = p.id order by v.id desc";

            command.Connection = connection;

            List<VendaViewModel> vendas = new List<VendaViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["IDVenda"]);

                    int idfuncionario = Convert.ToInt32(reader["IDFuncionario"]);
                    string nomefuncionario = Convert.ToString(reader["NomeFuncionario"]);
                    int idcliente = Convert.ToInt32(reader["IDCliente"]);
                    string nomecliente = Convert.ToString(reader["NomeCliente"]);
                    DateTime datadesaida = Convert.ToDateTime(reader["DataDeSaída"]);
                    int quantidade = Convert.ToInt32(reader["Quantidade"]);
                    double valor = Convert.ToDouble(reader["Valor"]);
                    int idproduto = Convert.ToInt32(reader["IDProduto"]);
                    string nomeproduto = Convert.ToString(reader["NomeProduto"]);

                    VendaViewModel venda = new VendaViewModel()
                    {
                        IDVenda = id,
                        IDFuncionario = idfuncionario,
                        NomeFuncionario = nomefuncionario,
                        IDCliente = idcliente,
                        NomeCliente = nomecliente,
                        DataDeVenda = datadesaida,
                        Quantidade = quantidade,
                        Valor = valor,
                        IDProduto = idproduto,
                        NomeProduto = nomeproduto
                    };
                    vendas.Add(venda);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return vendas;
        }
        #endregion

    }
}
