using System.Text.Json;

namespace ScreenSound_API.Models;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }

    public List<Musica>? MusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        MusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        MusicasFavoritas!.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");

        foreach(var musica in MusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            Console.WriteLine();
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new 
        { 
            nome = Nome ,
            musicas = MusicasFavoritas        
        });

        string nomeArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeArquivo, json); //escreva todo o texto
        Console.WriteLine($"O arquivo JSON foi criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }

    public void GerarArquivoTxt()
    {
        string nomeArquivo = $"musicas-favoritas-{Nome}.txt";

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo)) {

            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");

            foreach (var musica in MusicasFavoritas!)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }

        Console.WriteLine($"txt gerado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }
}
