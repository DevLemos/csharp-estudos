using ScreenSound_API.Models;

using (HttpClient cliente = new HttpClient()) 
{
    try
    {
        string response = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
