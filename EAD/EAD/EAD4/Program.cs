using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse(Console.ReadLine());
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Houve falta de argumento.",ex);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Formato incorreto.", ex);
                //throw new Exception(""Formato incorreto.""); para gerar uma exeção
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Valor fora da faixa válida.", ex);
            }
            Console.ReadKey();
        }
    }
}
