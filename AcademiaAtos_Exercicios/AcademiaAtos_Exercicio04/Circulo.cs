using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio04
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public void Apresentar()
        {
            Console.WriteLine("Círculo: ");
            Console.WriteLine($"Área: {CalcularArea().ToString("F3")}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro().ToString("F3")}");
            Console.WriteLine();
        }
    }
}
