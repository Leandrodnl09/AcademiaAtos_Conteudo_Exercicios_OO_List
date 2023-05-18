using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio07
{
    public class Retangulo : IFormaGeometrica
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double CalcularArea()
        {
            return altura * largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (altura + largura);
        }
    }
}
