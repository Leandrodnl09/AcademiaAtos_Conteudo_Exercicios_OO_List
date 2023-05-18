namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Crie uma classe Produto com as propriedades Codigo e Descricao.
            // Em seguida, crie as classes Livro e CD que herdam de Produto e adicionam uma propriedade Autor e Artista, respectivamente.

            Livro livro = new Livro
            {
                Codigo = 1,
                Descricao = "A menina que roubava livros",
                Autor = "Markus Zusak"
            };

            CD cd = new CD
            {
                Codigo = 2,
                Descricao = "Thriller",
                Artista = "Michael Jackson"
            };

            livro.Apresentar();
            cd.Apresentar();
        }
    }
}