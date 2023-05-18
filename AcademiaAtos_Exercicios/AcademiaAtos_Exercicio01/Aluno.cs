using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AcademiaAtos_Exercicio01
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Matrícula: {Matricula}");
        }
    }
}
