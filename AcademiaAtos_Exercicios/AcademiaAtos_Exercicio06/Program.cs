namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 - Classe Abstrata "ContaBancaria"
            // Crie uma classe abstrata chamada "ContaBancaria" com três propriedades abstratas: "Titular", "Saldo" e "TaxaDeJuros".
            // Em seguida, crie duas classes que herdam de "ContaBancaria": "ContaCorrente" e "ContaPoupanca".
            // Implemente as propriedades "Titular", "Saldo" e "TaxaDeJuros" para cada uma dessas classes.
            // Por fim, crie um objeto "ContaCorrente" e um objeto "ContaPoupanca", e imprima as suas propriedades na tela.


            ContaCorrente cc = new ContaCorrente("Fulano", 1000.00M, 0.01);
            
            ContaPoupanca cp = new ContaPoupanca("Ciclano", 500.00M, 0.05);

            cc.Apresentar();
            cp.Apresentar();
        }
    }
}