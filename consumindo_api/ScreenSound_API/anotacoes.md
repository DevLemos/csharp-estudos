# Consumindo API

## HttpCliente
O HttCliente � uma classe do .NET que fornece uma API moderna e eficiente para fazer
requisi��es HTTP. Ela � a forma recomendada para fazer comunica��o HTTP em aplica��es.
Respons�vel por gerenciar conex�es, cookies, headers, encoding, etc.

### Pra que serve?
- Integra��o com APIs REST: Consumir servi�os web
- Download de conte�do: Baixar arquivos, p�ginas web, dados
- Integra��o entre sistemas
- Consumo de microservi��s

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

# Exce��o
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

# Status Code
Os c�digos de status de resposta HTTP indica se uma solicita��o HTTP espec�fica foi conclu�da
com �xito. As respostas s�o agrupadas em cinco classes:

- Respostas informativas: 100 - 199
- Respostas bem-sucedidas: 200 - 299
- Mensagens de redirecionamento: 300 - 399
- Respostas de erro do cliente: 400 - 499
- Respostas de erro do servidor: 500 - 599

# Refer�ncias
- C�digos de status de respostas HTTP: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Reference/Status