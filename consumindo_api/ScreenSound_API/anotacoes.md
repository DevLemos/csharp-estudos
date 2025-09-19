# Consumindo API

## HttpCliente
O HttCliente é uma classe do .NET que fornece uma API moderna e eficiente para fazer
requisições HTTP. Ela é a forma recomendada para fazer comunicação HTTP em aplicações.
Responsável por gerenciar conexões, cookies, headers, encoding, etc.

### Pra que serve?
- Integração com APIs REST: Consumir serviços web
- Download de conteúdo: Baixar arquivos, páginas web, dados
- Integração entre sistemas
- Consumo de microserviçõs

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

# Exceção
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

# Status Code
Os códigos de status de resposta HTTP indica se uma solicitação HTTP específica foi concluída
com êxito. As respostas são agrupadas em cinco classes:

- Respostas informativas: 100 - 199
- Respostas bem-sucedidas: 200 - 299
- Mensagens de redirecionamento: 300 - 399
- Respostas de erro do cliente: 400 - 499
- Respostas de erro do servidor: 500 - 599

# Referências
- Códigos de status de respostas HTTP: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Reference/Status