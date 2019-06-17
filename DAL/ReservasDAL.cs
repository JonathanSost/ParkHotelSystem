using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservasDAL : IEntityCRUD<Reservas>
    {
        public string Atualizar(Reservas reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update reservas set quarto = @quarto, cliente = @cliente, diareserva = @diareserva, diaquesai = @diaquesai where id = @id";
            command.Parameters.AddWithValue("@quarto", reserva.IDQuarto);
            command.Parameters.AddWithValue("@cliente", reserva.IDCliente);
            command.Parameters.AddWithValue("@diareserva", reserva.DiaReserva);
            command.Parameters.AddWithValue("@diaquesai", reserva.DiaQueSai);

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

            return "Reserva atualizada com sucesso!";
        }

        public string Excluir(Reservas reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from reservas where id = @id";
            command.Parameters.AddWithValue("@id", reserva.ID);

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

            return "Reserva deletada do sistema com sucesso!";
        }

        public string Inserir(Reservas reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into reservas (quarto, cliente, diareserva, diaquesai) values (@quarto, @cliente, @diareserva, @diaquesai)";
            command.Parameters.AddWithValue("@quarto", reserva.IDQuarto);
            command.Parameters.AddWithValue("@cliente", reserva.IDCliente);
            command.Parameters.AddWithValue("@diareserva", reserva.DiaReserva);
            command.Parameters.AddWithValue("@diaquesai", reserva.DiaQueSai);

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

        public Reservas LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from reservas where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            Reservas r = null;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    
                    r = new Reservas();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return r;
        }

        public List<Reservas> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from reservas";
            command.Connection = connection;

            List<Reservas> reservas = new List<Reservas>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    //int id = (int)reader["ID"];
                    
                    Reservas reserva = new Reservas();
                    reservas.Add(reserva);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
            return reservas;
        }
    }
}
