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
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 2; j <= i; j++)
                    if (j % 2 == 0) Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
