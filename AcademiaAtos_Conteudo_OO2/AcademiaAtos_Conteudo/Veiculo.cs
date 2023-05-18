using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Conteudo
{
    internal class Veiculo
    {
        public string Modelo;
        public int Potencia;
        public virtual void Ligar()
        {
            Console.WriteLine("Oi, sou o veiculo ligado!");
        }
    }
}
