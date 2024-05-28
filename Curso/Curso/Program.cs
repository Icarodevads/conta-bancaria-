using Curso;
using System;
using System.ComponentModel.Design;
using System.Globalization;
namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre o numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            Char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("========================================================================================");
                Console.Write("Entre o valor de depósito inicial");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("========================================================================================");
            Console.Write("Deseja fazer um depósito extra? (s/n)? ");
            char resp1 = char.Parse(Console.ReadLine());

            if (resp1 == 's' || resp1 == 'S')
            {
                while (true)
                {
                    Console.WriteLine("========================================================================================");
                    Console.Write("Entre o valor de depósito Extra: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.DepositoExtra(quantia);

                    Console.Write("Deseja fazer outro depósito extra? (s/n)? ");
                    char respNovoDeposito = char.Parse(Console.ReadLine());

                    if (respNovoDeposito != 's' && respNovoDeposito != 'S')
                    {
                        break; // Sai do loop se a resposta não for 's' ou 'S'
                    }
                }
            }

            else
            {
                Console.WriteLine("========================================================================================");
                Console.WriteLine("Não foram realizados depósitos extras.");
            }

            Console.WriteLine(conta);
            // Console.WriteLine(conta);
            Console.WriteLine("========================================================================================");
            Console.Write("Deseja sacar ? (s/n)?");
            Char resp2 = char.Parse(Console.ReadLine());
            if (resp2 == 's' || resp2 == 'S')
            {
                Console.WriteLine("========================================================================================");
                Console.Write("Entre o valor de saque");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Verifica se há saldo suficiente para realizar o saque
                if (conta.Saldo >= quantia)
                {
                    conta.Saque(quantia);
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("Saque realizado com sucesso.");

                }



                else
                {
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("Saldo insuficiente para saque");
                }


            }

            else
            {
                Console.WriteLine("========================================================================================");
                Console.WriteLine("finalizando o atendimento");
            }


            Console.WriteLine(conta);









        }
    }
}