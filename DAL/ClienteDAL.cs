using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL : IClienteDataService
    {
        #region Atualizar
        public string Atualizar(Cliente cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update clientes set nome = @nome, cpf = @cpf, rg = @rg, telefone1 = @telefone1, " +
                "telefone2 = @telefone2, email = @email, cep = @cep, estado = @estado, cidade = @cidade, rua = @rua, " +
                "bairro = @bairro, numero = @numero, complemento = @complemento where id = @id";
            command.Parameters.AddWithValue("@nome", cli.Nome);
            command.Parameters.AddWithValue("@cpf", cli.CPF);
            command.Parameters.AddWithValue("@rg", cli.RG);
            command.Parameters.AddWithValue("@telefone1", cli.Telefone1);
            command.Parameters.AddWithValue("@telefone2", cli.Telefone2);
            command.Parameters.AddWithValue("@email", cli.Email);
            command.Parameters.AddWithValue("@cep", cli.CEP);
            command.Parameters.AddWithValue("@estado", cli.Estado);
            command.Parameters.AddWithValue("@cidade", cli.Cidade);
            command.Parameters.AddWithValue("@rua", cli.Rua);
            command.Parameters.AddWithValue("@bairro", cli.Bairro);
            command.Parameters.AddWithValue("@numero", cli.Numero);
            command.Parameters.AddWithValue("@complemento", cli.Complemento);

            command.Parameters.AddWithValue("@id", cli.ID);

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

            return "Cliente atualizado com sucesso!";
        }
        #endregion

        #region Excluir
        public string Excluir(Cliente cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from clientes where id = @id";
            command.Parameters.AddWithValue("@id", cli.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK"))
                {
                    return "Estado inválido!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Cliente deletado do sistema com sucesso!";
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Cliente cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into clientes (nome, cpf, rg, telefone1, telefone2, email, cep, estado, " +
                "cidade, rua, bairro, numero, complemento) values (@nome, @cpf, @rg, @telefone1, @telefone2, @email, " +
                "@cep, @estado, @cidade, @rua, @bairro, @numero, @complemento)";
            command.Parameters.AddWithValue("@nome", cli.Nome);
            command.Parameters.AddWithValue("@cpf", cli.CPF);
            command.Parameters.AddWithValue("@rg", cli.RG);
            command.Parameters.AddWithValue("@telefone1", cli.Telefone1);
            command.Parameters.AddWithValue("@telefone2", cli.Telefone2);
            command.Parameters.AddWithValue("@email", cli.Email);
            command.Parameters.AddWithValue("@cep", cli.CEP);
            command.Parameters.AddWithValue("@estado", cli.Estado);
            command.Parameters.AddWithValue("@cidade", cli.Cidade);
            command.Parameters.AddWithValue("@rua", cli.Rua);
            command.Parameters.AddWithValue("@bairro", cli.Bairro);
            command.Parameters.AddWithValue("@numero", cli.Numero);
            command.Parameters.AddWithValue("@complemento", cli.Complemento);

            command.Connection = connection;
            MessageResponse response = new MessageResponse();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.ToUpper().Contains("UNIQUE_CLI_CPF"))
                {
                    response.Message = "CPF já cadastrado.";
                }
                else if (ex.Message.ToUpper().Contains("UNIQUE_CLI_RG"))
                {
                    response.Message = "RG já cadastrado.";
                }
                else
                {
                    response.Message = "Banco de dados indisponível, favor contatar o suporte.";
                }
                return response;
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            response.Success = true;
            response.Message = "Cadastrado com sucesso.";
            return response;
        }
        #endregion

        #region Ler Clientes (ClienteViewModel)
        public List<ClienteViewModel> LerClientes()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id";

            command.Connection = connection;

            List<ClienteViewModel> clientes = new List<ClienteViewModel>();

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
                    string telefone1 = Convert.ToString(reader["Telefone"]);
                    string telefone2 = Convert.ToString(reader["Celular"]);
                    string email = Convert.ToString(reader["E-mail"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string estado = Convert.ToString(reader["Estado"]);
                    string cidade = Convert.ToString(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    ClienteViewModel cli = new ClienteViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        CPF = cpf,
                        RG = rg,
                        Telefone1 = telefone1,
                        Telefone2 = telefone2,
                        Email = email,
                        CEP = cep,
                        Estado = estado,
                        Cidade = cidade,
                        Rua = rua,
                        Bairro = bairro,
                        Numero = numero,
                        Complemento = complemento,
                    };
                    clientes.Add(cli);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return clientes;
        }
        #endregion

        #region Ler Por ID
        public Cliente LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Cliente cli = null;

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
                    string telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    string telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    int estado = Convert.ToInt32(reader["ESTADO"]);
                    int cidade = Convert.ToInt32(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    double conta = Convert.ToDouble(reader["CONTA"]);

                    cli = new Cliente(id, nome, cpf, rg, telefone1, telefone2, email, cep, estado, cidade,
                        rua, bairro, numero, complemento);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return cli;
        }
        #endregion

        #region Ler Todos
        public List<Cliente> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from clientes";

            command.Connection = connection;

            List<Cliente> clientes = new List<Cliente>();

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
                    string telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    string telefone2 = Convert.ToString(reader["TELEFON2"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    int estado = Convert.ToInt32(reader["ESTADO"]);
                    int cidade = Convert.ToInt32(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    Cliente cli = new Cliente(id, nome, cpf, rg, telefone1, telefone2, email, cep, estado, cidade,
                        rua, bairro, numero, complemento);
                    clientes.Add(cli);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }

            return clientes;
        }
        #endregion

        #region Verificar Existência do Cliente
        public bool VerificarExistenciaCliente(Cliente cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where id = @id";
            command.Parameters.AddWithValue("@id", cli.ID);
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

        public List<ClienteViewModel> PesquisarPorNome(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.nome like '%@nome%'";

            command.Parameters.AddWithValue("@nome", Nome);

            command.Connection = connection;

            List<ClienteViewModel> clientes = new List<ClienteViewModel>();

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
                    string telefone1 = Convert.ToString(reader["Telefone"]);
                    string telefone2 = Convert.ToString(reader["Celular"]);
                    string email = Convert.ToString(reader["E-mail"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string estado = Convert.ToString(reader["Estado"]);
                    string cidade = Convert.ToString(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    ClienteViewModel cli = new ClienteViewModel()
                    {
                        ID = id,
                        Nome = nome,
                        CPF = cpf,
                        RG = rg,
                        Telefone1 = telefone1,
                        Telefone2 = telefone2,
                        Email = email,
                        CEP = cep,
                        Estado = estado,
                        Cidade = cidade,
                        Rua = rua,
                        Bairro = bairro,
                        Numero = numero,
                        Complemento = complemento,
                    };
                    clientes.Add(cli);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return clientes;
        }
    }
}
