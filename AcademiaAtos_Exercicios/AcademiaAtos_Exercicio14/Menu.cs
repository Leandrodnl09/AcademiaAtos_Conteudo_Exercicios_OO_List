using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio14
{
    public class Menu
    {
        private GerenciadorLivros gerenciador;

        public Menu()
        {
            gerenciador = new GerenciadorLivros();
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1 - Cadastrar livro");
                Console.WriteLine("2 - Consultar livros cadastrados");
                Console.WriteLine("3 - Pesquisar livro por nome");
                Console.WriteLine("4 - Gravar em arquivo CSV");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome do livro: ");
                        string nomeLivro = Console.ReadLine();
                        Console.Write("Digite a quantidade de páginas: ");
                        int quantidadePaginas = int.Parse(Console.ReadLine());
                        gerenciador.CadastrarLivro(nomeLivro, quantidadePaginas);
                        break;
                    case "2":
                        gerenciador.ConsultarLivros();
                        break;
                    case "3":
                        Console.Write("Digite o nome do livro a ser pesquisado: ");
                        string nomePesquisa = Console.ReadLine();
                        gerenciador.PesquisarLivro(nomePesquisa);
                        break;
                    case "4":
                        Console.Write("Digite o nome do arquivo CSV para gravar os dados: ");
                        string nomeArquivo = Console.ReadLine();
                        gerenciador.GravarEmArquivoCSV(nomeArquivo);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
