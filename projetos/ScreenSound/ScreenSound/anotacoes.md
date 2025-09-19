# Anotações

## Tópicos de estudos
- Orientação a objetos
- Métodos estáticos
- Herança
- Interfaces
- Integrar projeto a biblioteca de terceiros

# Projeto - Screen Sound
Projeto desenvolvido para aprofundar conhecimento em orientação a objetos, utilizando heranças, interfaces,
modificador de acesso como internal, modificadores de comportamento como virtual e override. Aprendemos a utilizar
também um pouco do LINQ, método e propriedade static.

## Open AI API

Esse trecho de código foi básicamente no final do curso de C#: Dominando Orientação a Objetos,
onde eu precisava recarregar com $5 para ter um crédito na plataforma da OpenAI e assim liberar
minha ApiKey, mas acabei não recarregando então não consegui testar de fato.

A ideia aqui era usar a API externa da OpenAI para dar um resumo sobre a banda

NuGet baixado: OpenAI

```
var client = new OpenAIClient(ApiKey);

try
{
    //Cria uma conversa
    var chatClient = client.GetChatClient("gpt-5");

    var completo = await chatClient.CompleteChatAsync("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal.");

    Console.WriteLine($"Resposta: {completo.Value.Content[0].Text}");

} catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

## Referências
- Estrutura geral de um programa C#: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/
- Convenções comuns de código C#: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions
- Modificadores de acesso (Referência de C#): https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers
- interface (Referência de C#): https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/interface
