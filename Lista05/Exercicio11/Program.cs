using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {            
            string s = "Geovana adora programar em C#";
            int p = s.IndexOf(" ");
            while (p != -1) {
                Console.WriteLine(p);
                string x = s.Substring(0, p);
                Console.WriteLine(x);
                s = s.Substring(p + 1); 
                p = s.IndexOf(" ");
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
