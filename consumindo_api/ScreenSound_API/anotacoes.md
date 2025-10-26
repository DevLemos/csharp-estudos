# Consumindo API

![Cliente e Servidor](img/cliente-servidor.png)

## HttpCliente
O HttCliente é uma classe do .NET que fornece uma API moderna e eficiente para fazer
requisições HTTP. Ela é a forma recomendada para fazer comunicação HTTP em aplicações.
Responsável por gerenciar conexões, cookies, headers, encoding, etc.

### Pra que serve?
- Integração com APIs REST: Consumir serviços web
- Download de conteúdo: Baixar arquivos, páginas web, dados
- Integração entre sistemas
- Consumo de microserviços

```
using (HttpClient cliente = new HttpClient()) 
{
    string response = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(response);
}
```
A palavra reservada using garante que o objeto seja liberado da memória automaticamente

### GetStringAsync()
Esse método envia uma solicitação GET para a URI específicada e retorna o corpo da resposta
como uma cadeia de caracteres em uma operação assíncrona.

### using
É uma declaração muito útil que garante o descarte automático de recursos. Ele implementa o padrão
IDisposable, como funciona:
- Criação: O objeto é criado (new HttpClient())
- Uso: Você executa o código dentro do bloco
- Descarte automático: Quando o bloco termina (com sucesso ou erro), o método Dispose() é chamado automaticamente

## Exceção
Para garantir que não dê nenhum problema na requisição e a aplicação pare, vamos utilizar o
Try cath para capturar as exceções que eventualmente podem ser lançadas. Removi da minha API o "n" de "json"
para cair na exceção.

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

Isso quer dizer que cada requisição que a gente faz, tem um código de resposta e nesse caso
foi o 404.

## Status Code
Os códigos de status de resposta HTTP indica se uma solicitação HTTP específica foi concluída
com êxito. As respostas são agrupadas em cinco classes:

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
desse json, como artist, song, genre, etc. Porém eu quero nas 
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
É um atributo(annotation) do namespace ***System.Text.Json.Serialization***
que mapeia a propriedade C# para um campo JSON com nome diferente. Ele serve
para deserializar JSON em objetos C#

Exemplo:
```
string json = "{\"song\": \"Bohemian Rhapsody\"}";
Musica musica = JsonSerializer.Deserialize<Musica>(json);
Console.WriteLine(musica.Nome); // Saída: Bohemian Rhapsody
```

## O que é um annotation?
É uma marcação declarativa que adiciona metadados ao código. Você "anota" classes,
métodos, propriedades, parâmetros, etc.., com informações extras que podem ser lidas
em tempo de compilação ou execução.

### Pra que serve?
Os atributos informam ao compilador, frameworks ou bibliotecas como tratar aquele
elemento.

Exemplos comuns:
```
// Serialização JSON - diz como mapear propriedades
[JsonPropertyName("song")]
public string Nome { get; set; }

// Validação - define regras de validação
[Required]
[MaxLength(100)]
public string Titulo { get; set; }

// Entity Framework - define chave primária
[Key]
public int Id { get; set; }

// ASP.NET - define rota de API
[HttpGet("api/musicas")]
public IActionResult GetMusicas() { }

// Marca método como obsoleto
[Obsolete("Use NovoMetodo() ao invés deste")]
public void MetodoAntigo() { }
```

# Desserialização
A desserialização é fundamental quando trabalhamos com APIs. 
Basicamente, é o processo de converter dados recebidos 
(geralmente JSON ou XML) em objetos C#.

### JSON
```
{
  "id": 1,
  "nome": "João",
  "email": "joao@example.com"
}
```

### Principais Formas de Desserializar

1. System.Text.Json 
```
using System.Text.Json;

// Classe que representa a estrutura do JSON
public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}

// Desserializar
string jsonString = await response.Content.ReadAsStringAsync();
Usuario usuario = JsonSerializer.Deserialize<Usuario>(jsonString);
```
2. Newtonsoft.Json
```
using Newtonsoft.Json;

string jsonString = await response.Content.ReadAsStringAsync();
Usuario usuario = JsonConvert.DeserializeObject<Usuario>(jsonString);
```

3. Diretamente com HttpClient
```
using System.Net.Http.Json;

// Forma mais moderna e direta
Usuario usuario = await httpClient.GetFromJsonAsync<Usuario>("https://api.example.com/usuario/1");
```

### Dicas Importantes
Propriedades do JSON diferentes do C#? Use atributos:

```
public class Usuario
{
    [JsonPropertyName("user_id")] // System.Text.Json
    public int Id { get; set; }
    
    // ou
    [JsonProperty("user_name")] // Newtonsoft.Json
    public string Nome { get; set; }
}
```

# LINQ
LINQ significa **Language Integrated Query (Consulta 
Integrada à Linguagem)**. É uma funcionalidade poderosa 
do C# que permite fazer consultas e manipulações em coleções 
de dados de forma simples e elegante, usando uma sintaxe similar 
ao SQL.

### Por que LINQ é útil?
Ao invés de usar loops tradicionais para filtrar, ordenar ou transformar 
dados, você usa uma sintaxe mais limpa e declarativa.

### Exemplo
```
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var pares = numeros.Where(n => n % 2 == 0).ToList();
```

### Operadores LINQ Mais Usados

### Filtrar
- **Where( )** - filtra elementos baseado em uma condiçã

### Ordenar
- **OrderBy( ) / OrderByDescending()** - ordena crescente/decrescente
- **ThenBy( )** - ordenação secundária

### Transformar
- **Select( )** - projeta/transforma cada elemento

### Agregar
- **Count( )** - conta elementos
- **Sum( )**, **Average( )**, **Min( )**, **Max( )** - operações matemáticas
- **First( )**, **FirstOrDefault( )** - primeiro elemento
- **Single( )**, **SingleOrDefault( )** - único elemento

### Outros
- **Take( )** / Skip() - paginação
- **Any( )** - verifica se existe algum elemento
- **All( )** - verifica se todos atendem condição
- **Distinct( )** - remove duplicatas
- **GroupBy( )** - agrupa elementos


# Objetos Anônimos
Objetos anônimos são objetos sem uma classe definida explicitamente. Você 
cria um objeto "na hora", sem precisar declarar uma classe antes.

### Sintaxe
```
// Objeto anônimo
var pessoa = new { Nome = "João", Idade = 25 };

Console.WriteLine(pessoa.Nome);  // João
Console.WriteLine(pessoa.Idade); // 25
```

# Serialização
Serialização é o processo inverso da desserialização. Se desserialização 
transforma JSON em objetos C#, a serialização transforma objetos C# em JSON 
(ou XML).

### Por que usar Serialização?

- Enviar dados para uma API (POST, PUT, PATCH)
- Salvar dados em arquivos
- Armazenar dados em cache
- Transmitir dados pela rede

```
// Objeto C#
Usuario usuario = new Usuario 
{ 
    Id = 1, 
    Nome = "Maria", 
    Email = "maria@example.com" 
};

// ⬇️ SERIALIZAÇÃO ⬇️

// JSON (string)
{
  "id": 1,
  "nome": "Maria",
  "email": "maria@example.com"
}
```

# Criar arquivo json
```
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
```

# Criar arquivo txt
Para criar um arquivo de texto com C# de forma simples, você 
pode usar a classe StreamWriter juntamente com o método WriteLine() 
para escrever conteúdo no arquivo.

### Exemplo simples
```
public void GerarArquivoTxt()
    {
        string nomeArquivo = $"musicas-favoritas-{Nome}.txt";

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo)) {

            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");

            foreach (var musica in MusicasFavoritas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }

        Console.WriteLine($"txt gerado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }
```


# Referências
- Códigos de status de respostas HTTP: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Reference/Status
- Chamar uma API Web de um cliente .NET: https://learn.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
- Usando Exceções: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/using-exceptions
- LINQ (Consulta Integrada à Linguagem): https://learn.microsoft.com/pt-br/dotnet/csharp/linq/
- Introdução a consultas LINQ: https://learn.microsoft.com/pt-br/dotnet/csharp/linq/get-started/introduction-to-linq-queries
- Como gravar texto em um arquivo: https://learn.microsoft.com/pt-br/dotnet/standard/io/how-to-write-text-to-a-file
