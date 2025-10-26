using System.Text.Json;
using ScreenSound_API.Models;
using ScreenSound_API.Filtros;

using (HttpClient cliente = new HttpClient()) 
{
    try
    {
        string response = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        Console.WriteLine(musicas.Count);
            
        musicas[1].ExibirDetalhesMusica();

        LinqFilter.FiltrarMusicasComTonalidade(musicas, "C#");

        //LinqFilter.FiltrarGenerosMusicais(musicas);
        //Console.WriteLine("\n");
        //LinqOrder.ExibirListaArtistasOrdenados(musicas);
        //Console.WriteLine("\n");
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //Console.WriteLine("\n");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Justin Bieber");

        //var musicasPreferidas = new MusicasPreferidas("Daniel");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        //musicasPreferidas.GerarArquivoTxt();

    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
