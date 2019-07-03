using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ProdutoViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }
        public int IdFornecedor { get; set; }
        public string NomeEmpresaFornecedora { get; set; }
    }
}
