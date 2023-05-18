using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

namespace AcademiaAtos_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções.
            // Dessa forma, crie um programa em C# que represente
            // uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos(privados) posição x,
            // posição y(do asteroide em um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5)
            // e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
            // (propriedades getter e setter).Além disso, implementar 3 construtores(sobrecarga): um vazio, outro passando todos os parâmetros
            // de um objeto tipo Asteroide, e um terceiro que constrói um asteroide com posição x e posição y.
            // O programa principal(main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal,
            // construir um método de classe que exiba todos os asteróides da lista.

            List<Asteroide> listaAsteroides = new List<Asteroide>();

            // Preenchendo a lista de asteroides com base nas entradas do usuário
            Console.WriteLine("Quantos asteroides deseja adicionar?");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Asteroide {i + 1}:");
                Console.Write("Posição X: ");
                int posX = int.Parse(Console.ReadLine());
                Console.Write("Posição Y: ");
                int posY = int.Parse(Console.ReadLine());
                Console.Write("Tamanho (1 a 10): ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.Write("Velocidade (1 a 5): ");
                int velocidade = int.Parse(Console.ReadLine());
                Console.Write("Energia (1 a 5): ");
                int energia = int.Parse(Console.ReadLine());

                Asteroide asteroide = new Asteroide(posX, posY, tamanho, velocidade, energia);
                listaAsteroides.Add(asteroide);
            }

            Asteroide.ExibirAsteroides(listaAsteroides);
        }

        
    }
}