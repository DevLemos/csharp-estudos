# Propriedades

- `Length`: nos informa o tamanho de uma string;

---

# Métodos

- `ToLower()` e `ToUpper()`: convertem todas as letras de uma palavra para minúsculas e maiúsculas, respectivamente;
- `Contains()`: verifica se a string contém um texto específico;
- `StartsWith()` e `EndsWith()`: verifica se o início e o final da string, respectivamente, possuem um texto determinado;
- `IndexOf()`: identifica a posição de um caractere específico na string;
- `Substring()`: extrai uma parte da string desde o início até um tamanho determinado;
- `Replace()`: substitui um texto antigo por um novo;
- `Trim()`, `TrimStart()` e `TrimEnd()`: removem espaços em branco;
- `Split()`: separa uma string de acordo com um padrão separador;
- `Join()`: junta uma string seguindo um padrão.

---

# Escapes

- `\”` → para aspas duplas

```csharp
string mensagem = "Ola, meu e-mail é \"exemplo@gmail.com\" ";
```

- `\n` → para nova linha
- `\t` → para tabulação
- `\\`→ para representar a barra invertida
- `\’` → para aspas simples
- `\b` → apaga um caractere anterior
- `\\` → para representar a contra-barra

Exemplo de tabulação:

```csharp
public class ExemploTabulacao : EscapesBase
    {
        public override void Exemplo()
        {
            Console.WriteLine("\n----- Exemplo escape de tabulação -----\n");

            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:");
            string endereco = Console.ReadLine()!;

            Console.WriteLine("Digite o valor do frete:");
            double frete = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a data de entrega:");
            string data = Console.ReadLine()!;

            Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
            Console.WriteLine($"Cliente:\t \"{nome}\"");
            Console.WriteLine($"Endereço:\t \"{endereco}\"");
            Console.WriteLine($"Valor do frete: R$ {frete.ToString("0.00")}");
            Console.WriteLine($"Data:\t\t {data}\n");
            Console.WriteLine("==========================================");
        }
    }
```

Saída:

```
========== RELATÓRIO DE ENTREGA ==========

Cliente:         "joão pedro"
Endereço:        "estrada guarai"
Valor do frete: R$ 30.20
Data:            01/02/2025
```

---

# Verbatim

Verbatim é um modificador usado antes de literais de strings (e, em um contexto diferente, antes de identificadores) para mudar como o compilador interpreta o conteúdo. Ele é representado pelo símbolo `@` colocado antes da string ou do identificador.

Quando usamos antes de uma string, ele faz com que:

- Os caracteres de escapes não sejam interpretados (\n, \t, \\, etc).
- A string possa ocupar várias linhas no código.
- Cada caractere seja interpretado literalmente, exceto aspas duplas que precisa ser escrita como `“”string””`
- Com identificador permita usar palavras reservadas ou caracteres especiais como nome.

```csharp
string caminho = @"C:\Users\Kauan\Documentos\Projeto";
Console.WriteLine(caminho);

string mensagem = @"Olá! Meu email é ""iasmin@email.com""";
Console.WriteLine(mensagem);

// Multilinha
string texto = @"Linha 1
Linha 2
Linha 3";
Console.WriteLine(texto);
```

sem o `@` teria que escrever:

```csharp
string caminho = "C:\\Users\\Kauan\\Documentos\\Projeto";
```

---

# RegEx

RegEx (regular expressions) ou traduzindo Expressões Regulares é um tipo de linguagem de padrões usada para procurar, validar e manipular textos de forma flexível e poderosa.

## Padrões de Chaves PIX

- CPF: XXX.XXX.XXX-XX ⇒ `^\d{3}\.\d{3}\.\d{3}-\d{2}$`
- CNPJ: XX.XXX.XXX/XXXX-XX ⇒ `^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$`
- Telefone: (XX)XXXXX-XXXX ⇒ `^\(\d{2}\)\d{4,5}-\d{4}$`
- Email: xxxxxxx@xxx.xx ⇒ `^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$`

## Padrões reconhecidos

| **Símbolo** | **Descrição**                        |
| ----------- | ------------------------------------ |
| .           | Caractere, exceto quebra de linha    |
| \d          | Dígito (0-9)                         |
| \D          | Caractere que não é um dígito        |
| \w          | Caractere alfanumérico               |
| \W          | Caractere não alfanumérico           |
| \s          | Espaço em branco                     |
| \S          | Caractere que não é espaço em branco |
| ^           | Início da string                     |
| $           | Fim da string                        |

## Quantificadores

Quantificadores são símbolos ou padrões que definem quantas vezes um determinado caractere, grupo ou classe de caracteres devem aparecer para que haja ocorrência.

| **Símbolo** | **Descrição**                               | **Exemplo** | **Correspondência**           |
| ----------- | ------------------------------------------- | ----------- | ----------------------------- |
| \*          | 0 ou mais ocorrências do padrão anterior    | a\*         | "", "a", "aa", "aaa”          |
| +           | 1 ou mais ocorrências do padrão anterior    | a+          | "a", "aa", "aaa" (mas não "") |
| ?           | 0 ou 1 ocorrência do padrão anterior        | a?          | "", "a”                       |
| {n}         | Exatamente n ocorrências do padrão anterior | a{3}        | "aaa”                         |
| {n,}        | n ou mais ocorrências do padrão anterior    | a{2,}       | "aa", "aaa", "aaaa”           |
| {n, m}      | Entre n e m ocorrências do padrão anterior  | a{2,4}      | "aa", "aaa", "aaaa”           |

## Classe de caracteres

| **Símbolo** | **Descrição**                                                    |
| ----------- | ---------------------------------------------------------------- |
| [abc]       | Qualquer caractere dentro dos colchetes (’a’, ‘b’ ou ‘c’)        |
| [^abc]      | Qualquer caractere exceto o que não estejam dentro dos colchetes |
| [a-z]       | Qualquer caractere minúsculo de ‘a’ a ‘z’                        |
| [A-Z]       | Qualquer caractere maiúscula de ‘A’ a ‘Z’                        |
| [0-9]       | Qualquer dígito                                                  |
| [a-zA-Z]    | Qualquer letra maiúscula ou minúscula                            |

## Métodos da classe Regex

| Método      | **Descrição**                                       |
| ----------- | --------------------------------------------------- |
| `IsMatch()` | Verifica se um padrão existe na string              |
| `Match()`   | Retorna a primeira correspondência do padrão        |
| `Matches()` | Retorna todas as correspondência do padrão          |
| `Replace()` | Substitui ocorrências do padrão por uma nova string |
| `Split()`   | Divide uma string com base em um padrão             |

## Exemplo

Imagine que você está desenvolvendo um sistema de pré-moderação para um fórum online, onde **todos os links compartilhados precisam ser ocultados temporariamente** até que sejam aprovados por um moderador. Seu programa deve **identificar qualquer URL no texto e substituí-la por um marcador genérico**, garantindo que os usuários não acessem conteúdos potencialmente inseguros antes da revisão.

Crie um programa que:

- Receba um texto contendo links.
- Identifique todas as URLs que começam com "http://" ou "https://".
- Substitua cada URL encontrada por "[LINK]".
- Exiba o texto modificado na tela.

Exemplo de entrada

```
Digite o texto:
Acesse https://meusite.com ou http://exemplo.org para mais informações.
```

Saída esperada

```
Acesse [LINK] ou [LINK] para mais informações.
```

- `http` corresponde à parte fixa da URL.
- `s?` indica que o caractere "s" é opcional, cobrindo tanto "http://" quanto "https://".
- `://` é a sequência obrigatória após o protocolo.
- `\S+` captura qualquer sequência de caracteres que não sejam espaços, garantindo que toda a URL seja identificada.

```csharp
using System.Text.RegularExpressions;

Console.WriteLine("Digite o texto: ");
string texto = Console.ReadLine();

string regex = @"https?://\S+";

string resultado = Regex.Replace(texto, regex, "[LINK]");

Console.WriteLine(resultado);
```
