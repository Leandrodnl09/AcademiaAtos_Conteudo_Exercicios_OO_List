using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio06
{
    public abstract class ContaBancaria
    {
        public abstract string Titular { get; set; }
        public abstract decimal Saldo { get; set; }
        public abstract double TaxaDeJuros { get; set; }
    }
}

