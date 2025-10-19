using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista  { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"M�sica: {Nome}");
        Console.WriteLine($"Dura��o em segundos: {Duracao / 1000}");
        Console.WriteLine($"G�nero Musical: {Genero}");
    }
}