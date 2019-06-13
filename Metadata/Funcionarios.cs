using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Funcionarios
    {
        public Funcionarios(int id, string nome, string cpf, string rg, Enderecos endereco, string telefone, string email, string senha, bool ehadm)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.EhADM = ehadm;
        }
            
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Enderecos Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool EhADM { get; set; }

        public string LerDadosFuncionario()
        {
            return Nome + "\r\n" + CPF + "\r\n" + RG + "\r\n" + Telefone + "\r\n" + Endereco + "\r\n" + Email + "\r\n" + Senha + "\r\n";
        }
    }
}
