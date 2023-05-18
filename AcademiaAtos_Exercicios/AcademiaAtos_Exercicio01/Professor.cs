using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AcademiaAtos_Exercicio01
{
    internal class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Disciplina: {Disciplina}");
        }
    }
}
