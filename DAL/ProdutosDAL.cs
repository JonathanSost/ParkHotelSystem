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
        public string Atualizar(Produtos item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Produtos item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Produtos produto)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into funcionarios (nome, descricao, precound, estoque) values (@nome, @descricao, @precound, @estoque)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precound", produto.Preco);
            command.Parameters.AddWithValue("@estoque", produto.est);

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

        public Produtos LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produtos> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
