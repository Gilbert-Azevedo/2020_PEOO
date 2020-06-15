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
            // Entrada de dados
            Console.WriteLine("Informe os valores iniciais de base e altura do retângulo");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            // Instancia a classe
            Retangulo r = new Retangulo(b, h);
            // Dados do objeto
            Console.WriteLine($"Objeto = {r}");
            Console.WriteLine($"Base = {r.GetBase()}");
            Console.WriteLine($"Altura = {r.GetAltura()}");
            Console.WriteLine($"Área = {r.CalcArea()}");
            Console.WriteLine($"Diagonal = {r.CalcDiagonal()}");
            // Novos dados
            Console.WriteLine("Informe novos valores de base e altura");
            r.SetBase(double.Parse(Console.ReadLine()));
            r.SetAltura(double.Parse(Console.ReadLine()));
            // Dados do objeto
            Console.WriteLine($"Objeto = {r}");
            Console.WriteLine($"Base = {r.GetBase()}");
            Console.WriteLine($"Altura = {r.GetAltura()}");
            Console.WriteLine($"Área = {r.CalcArea()}");
            Console.WriteLine($"Diagonal = {r.CalcDiagonal()}");
            Console.ReadKey();
        }
    }
}
