using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        MessageResponse response = new MessageResponse();
        #region Atualizar
        public MessageResponse Atualizar(Funcionario funci)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = @"update funcionarios set nome = @nome, cpf = @cpf, rg = @rg,
                telefone = @telefone, cep = @cep, estado = @estado, cidade = @cidade, rua = @rua, bairro = @bairro,
                numero = @numero, complemento = @complemento, email = @email, senha = @senha, ehadm = @ehadm 
                where id = @id";
            command.Parameters.AddWithValue("@nome", funci.Nome);
            command.Parameters.AddWithValue("@cpf", funci.CPF);
            command.Parameters.AddWithValue("@rg", funci.RG);
            command.Parameters.AddWithValue("@telefone", funci.Telefone);
            command.Parameters.AddWithValue("@cep", funci.CEP);
            command.Parameters.AddWithValue("@estado", funci.Estado);
            command.Parameters.AddWithValue("@cidade", funci.Cidade);
            command.Parameters.AddWithValue("@rua", funci.Rua);
            command.Parameters.AddWithValue("@bairro", funci.Bairro);
            command.Parameters.AddWithValue("@numero", funci.Numero);
            command.Parameters.AddWithValue("@complemento", funci.Complemento);
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
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains(""))
                {

                }
                response.Message = "Banco de dados indisponível, favor contatar o suporte.";
                return response;
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }
            response.Success = true;
            response.Message = "Funcionário atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Funcionario funci)
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
            response.Message = "Funcionário deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Funcionario fun)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into funcionarios (nome, cpf, rg, telefone, email, senha, ehadm, estado, cidade, rua, bairro, numero, cep, complemento) " +
                "values (@nome, @cpf, @rg, @telefone, @email, @senha, @admin, @estado, @cidade, @rua, @bairro, @numero, @cep, @complemento)";
            command.Parameters.AddWithValue("@nome", fun.Nome);
            command.Parameters.AddWithValue("@cpf", fun.CPF);
            command.Parameters.AddWithValue("@rg", fun.RG);
            command.Parameters.AddWithValue("@telefone", fun.Telefone);
            command.Parameters.AddWithValue("@email", fun.Email);
            command.Parameters.AddWithValue("@senha", fun.Senha);
            command.Parameters.AddWithValue("@admin", fun.EhADM);
            command.Parameters.AddWithValue("@estado", fun.Estado);
            command.Parameters.AddWithValue("@cidade", fun.Cidade);
            command.Parameters.AddWithValue("@rua", fun.Rua);
            command.Parameters.AddWithValue("@bairro", fun.Bairro);
            command.Parameters.AddWithValue("@numero", fun.Numero);
            command.Parameters.AddWithValue("@cep", fun.CEP);
            command.Parameters.AddWithValue("@complemento", fun.Complemento);


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
                response.Message = "Banco de dados indisponível, favor contatar o suporte.";
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
                    string nome = Convert.ToString(reader["NOME"]);
                    string cpf = Convert.ToString(reader["CPF"]);
                    string rg = Convert.ToString(reader["RG"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);
                    string senha = Convert.ToString(reader["SENHA"]);
                    int estado = Convert.ToInt32(reader["ESTADO"]);
                    int cidade = Convert.ToInt32(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);

                    Funcionario funcionario = new Funcionario(id, nome, cpf, rg, telefone, email, senha, ehadm,
                        estado, cidade, cep, bairro, rua, numero, complemento);
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
                    int estado = Convert.ToInt32(reader["ESTADO"]);
                    int cidade = Convert.ToInt32(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);

                    Funcionario funcionario = new Funcionario(id, nome, cpf, rg, telefone, email, senha, ehadm, 
                        estado, cidade, cep, bairro, rua, numero, complemento);
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
        public List<FuncionarioViewModel> LerFuncionarios(Funcionario funci)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.id not like @funid";

            command.Parameters.AddWithValue("@funid", funci.ID);

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
        public bool VerificarExistenciaFuncionario(int idFuncionario)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios where id = @id";
            command.Parameters.AddWithValue("@id", idFuncionario);
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

        #region Verificar Existência do Funcionario (Inicialização do FormLogin)
        public bool VerificarExistenciaFuncionarioA()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from funcionarios";
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

        #region Logar
        public Funcionario Logar(string usuario, string senha)
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
                    int estado = Convert.ToInt32(reader["ESTADO"]);
                    int cidade = Convert.ToInt32(reader["CIDADE"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string cep = Convert.ToString(reader["CEP"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    bool ehadm = Convert.ToBoolean(reader["EHADM"]);


                    f = new Funcionario(id, nome, cpf, rg, telefone, usuario, senha, ehadm,
                        estado, cidade, cep, bairro, rua, numero, complemento);
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
        public List<FuncionarioViewModel> PesquisarPorNome(string Nome, Funcionario funci)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Nome like @Nome and fun.id not like @funid";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
            command.Parameters.AddWithValue("@funid", funci.ID);

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

        #region Pesquisar Por CPF
        public List<FuncionarioViewModel> PesquisarPorCPF(string CPF)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.CPF like @CPF";

            command.Parameters.AddWithValue("@CPF", "%" + CPF + "%");

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

        #region Pesquisar Por RG
        public List<FuncionarioViewModel> PesquisarPorRG(string RG)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.RG like @RG";

            command.Parameters.AddWithValue("@RG", "%" + RG + "%");

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

        #region Pesquisar Por Estado
        public List<FuncionarioViewModel> PesquisarPorEstado(int Estado)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Estado like @Estado";

            command.Parameters.AddWithValue("@Estado", "%" + Estado + "%");

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

        #region Pesquisar Por Cidade
        public List<FuncionarioViewModel> PesquisarPorCidade(int Cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Cidade like @Cidade";

            command.Parameters.AddWithValue("@Cidade", "%" + Cidade + "%");

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

        #region Pesquisar Por CEP
        public List<FuncionarioViewModel> PesquisarPorCEP(string CEP)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.CEP like @CEP";

            command.Parameters.AddWithValue("@CEP", "%" + CEP + "%");

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

        #region Pesquisar Por Bairro
        public List<FuncionarioViewModel> PesquisarPorBairro(string Bairro)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Bairro like @Bairro";

            command.Parameters.AddWithValue("@Bairro", "%" + Bairro + "%");

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

        #region Pesquisar Por Rua
        public List<FuncionarioViewModel> PesquisarPorRua(string Rua)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.Rua like @Rua";

            command.Parameters.AddWithValue("@Rua", "%" + Rua + "%");

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

        #region Pesquisar Admin
        public List<FuncionarioViewModel> PesquisarAdmin(bool Admin)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select fun.ID, fun.Nome, fun.CPF, fun.RG, fun.telefone, fun.email 'E-mail', fun.Senha, fun.ehadm,
            fun.CEP, est.Nome 'Estado', cid.nome 'Cidade', fun.Rua, fun.Bairro, fun.Numero, fun.Complemento 
            from funcionarios fun inner join cidades cid on fun.cidade = cid.id inner join estados est on 
            fun.estado = est.id where fun.ehadm = @admin";

            command.Parameters.AddWithValue("@admin", Admin);

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
