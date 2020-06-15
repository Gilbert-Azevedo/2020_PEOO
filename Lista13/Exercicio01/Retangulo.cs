using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Retangulo
    {
        private double b, h;
        // Construtor da classe. Armazena valores iniciais de base e altura se
        // forem positivos
        public Retangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
        }
        // Método de acesso. Altera valor da base se for positivo
        public void SetBase(double b)
        {
            if (b > 0) this.b = b;
        }
        // Método de acesso. Altera valor da altura se for positivo
        public void SetAltura(double h)
        {
            if (h > 0) this.h = h;
        }
        // Método de acesso. Retorna valor da base
        public double GetBase()
        {
            return b;
        }
        // Método de acesso. Retorna valor da altura
        public double GetAltura()
        {
            return h;
        }
        // Métodos de cálculo. Retornam área e diagonal, respectivamente
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(b * b + h * h);
        }
        // Sobrescrita do método ToString
        public override string ToString()
        {
            return $"Base = {b}, Altura = {h}";
        }
    }
}
