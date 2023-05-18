namespace AcademiaAtos_Conteudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula de Orientação a Objeto - Herança;
            Veiculo veiculo = new Veiculo();
            VeiculoEletrico veiculoEletrico = new VeiculoEletrico();
            Moto veiculoMoto = new Moto();  

            veiculo.Ligar();
            veiculo.Potencia = 1000;
            veiculo.Modelo = "Fiat";

            veiculoEletrico.Ligar();
            veiculoEletrico.Carregar();
            veiculoEletrico.Potencia = 2000;
            veiculoEletrico.Modelo = "Tesla";

            veiculoMoto.Ligar();
        }
    }
}