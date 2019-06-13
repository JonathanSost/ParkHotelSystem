using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Clientes
    {
        public Clientes (int id, string nome, string cpf, string rg, Enderecos endereco, string telefone1, string telefone2, string email, double conta )
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Email = email;
            this.Endereco = endereco;
            this.Conta = conta;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Enderecos Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public double Conta { get; set; }

        public string LerDadosCliente()
        {
            return ID + "\r\n" + Nome + "\r\n" + CPF + "\r\n" + RG + "\r\n" + Telefone1 + "\r\n" + Telefone2 + "\r\n" + Email + "\r\n" + Conta + "\r\n";
        }
    }
}
