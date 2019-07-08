using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        MessageResponse response = new MessageResponse();

        #region Atualizar
        public MessageResponse Atualizar(Fornecedor fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update fornecedores set nomeempresa = @nomeempresa, cnpj = @cnpj, " +
                "nome = @nome, telefone = @telefone, email = @email where id = @id";
            command.Parameters.AddWithValue("@id", fornecedor.ID);
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
            response.Message = "Fornecedor atualizado com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Fornecedor fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", fornecedor.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("FK_PRO_FORN"))
                {
                    response.Message = "O Fornecedor em questão está referenciado a um produto. Por favor, exclua o produto primeiro.";
                    return response;
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
            response.Message = "Fornecedor deletado do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Inserir
        public MessageResponse Inserir(Fornecedor fornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into fornecedores (nomeempresa, cnpj, nome, telefone, email) values (@nomeempresa, @cnpj, @nome, @telefone, @email)";
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
                response.Success = false;
                if (ex.Message.Contains("CNPJ"))
                {
                    response.Message = "CNPJ já cadastrado.";
                    return response;
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
            response.Message = "Fornecedor cadastrado com sucesso.";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Fornecedor LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Fornecedor f = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    f = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
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
        public List<Fornecedor> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores";
            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Ler Todos (Order By ID)
        public List<Fornecedor> LerTodosByID()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores order by id" +
                "";
            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Ler Todos (Order By ID Desc)
        public List<Fornecedor> LerTodosByIDDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores order by id desc";
            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Ler Todos (Order By Name)
        public List<Fornecedor> LerTodosByName()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores order by nome";
            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Ler Todos (Order By Name Desc)
        public List<Fornecedor> LerTodosByNameDesc()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores order by nome desc";
            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["TELEFONE"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(id, nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Verificar Existência do Fornecedor
        public bool VerificarExistenciaVenda(int idFornecedor)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from fornecedores where id = @id";
            command.Parameters.AddWithValue("@id", idFornecedor);
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

        #region Pesquisar Por Nome da Empresa
        public List<Fornecedor> PesquisarPorNomeEmpresa(string NomeEmpresa)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from fornecedores where nomeempresa like @NomeEmpresa";

            command.Parameters.AddWithValue("@NomeEmpresa", "%" + NomeEmpresa + "%");

            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["Telefone"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Pesquisar Por CNPJ
        public List<Fornecedor> PesquisarPorCNPJ(string CNPJ)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from fornecedores where cnpj like @CNPJ";

            command.Parameters.AddWithValue("@CNPJ", "%" + CNPJ + "%");

            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["Telefone"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion

        #region Pesquisar Por Nome
        public List<Fornecedor> PesquisarPorNome(string Nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from fornecedores where nome like @Nome";

            command.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            command.Connection = connection;

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);

                    string nomeempresa = Convert.ToString(reader["NOMEEMPRESA"]);
                    string cnpj = Convert.ToString(reader["CNPJ"]);
                    string nome = Convert.ToString(reader["NOME"]);
                    string telefone = Convert.ToString(reader["Telefone"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    Fornecedor fornecedor = new Fornecedor(nomeempresa, cnpj, nome, telefone, email);
                    fornecedores.Add(fornecedor);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return fornecedores;
        }
        #endregion
    }
}
