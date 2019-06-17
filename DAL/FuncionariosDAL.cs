using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionariosDAL : IEntityCRUD<Funcionarios>
    {
        #region Atualizar
        public string Atualizar(Funcionarios funci)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update funcionarios set nome = @nome, cpf = @cpf, rg = @rg, " +
                "endereco = @endereco, email = @email, senha = @senha, ehadm = @ehadm, where id = @id";
            command.Parameters.AddWithValue("@nome", funci.Nome);
            command.Parameters.AddWithValue("@cpf", funci.CPF);
            command.Parameters.AddWithValue("@rg", funci.RG);
            command.Parameters.AddWithValue("@end", funci.Email);
            command.Parameters.AddWithValue("@email", funci.Email);
            command.Parameters.AddWithValue("@senha", funci.Senha);
            command.Parameters.AddWithValue("@ehadm", funci.EhADM);
            command.Parameters.AddWithValue("@id", funci.ID);


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

            return "Funcionário atualizado com sucesso!";
        }
        #endregion

        #region Excluir
        public string Excluir(Funcionarios funci)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", funci.ID);

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

            return "Funcionário deletado do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public string Inserir(Funcionarios fun)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into funcionarios (nome, cpf, rg, telefone, email, senha) values (@nome, @cpf, @rg, @telefone, @email, @senha)";
            command.Parameters.AddWithValue("@nome", fun.Nome);
            command.Parameters.AddWithValue("@cpf", fun.CPF);
            command.Parameters.AddWithValue("@rg", fun.RG);
            command.Parameters.AddWithValue("@telefone", fun.Telefone);
            command.Parameters.AddWithValue("@email", fun.Email);
            command.Parameters.AddWithValue("@senha", fun.Senha);

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
        public Funcionarios LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Funcionarios f = null;

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
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);


                    f = new Funcionarios(id, nome, cpf, rg, telefone, email, senha, ehadm);
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
        #endregion

        #region Ler Todos
        public List<Funcionarios> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios";
            command.Connection = connection;

            List<Funcionarios> funcionarios = new List<Funcionarios>();

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
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);

                    Funcionarios funcionario = new Funcionarios(id, nome, cpf, rg, telefone, email, senha, ehadm);
                    funcionarios.Add(funcionario);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return funcionarios;
        }
        #endregion

        #region Verificar Existência do Funcionário
        public bool VerificarExistenciaFuncionario(Funcionarios fun)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios where email = @email and senha = @senha";
            command.Parameters.AddWithValue("@email", fun.Email);
            command.Parameters.AddWithValue("@senha", fun.Senha);
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
    }
}
