using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio04
{
    internal class Retangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public void Apresentar()
        {
            Console.WriteLine("Retângulo: ");
            Console.WriteLine($"Área: {CalcularArea().ToString("F3")}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro().ToString("F3")}");
            Console.WriteLine();
        }
    }
}
