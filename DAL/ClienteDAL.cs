using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL : IEntityCRUD<Clientes>
    {
        public string Atualizar(Clientes cli)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Clientes cli)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Clientes cli)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into clientes (nome, endereco, cpf, rg, telefone1, telefone2, email) values (@nome, @endereco, @cpf, @rg, @telefone1, @telefone2, @email)";
            command.Parameters.AddWithValue("@nome", cli.Nome);
            command.Parameters.AddWithValue("@endereco", cli.Endereco);
            command.Parameters.AddWithValue("@cpf", cli.CPF);
            command.Parameters.AddWithValue("@rg", cli.RG);
            command.Parameters.AddWithValue("@telefone1", cli.Telefone1);
            command.Parameters.AddWithValue("@telefone2", cli.Telefone2);
            command.Parameters.AddWithValue("@email", cli.Email);

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
                    return "Endereço inválido!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "Cliente cadastrado com sucesso!";
        }

        public Clientes LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Clientes> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select cli.Nome, cli.CPF, cli.RG, c.nome 'Cidade', e.nome 'Estado', 
                                  ende.CEP, ende.Rua, ende.Bairro, ende.Numero 'Número', ende.Complemento, 
                                  cli.Telefone1 'Telefone 1', cli.Telefone2 'Telefone 2', 
                                  cli.email 'E-Mail' from clientes cli inner
                                  join enderecos ende on cli.endereco = ende.id inner
                                  join cidades c on ende.cidade = c.id inner
                                  join estados e on c.estado = e.id";
            
            command.Connection = connection;

            List<Clientes> clientes = new List<Clientes>();

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
                    //Enderecos endereco = Convert.ToString(reader["ENDERECO"]);
                    string telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    string telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    string email = Convert.ToString(reader["EMAIL"]);

                    //Clientes cli = new Clientes(id, nome, cpf, rg, endereco, telefone1, telefone2, email);
                    //clientes.Add(cli);
                }
            }
            catch
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
