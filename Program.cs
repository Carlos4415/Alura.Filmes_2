// Este programa define duas classes principais: "Filme" e "Artista". 
// A classe "Filme" representa um filme com propriedades como título, duração e elenco. 
// A classe "Artista" representa uma pessoa que atua em filmes, com atributos como nome, idade e uma lista de filmes nos quais o artista participou. 
// Ambas as classes são organizadas dentro do namespace "Alura.Filmes_2", visando estruturar e reutilizar o código em projetos relacionados a filmes.

// PAREI EM
// 3. Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
using Alura.Filmes_2;

Artista robertDowneyJr = new Artista("Robert Downey Jr", 59);
Artista judeLaw = new Artista("Jude Law", 52);
Artista rachelMcAdams = new Artista("Rachel McAdams", 46);
Artista chrisEvans = new Artista("Chris Evans", 43);
Artista scarlettJohansson = new Artista("Scarlett Johansson", 40);

Filme sherlockHolmes = new Filme
(
    "Sherlock Holmes", 
    128, 
    new List<Artista>()
    {
        robertDowneyJr,
        judeLaw,
        rachelMcAdams,
    } 
 );

Filme vingadoresUltimato = new Filme("Vingadores: Ultimato", 181, new List<Artista>() { chrisEvans } );

vingadoresUltimato.AdicionarElenco(scarlettJohansson);
robertDowneyJr.AdicionarFilme(vingadoresUltimato);

sherlockHolmes.ListarElenco();
vingadoresUltimato.ListarElenco();

robertDowneyJr.MostrarFilmesAtuados();
judeLaw.MostrarFilmesAtuados();
rachelMcAdams.MostrarFilmesAtuados();
chrisEvans.MostrarFilmesAtuados();
scarlettJohansson.MostrarFilmesAtuados();