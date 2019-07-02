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
    public class FornecedorBLL
    {
        /// <summary>
        /// Realiza a validação do CNPJ do Fornecedor.
        /// </summary>
        public bool ValidarCNPJ(string cnpj)
        {
            #region Codigo Validar CNPJ
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
            #endregion
        }

        FornecedorDAL dal = new FornecedorDAL();
        MessageResponse response = new MessageResponse();

        #region Cadastrar
        /// <summary>
        /// Verifica se os dados do Fornecedor estão corretos. Se estiverem, o Fornecedor é cadastrado no banco.
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public MessageResponse Cadastrar(Fornecedor fornecedor)
        {
            List<string> erros = new List<string>();

            #region Nome Empresa
            if (string.IsNullOrWhiteSpace(fornecedor.NomeEmpresa))
            {
                erros.Add("O nome da empresa deve ser informado");
            }
            else
            {
                fornecedor.NomeContato = Regex.Replace(fornecedor.NomeContato, " {2,}", " ");
                fornecedor.NomeContato = fornecedor.NomeContato.Trim();
                if (fornecedor.NomeEmpresa.Length < 2 || fornecedor.NomeEmpresa.Length > 60)
                {
                    erros.Add("Nome da Empresa deve conter entre 2 e 60 caracteres.");
                }
            }
            #endregion

            #region Nome Contato
            if (string.IsNullOrWhiteSpace(fornecedor.NomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                fornecedor.NomeContato = Regex.Replace(fornecedor.NomeContato, " {2,}", " ");
                fornecedor.NomeContato = fornecedor.NomeContato.Trim();
                if (fornecedor.NomeContato.Length < 3 || fornecedor.NomeContato.Length > 60)
                {
                    erros.Add("Nome para contato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fornecedor.NomeContato.Length; i++)
                    {
                        if (!char.IsLetter(fornecedor.NomeContato[i]) && fornecedor.NomeContato[i] != ' ')
                        {
                            erros.Add("Nome para contato inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CNPJ
            if (string.IsNullOrWhiteSpace(fornecedor.CNPJ))
            {
                erros.Add("CNPJ deve ser informado!");
            }
            else
            {
                fornecedor.CNPJ = fornecedor.CNPJ.Trim();
                fornecedor.CNPJ = fornecedor.CNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
                if (!this.ValidarCNPJ(fornecedor.CNPJ))
                {
                    erros.Add("CNPJ inválido");
                }
            }

            #endregion

            #region Telefone
            if (string.IsNullOrWhiteSpace(fornecedor.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                fornecedor.Telefone =
                    fornecedor.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (fornecedor.Telefone.Length < 8 || fornecedor.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            if (string.IsNullOrWhiteSpace(fornecedor.Email))
            {
                erros.Add("Email deve ser informado!");
            }
            bool isEmail = Regex.IsMatch(fornecedor.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
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
                response.Success = false;
                response.Message = ErrosFornecedor.ToString();
                return response;
            }
            response = dal.Inserir(fornecedor);
            return response;
        }
        #endregion

        #region Atualizar
        /// <summary>
        /// Verifica se os dados do Fornecedor estão corretos. Se estiverem, os dados do Fornecedor são atualizados no banco.
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public MessageResponse Atualizar(Fornecedor fornecedor)
        {
            List<string> erros = new List<string>();

            #region Nome Empresa
            if (string.IsNullOrWhiteSpace(fornecedor.NomeEmpresa))
            {
                erros.Add("O nome da empresa deve ser informado");
            }
            else
            {
                fornecedor.NomeContato = Regex.Replace(fornecedor.NomeContato, " {2,}", " ");
                fornecedor.NomeContato = fornecedor.NomeContato.Trim();
                if (fornecedor.NomeEmpresa.Length < 2 || fornecedor.NomeEmpresa.Length > 60)
                {
                    erros.Add("Nome da Empresa deve conter entre 2 e 60 caracteres.");
                }
            }
            #endregion

            #region Nome Contato
            if (string.IsNullOrWhiteSpace(fornecedor.NomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                fornecedor.NomeContato = Regex.Replace(fornecedor.NomeContato, " {2,}", " ");
                fornecedor.NomeContato = fornecedor.NomeContato.Trim();
                if (fornecedor.NomeContato.Length < 3 || fornecedor.NomeContato.Length > 60)
                {
                    erros.Add("Nome para contato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fornecedor.NomeContato.Length; i++)
                    {
                        if (!char.IsLetter(fornecedor.NomeContato[i]) && fornecedor.NomeContato[i] != ' ')
                        {
                            erros.Add("Nome para contato inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CNPJ
            if (string.IsNullOrWhiteSpace(fornecedor.CNPJ))
            {
                erros.Add("CNPJ deve ser informado!");
            }
            else
            {
                fornecedor.CNPJ = fornecedor.CNPJ.Trim();
                fornecedor.CNPJ = fornecedor.CNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
                if (!this.ValidarCNPJ(fornecedor.CNPJ))
                {
                    erros.Add("CNPJ inválido");
                }
            }

            #endregion

            #region Telefone
            if (string.IsNullOrWhiteSpace(fornecedor.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                fornecedor.Telefone =
                    fornecedor.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (fornecedor.Telefone.Length < 8 || fornecedor.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            if (string.IsNullOrWhiteSpace(fornecedor.Email))
            {
                erros.Add("Email deve ser informado!");
            }
            bool isEmail = Regex.IsMatch(fornecedor.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            MessageResponse response = new MessageResponse();
            StringBuilder ErrosFornecedor = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    ErrosFornecedor.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = ErrosFornecedor.ToString();
                return response;
            }
            response = dal.Atualizar(fornecedor);
            return response;
        }
        #endregion

        #region Excluir
        /// <summary>
        /// Exclui o Fornecedor com o ID em questão do banco de dados.
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public MessageResponse Excluir(Fornecedor fornecedor)
        {
            if (dal.VerificarExistenciaVenda(fornecedor.ID))
            {
                response.Success = false;
                response.Message = "Fornecedor inexistente!";
            }
            response = dal.Excluir(fornecedor);
            return response;
        }
        #endregion

        #region Ler Por ID
        /// <summary>
        /// Pesquisa pelo Fornecedor com o ID especificado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Fornecedor LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        /// <summary>
        /// Traz uma lista com todos os Fornecedores do banco de dados.
        /// </summary>
        /// <returns></returns>
        public List<Fornecedor> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion

        #region Pesquisar Por Nome da Empresa
        /// <summary>
        /// Traz uma lista com os Fornecedores que possuem o nome da empresa parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="NomeEmpresa"></param>
        /// <returns></returns>
        public List<Fornecedor> PesquisarPorNomeEmpresa(string NomeEmpresa)
        {
            return dal.PesquisarPorNomeEmpresa(NomeEmpresa);
        }
        #endregion

        #region Pesquisar Por CNPJ
        /// <summary>
        /// Traz uma lista com os Fornecedores que possuem um CNPJ parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <returns></returns>
        public List<Fornecedor> PesquisarPorCNPJ(string CNPJ)
        {
            return dal.PesquisarPorCNPJ(CNPJ);
        }
        #endregion

        #region Pesquisar Por Nome
        /// <summary>
        /// Traz uma lista com os Fornecedores que possuem um nome parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        public List<Fornecedor> PesquisarPorNome(string Nome)
        {
            return dal.PesquisarPorNome(Nome);
        }
        #endregion
    }
}
