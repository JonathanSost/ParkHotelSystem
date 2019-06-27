using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL : IEntityCRUD<Funcionario>
    {
        #region Atualizar
        public string Atualizar(Funcionario funci)
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
        public string Excluir(Funcionario funci)
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
        public string Inserir(Funcionario fun)
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
        public Funcionario LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Funcionario f = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);


                    f = new Funcionario(id, nome, cpf, rg, telefone, email, senha, ehadm);
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
        public List<Funcionario> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios";
            command.Connection = connection;

            List<Funcionario> funcionarios = new List<Funcionario>();

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

                    Funcionario funcionario = new Funcionario(id, nome, cpf, rg, telefone, email, senha, ehadm);
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

        #region Ler Funcionários (FuncionarioViewModel)
        public List<FuncionarioViewModel> LerFuncionarios()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id";

            command.Connection = connection;

            List<FuncionarioViewModel> funcionarios = new List<FuncionarioViewModel>();

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
                    string email = Convert.ToString(reader["E-mail"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string estado = Convert.ToString(reader["Estado"]);
                    string cidade = Convert.ToString(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    FuncionarioViewModel fun = new FuncionarioViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        CPF = cpf,
                        RG = rg,
                        Telefone = telefone,
                        Email = email,
                        Senha = senha,
                        EhAdm = ehadm,
                        CEP = cep,
                        Estado = estado,
                        Cidade = cidade,
                        Rua = rua,
                        Bairro = bairro,
                        Numero = numero,
                        Complemento = complemento,
                    };
                    funcionarios.Add(fun);
                }
            }
            catch (Exception ex)
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
        public Funcionario VerificarExistenciaFuncionario(string usuario, string senha)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios where email = @email and senha = @senha";
            command.Parameters.AddWithValue("@email", usuario);
            command.Parameters.AddWithValue("@senha", senha);
            command.Connection = connection;

            Funcionario f = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    usuario = Convert.ToString(reader["EMAIL"]);
                    senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);


                    f = new Funcionario(id, nome, cpf, rg, telefone, usuario, senha, ehadm);
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

        #region Pesquisar Por Nome
        public List<FuncionarioViewModel> PesquisarPorNome(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Nome like @Nome";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            command.Connection = connection;

            List<FuncionarioViewModel> funcionarios = new List<FuncionarioViewModel>();

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
                    string email = Convert.ToString(reader["E-mail"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string estado = Convert.ToString(reader["Estado"]);
                    string cidade = Convert.ToString(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    FuncionarioViewModel fun = new FuncionarioViewModel() 
                    {
                        ID = id,
                        Nome = nome,
                        CPF = cpf,
                        RG = rg,
                        Telefone = telefone,
                        Email = email,
                        Senha = senha,
                        EhAdm = ehadm,
                        CEP = cep,
                        Estado = estado,
                        Cidade = cidade,
                        Rua = rua,
                        Bairro = bairro,
                        Numero = numero,
                        Complemento = complemento,
                    };
                    funcionarios.Add(fun);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return funcionarios;
        }
        #endregion
    }
}
