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
    public class ClienteBLL
    {
        MessageResponse response = new MessageResponse();
        ClienteDAL dal = new ClienteDAL();
        List<string> erros = null;

        #region Validar CPF
        /// <summary>
        /// Método para verificar se o CPF em questão atende aos padrões de um CPF normalizado no Brasil.
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        private bool ValidarCPF(string cpf)
        {
            #region Codigo Validar CPF
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Replace(".", "").Replace("-", "");

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
        #endregion

        #region Cadastrar
        /// <summary>
        /// Verifica se os dados do Cliente estão corretos. Se estiverem, o Cliente é cadastrado no banco.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public MessageResponse Cadastrar(Cliente cli)
        {
            MessageResponse response = new MessageResponse();
            erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(cli.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                cli.Nome = Regex.Replace(cli.Nome, " {2,}", " ");
                cli.Nome = cli.Nome.Trim();
                if (cli.Nome.Length < 3 || cli.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < cli.Nome.Length; i++)
                    {
                        if (!char.IsLetter(cli.Nome[i]) && cli.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(cli.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            if (dal.ChecarCPF(cli.CPF))
            {
                erros.Add("CPF já cadastrado.");
            }
            else
            {
                cli.CPF = cli.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(cli.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cli.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            if (dal.ChecarRG(cli.RG))
            {
                erros.Add("RG já cadastrado.");
            }
            else
            {
                cli.RG = cli.RG.Trim();
                cli.RG = cli.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cli.RG.Length < 5 || cli.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region Endereço

            #region CEP
            if (string.IsNullOrWhiteSpace(cli.CEP))
            {
                erros.Add("CEP deve ser informado");
            }
            else
            {
                cli.CEP =
                cli.CEP.Replace(" ", "").Replace("-", "");



                if (cli.CEP.Length != 8)
                {
                    erros.Add("CEP deve conter 8 digitos");
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (!char.IsNumber(cli.CEP[i]))
                        {
                            erros.Add("CEP deve conter apenas numeros");
                            break;
                        }
                    }

                }
            }
            #endregion

            #region Estado
            //if (int.IsNullOrWhiteSpace(cli.Estado))
            //{
            //    erros.Add("Estado deve ser informado");
            //}
            //
            EstadoDAL estdal = new EstadoDAL();
            
            if (!estdal.VerificarExistenciaEstado(cli.Estado))
            {
                erros.Add("Estado inexistente!");
            }
            #endregion

            #region Cidade
            CidadeDAL cidades = new CidadeDAL();
            if (!cidades.VerificarExistenciaCidade(cli.Cidade))
            {
                erros.Add("Cidade inexistente!");
            }
            #endregion

            #region Bairro
            if (string.IsNullOrWhiteSpace(cli.Bairro))
            {
                erros.Add("Bairro deve ser informado");
            }
            else
            {
                cli.Bairro = Regex.Replace(cli.Bairro, " {2,}", " ");
                if (cli.Bairro.Length < 3 || cli.Bairro.Length > 50)
                {
                    erros.Add("Bairro deve conter entre 3 e 50 caracteres");
                }

            }
            #endregion

            #region Rua
            if (string.IsNullOrWhiteSpace(cli.Rua))
            {
                erros.Add("Rua deve ser informada");
            }
            else
            {
                cli.Rua = cli.Rua.Replace(" ", "");
                if (cli.Rua.Length < 3 || cli.Rua.Length > 70)
                {
                    erros.Add("Rua deve conter entre 3 e 70 caracteres");
                }

            }
            #endregion

            #region Numero
            if (string.IsNullOrWhiteSpace(cli.Numero))
            {
                erros.Add("Número deve ser informado");
            }
            else
            {
                for (int i = 0; i < cli.CEP.Length; i++)
                {
                    if (!char.IsNumber(cli.CEP[i]))
                    {
                        erros.Add("Número de residência inválido");
                    }
                }
            }
            #endregion

            #endregion

            #region Telefone1
            if (string.IsNullOrWhiteSpace(cli.Telefone1))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone1 =
                    cli.Telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone1.Length < 8 || cli.Telefone1.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Telefone2
            if (string.IsNullOrWhiteSpace(cli.Telefone2))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone2 =
                    cli.Telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone2.Length < 8 || cli.Telefone2.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            bool isEmail = Regex.IsMatch(cli.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(cli.Email))
            {
                erros.Add("Email deve ser informado.");
            }
            if (dal.ChecarEmail(cli.Email))
            {
                erros.Add("E-Mail já cadastrado.");
            }
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            response = dal.Inserir(cli);
            return response;
        }
        #endregion

        #region Atualizar
        /// <summary>
        /// Verifica se os dados do Cliente estão corretos. Se estiverem, os dados do Cliente são atualizados no banco.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public MessageResponse Atualizar(Cliente cli)
        {
            erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(cli.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                cli.Nome = Regex.Replace(cli.Nome, " {2,}", " ");
                cli.Nome = cli.Nome.Trim();
                if (cli.Nome.Length < 3 || cli.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < cli.Nome.Length; i++)
                    {
                        if (!char.IsLetter(cli.Nome[i]) && cli.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(cli.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            if (dal.ChecarCPF(cli.CPF))
            {
                erros.Add("CPF já cadastrado.");
            }
            else
            {
                cli.CPF = cli.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(cli.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cli.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            if (dal.ChecarRG(cli.RG))
            {
                erros.Add("RG já cadastrado.");
            }
            else
            {
                cli.RG = cli.RG.Trim();
                cli.RG = cli.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cli.RG.Length < 5 || cli.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region Endereço

            #region CEP
            if (string.IsNullOrWhiteSpace(cli.CEP))
            {
                erros.Add("CEP deve ser informado");
            }
            else
            {
                cli.CEP =
                cli.CEP.Replace(" ", "").Replace("-", "");



                if (cli.CEP.Length != 8)
                {
                    erros.Add("CEP deve conter 8 digitos");
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (!char.IsNumber(cli.CEP[i]))
                        {
                            erros.Add("CEP deve conter apenas numeros");
                            break;
                        }
                    }

                }
            }
            #endregion

            #region Estado
            //if (int.IsNullOrWhiteSpace(cli.Estado))
            //{
            //    erros.Add("Estado deve ser informado");
            //}
            //
            EstadoDAL estdal = new EstadoDAL();

            if (!estdal.VerificarExistenciaEstado(cli.Estado))
            {
                erros.Add("Estado inexistente!");
            }
            #endregion

            #region Cidade
            CidadeDAL cidades = new CidadeDAL();
            if (!cidades.VerificarExistenciaCidade(cli.Cidade))
            {
                erros.Add("Cidade inexistente!");
            }
            #endregion

            #region Bairro
            if (string.IsNullOrWhiteSpace(cli.Bairro))
            {
                erros.Add("Bairro deve ser informado");
            }
            else
            {
                cli.Bairro = Regex.Replace(cli.Bairro, " {2,}", " ");
                if (cli.Bairro.Length < 3 || cli.Bairro.Length > 50)
                {
                    erros.Add("Bairro deve conter entre 3 e 50 caracteres");
                }

            }
            #endregion

            #region Rua
            if (string.IsNullOrWhiteSpace(cli.Rua))
            {
                erros.Add("Rua deve ser informada");
            }
            else
            {
                cli.Rua = cli.Rua.Replace(" ", "");
                if (cli.Rua.Length < 3 || cli.Rua.Length > 70)
                {
                    erros.Add("Rua deve conter entre 3 e 70 caracteres");
                }

            }
            #endregion

            #region Numero
            if (string.IsNullOrWhiteSpace(cli.Numero))
            {
                erros.Add("Número deve ser informado");
            }
            else
            {
                for (int i = 0; i < cli.CEP.Length; i++)
                {
                    if (!char.IsNumber(cli.CEP[i]))
                    {
                        erros.Add("Número de residência inválido");
                    }
                }
            }
            #endregion

            #endregion

            #region Telefone1
            if (string.IsNullOrWhiteSpace(cli.Telefone1))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone1 =
                    cli.Telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone1.Length < 8 || cli.Telefone1.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Telefone2
            if (string.IsNullOrWhiteSpace(cli.Telefone2))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone2 =
                    cli.Telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone2.Length < 8 || cli.Telefone2.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            bool isEmail = Regex.IsMatch(cli.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(cli.Email))
            {
                erros.Add("Email deve ser informado.");
            }
            if (dal.ChecarEmail(cli.Email))
            {
                erros.Add("E-Mail já cadastrado.");
            }
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            return dal.Atualizar(cli);
        }
        #endregion

        #region Excluir
        /// <summary>
        /// Exclui o Cliente com o ID em questão do banco de dados.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public MessageResponse Excluir(Cliente cli)
        {
            List<string> erros = new List<string>();

            if (!dal.VerificarExistenciaCliente(cli.ID))
            {
                erros.Add("Cliente inexistente");
            }
            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            return dal.Excluir(cli);
        }
        #endregion

        #region Ler Por ID
        /// <summary>
        /// Pesquisa pelo Cliente com o ID especificado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        /// <summary>
        /// Traz uma lista com todos os Clientes do banco de dados.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion

        #region Ler Clientes
        /// <summary>
        /// Traz uma lista com todos os Clientes do banco de dados, porém, de forma aprimorada.
        /// </summary>
        /// <returns></returns>
        public List<ClienteViewModel>LerClientes()
        {
            return dal.LerClientes();
        }
        #endregion

        #region Pesquisar Por Nome
        /// <summary>
        /// Traz uma lista com os Clientes que possuem um nome parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorNome(string Nome)
        {
            return dal.PesquisarPorNome(Nome);
        }
        #endregion

        #region Pesquisar Por CPF
        /// <summary>
        /// Traz uma lista com os Clientes que possuem um CPF parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorCPF(string CPF)
        {
            return dal.PesquisarPorCPF(CPF);
        }
        #endregion

        #region Pesquisar Por RG
        /// <summary>
        /// Traz uma lista com os Clientes que possuem um RG parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="RG"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorRG(string RG)
        {
            return dal.PesquisarPorRG(RG);
        }
        #endregion

        #region Pesquisar Por Estado
        /// <summary>
        /// Traz uma lista com os Clientes que residem em tal Estado.
        /// </summary>
        /// <param name="Estado"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorEstado(int Estado)
        {
            return dal.PesquisarPorEstado(Estado);
        }
        #endregion

        #region Pesquisar Por Cidade
        /// <summary>
        /// Traz uma lista com os Clientes que residem em tal Cidade.
        /// </summary>
        /// <param name="Cidade"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorCidade(int Cidade)
        {
            return dal.PesquisarPorCidade(Cidade);
        }
        #endregion

        #region Pesquisar Por CEP
        /// <summary>
        /// Traz uma lista com os Clientes que possuem um CEP parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="CEP"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorCEP(string CEP)
        {
            return dal.PesquisarPorCEP(CEP);
        }
        #endregion

        #region Pesquisar Por Bairro
        /// <summary>
        /// Traz uma lista com os Clientes que possuem um Bairro parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="Bairro"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorBairro(string Bairro)
        {
            return dal.PesquisarPorBairro(Bairro);
        }
        #endregion

        #region Pesquisar Por Rua
        /// <summary>
        /// Traz uma lista com os Clientes que possuem uma Rua parecida com a do parâmetro passado.
        /// </summary>
        /// <param name="Rua"></param>
        /// <returns></returns>
        public List<ClienteViewModel> PesquisarPorRua(string Rua)
        {
            return dal.PesquisarPorRua(Rua);
        }
        #endregion
    }
}
