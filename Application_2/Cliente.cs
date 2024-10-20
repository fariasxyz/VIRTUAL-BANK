using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2
{
    public class Cliente
    {
        public string Nome { get; set;}
        public string CPF { get; set;}
        public string Senha { get; set;}

        public Cliente(string nome, string cpf, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Senha = senha;
        }
    }
}