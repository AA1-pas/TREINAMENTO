using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte a = 100; // de 0 - 255 int8
            short b = 100; // int16
            int c = 100; // int32
            long d = 100; // int64
            float e = 10.8f; // Single - tem que por f
            float ee = (float)10.8;
            double f = 10.75; //Double
            decimal g = 11.58m; //Decimal tem que por m
            decimal gg = (decimal)11.58;
            
            sbyte i = 127; // de -128 á 127 int8
            ushort j = 115; // somente positivos int16
            uint h = 155; // somente positivos int32
            ulong k = 125; // somente positivo int64

            string l = "s"; // unico dos "primitivos"que não é struct e sim class

            Cesta cesta = new Cesta();
            cesta.Fruta = teste2.abacate | teste2.Cenoura;
            if (cesta.Fruta.HasFlag(teste2.abacate))
                Console.WriteLine("ok");
            Console.ReadLine();
        }

        enum Teste
        {
            banana, laranja, abacaxi
        }

        [Flags]
        enum teste2 
        {
            limao = 1,
            abacate = 2,
            Cenoura = 4,
            alface = 8
        }

       class Cesta
        {
            public teste2 Fruta { get; set; }
            public int Quantidade { get; set; }
        }
    }
}
