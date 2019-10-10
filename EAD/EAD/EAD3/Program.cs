using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;
            DateTime aniversario = new DateTime(1989, 04, 30);
            TimeSpan tempo = agora - aniversario;
            Console.WriteLine("{0} / {1}", tempo.TotalDays/365, tempo.TotalHours);
            Console.ReadLine();

        }
    }
}
