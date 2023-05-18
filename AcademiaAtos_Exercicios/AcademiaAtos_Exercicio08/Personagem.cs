using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio08
{
    class Personagem
    {
        public string Nome { get; set; }
        public int Poder { get; set; }

        public Personagem()
        {
        }

        public Personagem(string nome, int poder)
        {
            Nome = nome;
            Poder = poder;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Poder: " + Poder);
        }
    }
}
