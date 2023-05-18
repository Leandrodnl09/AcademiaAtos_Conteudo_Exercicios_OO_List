using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio13
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataEntradaBanco { get; set; }
        public string RG { get; set; }
        public bool Ativo { get; set; }

        public Funcionario(string nome, string departamento, double salario, string dataEntradaBanco, string rg)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataEntradaBanco = dataEntradaBanco;
            RG = rg;
            Ativo = true;
        }

        public void BonificarFuncionario(double valorAumento)
        {
            Salario += valorAumento;
            Console.WriteLine($"O salário do funcionário {Nome} foi aumentado para {Salario:C2}.");
        }

        public void Demitir()
        {
            Ativo = false;
            Console.WriteLine($"O funcionário {Nome} foi demitido.");
        }

        public virtual void ExecutarTrabalho()
        {
            Console.WriteLine($"O funcionário {Nome} está executando o seu trabalho.");
        }
    }
}
