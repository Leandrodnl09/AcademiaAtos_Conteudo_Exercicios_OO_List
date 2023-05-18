namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()".
            // Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo".
            // Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes,
            // de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área
            // e o perímetro de um círculo. Por fim, crie uma lista de "IFormaGeometrica" contendo um objeto "Retangulo" e um objeto "Circulo",
            // e chame os métodos "CalcularArea()" e "CalcularPerimetro()" para cada um dos objetos.

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite o tipo de forma geométrica que deseja criar (1 para retângulo, 2 para círculo, 0 para sair):");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        continuar = false;
                        break;

                    case 1:
                        Console.WriteLine("Digite a altura do retângulo:");
                        double alturaRetangulo = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a largura do retângulo:");
                        double larguraRetangulo = double.Parse(Console.ReadLine());

                        formas.Add(new Retangulo(alturaRetangulo, larguraRetangulo));
                        break;

                    case 2:
                        Console.WriteLine("Digite o raio do círculo:");
                        double raioCirculo = double.Parse(Console.ReadLine());

                        formas.Add(new Circulo(raioCirculo));
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine();

            foreach (IFormaGeometrica forma in formas)
            {
                Console.WriteLine("Calculando " + (forma is Retangulo ? "Retângulo" : "Círculo") + ":");
                Console.WriteLine("Área: " + forma.CalcularArea());
                Console.WriteLine("Perímetro: " + forma.CalcularPerimetro());
                Console.WriteLine();
            }
        }
    }
}