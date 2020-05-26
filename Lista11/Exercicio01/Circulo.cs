using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    // A classe Circulo modela a figura geométrica círculo e é usado para calcular
    // sua área e circunferência. Para esses cálculos, apenas a informação do raio
    // é necessário. Portanto, a classe vai ter um único atributo.
    class Circulo
    {
        // Atributo - Por enquanto definido como público até que o conceito
        // de encapsulamento não ser apresentado
        public double raio;
        // Métodos para calcular a área e circunferência
        public double CalcArea()
        {
            return Math.PI * raio * raio;
        }
        public double CalcCircunferencia()
        {
            return 2 * Math.PI * raio;
        }
    }
}
