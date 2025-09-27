# Estruturas de decisão

## if / else if / else

**Definição**: Executa blocos de código baseado em condições booleanas.

**Sintaxe**:

```csharp
if (condição1)
{
    // código se condição1 for verdadeira
}
else if (condição2)
{
    // código se condição2 for verdadeira
}
else
{
    // código se nenhuma condição for verdadeira
}
```

**Exemplos práticos**

```csharp
// Exemplo 1: Verificação de idade
int idade = 25;
string categoria;

if (idade < 13)
{
    categoria = "Criança";
}
else if (idade < 18)
{
    categoria = "Adolescente";
}
else if (idade < 60)
{
    categoria = "Adulto";
}
else
{
    categoria = "Idoso";
}

Console.WriteLine($"Categoria: {categoria}");

// Exemplo 2: Validação de nota
double nota = 8.5;
string conceito;

if (nota >= 9.0)
    conceito = "Excelente";
else if (nota >= 7.0)
    conceito = "Bom";
else if (nota >= 5.0)
    conceito = "Regular";
else
    conceito = "Insuficiente";

// Exemplo 3: Condições compostas
int x = 10, y = 20, z = 15;

if (x > 5 && y < 25)
{
    Console.WriteLine("Primeira condição atendida");
}

if (x == 10 || z > 20)
{
    Console.WriteLine("Segunda condição atendida");
}

if (!(x > y))
{
    Console.WriteLine("x não é maior que y");
}
```

---

## Operador Ternário (?:)

**Definição:** Forma compacta do if/else para atribuições simples.

**Sintaxe:** `condição ? valor_se_verdadeiro : valor_se_falso`

```csharp
int numero = 15;
string resultado = numero % 2 == 0 ? "Par" : "Ímpar";
Console.WriteLine(resultado); // Output: Ímpar

// Exemplo mais complexo
int a = 10, b = 20;
int maior = a > b ? a : b;
string status = maior > 15 ? "Alto" : "Baixo";

// Ternário aninhado (use com moderação)
int pontos = 85;
string classificacao = pontos >= 90 ? "A" :
                      pontos >= 80 ? "B" :
                      pontos >= 70 ? "C" : "D";
```

---

## switch / case

**Definição:** Compara uma expressão com múltiplos valores constantes.

**Sintaxe tradicional:**

```csharp
switch (expressão)
{
    case valor1:
        // código
        break;
    case valor2:
        // código
        break;
    default:
        // código padrão
        break;
}
```

Exemplos práticos

```csharp
// Exemplo 1: Menu de opções
Console.Write("Digite uma opção (A, B, C): ");
char opcao = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (opcao)
{
    case 'A':
    case 'a':
        Console.WriteLine("Opção A: Cadastrar usuário");
        break;
    case 'B':
    case 'b':
        Console.WriteLine("Opção B: Listar usuários");
        break;
    case 'C':
    case 'c':
        Console.WriteLine("Opção C: Sair do programa");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

// Exemplo 2: Dias da semana
int diaSemana = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Monday => 1,
    DayOfWeek.Tuesday => 2,
    DayOfWeek.Wednesday => 3,
    DayOfWeek.Thursday => 4,
    DayOfWeek.Friday => 5,
    DayOfWeek.Saturday => 6,
    DayOfWeek.Sunday => 7,
    _ => 0
};

// Exemplo 3: Calculadora
double num1 = 10, num2 = 5;
char operador = '+';
double resultado = 0;

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            resultado = num1 / num2;
        else
            Console.WriteLine("Divisão por zero!");
        break;
    default:
        Console.WriteLine("Operador inválido!");
        break;
}
```

## switch Expression (C# 8.0+)

```csharp
// Sintaxe mais moderna
string GetStatusMessage(int codigo) => codigo switch
{
    200 => "OK",
    404 => "Não encontrado",
    500 => "Erro interno",
    _ => "Código desconhecido"
};

// Com múltiplas condições
string ClassificarProduto(string categoria, decimal preco) => (categoria, preco) switch
{
    ("Eletrônicos", > 1000) => "Premium",
    ("Eletrônicos", _) => "Standard",
    ("Roupas", > 200) => "Luxo",
    ("Roupas", _) => "Casual",
    _ => "Categoria desconhecida"
};
```

---

# Estruturas de repetição

Laços de repetição são estruturas que permitem executar blocos de código repetidamente, enquanto uma condição for verdadeira.

## for

**Definição:** Loop com inicialização, condição e incremento definidos.

**Sintaxe:**

```csharp
for (inicialização; condição; incremento)
{
    // código a ser repetido
}
```

**Exemplos práticos**

```csharp
// Exemplo 1: Contagem simples
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Número: {i}");
}

// Exemplo 2: Contagem regressiva
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine($"Contagem regressiva: {i}");
}

// Exemplo 3: Incremento personalizado
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine($"Número par: {i}");
}

// Exemplo 4: Percorrendo arrays
int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Posição {i}: {numeros[i]}");
}

// Exemplo 5: Tabuada
int numero = 7;
Console.WriteLine($"Tabuada do {numero}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

// Exemplo 6: For aninhado (matriz)
int[,] matriz = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine();
}

// Exemplo 7: Múltiplas variáveis
for (int i = 0, j = 10; i < 5; i++, j--)
{
    Console.WriteLine($"i: {i}, j: {j}");
}
```

---

## while

**Definição:** Executa enquanto uma condição for verdadeira (teste no início).

**Sintaxe:**

```csharp
while (condição)
{
    // código a ser repetido
}
```

**Exemplos práticos**

```csharp
// Exemplo 1: Contador simples
int contador = 1;
while (contador <= 5)
{
    Console.WriteLine($"Iteração: {contador}");
    contador++;
}

// Exemplo 2: Validação de entrada
string senha;
int tentativas = 0;
const int maxTentativas = 3;

while (tentativas < maxTentativas)
{
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();

    if (senha == "123456")
    {
        Console.WriteLine("Senha correta!");
        break;
    }

    tentativas++;
    Console.WriteLine($"Senha incorreta. Tentativas restantes: {maxTentativas - tentativas}");
}

if (tentativas == maxTentativas)
{
    Console.WriteLine("Número máximo de tentativas excedido!");
}

// Exemplo 3: Leitura de números até zero
int numero;
int soma = 0;

Console.WriteLine("Digite números (0 para parar):");
while ((numero = int.Parse(Console.ReadLine())) != 0)
{
    soma += numero;
    Console.WriteLine($"Soma atual: {soma}");
}

// Exemplo 4: Jogo de adivinhação
Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int tentativa;
int numeroTentativas = 0;

Console.WriteLine("Adivinhe o número entre 1 e 100:");

while (true)
{
    tentativa = int.Parse(Console.ReadLine());
    numeroTentativas++;

    if (tentativa == numeroSecreto)
    {
        Console.WriteLine($"Parabéns! Você acertou em {numeroTentativas} tentativas!");
        break;
    }
    else if (tentativa < numeroSecreto)
    {
        Console.WriteLine("Muito baixo! Tente um número maior.");
    }
    else
    {
        Console.WriteLine("Muito alto! Tente um número menor.");
    }
}
```

Outro exemplo

```csharp
List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };

Console.WriteLine("Digite o nome do aluno:");
string nomeBusca = Console.ReadLine();
int indice = 0;
bool encontrado = false;

while (indice < alunos.Count)
{
    if (alunos[indice] == nomeBusca)
    {
        encontrado = true;
        break;
    }
    indice++;
}

if (encontrado)
{
    Console.WriteLine($"Aluno encontrado na posição: {indice}");
}
else
{
    Console.WriteLine("Aluno não está presente na lista");
}
```

---

## do-while

**Definição:** Executa pelo menos uma vez, depois verifica a condição (teste no final).

**Sintaxe:**

```csharp
do
{
    // código a ser executado
} while (condição);
```

Exemplos práticos:

```csharp
// Exemplo 1: Menu que executa pelo menos uma vez
char opcao;
do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1 - Nova operação");
    Console.WriteLine("2 - Ver histórico");
    Console.WriteLine("3 - Configurações");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (opcao)
    {
        case '1':
            Console.WriteLine("Nova operação selecionada");
            break;
        case '2':
            Console.WriteLine("Histórico selecionado");
            break;
        case '3':
            Console.WriteLine("Configurações selecionadas");
            break;
        case '0':
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
} while (opcao != '0');

// Exemplo 2: Validação de entrada
int idade;
do
{
    Console.Write("Digite sua idade (0-120): ");
    idade = int.Parse(Console.ReadLine());

    if (idade < 0 || idade > 120)
    {
        Console.WriteLine("Idade inválida! Tente novamente.");
    }
} while (idade < 0 || idade > 120);

Console.WriteLine($"Idade válida: {idade} anos");

// Exemplo 3: Jogo simples
Random random = new Random();
string jogarNovamente;

do
{
    int numeroSorteado = random.Next(1, 7);
    Console.Write("Adivinhe o número do dado (1-6): ");
    int palpite = int.Parse(Console.ReadLine());

    if (palpite == numeroSorteado)
    {
        Console.WriteLine("Parabéns! Você acertou!");
    }
    else
    {
        Console.WriteLine($"Errou! O número era {numeroSorteado}");
    }

    Console.Write("Jogar novamente? (s/n): ");
    jogarNovamente = Console.ReadLine().ToLower();

} while (jogarNovamente == "s" || jogarNovamente == "sim");
```

---

## foreach

**Definição:** Itera sobre elementos de uma coleção sem usar índices.

**Sintaxe:**

```csharp
foreach (tipo variavel in coleção)
{
    // código para cada elemento
}
```

**Exemplos práticos:**

```csharp
// Exemplo 1: Array de strings
string[] nomes = {"Ana", "Bruno", "Carlos", "Diana", "Eduardo"};

foreach (string nome in nomes)
{
    Console.WriteLine($"Nome: {nome}");
}

// Exemplo 2: Lista de inteiros
List<int> numeros = new List<int> {2, 4, 6, 8, 10, 12, 14};

foreach (int numero in numeros)
{
    Console.WriteLine($"Número: {numero}, Quadrado: {numero * numero}");
}

// Exemplo 3: Dicionário
Dictionary<string, int> idades = new Dictionary<string, int>
{
    {"Ana", 25},
    {"Bruno", 30},
    {"Carlos", 28}
};

foreach (KeyValuePair<string, int> pessoa in idades)
{
    Console.WriteLine($"{pessoa.Key} tem {pessoa.Value} anos");
}

// Ou usando var para simplificar
foreach (var pessoa in idades)
{
    Console.WriteLine($"{pessoa.Key} tem {pessoa.Value} anos");
}

// Exemplo 4: Array multidimensional
int[,] matriz = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

foreach (int valor in matriz)
{
    Console.Write($"{valor} ");
}

// Exemplo 5: String (cada caractere)
string palavra = "Programação";

foreach (char letra in palavra)
{
    Console.WriteLine($"Letra: {letra}");
}

// Exemplo 6: Coleção personalizada
List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Notebook", Preco = 2500.00m },
    new Produto { Nome = "Mouse", Preco = 50.00m },
    new Produto { Nome = "Teclado", Preco = 150.00m }
};

foreach (Produto produto in produtos)
{
    Console.WriteLine($"Produto: {produto.Nome}, Preço: R$ {produto.Preco:F2}");
}

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```

# Controle de fluxo

## break

**Definição:** Interrompe completamente a execução de um loop ou switch.

```csharp
// Exemplo 1: Saindo de um for
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Interrompendo no 5");
        break;
    }
    Console.WriteLine($"Número: {i}");
}
// Output: 1, 2, 3, 4, "Interrompendo no 5"

// Exemplo 2: Busca em array
string[] nomes = {"Ana", "Bruno", "Carlos", "Diana"};
string procurado = "Carlos";
bool encontrado = false;

foreach (string nome in nomes)
{
    if (nome == procurado)
    {
        Console.WriteLine($"Encontrado: {nome}");
        encontrado = true;
        break; // Para a busca
    }
}

// Exemplo 3: Break em loops aninhados (só sai do loop interno)
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Loop externo: {i}");

    for (int j = 1; j <= 5; j++)
    {
        if (j == 3)
        {
            Console.WriteLine("Break no loop interno");
            break; // Só sai do loop interno
        }
        Console.WriteLine($"  Loop interno: {j}");
    }
}
```

---

## continue

**Definição:** Pula para a próxima iteração do loop, ignorando o código restante.

```csharp
// Exemplo 1: Pulando números pares
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Pula números pares
    }
    Console.WriteLine($"Número ímpar: {i}");
}
// Output: 1, 3, 5, 7, 9

// Exemplo 2: Processando apenas valores válidos
int[] numeros = {1, -2, 3, -4, 5, 0, 7};

foreach (int numero in numeros)
{
    if (numero <= 0)
    {
        continue; // Pula números negativos e zero
    }

    Console.WriteLine($"Processando: {numero}");
    // Mais processamento aqui...
}

// Exemplo 3: Validação em loop
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    string entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int numero))
    {
        Console.WriteLine("Entrada inválida, pulando...");
        continue;
    }

    Console.WriteLine($"Número válido: {numero}");
}
```

---

## return

**Definição:** Sai de um método e opcionalmente retorna um valor.

```csharp
// Exemplo 1: Método que retorna valor
public static int Somar(int a, int b)
{
    if (a < 0 || b < 0)
    {
        Console.WriteLine("Números negativos não são permitidos");
        return -1; // Código de erro
    }

    return a + b; // Retorna a soma
}

// Exemplo 2: Método void com return para controle de fluxo
public static void ProcessarIdade(int idade)
{
    if (idade < 0)
    {
        Console.WriteLine("Idade inválida");
        return; // Sai do método sem processar
    }

    if (idade < 18)
    {
        Console.WriteLine("Menor de idade");
        return;
    }

    Console.WriteLine("Maior de idade");
    // Mais processamento...
}

// Exemplo 3: Return em loops
public static int EncontrarPrimeiroNegativo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            return i; // Retorna o índice do primeiro negativo
        }
    }

    return -1; // Não encontrou
}
```

---

## goto(raramente usado)

**Definição:** Salta para um rótulo específico no código.

```csharp
// Exemplo (não recomendado para uso comum)
int numero = 5;

if (numero > 10)
    goto maior;
else
    goto menor;

maior:
    Console.WriteLine("Número é maior que 10");
    goto fim;

menor:
    Console.WriteLine("Número é menor ou igual a 10");
    goto fim;

fim:
    Console.WriteLine("Fim do programa");

// Uso mais apropriado: saindo de loops aninhados
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (i * j > 20)
            goto sair; // Sai de ambos os loops

        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}

sair:
Console.WriteLine("Saiu dos loops aninhados");
```

# Estruturas avançadas

## try-catch-finally

**Definição:** Tratamento de exceções e controle de fluxo em situações de erro.

```csharp
try
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    int resultado = 100 / numero;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Divisão por zero!");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Formato de número inválido!");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Bloco finally sempre executa");
}
```

---

## using

**Definição:** Garante que recursos sejam liberados automaticamente.

```csharp
// Exemplo com arquivo
using (StreamWriter writer = new StreamWriter("arquivo.txt"))
{
    writer.WriteLine("Conteúdo do arquivo");
    // Arquivo é fechado automaticamente ao sair do bloco
}

// Sintaxe mais nova (C# 8.0+)
using StreamReader reader = new StreamReader("arquivo.txt");
string conteudo = reader.ReadToEnd();
// Reader é liberado automaticamente no final do escopo
```
