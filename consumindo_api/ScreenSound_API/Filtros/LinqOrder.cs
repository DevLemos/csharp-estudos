using ScreenSound_API.Models;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.
            OrderBy(musica => musica.Artista). // ordena as músicas pelo artista
            Select(musica => musica.Artista). // seleciona apenas os artistas
            Distinct(). // remove as duplicidades
            ToList(); // converte o resultado em uma lista

        Console.WriteLine("Lista de artistas ordenados");

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
