using System;

namespace AcademiaAtos_Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário (double), a data de entrada no banco (String),
            // seu RG (String) e um valor booleano que indique se o
            // funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.
            // Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método bonifica que aumenta o salario do funcionário de acordo com o
            // parâmetro passado como argumento. Crie, também, um
            // método demite, que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.
            // Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e consultar todos os funcionários cadastratos.

            // Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho".Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
            // Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário

            string caminhoArquivo = "D:\\LEANDRO\\CURSOS\\AcademiaAtosNET2023\\Aula22\\AcademiaAtos_Exercicios\\AcademiaAtos_Exercicio13\\funcionarios.csv";
            FuncionarioFileHandler fileHandler = new FuncionarioFileHandler(caminhoArquivo);

            List<Funcionario> funcionarios = fileHandler.LerFuncionarios();

            Menu menu = new Menu(funcionarios, fileHandler);
            menu.Executar();

        }

    }
}