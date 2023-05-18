using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_OO_Abstract
{
    internal class Pessoa
    {
        public string Nome;
        public Endereco end;
        public List<Cachorro> caes;
        public Pessoa(string nome)
        {
            Nome = nome;
        }

    }
}
