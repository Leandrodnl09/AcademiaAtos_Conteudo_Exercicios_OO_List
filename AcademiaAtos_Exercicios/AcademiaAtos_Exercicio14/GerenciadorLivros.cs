using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio14
{
    public class GerenciadorLivros
    {
        private Dictionary<string, Livro> livros;

        public GerenciadorLivros()
        {
            livros = new Dictionary<string, Livro>();
        }

        public void CadastrarLivro(string nome, int quantidadePaginas)
        {
            if (livros.ContainsKey(nome))
            {
                Console.WriteLine("Livro já cadastrado.");
                return;
            }

            Livro livro = new Livro
            {
                Nome = nome,
                QuantidadePaginas = quantidadePaginas
            };

            livros[nome] = livro;

            Console.WriteLine("Livro cadastrado com sucesso.");
        }

        public void ConsultarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            Console.WriteLine("Livros cadastrados:");
            foreach (var livro in livros.Values)
            {
                Console.WriteLine($"Nome: {livro.Nome}, Páginas: {livro.QuantidadePaginas}");
            }
        }

        public void PesquisarLivro(string nome)
        {
            if (livros.ContainsKey(nome))
            {
                Livro livro = livros[nome];
                Console.WriteLine($"Nome: {livro.Nome}, Páginas: {livro.QuantidadePaginas}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void GravarEmArquivoCSV(string nomeArquivo)
        {
            string caminhoCompleto = @"D:\LEANDRO\CURSOS\AcademiaAtosNET2023\Aula22\AcademiaAtos_Exercicios\AcademiaAtos_Exercicio14\" + nomeArquivo;

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoCompleto))
                {
                    foreach (var livro in livros.Values)
                    {
                        writer.WriteLine($"{livro.Nome},{livro.QuantidadePaginas}");
                    }
                }

                Console.WriteLine("Dados gravados em arquivo CSV.");
                Console.WriteLine("Caminho completo do arquivo: " + caminhoCompleto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao gravar o arquivo CSV: {ex.Message}");
            }
        }
    }
}
