using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio05
{
    internal class CD : Produto
    {
        public string Artista { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("CD:");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Descrição: " + Descricao);
            Console.WriteLine("Artista: " + Artista);
            Console.WriteLine();
        }
    }
}
