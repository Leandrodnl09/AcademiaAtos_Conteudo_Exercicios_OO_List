namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma classe Veiculo que contém as propriedades Marca e Modelo.
            // Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
            // A classe Carro deve ter uma propriedade adicional QuantidadeDePortas,
            // enquanto a classe Moto deve ter uma propriedade adicional Cilindrada.
            // Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>".
            // Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas"
            // e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".

            Veiculo veiculo = new Veiculo()
            {
                Marca = "Ford",
                Modelo = "Fiesta"
            };

            Carro carro = new Carro()
            {
                Marca = "Volkswagen",
                Modelo = "Gol",
                QuantidadeDePortas = 4
            };

            Moto moto = new Moto()
            {
                Marca = "Honda",
                Modelo = "CB 500X",
                Cilindrada = 500
            };

            veiculo.Dirigir(); 
            carro.Dirigir(); 
            moto.Dirigir(); 
        }
    }
}