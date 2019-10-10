using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dolar d = 10.58;
            // double valor = d;
            // Console.WriteLine($"d {d.Valor}  e  valor {valor}");

            Dolar d = (Dolar)10.58;
            double valor = (double)d;
            Console.WriteLine($"d {d.Valor}  e  valor {valor}") ;
        }

        public class Dolar
        {
            public double Valor { get; set; }

            //public static implicit operator double(Dolar dolar)
            //{
            //    return dolar.Valor;
            //}

           // public static implicit operator Dolar(double valorRecebido)
           // {
           //     return new Dolar() { Valor = valorRecebido };
           // }

            public static explicit operator Dolar(double valorRecebido)
            {
                return new Dolar() { Valor = valorRecebido };
            }

            public static explicit operator double(Dolar dolar)
            {
                return dolar.Valor;
            }
        }
    }
}
