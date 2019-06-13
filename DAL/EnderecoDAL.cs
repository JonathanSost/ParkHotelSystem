using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EnderecoDAL : IEntityCRUD<Enderecos>
    {
        public string Atualizar(Enderecos item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Enderecos item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Enderecos ende)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into enderecos (cep, cidade, rua, bairro, numero, complemento) values (@cep, @cidade, @rua, @bairro, @numero, @complemento)";
            command.Parameters.AddWithValue("@cep", ende.CEP);
            command.Parameters.AddWithValue("@cidade", ende.Cidade);
            command.Parameters.AddWithValue("@rua", ende.Rua);
            command.Parameters.AddWithValue("@bairro", ende.Bairro);
            command.Parameters.AddWithValue("@numero", ende.Numero);
            command.Parameters.AddWithValue("@complemento", ende.Complemento);

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
                    return "Cidade Inválida!";
                }
                return "Banco de dados indisponível, favor contatar o suporte.";
            }
            finally
            {
                //código executado SEMPRE
                connection.Dispose();
            }

            return "";
        }

        public Enderecos LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Enderecos> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from enderecos";

            command.Connection = connection;

            List<Enderecos> enderecos = new List<Enderecos>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];

                    string cep = Convert.ToString(reader["CEP"]);
                    string bairro = Convert.ToString(reader["BAIRRO"]);
                    string rua = Convert.ToString(reader["RUA"]);
                    string numero = Convert.ToString(reader["NUMERO"]);
                    string complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    //Enderecos ende = new Enderecos(id, cep, Estado, Cidade, bairro, rua, numero, complemento);
                    //enderecos.Add(ende);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }

            return enderecos;
        }
    }
}
