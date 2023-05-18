using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Conteudo
{
    internal class VeiculoEletrico : Veiculo
    {
        public double Autonomia;
        public void Carregar()
        {
            this.Autonomia += 10;
            Console.WriteLine("Carreguei 10%!");
        }

        public void Ligar() 
        { 
            if(this.Autonomia > 0)
            {
                Console.WriteLine("Veiculo eletrico pode ser ligado!");
            }
            else
            {
                Console.WriteLine("Carregar veiculo eletrico!");
            }
        }
    }
}
