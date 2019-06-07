using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedoresBLL
    {   /// <summary>
        /// Realiza a validação do CNPJ
        /// </summary>
        public bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public string Cadastrar(Fornecedores For)
        {
            List<string> erros = new List<string>();

            #region Nome Empresa
            if (string.IsNullOrWhiteSpace(For.NomeEmpresa))
            {
                erros.Add("O nome da empresa deve ser informado");
            }
            else
            {
                For.NomeContato = Regex.Replace(For.NomeContato, " {2,}", " ");
                For.NomeContato = For.NomeContato.Trim();
                if (For.NomeEmpresa.Length < 2 || For.NomeEmpresa.Length > 60)
                {
                    erros.Add("Nome da Empresa deve conter entre 2 e 60 caracteres.");
                }
            }
            #endregion

            #region Nome Contato
            if (string.IsNullOrWhiteSpace(For.NomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                For.NomeContato = Regex.Replace(For.NomeContato, " {2,}", " ");
                For.NomeContato = For.NomeContato.Trim();
                if (For.NomeContato.Length < 3 || For.NomeContato.Length > 60)
                {
                    erros.Add("Nome para contato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < For.NomeContato.Length; i++)
                    {
                        if (!char.IsLetter(For.NomeContato[i]) && For.NomeContato[i] != ' ')
                        {
                            erros.Add("Nome para contato inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CNPJ
            if (string.IsNullOrWhiteSpace(For.CNPJ))
            {
                erros.Add("CNPJ deve ser informado!");
            }
            else
            {
                For.CNPJ = For.CNPJ.Trim();
                For.CNPJ = For.CNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
                if (!this.ValidarCNPJ(For.CNPJ))
                {
                    erros.Add("CNPJ inválido");
                }
            }

            #endregion

            #region Telefone
            if (string.IsNullOrWhiteSpace(For.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                For.Telefone =
                    For.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (For.Telefone.Length < 8 || For.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            if (string.IsNullOrWhiteSpace(For.Email))
            {
                erros.Add("Email deve ser informado!");
            }
            bool isEmail = Regex.IsMatch(For.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            StringBuilder ErrosFornecedor = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    ErrosFornecedor.AppendLine(erros[i]);
                }
                return ErrosFornecedor.ToString();
            }
            new FornecedoresDAL().Inserir(For);
            return "Fornecedor cadastrado com sucesso!";
        }
    }
}
