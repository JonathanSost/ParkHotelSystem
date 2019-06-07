﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produtos
    {
        public Produtos(int id, string nome, string descricao, double preco)
        {
            this.ID = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public string LerDadosProduto()
        {
            return Nome + "\r\n" + Descricao + "\r\n" + Preco + "\r\n";
        }
    }
}