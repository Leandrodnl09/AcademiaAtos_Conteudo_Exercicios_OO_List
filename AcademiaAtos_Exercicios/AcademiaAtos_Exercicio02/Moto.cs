using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio02
{
    internal class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindrada} cilindradas");
        }
    }
}
