# Consumindo API

![Cliente e Servidor](img/cliente-servidor.png)

## HttpCliente
O HttCliente � uma classe do .NET que fornece uma API moderna e eficiente para fazer
requisi��es HTTP. Ela � a forma recomendada para fazer comunica��o HTTP em aplica��es.
Respons�vel por gerenciar conex�es, cookies, headers, encoding, etc.

### Pra que serve?
- Integra��o com APIs REST: Consumir servi�os web
- Download de conte�do: Baixar arquivos, p�ginas web, dados
- Integra��o entre sistemas
- Consumo de microservi�os

```
using (HttpClient cliente = new HttpClient()) 
{
    string response = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(response);
}
```
A palavra reservada using garante que o objeto seja liberado da mem�ria automaticamente

### GetStringAsync()
Esse m�todo envia uma solicita��o GET para a URI espec�ficada e retorna o corpo da resposta
como uma cadeia de caracteres em uma opera��o ass�ncrona.

### using
� uma declara��o muito �til que garante o descarte autom�tico de recursos. Ele implementa o padr�o
IDisposable, como funciona:
- Cria��o: O objeto � criado (new HttpClient())
- Uso: Voc� executa o c�digo dentro do bloco
- Descarte autom�tico: Quando o bloco termina (com sucesso ou erro), o m�todo Dispose() � chamado automaticamente

## Exce��o
Para garantir que n�o d� nenhum problema na requisi��o e a aplica��o pare, vamos utilizar o
Try cath para capturar as exce��es que eventualmente podem ser lan�adas. Removi da minha API o "n" de "json"
para cair na exce��o.

```
using (HttpClient cliente = new HttpClient()) 
{
    try
    {
        string response = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        Console.WriteLine(response);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
```

Retorno: Error: Response status code does not indicate success: 404 (Not Found).

Isso quer dizer que cada requisi��o que a gente faz, tem um c�digo de resposta e nesse caso
foi o 404.

## Status Code
Os c�digos de status de resposta HTTP indica se uma solicita��o HTTP espec�fica foi conclu�da
com �xito. As respostas s�o agrupadas em cinco classes:

- Respostas informativas: 100 - 199
- Respostas bem-sucedidas: 200 - 299
- Mensagens de redirecionamento: 300 - 399
- Respostas de erro do cliente: 400 - 499
- Respostas de erro do servidor: 500 - 599

## Resposta do meu JSON
```
{
        "artist": "Post Malone",
        "song": "rockstar (feat. 21 Savage)",
        "duration_ms": 218146,
        "explicit": "True",
        "year": "2018",
        "popularity": "83",
        "danceability": "0.585",
        "energy": "0.52",
        "key": 5,
        "loudness": "-6.136",
        "mode": "0",
        "speechiness": "0.0712",
        "acousticness": "0.124",
        "instrumentalness": "7.01e-05",
        "liveness": "0.131",
        "valence": "0.129",
        "tempo": "159.801",
        "genre": "hip hop"
    },
```

Vamos supor que eu queria usar apenas algumas propriedades 
desse json, como artist, song, genre, etc. Por�m eu quero nas 
propriedades da minha classe e com nomes diferentes.

Usando JsonPropertyName eu consigo fazer isso:
```
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
}
```

### JsonPropertyName
� um atributo(annotation) do namespace ***System.Text.Json.Serialization***
que mapeia a propriedade C# para um campo JSON com nome diferente. Ele serve
para deserializar JSON em objetos C#

Exemplo:
```
string json = "{\"song\": \"Bohemian Rhapsody\"}";
Musica musica = JsonSerializer.Deserialize<Musica>(json);
Console.WriteLine(musica.Nome); // Sa�da: Bohemian Rhapsody
```

## O que � um annotation?
� uma marca��o declarativa que adiciona metadados ao c�digo. Voc� "anota" classes,
m�todos, propriedades, par�metros, etc.., com informa��es extras que podem ser lidas
em tempo de compila��o ou execu��o.

### Pra que serve?
Os atributos informam ao compilador, frameworks ou bibliotecas como tratar aquele
elemento.

Exemplos comuns:
```
// Serializa��o JSON - diz como mapear propriedades
[JsonPropertyName("song")]
public string Nome { get; set; }

// Valida��o - define regras de valida��o
[Required]
[MaxLength(100)]
public string Titulo { get; set; }

// Entity Framework - define chave prim�ria
[Key]
public int Id { get; set; }

// ASP.NET - define rota de API
[HttpGet("api/musicas")]
public IActionResult GetMusicas() { }

// Marca m�todo como obsoleto
[Obsolete("Use NovoMetodo() ao inv�s deste")]
public void MetodoAntigo() { }
```





# Refer�ncias
- C�digos de status de respostas HTTP: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Reference/Status