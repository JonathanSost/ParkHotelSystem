using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cliente
    {
        public Cliente (string nome, string cpf, string rg, string telefone1, 
            string telefone2, string email, string cep, int estado, int cidade, string rua, 
            string bairro, string numero, string complemento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Email = email;
            this.CEP = cep;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Complemento = complemento;
        }

        public Cliente(int id, string nome, string cpf, string rg, string telefone1,
            string telefone2, string email, string cep, int estado, int cidade, string rua,
            string bairro, string numero, string complemento)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Email = email;
            this.CEP = cep;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Complemento = complemento;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public double Conta { get; set; }

        public int Estado { get; set; }
        public int Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
    }
}
