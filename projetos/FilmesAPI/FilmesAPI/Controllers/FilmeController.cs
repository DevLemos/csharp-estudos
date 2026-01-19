using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> listaFilmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        listaFilmes.Add(filme);
        Console.WriteLine(filme.Duracao);
        Console.WriteLine(filme.Nome);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes()
    {
        return listaFilmes;
    }
}
