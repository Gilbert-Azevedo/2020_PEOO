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
            // Uma referência para a classe Circulo
            Circulo c;
            // Instancia a classe e faz a referência controlar o objeto
            c = new Circulo();
            // Atribui um valor para o raio
            Console.WriteLine("Informe o raio do círculo");
            c.raio = double.Parse(Console.ReadLine());
            // Calcula e mostra a área e a circunferência
            Console.WriteLine($"Área = {c.CalcArea():0.00}");
            Console.WriteLine($"Circunferência = {c.CalcCircunferencia():0.00}");
            Console.ReadKey();
        }
    }
}
