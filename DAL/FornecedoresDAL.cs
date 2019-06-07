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
        public string Atualizar(Fornecedores item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Fornecedores item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Fornecedores> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
