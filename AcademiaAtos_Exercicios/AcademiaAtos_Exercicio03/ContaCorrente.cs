﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio03
{
    internal class ContaCorrente : Conta
    {
        public void Apresentar()
        {
            Console.WriteLine("Conta Corrente");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Saldo: {Saldo:C2}");
            Console.WriteLine($"Taxa de Juros: {TaxaDeJuros}%");
            Console.WriteLine($"Limite de Crédito: {LimiteDeCredito:C2}");
            Console.WriteLine();
        }
    }
}
