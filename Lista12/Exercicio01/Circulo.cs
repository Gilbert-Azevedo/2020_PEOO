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
        // Atributo - Agora encapsulado. Com isso, é possível garantir o estado
        // dos objetos de forma que nenhum círculo tenha raio negativo.
        private double raio;
        // Métodos de acesso
        public void SetRaio(double v)
        {
            // Os métodos set normalmente são void (não retornam valor )
            // e testam os argumentos recebidos para garantir o estado do objeto
            // Só armazena o raio de o valor for positivo
            if (v > 0) raio = v;
        }
        public double GetRaio()
        {
            // Os métodos get retornam o valor de um atributo. O tipo de retorno é,
            // portanto, igual ao tipo do atributo
            return raio;
        }
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
