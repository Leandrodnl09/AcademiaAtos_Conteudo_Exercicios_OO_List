using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio13
{
    class Menu
    {
        private List<Funcionario> funcionarios;
        private FuncionarioFileHandler fileHandler;

        public Menu(List<Funcionario> funcionarios, FuncionarioFileHandler fileHandler)
        {
            this.funcionarios = funcionarios;
            this.fileHandler = fileHandler;
        }

        public void Executar()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("-------- MENU --------");
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Consultar funcionários");
                Console.WriteLine("3 - Bonificar salário");
                Console.WriteLine("4 - Excluir funcionário");
                Console.WriteLine("5 - Demitir funcionário");
                Console.WriteLine("6 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarFuncionario();
                        break;
                    case 2:
                        ConsultarFuncionarios();
                        break;
                    case 3:
                        BonificarSalario();
                        break;
                    case 4:
                        ExcluirFuncionario();
                        break;
                    case 5:
                        DemitirFuncionario();
                        break;
                    case 6:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                fileHandler.EscreverFuncionarios(funcionarios);

                Console.WriteLine();
            } while (opcao != 6);
        }

        private void CadastrarFuncionario()
        {
            Console.WriteLine("----- CADASTRO DE FUNCIONÁRIO -----");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Departamento (Gerente ou Operador): ");
            string departamento = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Data de entrada no banco: ");
            string dataEntradaBanco = Console.ReadLine();
            Console.Write("RG: ");
            string rg = Console.ReadLine();

            Console.WriteLine("Selecione o tipo de funcionário:");
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Operador");
            Console.Write("Opção: ");
            int tipoFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionario;

            switch (tipoFuncionario)
            {
                case 1:
                    funcionario = new Gerente(nome, departamento, salario, dataEntradaBanco, rg);
                    break;
                case 2:
                    funcionario = new Operador(nome, departamento, salario, dataEntradaBanco, rg);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Cadastro cancelado.");
                    return;
            }

            funcionarios.Add(funcionario);
            Console.WriteLine("Funcionário cadastrado com sucesso!");
            fileHandler.EscreverFuncionarios(funcionarios);
        }

        private void ExcluirFuncionario()
        {
            Console.WriteLine("----- EXCLUSÃO DE FUNCIONÁRIO -----");
            Console.Write("Digite o nome do funcionário a ser excluído: ");
            string nome = Console.ReadLine();

            Funcionario funcionario = funcionarios.Find(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (funcionario != null)
            {
                funcionarios.Remove(funcionario);
                Console.WriteLine("Funcionário excluído com sucesso!");

                fileHandler.EscreverFuncionarios(funcionarios);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        private void DemitirFuncionario()
        {
            Console.Write("Digite o RG do funcionário a ser demitido: ");
            string rg = Console.ReadLine();

            Funcionario funcionario = funcionarios.Find(f => f.RG == rg);

            if (funcionario != null)
            {
                funcionario.Demitir();

                Console.WriteLine("Funcionário demitido com sucesso!");

                fileHandler.EscreverFuncionarios(funcionarios);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void ExecutarTrabalho()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.Nome == nome);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            else
            {
                funcionario.ExecutarTrabalho();
            }
        }

        public void BonificarSalario()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da bonificação:");
            double valor = Convert.ToDouble(Console.ReadLine());

            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.Nome == nome);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            else
            {
                funcionario.BonificarFuncionario(valor);
            }
        }

        private void ConsultarFuncionarios()
        {
            Console.WriteLine("----- CONSULTA DE FUNCIONÁRIOS -----");

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
            }
            else
            {
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"Nome: {funcionario.Nome}");
                    Console.WriteLine($"Departamento: {funcionario.Departamento}");
                    Console.WriteLine($"Salário: {funcionario.Salario:C2}");
                    Console.WriteLine($"Data de entrada no banco: {funcionario.DataEntradaBanco}");
                    Console.WriteLine($"RG: {funcionario.RG}");
                    Console.WriteLine($"Situação: {(funcionario.Ativo ? "Ativo" : "Demitido")}");
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
}
