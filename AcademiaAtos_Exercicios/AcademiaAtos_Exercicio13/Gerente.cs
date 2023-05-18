using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio13
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, string departamento, double salario, string dataEntradaBanco, string rg)
            : base(nome, departamento, salario, dataEntradaBanco, rg)
        {
        }

        public override void ExecutarTrabalho()
        {
            Console.WriteLine($"O gerente {Nome} está gerenciando o departamento {Departamento}.");
        }
    }

}
