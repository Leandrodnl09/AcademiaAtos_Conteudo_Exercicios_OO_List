using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio06
{
    public class ContaPoupanca : ContaBancaria
    {
        public override string Titular { get; set; }
        public override decimal Saldo { get; set; }
        public override double TaxaDeJuros { get; set; }

        public ContaPoupanca(string titular, decimal saldo, double taxaDeJuros)
        {
            Titular = titular;
            Saldo = saldo;
            TaxaDeJuros = taxaDeJuros;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Conta Poupança de {Titular}: Saldo = {Saldo:C}, Taxa de Juros = {TaxaDeJuros:P}");
        }
    }
}
