using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_2
{
    public class Produtox
    {
        public Produtox(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
