using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio13
{
    internal class FuncionarioFileHandler
    {
        private string caminhoArquivo;

        public FuncionarioFileHandler(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        public void EscreverFuncionarios(List<Funcionario> funcionarios)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
                {
                    foreach (var funcionario in funcionarios)
                    {
                        string linha = $"{funcionario.Nome},{funcionario.Departamento},{funcionario.Salario},{funcionario.DataEntradaBanco},{funcionario.RG},{funcionario.Ativo}";
                        escritor.WriteLine(linha);
                    }
                }

                Console.WriteLine("Os funcionários cadastrados foram salvos no arquivo CSV com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao salvar os funcionários no arquivo CSV: {ex.Message}");
            }
        }

        public List<Funcionario> LerFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                using (StreamReader leitor = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');

                        string nome = dados[0];
                        string departamento = dados[1];
                        double salario = double.Parse(dados[2]);
                        string dataEntradaBanco = dados[3];
                        string rg = dados[4];
                        bool ativo = bool.Parse(dados[5]);

                        Funcionario funcionario;

                        if (departamento == "Gerente")
                        {
                            funcionario = new Gerente(nome, departamento, salario, dataEntradaBanco, rg);
                        }
                        else if (departamento == "Operador")
                        {
                            funcionario = new Operador(nome, departamento, salario, dataEntradaBanco, rg);
                        }
                        else
                        {
                            Console.WriteLine($"Departamento inválido encontrado no arquivo CSV: {departamento}. Ignorando o funcionário.");
                            continue;
                        }

                        funcionario.Ativo = ativo;
                        funcionarios.Add(funcionario);
                    }
                }

                Console.WriteLine("Os funcionários foram carregados do arquivo CSV com sucesso.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo CSV não encontrado. Será criado um novo arquivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao carregar os funcionários do arquivo CSV: {ex.Message}");
            }

            return funcionarios;
        }
    }
}

