using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2
{
    public class Conta
    {
        public string NumeroConta { get; set;}
        public double Saldo { get; set;}

        public Conta(string numeroConta)
        {
            NumeroConta = numeroConta;
            Saldo = 0;
        }

        // Metodo para depositar dinheiro na conta (adicionar dinheiro na conta)
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return false;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            return true;
        }

        public void ChecarInfoConta(Conta conta, Cliente cliente) // Aqui ele bota os parametros dos que já foram criados, como o Nome do Cliente, CPF, NumeroConta e Saldo vieram da Conta do Cliente.
        {
            Console.WriteLine("--/-- INFORMAÇÕES DA SUA CONTA --/--");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
            Console.WriteLine($"Saldo: {conta.Saldo:C}");
            Console.WriteLine("--/-- FIM --/--");
        }
    }
}