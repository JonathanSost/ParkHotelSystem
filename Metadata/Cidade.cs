﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cidade
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(int id, string nome, Estado estado)
        {
            this.ID = id;
            this.Nome = nome;
            this.Estado = estado;
        }
    }
}
