using System.Runtime.Intrinsics.X86;

namespace AcademiaAtos_Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
            // tem como atributos 'x' e 'y'.Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
            // um método para exibir um objeto(x, y).
            // Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
            // os objetos da lista.

            List<PlanoCartesiano> coordenadas = new List<PlanoCartesiano>();

            // Solicitar ao usuário a entrada das coordenadas
            Console.WriteLine("Digite as coordenadas (x, y) separadas por vírgula. Pressione Enter para adicionar ou 'sair' para finalizar.");

            while (true)
            {
                Console.Write("Coordenada: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                string[] valores = entrada.Split(',');

                if (valores.Length != 2)
                {
                    Console.WriteLine("Entrada inválida. Digite as coordenadas no formato correto.");
                    continue;
                }

                if (int.TryParse(valores[0], out int x) && int.TryParse(valores[1], out int y))
                {
                    coordenadas.Add(new PlanoCartesiano(x, y));
                    Console.WriteLine("Coordenada adicionada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite valores inteiros para as coordenadas.");
                }
            }

            Console.WriteLine("Coordenadas inseridas:");
            foreach (PlanoCartesiano coordenada in coordenadas)
            {
                coordenada.ExibirNaTela();
            }
        }
    }
}