# Console.Read( )

Esse método do C# **lê um caractere** do console e retorna o seu código ASCII como `int`. Espera o usuário pressionar ENTER para processar.

## Exemplo 1

```csharp
public static void ExemploRead()
{
		 Console.WriteLine("\nConsole.Read() lê um caractere por vez (como int)");
     Console.WriteLine("Digite algumas letras e pressione ENTER:\n");

     Console.WriteLine("Sua entrada: ");

     // Read lê caractere por caractere
     int entrada01 = Console.Read();
     int entrada02 = Console.Read();
     int entrada03 = Console.Read();

     Console.WriteLine($"\nPrimeiro caractere, código ASCII: {entrada01}, Caractere: ('{(char)entrada01}')");
     Console.WriteLine($"Segundo caractere, código ASCII: {entrada02}, Caractere: ('{(char)entrada02}')");
     Console.WriteLine($"Terceiro caractere, código ASCII: {entrada03}, Caractere: ('{(char)entrada03}')");
}
```

Saída:

```
Sua entrada:
abc

Primeiro caractere, código ASCII: 97, Caractere: ('a')
Segundo caractere, código ASCII: 98, Caractere: ('b')
Terceiro caractere, código ASCII: 99, Caractere: ('c')
```

## Exemplo 2

```csharp
public static void ExemploRead()
{
    Console.WriteLine("\nExemplo 2: ");
    Console.WriteLine("Digite 'S' para Sim ou 'N' para Não:");

    int resposta = Console.Read();
    char respostaChar = (char)resposta;

    //Limpa ENTER do buffer
    Console.ReadLine();

    if (respostaChar == 'S' || respostaChar == 's')
    {
        Console.WriteLine("Você escolheu SIM!");
    }
    else if (respostaChar == 'N' || respostaChar == 'n')
    {
        Console.WriteLine("Você escolheu NÃO!");
    }
    else
    {
        Console.WriteLine($"Opção inválida: '{respostaChar}'");
    }

    Console.WriteLine("\n" + new string('-', 50));
}
```

Saída:

```
Exemplo 2:
Digite 'S' para Sim ou 'N' para Não:
s
Você escolheu SIM!
```

### Pra que serve?

- Validação de uma única letra (S/N)
- Leitura caractere por caractere
- Casos muito específicos (raramente usado)

---

# Console.ReadLine( )

Esse método lê a próxima linha de caracteres do fluxo de entrada padrão. Retorna a linha que foi lida ou `null`, se não houver linhas disponíveis.

## Exemplo 1

Exemplos a seguir:

- Lê um texto até a quebra de linha e armazena em uma variável
- Ler três palavras, uma em cada linha, armazenando cada uma em uma variável
- Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável

```csharp
public static void Main(string[] args)
{
    //lendo até a quebra de linha
    Console.WriteLine("Entre com uma frase: ");
    string frase = Console.ReadLine();

     //lendo uma palavra por linha
     Console.WriteLine("Digite 3 palavras uma em cada linha: ");
     string palavra01 = Console.ReadLine();
     string palavra02 = Console.ReadLine();
	   string palavra03 = Console.ReadLine();

     //lendo 3 palavras na mesma linha
     Console.WriteLine("Digite 3 palavras na mesma linha: ");
     string entrada = Console.ReadLine();
     string[] arrayStrings = entrada.Split(' ');
     string s1 = arrayStrings[0];
     string s2 = arrayStrings[1];
     string s3 = arrayStrings[2];

     Console.WriteLine("\nVocê digitou: ");
     Console.WriteLine($"Frase: {frase}");
     Console.WriteLine($"Primeira palavra: {palavra01}");
     Console.WriteLine($"Segunda palavra: {palavra02}");
     Console.WriteLine($"Terceira palavra: {palavra03}");
     Console.WriteLine($"Palavras digitadas na mesma linha: '{s1}', '{s2}', '{s3}'");
}
```

Como o conteúdo é armazenado:

![Sem título.jpg](attachment:537d2f81-89ce-4227-9b83-27e85d95729e:Sem_ttulo.jpg)

### Split( )

Usando o método `Split()` separando por espaços.

![Sem título (1).jpg](<attachment:c14fb8bf-d9ed-4049-a0e1-f179e9280b97:Sem_ttulo_(1).jpg>)

## Exemplos 2

- Ler um número inteiro
- Ler um caractere
- Ler um número double
- Ler um nome (única palavra), sexo (caractere F ou M), idade (inteiro) e altura (double) na mesma linha, armazenando-os em quatro variáveis com os devidos tipos

```csharp
Console.WriteLine("\n------ Exemplo 2 ------\n");

Console.WriteLine("Entre com a idade: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o sexo: ");
char ch = char.Parse(Console.ReadLine());

Console.WriteLine("Entre com a altura: ");
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Agora entre com Nome, Sexo, idade e Altura na mesma linha: ");
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou:");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
```

## Exercício de Fixação

Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:

```
Entre com seu nome completo:
Alex Green
Quantos quartos tem na sua casa?
3
Entre com o preço de um produto:
500.50
Entre seu último nome, idade e altura (mesma linha):
Green 21 1.73
```

SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS):

```
Alex Green
3
500.50
Green
21
1.73
```

Resolução:

```csharp
Console.WriteLine("\n------ Exercício de Fixação ------\n");

Console.WriteLine("Entre com seu nome completo: ");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int qtdQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
string[] arrayDados = Console.ReadLine().Split(' ');
string sobrenomeArray = arrayDados[0];
int idadeArray = int.Parse(arrayDados[1]);
double alturaArray = double.Parse(arrayDados[2], CultureInfo.InvariantCulture);

Console.WriteLine(nomeCompleto);
Console.WriteLine(qtdQuartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(sobrenomeArray);
Console.WriteLine(idadeArray);
Console.WriteLine(alturaArray.ToString("F2", CultureInfo.InvariantCulture));
```

---

# Console.ReadKey( )

Esse método **lê uma tecla imediatamente** (sem precisar de ENTER) e retorna `ConsoleKeyInfo` com informações detalhadas.

## Exemplo 1

```csharp
Console.WriteLine("\nReadKey Básico");
Console.WriteLine("Pressione qualquer tecla: ");
ConsoleKeyInfo tecla1 = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Tecla pressionada: {tecla1.Key}");
Console.WriteLine($"Caractere: '{tecla1.KeyChar}'");
Console.WriteLine($"Modificadores: {tecla1.Modifiers}");
```

Saída:

```
ReadKey Básico
Pressione qualquer tecla:
y                             //aparece na tela
Tecla pressionada: Y
Caractere: 'y'
Modificadores: None
```

## Exemplo 2

```csharp
Console.WriteLine("\nReadKey com intercept");
Console.WriteLine("Pressione qualquer tecla (não aparecerá na tela): ");
ConsoleKeyInfo tecla2 = Console.ReadKey(true); //true intercepta = não mostra a tecla na tela
Console.WriteLine($"Tecla interceptada: '{tecla2.KeyChar}' - {tecla2.Key}");
```

Saída

```
ReadKey com intercept
Pressione qualquer tecla (não aparecerá na tela):
Tecla interceptada: 'f' - F
```

## Exemplo 3

```csharp
Console.WriteLine("\nDetectar teclas especiais");
Console.WriteLine("Pressione qualquer tecla especial (ESC, F1, Setas, etc): ");
ConsoleKeyInfo tecla3 = Console.ReadKey();
Console.WriteLine("Informações sobre a tecla pressionada:");
Console.WriteLine($"Tecla: {tecla3.Key}");
Console.WriteLine($"Caractere: '{tecla3.KeyChar}'");
Console.WriteLine($"Modificadores: {tecla3.Modifiers}");
```

Saída

```
Detectar teclas especiais
Pressione qualquer tecla especial (ESC, F1, Setas, etc):
Informações sobre a tecla pressionada:
Tecla: UpArrow
Caractere: ''
Modificadores: None
```

## Exemplo 4

```csharp
Console.WriteLine("\nDetectar modificadores");
Console.WriteLine("Pressione uma tecla com Ctrl, Alt ou Shift: \n");
ConsoleKeyInfo tecla4 = Console.ReadKey();
Console.WriteLine($"Tecla: {tecla4.Key}");

if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Control))
    Console.WriteLine("Ctrl estava pressionado!");
if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Alt))
    Console.WriteLine("Alt estava pressionado!");
if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Shift))
    Console.WriteLine("Shift estava pressionado!");

Console.WriteLine("\n" + new string('-', 50));
```

Saída

```
Detectar modificadores
Pressione uma tecla com Ctrl, Alt ou Shift:
Tecla: S
Ctrl estava pressionado!
```

## Exemplo de menu interativo

```csharp
Console.WriteLine("Escolha a seguir os métodos que deseja: ");
Console.WriteLine("1. Read()");
Console.WriteLine("2. ReadLine()");
Console.WriteLine("3. ReadKey()");
Console.WriteLine("4. Write()");
Console.WriteLine("5. WriteLine()");

Console.WriteLine("\nInforme o número: ");
ConsoleKeyInfo teclaMenu = Console.ReadKey(true);

switch (teclaMenu.Key)
{
    case ConsoleKey.D1:
    case ConsoleKey.NumPad1:
        ExemploRead();
        break;
    case ConsoleKey.D2:
    case ConsoleKey.NumPad2:
        ExemploReadLine();
        break;
    case ConsoleKey.D3:
    case ConsoleKey.NumPad3:
        ExemploReadKey();
        break;
    case ConsoleKey.D4:
    case ConsoleKey.NumPad4:
        ExemploWrite();
        break;
    case ConsoleKey.D5:
    case ConsoleKey.NumPad5:
        ExemploWriteLine();
        break;
    default:
        Console.WriteLine("\n\nOpção inválida!");
        break;
}
```

### Por que dois `case` para o mesmo número?

O teclado tem **duas formas diferentes** de digitar o número "1":

1. ConsoleKey.D1

- **D** = "Digit" (dígito)
- Representa a tecla **"1" da fileira superior** do teclado (acima das letras QWERTY)
- As teclas são: `1 2 3 4 5 6 7 8 9 0`

1. ConsoleKey.NumPad1

- **NumPad** = "Numeric Pad" (teclado numérico)
- Representa a tecla **"1" do teclado numérico** (lado direito)
- As teclas são: `7 8 9`, `4 5 6`, `1 2 3`, `0`

## Pra que serve?

- Menus interativos (pressiona tecla = ação imediata)
- Jogos de console
- Pausas (”Pressione qualquer tecla para continuar”)
- Senhas mascaradas
- Navegação com setas

---

# Console.Write ( )

É um método da biblioteca de classes base do C# que é usado para escrever um texto **sem pular linha**. O cursor fica na mesma linha após a saída.

## Exemplo

```csharp
public static void ExemploWrite()
{
		Console.Write("Write: ");
    Console.Write("João");
    Console.Write(" | ");
    Console.Write("Maria");
    Console.Write(" | ");
    Console.Write("Pedro");
}
```

Saída:

```csharp
Write: João | Maria | Pedro
```

### Pra que serve?

- Criar saídas na mesma linha
- Barras de progresso
- Menus horizontais
- Quando você quer controlar exatamente onde quebrar a linha

---

# Console.WriteLine ( )

É um método da biblioteca de classes base do C# que é usado para escrever um texto no console e **pula linha automaticamente**. O cursor vai para a próxima linha.

## Exemplo

```csharp
public static void ExemploWriteLine()
{
    Console.WriteLine("WriteLine: ");
    Console.WriteLine("Maria");
    Console.WriteLine("João");
    Console.WriteLine("Pedro");
}
```

Saída:

```csharp
WriteLine:
Maria
João
Pedro
```

### Pra que serve?

- Exibir informações linha por linha
- Logs e relatórios
- Menus verticais
- Mensagens para o usuário.

---

# Console.Clear ( )

Esse método C# **remove** todo o **conteúdo visível** da tela do console. Apaga todos os caracteres exibidos e reposiciona o cursor no canto superior esquerdo (0, 0)
