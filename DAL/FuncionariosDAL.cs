using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionariosDAL : IEntityCRUD<Funcionarios>
    {
        public string Atualizar(Funcionarios item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Funcionarios item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Funcionarios fun)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into funcionarios (nome, cpf, rg, endereco, telefone, email, senha) values (@nome, @cpf, @rg, @endereco, @telefone, @email, @senha)";
            command.Parameters.AddWithValue("@nome", fun.Nome);
            command.Parameters.AddWithValue("@cpf", fun.CPF);
            command.Parameters.AddWithValue("@rg", fun.RG);
            command.Parameters.AddWithValue("@endereco", fun.Endereco);
            command.Parameters.AddWithValue("@telefone", fun.Telefone);
            command.Parameters.AddWithValue("@email", fun.Email);
            command.Parameters.AddWithValue("@senha", fun.Email);

            command.Connection = connection;
        }

        public Funcionarios LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
