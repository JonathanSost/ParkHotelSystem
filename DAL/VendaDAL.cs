using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendaDAL : IEntityCRUD<Vendas>
    {
        #region Atualizar
        public string Atualizar(Vendas venda)
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
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Venda atualizada com sucesso!";
        }
        #endregion

        #region Excluir
        public string Excluir(Vendas venda)
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
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Venda deletada do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public string Inserir(Vendas venda)
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
        public Vendas LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from vendas where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Vendas v = null;

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
        public List<Vendas> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from vendas";
            command.Connection = connection;

            List<Vendas> vendas = new List<Vendas>();

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
    }
}
