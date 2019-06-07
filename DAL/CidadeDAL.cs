using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CidadeDAL : IEntityCRUD<Cidades>
    {
        public string Atualizar(Cidades cidade)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Cidades cidade)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Cidades cidade)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into estados (nome, estado) values (@nome, @estado)";
            command.Parameters.AddWithValue("@nome", cidade.Nome);
            command.Parameters.AddWithValue("@estado", cidade.Estado.ID);

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

            return "Cidade cadastrada com sucesso!";
        }

        public Cidades LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cidades> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from cidades";
            command.Connection = connection;

            List<Cidades> cidades = new List<Cidades>();

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
                    Cidades cidade = new Cidades(id, nome, new Estados((int)reader["ESTADO"], "", ""));
                    cidades.Add(cidade);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return cidades;
        }
    }
}
