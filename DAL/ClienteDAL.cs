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
        MessageResponse response = new MessageResponse();
        #region Atualizar
        public MessageResponse Atualizar(Cliente cli)
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
            response.Message = "Cliente atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Cliente cli)
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
                    response.Message = "Estado Inválido";
                    return response;
                }
                
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
            response.Message = "Cliente deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Cliente cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into clientes (nome, cpf, rg, telefone1, telefone2, email, cep, estado, " +
                "cidade, rua, bairro, numero, complemento, conta) values (@nome, @cpf, @rg, @telefone1, @telefone2, @email, " +
                "@cep, @estado, @cidade, @rua, @bairro, @numero, @complemento, @conta)";
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
            command.Parameters.AddWithValue("@conta", cli.Conta);

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
                List<string> erros = new List<string>(); 
                if (ex.Message.ToUpper().Contains("UNIQUE_CLI_CPF"))
                {
                    erros.Add("CPF já cadastrado.");
                }
                if (ex.Message.ToUpper().Contains("UNIQUE_CLI_RG"))
                {
                    erros.Add("RG já cadastrado.");
                }
                if (ex.Message.ToUpper().Contains("UNIQUE_CLI_EMAIL"))
                {
                    erros.Add("E-Mail já cadastrado.");
                }
                else
                {
                    erros.Add("Banco de dados indisponível, favor contatar o suporte.");
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Message = builder.ToString();
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

        #region Checar CPF
        public bool ChecarCPF(string cpf)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", cpf);
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

        #region Checar RG
        public bool ChecarRG(string rg)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where rg = @rg";
            command.Parameters.AddWithValue("@rg", rg);
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

        #region Checar E-Mail
        public bool ChecarEmail(string email)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where email = @email";
            command.Parameters.AddWithValue("@email", email);
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

        #region Ler Clientes (ClienteViewModel)
        public List<ClienteViewModel> LerClientes()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome 'Nome', cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'Email', cli.CEP, est.Nome 'Estado', cid.Nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento, cli.Conta from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id";

            command.Connection = connection;

            List<ClienteViewModel> clientes = new List<ClienteViewModel>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string nome = Convert.ToString(reader["Nome"]);
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone1 = Convert.ToString(reader["Telefone"]);
                    string telefone2 = Convert.ToString(reader["Celular"]);
                    string email = Convert.ToString(reader["Email"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string estado = Convert.ToString(reader["Estado"]);
                    string cidade = Convert.ToString(reader["Cidade"]);
                    string rua = Convert.ToString(reader["Rua"]);
                    string bairro = Convert.ToString(reader["Bairro"]);
                    string numero = Convert.ToString(reader["Numero"]);
                    string complemento = Convert.ToString(reader["Complemento"]);
                    double conta = Convert.ToDouble(reader["Conta"]);

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
                        Conta = conta
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
        public bool VerificarExistenciaCliente(int idCliente)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where id = @id";
            command.Parameters.AddWithValue("@id", idCliente);
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

        #region Pesquisar Por Nome
        public List<ClienteViewModel> PesquisarPorNome(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.Nome like @Nome";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

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

        #region Pesquisar Por CPF
        public List<ClienteViewModel> PesquisarPorCPF(string CPF)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.CPF like @CPF";

            command.Parameters.AddWithValue("@CPF", "%" + CPF + "%");

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

        #region Pesquisar Por RG
        public List<ClienteViewModel> PesquisarPorRG(string RG)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.RG like @RG";

            command.Parameters.AddWithValue("@RG", "%" + RG + "%");

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

        #region Pesquisar Por Estado
        public List<ClienteViewModel> PesquisarPorEstado(int Estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.estado like @estado";

            command.Parameters.AddWithValue("@estado", "%" + Estado + "%");

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

        #region Pesquisar Por Cidade
        public List<ClienteViewModel> PesquisarPorCidade(int Cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.cidade like @cidade";

            command.Parameters.AddWithValue("@cidade", "%" + Cidade + "%");

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

        #region Pesquisar Por CEP
        public List<ClienteViewModel> PesquisarPorCEP(string CEP)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.CEP like @CEP";

            command.Parameters.AddWithValue("@CEP", "%" + CEP + "%");

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

        #region Pesquisar Por Bairro
        public List<ClienteViewModel> PesquisarPorBairro(string Bairro)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.bairro like @bairro";

            command.Parameters.AddWithValue("@bairro", "%" + Bairro + "%");

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

        #region Pesquisar Por Rua
        public List<ClienteViewModel> PesquisarPorRua(string Rua)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.ID, cli.Nome, cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id where cli.rua like @rua";

            command.Parameters.AddWithValue("@rua", "%" + Rua + "%");

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
    }
}
