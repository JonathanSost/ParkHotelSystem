using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Enderecos
    {
        public Enderecos(string CEP)
        {
            this.CEP = CEP;
        }

        public string LerDadosEndereco()
        {
            return this.ID + "\r\n" +
                this.CEP + "\r\n" +
                this.Cidade + "\r\n" +
                this.Complemento + "\r\n" +
                this.Bairro + "\r\n" +
                this.Complemento + "\r\n" +
                this.Estado + "\r\n" +
                this.Numero + "\r\n" +
                this.Rua + "\r\n";
        }

        public Enderecos(int id, string CEP,
                        string Estado,
                        string Cidade,
                        string Bairro,
                        string Rua,
                        string Numero,
                        string Complemento)
        {
            this.ID = id;
            this.CEP = CEP;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.Bairro = Bairro;
            this.Rua = Rua;
            this.Numero = Numero;
            this.Complemento = Complemento;
        }

        public int ID { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; } 
        public string Cidade { get; set; } 
        public string Bairro { get; set; } 
        public string Rua { get; set; } 
        public string Numero { get; set; } 
        public string Complemento { get; set; }  
    }
}
