using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcaademiaAtos_Conteudo02_Abstract
{
    internal class MotorCombustao : IMotor
    {
        public double combustivel;
        public bool ligado;
        public void Desligar()
        {
            if (ligado)
            {
                ligado = false;
                
            }
            Console.WriteLine("Motor Combustão desligado!");

        }

        public void Ligar()
        {
            if (combustivel > 0 && !ligado)
            {
                ligado = true;
                
            }
            Console.WriteLine("Motor Combustão ligado!");
        }
    }
}
