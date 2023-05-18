using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio11
{
    class ItemCenario
    {
        private string descricao;
        private DateTime dataCriacao;
        private float altura;

        public ItemCenario(string descricao, DateTime dataCriacao, float altura)
        {
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.altura = altura;
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Descrição: " + descricao);
            Console.WriteLine("Data de Criação: " + dataCriacao.ToShortDateString());
            Console.WriteLine("Altura: " + altura);
        }

        public string CalcularTempoCriacao()
        {
            TimeSpan tempoDecorrido = DateTime.Now - dataCriacao;
            int dias = (int)tempoDecorrido.TotalDays;
            return dias.ToString() + " dias";
        }
    }
}
