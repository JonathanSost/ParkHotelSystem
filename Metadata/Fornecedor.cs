using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Fornecedor
    {
        public Fornecedor()
        {

        }

        public Fornecedor(int id, string nomeEmpresa, string cnpj, string nomeContato, string telefone, string email)
        {
            this.ID = id;
            this.NomeEmpresa = nomeEmpresa;
            this.CNPJ = cnpj;
            this.NomeContato = nomeContato;
            this.Telefone = telefone;
            this.Email = email;
        }

        public Fornecedor(string nomeEmpresa, string cnpj, string nomeContato, string telefone, string email)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.CNPJ = cnpj;
            this.NomeContato = nomeContato;
            this.Telefone = telefone;
            this.Email = email;
        }

        public int ID { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
