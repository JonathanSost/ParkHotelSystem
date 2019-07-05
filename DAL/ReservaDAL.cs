using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL
    {
        MessageResponse response = new MessageResponse();

        #region Atualizar
        public MessageResponse Atualizar(Reserva reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "update reservas set quarto = @quarto, cliente = @cliente, diareserva = @diareserva, diaquesai = @diaquesai where id = @id";
            command.Parameters.AddWithValue("@quarto", reserva.IDQuarto);
            command.Parameters.AddWithValue("@cliente", reserva.IDCliente);
            command.Parameters.AddWithValue("@diareserva", reserva.CheckIn);
            command.Parameters.AddWithValue("@diaquesai", reserva.CheckOut);

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
            response.Message = "Reserva atualizada com sucesso!";
            return response;
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Reserva reserva)
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
            response.Message = "Reserva deletada do sistema com sucesso!";
            return response;
        }
        #endregion

        #region Checkin
        public MessageResponse Checkin(Reserva reserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into reservas (quarto, cliente, diareserva, diaquesai) values (@quarto, @cliente, @diareserva, @diaquesai)";
            command.Parameters.AddWithValue("@quarto", reserva.IDQuarto);
            command.Parameters.AddWithValue("@cliente", reserva.IDCliente);
            command.Parameters.AddWithValue("@diareserva", reserva.CheckIn);
            command.Parameters.AddWithValue("@diaquesai", reserva.CheckOut);

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
            response.Message = "Reserva cadastrada no sistema com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Reserva LerPorID(int id)
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

            Reserva r = null;

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

                    r = new Reserva(id, idQuarto, idCliente, checkin, checkout);
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
        public List<Reserva> LerTodos()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select res.id 'ID da Reserva', qua.id 'ID do Quarto', cli.id 'ID do Cliente',
                res.diareserva 'Dia do Check-In', res.diaquesai 'Dia do Check-Out' from reservas res inner join
                clientes cli on res.cliente = cli.id inner join quartos qua on res.quarto = qua.id";
            command.Connection = connection;

            List<Reserva> reservas = new List<Reserva>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Em cada loop, o objeto Reader aponta para um registro do banco de dados que retornou do teu comando select
                    int id = Convert.ToInt32(reader["ID"]);
                    int idquarto = Convert.ToInt32(reader["QUARTO"]);
                    int idcliente = Convert.ToInt32(reader["CLIENTE"]);
                    DateTime checkin = Convert.ToDateTime(reader["CHECKIN"]);
                    DateTime checkout = Convert.ToDateTime(reader["CHECKOUT"]);


                    Reserva reserva = new Reserva(id, idquarto, idcliente, checkin, checkout);
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
        #endregion

        #region Verificar Existência da Reserva
        public bool VerificarExistenciaReserva(int idReserva)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from reservas where id = @id";
            command.Parameters.AddWithValue("@id", idReserva);
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

        #region Realizar Check-Out Automático
        public void RealizarCheckoutAutomatico()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select res.id 'ID da Reserva', qua.id 'ID do Quarto', cli.id 'ID do Cliente',
                res.diareserva 'Dia do Check-In', res.diaquesai 'Dia do Check-Out' from reservas res inner join
                clientes cli on res.cliente = cli.id inner join quartos qua on res.quarto = qua.id";
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID da Reserva"]);
                    int idquarto = Convert.ToInt32(reader["ID do Quarto"]);
                    int idcliente = Convert.ToInt32(reader["ID do Cliente"]);
                    DateTime checkin = Convert.ToDateTime(reader["Dia do Check-In"]);
                    DateTime checkout = Convert.ToDateTime(reader["Dia do Check-Out"]);

                    if (checkout.Date <= DateTime.Now && SelecionarClienteAtivo(idcliente))
                    {
                        List<SqlCommand> comandos = new List<SqlCommand>();
                        SqlCommand command1 = new SqlCommand();
                        command1.CommandText = "update quartos set disponivel = 1 where id = @idquarto";
                        command1.Parameters.AddWithValue("@idquarto", idquarto);
                        SqlCommand command2 = new SqlCommand();
                        command2.CommandText = "update clientes set ativo = 0 where id = @idcliente";
                        command.Parameters.AddWithValue("@idcliente", idcliente);
                        connection.Open();
                        for (int i = 0; i < comandos.Count; i++)
                        {
                            comandos[i].ExecuteNonQuery();
                        }
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
        }
        #endregion

        #region Selecionar Cliente Ativo
        public bool SelecionarClienteAtivo(int idcliente)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where id = @id and ativo = 1";
            command.Parameters.AddWithValue("@id", idcliente);
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

        public void RealizarCheckin()
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"select res.id 'ID da Reserva', qua.id 'ID do Quarto', cli.id 'ID do Cliente',
                res.diareserva 'Dia do Check-In', res.diaquesai 'Dia do Check-Out' from reservas res inner join
                clientes cli on res.cliente = cli.id inner join quartos qua on res.quarto = qua.id";
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID da Reserva"]);
                    int idquarto = Convert.ToInt32(reader["ID do Quarto"]);
                    int idcliente = Convert.ToInt32(reader["ID do Cliente"]);
                    DateTime checkin = Convert.ToDateTime(reader["Dia do Check-In"]);
                    DateTime checkout = Convert.ToDateTime(reader["Dia do Check-Out"]);

                    if (checkout.Day <= DateTime.Now.Day && SelecionarClienteAtivo(idcliente))
                    {
                        List<string> comandos = new List<string>();
                        comandos.Add("update quartos set disponivel = 1 where id = @idquarto");
                        comandos.Add("update clientes set ativo = 0 where id = @idcliente");

                        command.Parameters.AddWithValue("@idquarto", idquarto);
                        command.Parameters.AddWithValue("@idcliente", idcliente);
                        for (int i = 0; i < comandos.Count; i++)
                        {
                            command.CommandText = comandos[i];
                            connection.Open();
                        }
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
