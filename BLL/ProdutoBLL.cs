﻿using DAL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {

        ProdutoDAL dal = new ProdutoDAL();
        MessageResponse response = new MessageResponse();

        #region Cadastrar
        public MessageResponse Cadastrar (Produto produto)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(produto.Nome))
            {
                erros.Add("Nome do Produto deve ser informado.");
            }
            else
            {
                produto.Nome = produto.Nome.Trim();
                if (produto.Nome.Length < 2 || produto.Nome.Length > 70)
                {
                    erros.Add("Nome do Produto deve conter entre 2 e 70 caracteres.");
                }
            }
            if (produto.Estoque <= 0)
            {
                erros.Add("Quantidade de Estoque inválida.");
            }
            if (string.IsNullOrWhiteSpace(produto.Descricao))
            {
                erros.Add("Descrição do Produto deve ser informada.");
            }
            else
            {
                produto.Descricao = produto.Descricao.Trim();
                if (produto.Descricao.Length < 2 || produto.Descricao.Length > 80)
                {
                    erros.Add("Descrição do Produto deve conter entre 2 e 80 caracteres.");
                }
            }
            if (produto.Preco < 0)
            {
                erros.Add("Valor inexistente.");
            }
            if (erros.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < erros.Count; i++)
                {
                    //Environment.NewLine
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            return dal.Inserir(produto);
        }
        #endregion

        #region Atualizar
        public MessageResponse Atualizar(Produto produto)
        {
            List<string> erros = new List<string>();

            if (!dal.VerificarExistenciaProduto(produto.ID))
            {
                response.Success = false;
                response.Message = "Produto inexistente";
                return response;
            }

            if (string.IsNullOrWhiteSpace(produto.Nome))
            {
                erros.Add("Nome do Produto deve ser informado.");
            }
            else
            {
                produto.Nome = produto.Nome.Trim();
                if (produto.Nome.Length < 2 || produto.Nome.Length > 70)
                {
                    erros.Add("Nome do Produto deve conter entre 2 e 70 caracteres.");
                }
            }
            if (produto.Estoque <= 0)
            {
                erros.Add("Quantidade de Estoque inválida.");
            }
            if (string.IsNullOrWhiteSpace(produto.Descricao))
            {
                erros.Add("Descrição do Produto deve ser informada.");
            }
            else
            {
                produto.Descricao = produto.Descricao.Trim();
                if (produto.Descricao.Length < 2 || produto.Descricao.Length > 80)
                {
                    erros.Add("Descrição do Produto deve conter entre 2 e 80 caracteres.");
                }
            }
            if (produto.Preco < 0)
            {
                erros.Add("Valor inexistente.");
            }
            if (erros.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < erros.Count; i++)
                {
                    //Environment.NewLine
                    builder.AppendLine(erros[i]);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
            return dal.Atualizar(produto);
        }
        #endregion

        #region Excluir
        public MessageResponse Excluir(Produto produto)
        {
            if (!dal.VerificarExistenciaProduto(produto.ID))
            {
                response.Success = false;
                response.Message = "Produto inexistente";
                return response;
            }
            response = dal.Excluir(produto);
            response.Message = "Produto deletado com sucesso!";
            return response;
        }
        #endregion

        #region Ler Por ID
        public Produto LerPorID(int id)
        {
            return dal.LerPorID(id);
        }
        #endregion

        #region Ler Todos
        public List<Produto> LerTodos()
        {
            return dal.LerTodos();
        }
        #endregion
    }
}
