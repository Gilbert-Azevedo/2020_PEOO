using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo x = Console.ReadKey();
            if (x.KeyChar == 's') Console.WriteLine("Você digitou s");
            if (x.KeyChar == 'n') Console.WriteLine("Você digitou n");
            Console.ReadKey();
        }
    }
}
