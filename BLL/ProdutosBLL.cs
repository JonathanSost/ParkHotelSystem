using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutosBLL
    {
        public string Cadastrar (Produtos pro)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(pro.Nome))
            {
                erros.Add("Nome do Produto deve ser informado.");
            }
            else
            {
                pro.Nome = pro.Nome.Trim();
                if (pro.Nome.Length < 2 || pro.Nome.Length > 70)
                {
                    erros.Add("Nome do Produto deve conter entre 2 e 70 caracteres.");
                }
            }
            if (pro.Estoque <= 0)
            {
                erros.Add("Quantidade de Estoque inválida.");
            }
            if (string.IsNullOrWhiteSpace(pro.Descricao))
            {
                erros.Add("Descrição do Produto deve ser informada.");
            }
            else
            {
                pro.Descricao = pro.Descricao.Trim();
                if (pro.Descricao.Length < 2 || pro.Descricao.Length > 80)
                {
                    erros.Add("Descrição do Produto deve conter entre 2 e 80 caracteres.");
                }
            }
            if (pro.Preco < 0)
            {
                erros.Add("Valor inexistente.");
            }

            return "";
        }
    }
}
