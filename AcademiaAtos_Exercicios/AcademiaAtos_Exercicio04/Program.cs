namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 - Crie uma classe Forma com os métodos CalcularArea e CalcularPerimetro.
            // Em seguida, crie as classes Retangulo e Circulo que herdam de Forma e implementam os métodos CalcularArea
            // e CalcularPerimetro de forma diferente.

            // Criando um retângulo
            Retangulo retangulo = new Retangulo();
            retangulo.Base = 5;
            retangulo.Altura = 3;

            // Calculando e exibindo a área e o perímetro do retângulo
            double areaRetangulo = retangulo.CalcularArea();
            double perimetroRetangulo = retangulo.CalcularPerimetro();

            // Criando um círculo
            Circulo circulo = new Circulo();
            circulo.Raio = 2;

            // Calculando e exibindo a área e o perímetro do círculo
            double areaCirculo = circulo.CalcularArea();
            double perimetroCirculo = circulo.CalcularPerimetro();


            retangulo.Apresentar();
            circulo.Apresentar();

        }
    }
}