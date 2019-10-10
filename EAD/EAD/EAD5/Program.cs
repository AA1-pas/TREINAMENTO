using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaGolde saldo = new ContaGolde();
            saldo.Sacar(300);
            Console.ReadKey();
        }

        public class ContaBancaria
        {
            public double Saldo { get; private set; } // O private não deixa sobscrever o saldo -  no lugar de private poderia se protected 
            public virtual void Sacar(double quantia)
            {
                if (quantia < 0)
                {
                    throw new Exception("Quantia insuficiente.");
                }
                Saldo -= quantia;
            }
        }

        public class ContaGolde : ContaBancaria
        {
            public double Limite { get; protected set; }
            public override void Sacar(double quantia)
            {
                if (quantia > Saldo)
                {
                    Limite = quantia - Saldo;
                }
                base.Sacar(quantia);
            }
        }

        public class ContaUniversitaria : ContaBancaria
        {
            public override void Sacar(double quantia)
            {
                if (quantia > Saldo)
                {
                    throw new Exception("Saldo insuficiente");
                }
                base.Sacar(quantia);
            }
        }
    }
}
