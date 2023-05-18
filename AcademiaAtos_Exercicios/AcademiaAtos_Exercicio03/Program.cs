namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Crie uma classe Conta com as propriedades Numero e Saldo.
            // Em seguida, crie as classes ContaCorrente e ContaPoupanca que herdam de Conta e
            // adicionam uma propriedade TaxaDeJuros e LimiteDeCredito, respectivamente.
            
            // criando conta corrente
            var contaCorrente = new ContaCorrente
            {
                Numero = 1234,
                Saldo = 1000.0,
                TaxaDeJuros = 1.5
            };

            // criando uma conta poupança
            var contaPoupanca = new ContaPoupanca
            {
                Numero = 5678,
                Saldo = 500.0,
                LimiteDeCredito = 1000.0
            };

            contaCorrente.Apresentar();
            contaPoupanca.Apresentar();
        }
    }
}