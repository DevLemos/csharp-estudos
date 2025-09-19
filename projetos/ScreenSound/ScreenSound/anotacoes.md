# Anota��es

## T�picos de estudos
- Orienta��o a objetos
- M�todos est�ticos
- Heran�a
- Interfaces
- Integrar projeto a biblioteca de terceiros

# Projeto - Screen Sound
Projeto desenvolvido para aprofundar conhecimento em orienta��o a objetos, utilizando heran�as, interfaces,
modificador de acesso como internal, modificadores de comportamento como virtual e override. Aprendemos a utilizar
tamb�m um pouco do LINQ, m�todo e propriedade static.

## Open AI API

Esse trecho de c�digo foi b�sicamente no final do curso de C#: Dominando Orienta��o a Objetos,
onde eu precisava recarregar com $5 para ter um cr�dito na plataforma da OpenAI e assim liberar
minha ApiKey, mas acabei n�o recarregando ent�o n�o consegui testar de fato.

A ideia aqui era usar a API externa da OpenAI para dar um resumo sobre a banda

NuGet baixado: OpenAI

```
var client = new OpenAIClient(ApiKey);

try
{
    //Cria uma conversa
    var chatClient = client.GetChatClient("gpt-5");

    var completo = await chatClient.CompleteChatAsync("Resuma a banda Ira! em 1 par�grafo. Adote um estilo informal.");

    Console.WriteLine($"Resposta: {completo.Value.Content[0].Text}");

} catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

## Refer�ncias
- Estrutura geral de um programa C#: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/
- Conven��es comuns de c�digo C#: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions
- Modificadores de acesso (Refer�ncia de C#): https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers
- interface (Refer�ncia de C#): https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/interface
