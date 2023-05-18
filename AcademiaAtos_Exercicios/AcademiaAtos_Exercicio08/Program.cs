namespace AcademiaAtos_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
            // O programa deverá informar o nome do personagem que possuir o maior poder.

            // Regras que deverão ser seguidas para a implementação do algoritmo:

            // É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades(características) um nome e um poder.
            // A classe também deverá possuir um método chamado ExibirDados.Esse método deverá exibir o nome e o poder do personagem em questão.
            // Ao implementar a classe é obrigatório implementar dois construtores(Sobrecarga), um que não recebe parâmetro algum e outro que
            // irá receber o nome e o poder de um personagem


            Personagem personagem1 = CriarPersonagem();
            Personagem personagem2 = CriarPersonagem();
            Personagem personagem3 = CriarPersonagem();

            Personagem personagemComMaiorPoder = ObterPersonagemComMaiorPoder(personagem1, personagem2, personagem3);

            Console.WriteLine("O personagem com o maior poder é:");
            personagemComMaiorPoder.ExibirDados();
        }

        static Personagem CriarPersonagem()
        {
            Console.Write("Informe o nome do personagem: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o poder do personagem (0 a 10): ");
            int poder = int.Parse(Console.ReadLine());

            return new Personagem(nome, poder);
        }

        static Personagem ObterPersonagemComMaiorPoder(params Personagem[] personagens)
        {
            Personagem personagemComMaiorPoder = personagens[0];

            for (int i = 1; i < personagens.Length; i++)
            {
                if (personagens[i].Poder > personagemComMaiorPoder.Poder)
                {
                    personagemComMaiorPoder = personagens[i];
                }
            }

            return personagemComMaiorPoder;
        }

    }
}
