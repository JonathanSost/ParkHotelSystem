using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ClienteViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        [DisplayName("Telefone")]
        public string Telefone1 { get; set; }
        [DisplayName("Celular")]
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        //[Browsable(false)]
        public double Conta { get; set; }
    }
}
