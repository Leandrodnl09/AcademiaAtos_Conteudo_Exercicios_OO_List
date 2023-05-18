using static System.Net.WebRequestMethods;

namespace AcademiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11) Crie uma classe para representar um item de cenário, com os atributos privados de:
            // *descrição(string), 
            // *data de criação(date -https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
            // *altura(float).

            // Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir
            // todos dados de um item de cenário. 
            // Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
            // a classe criada.

            // Testando a classe ItemCenario
            ItemCenario item = new ItemCenario("Item 1", new DateTime(2023, 5, 1), 10.5f);

            item.ImprimirDados();

            Console.WriteLine("Tempo de criação: " + item.CalcularTempoCriacao());
        }
    }
}