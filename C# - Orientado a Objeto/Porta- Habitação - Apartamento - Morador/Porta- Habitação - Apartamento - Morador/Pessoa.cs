﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    public abstract class Pessoa 
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        

    }
}
