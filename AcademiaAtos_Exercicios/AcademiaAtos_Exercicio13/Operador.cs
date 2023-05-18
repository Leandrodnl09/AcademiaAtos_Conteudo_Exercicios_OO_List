using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio13
{
    class Operador : Funcionario
    {
        public Operador(string nome, string departamento, double salario, string dataEntradaBanco, string rg)
            : base(nome, departamento, salario, dataEntradaBanco, rg)
        {
        }

        public override void ExecutarTrabalho()
        {
            Console.WriteLine($"O operador {Nome} está realizando a operação específica do departamento {Departamento}.");
        }
    }
}
