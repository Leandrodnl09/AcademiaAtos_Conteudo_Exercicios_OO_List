﻿namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma classe Pessoa que contém as propriedades Nome e Idade.
            // Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
            // A classe Aluno deve ter uma propriedade adicional Matricula,
            // enquanto a classe Professor deve ter uma propriedade adicional Disciplina.
            // Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa.
            // Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno,
            // e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.

            Pessoa pessoa = new Pessoa { Nome = "João", Idade = 20 };
            pessoa.Apresentar();

            Aluno aluno = new Aluno { Nome = "Maria", Idade = 18, Matricula = 12345 };
            aluno.Apresentar();

            Professor professor = new Professor { Nome = "José", Idade = 40, Disciplina = "Matemática" };
            professor.Apresentar();
        }
    }
}