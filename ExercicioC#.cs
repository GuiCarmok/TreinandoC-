using System;
using System.Globalization;

namespace ExerciciosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta;
            
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char pergunta = char.Parse(Console.ReadLine());

            
            
            
            if (pergunta == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCorrente(numero, titular, deposito);
                Console.WriteLine();
                Console.WriteLine(conta);
                Console.WriteLine();                
            }
            else
            {
                conta = new ContaCorrente(numero, titular);
                Console.WriteLine();
                Console.WriteLine(conta);
                Console.WriteLine();
            }
            
            Console.Write("Entre um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

        }
    }
}
