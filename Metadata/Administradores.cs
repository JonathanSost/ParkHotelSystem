﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Administradores
    {
        public Administradores(int id, string nome, string cpf, string rg, Enderecos endereco, string telefone, string email, string senha)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;

        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Enderecos Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
