using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio10
{
    class Asteroide
    {
        private int posX;
        private int posY;
        private int tamanho;
        private int velocidade;
        private int energia;

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }

        public int Energia
        {
            get { return energia; }
            set { energia = value; }
        }

        public Asteroide()
        {
            // Construtor vazio
        }

        public Asteroide(int posX, int posY, int tamanho, int velocidade, int energia)
        {
            this.posX = posX;
            this.posY = posY;
            this.tamanho = tamanho;
            this.velocidade = velocidade;
            this.energia = energia;
        }

        public Asteroide(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        internal static void ExibirAsteroides(List<Asteroide> asteroides)
        {
            Console.WriteLine("\nLista de Asteroides:");
            foreach (Asteroide asteroide in asteroides)
            {
                Console.WriteLine($"Posição: ({asteroide.PosX}, {asteroide.PosY})");
                Console.WriteLine($"Tamanho: {asteroide.Tamanho}");
                Console.WriteLine($"Velocidade: {asteroide.Velocidade}");
                Console.WriteLine($"Energia: {asteroide.Energia}");
                Console.WriteLine();
            }
        }
    }

}
