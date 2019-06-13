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
    public class AdministradoresBLL
    {
        private bool ValidarCPF(string cpf)
        {
            #region Codigo Validar CPF
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
            #endregion
        }

        public string Cadastrar(Administradores admin)
        {

            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(admin.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                admin.Nome = Regex.Replace(admin.Nome, " {2,}", " ");
                admin.Nome = admin.Nome.Trim();
                if (admin.Nome.Length < 3 || admin.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < admin.Nome.Length; i++)
                    {
                        if (!char.IsLetter(admin.Nome[i]) && admin.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(admin.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {

                admin.CPF = admin.CPF.Trim();
                admin.CPF = admin.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(admin.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(admin.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                admin.RG = admin.RG.Trim();
                admin.RG = admin.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (admin.RG.Length < 5 || admin.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region Endereço
            EnderecosBLL eBLL = new EnderecosBLL();
            string errosEndereco = eBLL.Validar(admin.Endereco);
            if (!string.IsNullOrWhiteSpace(errosEndereco))
            {
                erros.Add(errosEndereco);
            }
            #endregion 

            #region Telefone
            if (string.IsNullOrWhiteSpace(admin.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                admin.Telefone =
                    admin.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (admin.Telefone.Length < 8 || admin .Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            bool isEmail = Regex.IsMatch(admin.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }
            #endregion

            #region Senha
            if (string.IsNullOrWhiteSpace(admin.Senha))
            {
                erros.Add("Senha deve ser informada.");
            }

            else
            {
                admin.Senha = admin.Senha.Trim();
                if (admin.Nome.Length < 8 || admin.Nome.Length > 25)
                {
                    erros.Add("Senha deve conter entre 8 e 25 caracteres.");
                }
                else
                {
                    for (int i = 0; i < admin.Senha.Length; i++)
                    {
                        if (!char.IsLetter(admin.Senha[i]) || !char.IsNumber(admin.Senha[i]))
                        {
                            erros.Add("Senha deve conter apenas letras ou números!");
                            break;
                        }
                    }
                }
            }
            #endregion

            StringBuilder errosCliente = new StringBuilder();

            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    errosCliente.AppendLine(erros[i].ToString());
                }
                return errosCliente.ToString();
            }
            //chamar o DAL para cadastrar
            new AdministradoresDAL().Inserir(admin);
            return "Funcionário cadastrado com sucesso";
        }
    }
}
