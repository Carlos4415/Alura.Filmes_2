namespace Alura.Filmes_2;

public class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeFilmes => FilmesAtuados.Count;

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);

        if (!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }

    public void MostrarFilmesAtuados()
    {
        if (this.FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"\nNenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"\nFilmes de {this.Nome}...");

        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}
