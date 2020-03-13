using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExString
{
    class Program
    {
        static void Main(string[] args)
        {
            //          01234567890123456
            string s = "Esta é uma string. Ficou maior agora";
            Console.WriteLine(s[0]); // 'E'
            Console.WriteLine(s[1]); // 's'
            // Procurar um texto na string
            int p = s.IndexOf("uma");     // Posição 7 = início de uma em s
            string x = s.Substring(7, 3); // "uma" - 7=ínicio 3=tamanho
            string y = s.Substring(11);   // "string" - da posição 11 até o final
            Console.WriteLine(p);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s.Length); // Tamanho = 17
            int e = s.IndexOf(' ');      // Posição do espaço = 4
            Console.WriteLine(s);
            Console.WriteLine(s.Substring(e + 1));
            Console.WriteLine(s);
            s = s.Substring(e + 1);      // Pega a string após o espaço
            Console.WriteLine(s);
            // Pegar o segundo espaço
            e = s.IndexOf(' ');          // Procura o primeiro espaço
            Console.WriteLine(e);
            e = s.IndexOf(' ', e + 1);   // Procura o segundo espaço
            Console.WriteLine(e);
            e = s.IndexOf('x');          // Procura a primeira letra 'x'
            Console.WriteLine(e);
            // Contar palavras: 1. Usando IndexOf
            e = s.IndexOf(' ');
            int k = 0;
            while (e != -1)
            {
                k++;
                e = s.IndexOf(' ', e + 1);   // Procura o outro espaço
            }
            Console.WriteLine(k);
            // Contar palavras: 2. Usando []
            k = 0;
            for (e = 0; e < s.Length; e++)
                if (s[e] == ' ') k++;
            Console.WriteLine(k);
            // Contar palavras: 3. Usando Split
            string[] v = s.Split(' ');
            Console.WriteLine(v[0]);
            Console.WriteLine(v[1]);
            Console.WriteLine(v[2]);
            Console.WriteLine(v.Length);
            Console.WriteLine(v[0].Length);
            Console.WriteLine(v[1].Length);
            Console.WriteLine(v[2].Length);

            s = "Teste 123";
            if (s.StartsWith("T")) Console.WriteLine("ok");
            Console.WriteLine(s.Substring(0, 5));
            Console.WriteLine(s.Remove(0, 5));

            s = "abc ghi def rst jkl";
            v = s.Split(' ');
            foreach (string ss in v) Console.WriteLine(ss);
            Array.Sort(v);
            Array.Reverse(v);
            foreach (string ss in v) Console.WriteLine(ss);

            e = 10;
            Console.WriteLine(e);
            Console.WriteLine(++e);
            Console.WriteLine(e++);
            Console.WriteLine(e);
            e = 10;
            double r = e++ / 2;
            //r = e / 2;
            //e = e + 1;
            double t = ++e / 2;
            //e = e + 1;
            //t = e / 2;

            Console.WriteLine(r); // 10/2 = 5
            Console.WriteLine(t); // 12/2 = 6


            Console.ReadKey();

        }
    }
}
