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

            #region Estado
            if (string.IsNullOrWhiteSpace(endereco.Estado))
            {
                erros.Add("Estado deve ser informado");
            }
            //else
            //{
            //    if (endereco.Estado.ToLower() != "sc" && endereco.Estado.ToLower() != "rs" && endereco.Estado.ToLower() != "sp"
            //        && endereco.Estado.ToLower() != "ac" && endereco.Estado.ToLower() != "pr" && endereco.Estado.ToLower() != "al" && endereco.Estado.ToLower() != "ap" &&
            //         endereco.Estado.ToLower() != "am" && endereco.Estado.ToLower() != "ba" && endereco.Estado.ToLower() != "ce" && endereco.Estado.ToLower() != "df"
            //         && endereco.Estado.ToLower() != "es" && endereco.Estado.ToLower() != "go" && endereco.Estado.ToLower() != "ma" && endereco.Estado.ToLower() != "mt"
            //         && endereco.Estado.ToLower() != "ms" && endereco.Estado.ToLower() != "mg" && endereco.Estado.ToLower() != "pa" && endereco.Estado.ToLower() != "pb"
            //         && endereco.Estado.ToLower() != "pe" && endereco.Estado.ToLower() != "pi" && endereco.Estado.ToLower() != "rj" && endereco.Estado.ToLower() != "rn"
            //         && endereco.Estado.ToLower() != "ro" && endereco.Estado.ToLower() != "rr" && endereco.Estado.ToLower() != "se" && endereco.Estado.ToLower() != "to")
            //    {
            //        erros.Add("Estado inválido");
            //    }
            //}
            EstadoDAL estdal = new EstadoDAL();

            if (!estdal.VerificarExistenciaEstado(endereco.Estado))
            {
                erros.Add("Estado inexistente!");
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
