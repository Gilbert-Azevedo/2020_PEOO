using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int a = x; int b = y;
            int r = x % y;
            while (r != 0) { x = y; y = r; r = x % y; } // Algortimo de Euclides
            Console.WriteLine($"MDC = {y}");
            Console.WriteLine($"MMC = {a*b/y}");
            Console.ReadKey();
        }
    }
}
