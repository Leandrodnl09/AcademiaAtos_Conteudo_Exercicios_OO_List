using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_OO_Abstract
{
    internal class Motocicleta : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Moto ligada");
        }
    }
}
