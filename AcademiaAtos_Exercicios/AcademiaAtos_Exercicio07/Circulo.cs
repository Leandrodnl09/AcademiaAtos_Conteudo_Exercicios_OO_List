using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio07
{
    public class Circulo : IFormaGeometrica
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
