using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL : IEntityCRUD<Reservas>
    {
        #region Atualizar
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
        #endregion

        #region Excluir
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
        #endregion

        #region Inserir
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
        #endregion

        #region Ler Por ID
        public Reservas LerPorID(int id)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select res.id 'ID da Reserva', qua.id 'ID do Quarto', cli.id 'ID do Cliente',
                res.diareserva 'Dia do Check-In', res.diaquesai 'Dia do Check-Out' from reservas res inner join
                clientes cli on res.cliente = cli.id inner join quartos qua on res.quarto = qua.id";
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
                    id = Convert.ToInt32(reader["ID da Reserva"]);
                    int idQuarto = Convert.ToInt32(reader["ID do Quarto"]);
                    int idCliente = Convert.ToInt32(reader["ID do Cliente"]);
                    DateTime checkin = Convert.ToDateTime(reader["Dia do Check-In"]);
                    DateTime checkout = Convert.ToDateTime(reader["Dia do Check-Out"]);

                    //int id = (int)reader["ID"];

                    r = new Reservas(id, idQuarto, idCliente, checkin, checkout);
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
        #endregion

        #region Ler Todos
        public List<Reservas> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select res.id 'ID da Reserva', qua.id 'ID do Quarto', cli.id 'ID do Cliente',
                res.diareserva 'Dia do Check-In', res.diaquesai 'Dia do Check-Out' from reservas res inner join
                clientes cli on res.cliente = cli.id inner join quartos qua on res.quarto = qua.id";
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
                    
                    //Reservas reserva = new Reservas();
                    //reservas.Add(reserva);
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
        #endregion
    }
}
