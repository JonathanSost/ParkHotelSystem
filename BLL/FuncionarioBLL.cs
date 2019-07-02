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
    public class FuncionarioBLL
    {
        #region Validar CPF
        /// <summary>
        /// Realiza a validação do CPF do Funcionário.
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

        FuncionarioDAL dal = new FuncionarioDAL();
        MessageResponse response = new MessageResponse();

        #region Logar
        /// <summary>
        /// Realiza o Login do Funcionário.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Funcionario Logar(string usuario, string senha)
        {
            return dal.Logar(usuario, senha);
        }
        #endregion

        #region Cadastrar
        /// <summary>
        /// Verifica se os dados do Funcionário estão corretos. Se estiverem, o Funcionário é cadastrado no banco.
        /// </summary>
        /// <param name="fun"></param>
        /// <returns></returns>
        public MessageResponse Cadastrar(Funcionario fun)
        {
            MessageResponse response = new MessageResponse();
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(fun.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                fun.Nome = Regex.Replace(fun.Nome, " {2,}", " ");
                fun.Nome = fun.Nome.Trim();
                if (fun.Nome.Length < 3 || fun.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fun.Nome.Length; i++)
                    {
                        if (!char.IsLetter(fun.Nome[i]) && fun.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(fun.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {

                fun.CPF = fun.CPF.Trim();
                fun.CPF = fun.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(fun.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(fun.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                fun.RG = fun.RG.Trim();
                fun.RG = fun.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (fun.RG.Length < 5 || fun.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region Endereço

            #region CEP
            if (string.IsNullOrWhiteSpace(fun.CEP))
            {
                erros.Add("CEP deve ser informado");
            }
            else
            {
                fun.CEP =
                fun.CEP.Replace(" ", "").Replace("-", "");



                if (fun.CEP.Length != 8)
                {
                    erros.Add("CEP deve conter 8 digitos");
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (!char.IsNumber(fun.CEP[i]))
                        {
                            erros.Add("CEP deve conter apenas numeros");
                            break;
                        }
                    }

                }
            }
            #endregion

            #region Estado
            //if (string.IsNullOrWhiteSpace(fun.Estado))
            //{
            //    erros.Add("Estado deve ser informado");
            //}

            EstadoDAL estdal = new EstadoDAL();

            if (!estdal.VerificarExistenciaEstado(fun.Estado))
            {
                erros.Add("Estado inexistente!");
            }
            #endregion

            #region Cidade
            CidadeDAL cidades = new CidadeDAL();
            if (!cidades.VerificarExistenciaCidade(fun.Cidade))
            {
                erros.Add("Cidade inexistente!");
            }
            #endregion

            #region Bairro
            if (string.IsNullOrWhiteSpace(fun.Bairro))
            {
                erros.Add("Bairro deve ser informado");
            }
            else
            {
                fun.Bairro = fun.Bairro.Replace(" ", "");
                if (fun.Bairro.Length < 3 || fun.Bairro.Length > 50)
                {
                    erros.Add("Bairro deve conter entre 3 e 50 caracteres");
                }

            }
            #endregion

            #region Rua
            if (string.IsNullOrWhiteSpace(fun.Rua))
            {
                erros.Add("Rua deve ser informada");
            }
            else
            {
                fun.Rua = fun.Rua.Replace(" ", "");
                if (fun.Rua.Length < 3 || fun.Rua.Length > 70)
                {
                    erros.Add("Rua deve conter entre 3 e 70 caracteres");
                }

            }
            #endregion

            #region Numero
            if (string.IsNullOrWhiteSpace(fun.Numero))
            {
                erros.Add("Número deve ser informado");
            }
            else
            {
                for (int i = 0; i < fun.CEP.Length; i++)
                {
                    if (!char.IsNumber(fun.CEP[i]))
                    {
                        erros.Add("Número de residência inválido");
                    }
                }
            }
            #endregion

            #endregion

            #region Telefone
            if (string.IsNullOrWhiteSpace(fun.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                fun.Telefone =
                    fun.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (fun.Telefone.Length < 8 || fun.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            bool isEmail = Regex.IsMatch(fun.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(fun.Email))
            {
                erros.Add("Email deve ser informado.");
            }
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            #region Senha
            if (string.IsNullOrWhiteSpace(fun.Senha))
            {
                erros.Add("Senha deve ser informada.");
            }

            else
            {
                fun.Senha = fun.Senha.Trim();
                if (fun.Senha.Length < 8 || fun.Senha.Length > 25)
                {
                    erros.Add("Senha deve conter entre 8 e 25 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fun.Senha.Length; i++)
                    {
                        if (!char.IsLetter(fun.Senha[i]) && !char.IsNumber(fun.Senha[i]))
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
                response.Success = false;
                response.Message = errosCliente.ToString();
                return response;
            }
            //chamar o DAL para cadastrar
            response = dal.Inserir(fun);
            response.Message = "Funcionário cadastrado com sucesso!";
            return response;
        }
        #endregion

        #region Atualizar
        /// <summary>
        /// Verifica se os dados do Funcionário estão corretos. Se estiverem, os dados do Funcionário são atualizados no banco.
        /// </summary>
        /// <param name="fun"></param>
        /// <returns></returns>
        public MessageResponse Atualizar(Funcionario fun)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(fun.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                fun.Nome = Regex.Replace(fun.Nome, " {2,}", " ");
                fun.Nome = fun.Nome.Trim();
                if (fun.Nome.Length < 3 || fun.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fun.Nome.Length; i++)
                    {
                        if (!char.IsLetter(fun.Nome[i]) && fun.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(fun.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {

                fun.CPF = fun.CPF.Trim();
                fun.CPF = fun.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(fun.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(fun.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                fun.RG = fun.RG.Trim();
                fun.RG = fun.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (fun.RG.Length < 5 || fun.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region Endereço

            #region CEP
            if (string.IsNullOrWhiteSpace(fun.CEP))
            {
                erros.Add("CEP deve ser informado");
            }
            else
            {
                fun.CEP =
                fun.CEP.Replace(" ", "").Replace("-", "");



                if (fun.CEP.Length != 8)
                {
                    erros.Add("CEP deve conter 8 digitos");
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (!char.IsNumber(fun.CEP[i]))
                        {
                            erros.Add("CEP deve conter apenas numeros");
                            break;
                        }
                    }

                }
            }
            #endregion

            #region Estado
            //if (string.IsNullOrWhiteSpace(fun.Estado))
            //{
            //    erros.Add("Estado deve ser informado");
            //}

            EstadoDAL estdal = new EstadoDAL();

            if (!estdal.VerificarExistenciaEstado(fun.Estado))
            {
                erros.Add("Estado inexistente!");
            }
            #endregion

            #region Cidade
            CidadeDAL cidades = new CidadeDAL();
            if (!cidades.VerificarExistenciaCidade(fun.Cidade))
            {
                erros.Add("Cidade inexistente!");
            }
            #endregion

            #region Bairro
            if (string.IsNullOrWhiteSpace(fun.Bairro))
            {
                erros.Add("Bairro deve ser informado");
            }
            else
            {
                fun.Bairro = Regex.Replace(fun.Bairro, " {2,}", " ");
                if (fun.Bairro.Length < 3 || fun.Bairro.Length > 50)
                {
                    erros.Add("Bairro deve conter entre 3 e 50 caracteres");
                }

            }
            #endregion

            #region Rua
            if (string.IsNullOrWhiteSpace(fun.Rua))
            {
                erros.Add("Rua deve ser informada");
            }
            else
            {
                fun.Rua = Regex.Replace(fun.Rua, " {2,}", " ");
                if (fun.Rua.Length < 3 || fun.Rua.Length > 70)
                {
                    erros.Add("Rua deve conter entre 3 e 70 caracteres");
                }

            }
            #endregion

            #region Numero
            if (string.IsNullOrWhiteSpace(fun.Numero))
            {
                erros.Add("Número deve ser informado");
            }
            else
            {
                for (int i = 0; i < fun.CEP.Length; i++)
                {
                    if (!char.IsNumber(fun.CEP[i]))
                    {
                        erros.Add("Número de residência inválido");
                    }
                }
            }
            #endregion

            #endregion

            #region Telefone
            if (string.IsNullOrWhiteSpace(fun.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                fun.Telefone =
                    fun.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (fun.Telefone.Length < 8 || fun.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Email
            bool isEmail = Regex.IsMatch(fun.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(fun.Email))
            {
                erros.Add("Email deve ser informado.");
            }
            if (!isEmail)
            {
                erros.Add("Email inválido.");
            }
            #endregion

            #region Senha
            if (string.IsNullOrWhiteSpace(fun.Senha))
            {
                erros.Add("Senha deve ser informada.");
            }

            else
            {
                fun.Senha = fun.Senha.Trim();
                if (fun.Senha.Length < 8 || fun.Senha.Length > 25)
                {
                    erros.Add("Senha deve conter entre 8 e 25 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fun.Senha.Length; i++)
                    {
                        if (!char.IsLetter(fun.Senha[i]) && !char.IsNumber(fun.Senha[i]))
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
                response.Success = false;
                response.Message = errosCliente.ToString();
                return response;
            }
            return dal.Atualizar(fun);
        }
        #endregion

        #region Excluir
        /// <summary>
        /// Exclui o Funcionário com o ID em questão do banco de dados.
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public MessageResponse Excluir(Funcionario funcionario)
        {
            if (!dal.VerificarExistenciaFuncionario(funcionario.ID))
            {
                response.Success = false;
                response.Message = "Funcionário inexistente!";
            }
            return dal.Excluir(funcionario);
        }
        #endregion

        #region Ler Por ID
        /// <summary>
        /// Pesquisa pelo Funcionário com o ID especificado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Funcionario LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        /// <summary>
        /// Traz uma lista com todos os Funcionários do banco de dados.
        /// </summary>
        /// <returns></returns>
        public List<Funcionario> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion

        #region Ler Funcionários
        /// <summary>
        /// Traz uma lista com todos os Funcionários do banco de dados, porém, de forma mais organizada.
        /// </summary>
        /// <param name="funci"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> LerFuncionarios(Funcionario funci)
        {
            return dal.LerFuncionarios(funci);
        }
        #endregion

        public bool VerificarExistenciaFuncionario(int idFuncionario)
        {
            return dal.VerificarExistenciaFuncionario(idFuncionario);
        }

        public bool VerificarExistenciaFuncionarioA()
        {
            return dal.VerificarExistenciaFuncionarioA();
        }

        #region Pesquisar Por Nome
        /// <summary>
        /// Traz uma lista com os Funcionários que possuem um nome parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="funci"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorNome(string Nome, Funcionario funci)
        {
            return dal.PesquisarPorNome(Nome, funci);
        }
        #endregion

        #region Pesquisar Por CPF
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem um CPF parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorCPF(string CPF)
        {
            return dal.PesquisarPorCPF(CPF);
        }
        #endregion

        #region Pesquisar Por RG
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem um RG parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="RG"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorRG(string RG)
        {
            return dal.PesquisarPorRG(RG);
        }
        #endregion

        #region Pesquisar Por Estado
        /// <summary>
        /// Traz uma lista com os Funcionarios que residem em tal Estado.
        /// </summary>
        /// <param name="Estado"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorEstado(int Estado)
        {
            return dal.PesquisarPorEstado(Estado);
        }
        #endregion

        #region Pesquisar Por Cidade
        /// <summary>
        /// Traz uma lista com os Funcionarios que residem em tal Cidade.
        /// </summary>
        /// <param name="Cidade"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorCidade(int Cidade)
        {
            return dal.PesquisarPorCidade(Cidade);
        }
        #endregion

        #region Pesquisar Por CEP
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem um CEP parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="CEP"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorCEP(string CEP)
        {
            return dal.PesquisarPorCEP(CEP);
        }
        #endregion

        #region Pesquisar Por Bairro
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem um Bairro parecido com o do parâmetro passado.
        /// </summary>
        /// <param name="Bairro"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorBairro(string Bairro)
        {
            return dal.PesquisarPorBairro(Bairro);
        }
        #endregion

        #region Pesquisar Por Rua
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem uma Rua parecida com a do parâmetro passado.
        /// </summary>
        /// <param name="Rua"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarPorRua(string Rua)
        {
            return dal.PesquisarPorRua(Rua);
        }
        #endregion

        #region Pesquisar Admin
        /// <summary>
        /// Traz uma lista com os Funcionarios que possuem acesso de Administrador.
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public List<FuncionarioViewModel> PesquisarAdmin(bool Admin)
        {
            return dal.PesquisarAdmin(Admin);
        }
        #endregion
    }
}
