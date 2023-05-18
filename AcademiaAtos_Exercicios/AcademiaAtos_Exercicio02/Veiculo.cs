using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio02
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo}");
        }
    }
}
