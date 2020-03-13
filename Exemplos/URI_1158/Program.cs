using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);
                if (x % 2 == 0) x++;
                int soma = 0;
                for (int k = 1; k <= y; k++)
                {
                    soma += x;
                    x += 2;
                }
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
