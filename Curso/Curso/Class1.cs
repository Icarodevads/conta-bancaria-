using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class ContaBancaria
    {
       public int Numero { get; private set; }
        public string Titular { get; set; } 
        public double Saldo { get; private set; }

        public ContaBancaria (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        public ContaBancaria(int numero, string titular, double saldo):this(numero,titular)
        {
            Saldo = saldo;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
            Saldo += 5.0;
        }
        public void DepositoExtra(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {

            Saldo -= quantia;
        }

        public override string ToString()
        {
            return "Conta:"
                + Numero + ","
                +"Titular:" 
                + Titular 
                + ","
                +"Saldo :"
                + Saldo.ToString("f2",CultureInfo.InvariantCulture);    

                    
        }

    }
       
         
    


    
}
