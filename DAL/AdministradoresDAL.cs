using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdministradoresDAL : IEntityCRUD<Administradores>
    {
        public string Atualizar(Administradores item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Administradores item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Administradores admin)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into administradores (nome, cpf, rg, endereco, telefone, email, senha) values (@nome, @cpf, @rg, @endereco, @telefone, @email, @senha)";
            command.Parameters.AddWithValue("@nome", admin.Nome);
            command.Parameters.AddWithValue("@cpf", admin.CPF);
            command.Parameters.AddWithValue("@rg", admin.RG);
            command.Parameters.AddWithValue("@endereco", admin.Endereco);
            command.Parameters.AddWithValue("@telefone", admin.Telefone);
            command.Parameters.AddWithValue("@email", admin.Email);
            command.Parameters.AddWithValue("@senha", admin.Email);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains(" "))
                {

                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Admin cadastrado com sucesso!";
        }

        public Administradores LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Administradores> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
