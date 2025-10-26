using ScreenSound_API.Models;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var generosMusicais = musicas.
            Select(generos => generos.Genero).
            Distinct().
            ToList();

        foreach(var genero in generosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.
            Where(musica => musica.Genero!.Contains(genero)).
            Select(musica => musica.Artista).
            Distinct().
            ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.
            Where(musica => musica.Artista!.Equals(artista)).
            Select(musica => musica.Nome).
            Distinct().
            ToList();

        Console.WriteLine($"Músicas do artista >>> {artista}");

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasComTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasComTonalidade = musicas.
            Where(musica => musica.Tonalidade!.Equals(tonalidade)).
            Select(musica => musica.Nome).
            Distinct().
            ToList();

        Console.WriteLine($"Músicas com a tonalidade >>> {tonalidade}");

        foreach (var musica in musicasComTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
