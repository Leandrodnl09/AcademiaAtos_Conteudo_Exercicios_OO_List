using System.Net;
using System;

namespace AcademiaAtos_Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
            // O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

            // Regras que deverão ser seguidas para a implementação do programa:

            // Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
            // Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
            // É obrigatório criar uma classe para representar o Animal.
            // A classe deverá possuir dois dados privados(propriedades) para representar as características do animal.
            // A classe deverá possuir métodos de acesso(propriedade getter e setter) para permitir que o usuário
            // armazene/ leia os dados dos dois dados privados(propriedades).

            Animal[] animais = new Animal[5];
            int cachorros = 0;
            int gatos = 0;
            int peixes = 0;

            for (int i = 0; i < animais.Length; i++)
            {
                Console.WriteLine($"Animal {i + 1}:");
                animais[i] = new Animal();

                Console.Write("Nome: ");
                animais[i].Nome = Console.ReadLine();

                while (true)
                {
                    Console.Write("Tipo (Cachorro, Gato ou Peixe): ");
                    string tipo = Console.ReadLine();

                    if (tipo == "Cachorro")
                    {
                        animais[i].Tipo = tipo;
                        cachorros++;
                        break;
                    }
                    else if (tipo == "Gato")
                    {
                        animais[i].Tipo = tipo;
                        gatos++;
                        break;
                    }
                    else if (tipo == "Peixe")
                    {
                        animais[i].Tipo = tipo;
                        peixes++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tipo inválido. Por favor, tente novamente.");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine($"Quantidade de Cachorros: {cachorros}");
            Console.WriteLine($"Quantidade de Gatos: {gatos}");
            Console.WriteLine($"Quantidade de Peixes: {peixes}");
            Console.WriteLine();
        }
    }
}