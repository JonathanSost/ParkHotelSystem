using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Funcionario
    {
        public Funcionario()
        {

        }

        public Funcionario(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }

        public Funcionario(int id, string nome, string cpf, string rg, string telefone, string email, string senha, 
            bool ehadm, int estado, int cidade, string cep, string bairro, string rua, string numero, string complemento, bool ativo)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.Estado = estado;
            this.Cidade = cidade;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.EhADM = ehadm;
            this.Ativo = ativo;
        }

        public Funcionario(string nome, string cpf, string rg, string telefone, string email, string senha,
            bool ehadm, int estado, int cidade, string cep, string bairro, string rua, string numero, string complemento, bool ativo)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.Estado = estado;
            this.Cidade = cidade;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.EhADM = ehadm;
            this.Ativo = ativo;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool EhADM { get; set; }
        public bool Ativo { get; set; }

        public int Estado { get; set; }
        public int Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }

        public string LerPrimeiroNome()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Nome.Length; i++)
            {
                if (Nome[i] == ' ')
                {
                    break;
                }
                builder.Append(Nome[i]);
            }
            return builder.ToString();
        }
    }
}
