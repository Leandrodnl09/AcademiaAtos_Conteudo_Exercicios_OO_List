using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio12
{
    internal class PlanoCartesiano
    {
        public int EixoX { get; set; }
        public int EixoY { get; set; }
        
        public PlanoCartesiano(int eixoX, int eixoY)
        {
            EixoX = eixoX;
            EixoY = eixoY;
        }

        public int CalcularNumeroDoMeio(int eixoX, int eixoY)
        {
            return (eixoX + eixoY) / 2;
        }

        public void ExibirNaTela()
        {
            Console.WriteLine($"Os numeros digitados do Eixo X é {EixoX}, e do Eixo Y é {EixoY}...");
            Console.WriteLine($"Plotando o número {CalcularNumeroDoMeio(EixoX,  EixoY)} no plano cartesiano.");
        }
    }
}
