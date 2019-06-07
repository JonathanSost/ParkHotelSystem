using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class EnderecosBLL
    {
        public string Validar(Enderecos endereco)
        {
            List<string> erros = new List<string>();

            #region CEP
            if (string.IsNullOrWhiteSpace(endereco.CEP))
            {
                erros.Add("CEP deve ser informado");
            }
            else
            {
                endereco.CEP =
                endereco.CEP.Replace(" ", "").Replace("-", "");

                

                if (endereco.CEP.Length != 8)
                {
                    erros.Add("CEP deve conter 8 digitos");
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (!char.IsNumber(endereco.CEP[i]))
                        {
                            erros.Add("CEP deve conter apenas numeros");
                            break;
                        }
                    }

                }
            }
            #endregion


            //afonso cláudio

            #region Estado
            if (string.IsNullOrWhiteSpace(endereco.Estado))
            {
                erros.Add("Estado deve ser informado");
            }
            else
            {
                if (endereco.Estado != "SC" && endereco.Estado != "RS" && endereco.Estado != "SP"
                    && endereco.Estado != "AC" && endereco.Estado != "PR" && endereco.Estado != "AL" && endereco.Estado != "AP" &&
                     endereco.Estado != "AM" && endereco.Estado != "BA" && endereco.Estado != "CE" && endereco.Estado != "DF"
                     && endereco.Estado != "ES" && endereco.Estado != "GO" && endereco.Estado != "MA" && endereco.Estado != "MT"
                     && endereco.Estado != "MS" && endereco.Estado != "MG" && endereco.Estado != "PA" && endereco.Estado != "PB"
                     && endereco.Estado != "PE" && endereco.Estado != "PI" && endereco.Estado != "RJ" && endereco.Estado != "RN"
                     && endereco.Estado != "RO" && endereco.Estado != "RR" && endereco.Estado != "SE" && endereco.Estado != "TO")
                {
                    erros.Add("Estado inválido");
                }
            }
            #endregion

            #region Cidade
            CidadeDAL cidades = new CidadeDAL();
            if (!cidades.VerificarExistenciaCidade(endereco.Cidade))
            {
                erros.Add("Cidade inexistente!");
            }
            #endregion

            #region Bairro
            if (string.IsNullOrWhiteSpace(endereco.Bairro))
            {
                erros.Add("Bairro deve ser informado");
            }
            else
            {
                endereco.Bairro = endereco.Bairro.Replace(" ", "");
                if (endereco.Bairro.Length < 3 || endereco.Bairro.Length > 50)
                {
                    erros.Add("Bairro deve conter entre 3 e 50 caracteres");
                }

            }
            #endregion

            #region Rua
            if (string.IsNullOrWhiteSpace(endereco.Rua))
            {
                erros.Add("Rua deve ser informada");
            }
            else
            {
                endereco.Rua = endereco.Rua.Replace(" ", "");
                if (endereco.Rua.Length < 3 || endereco.Rua.Length > 70)
                {
                    erros.Add("Rua deve conter entre 3 e 70 caracteres");
                }

            }
            #endregion

            #region Numero
            if (string.IsNullOrWhiteSpace(endereco.Numero))
            {
                erros.Add("Número deve ser informado");
            }
            else
            {
                for (int i = 0; i < endereco.CEP.Length; i++)
                {
                    if (!char.IsNumber(endereco.CEP[i]))
                    {
                        erros.Add("Número de residência inválido");
                    }
                }
            }
            #endregion

            StringBuilder ErrosEndereco = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    ErrosEndereco.AppendLine(erros[i]);
                }
            }
            return ErrosEndereco.ToString();
        }
    }
}
