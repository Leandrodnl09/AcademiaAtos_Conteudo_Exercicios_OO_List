using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio05
{
    internal class Livro : Produto
    {
        public string Autor { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Livro:");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Descrição: " + Descricao);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine();
        }
    }
}
