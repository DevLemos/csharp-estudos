#is #as #aritmeticos #unarios #comparacao #logicos #condicionais #atribuicao #typeof

# Typeof

O operador `Typeof` em C# é usado para obter o tipo de um dado em tempo de compilação. Ele retorna um objeto do tipo `System.Type`, que representa informações do tipo especificado.

Sintaxe:

```csharp
typeof(NomeDoTipo)
```

### Exemplo

```csharp
Console.WriteLine($"\n----------------------------------------------------");

Console.WriteLine("\nExemplo 4");

Console.WriteLine("Operador Typeof");

Console.WriteLine($"Typeof: {typeof(int)}"); //System.Int32
Console.WriteLine($"Typeof: {typeof(string)}"); //System.String
Console.WriteLine($"Typeof: {typeof(DateTime)}\n"); //System.DateTime

if (typeof(int) == typeof(System.Int32))
{
	Console.WriteLine("São equivalentes");
}
```

---

# Operador IS

O **operador IS** serve para **verificar a compatibilidade de tipo de um objeto** em tempo de execução. Ele retorna um valor booleano (true ou false) indicando se um objeto pode ser convertido (ou é compatível) com um tipo especifico.

## Como funciona?

1. `expressao is tipo`:
   1. Verifica se `expressao` (que geralmente é uma variável que contém um objeto) é compatível com `Tipo`.
   2. Retorna `true` se a `expressao` for do `Tipo` especificado, ou de um tipo que **herda** do `Tipo` (uma subclasse), ou se implementar uma `interface` especificada. Caso contrário, retorna `false`
   3. É importante notar que `is` retorna `false` se a `expressao` for `null`
2. `expressao is Tipo nomeVariavel` (Pattern Matching - a partir do C# 7.0):
   1. Esta é uma forma mais moderna e poderosa do `is`.
   2. Ele não só verifica se a `expressao` é compatível com o `Tipo`, mas se for, também a **converte para esse `Tipo` e a atribui a uma nova variável `nomeVariavel`**, tudo em uma única linha e de forma segura.
   3. Se a `expressao` não for compatível com o `Tipo` (ou for `null`), o resultado da expressão `is` é `false`, e a variável `nomeVariavel` não é atribuída (ou mantém seu valor padrão para tipos de valor, ou `null` para tipos de referência).

## Exemplo

### Classes

```csharp
namespace model
{
    public class Animal
    {
        public string Name;
    }
}
```

```csharp
namespace model
{
    public class Cachorro : Animal
    {
        public string Raca;
    }
}
```

```csharp
namespace model
{
    public class Gato : Animal
    {
        public int vidasRestantes;
    }
}
```

```csharp
namespace model
{
    public class Humano
    {
        public string CPF;
    }
}
```

### 1. Primeiro exemplo

```csharp
Animal animal1 = new Cachorro { Name = "Bento", Raca = "Labrador" };
Animal animal2 = new Gato { Name = "Felix", vidasRestantes = 5 };
Humano pessoa = new Humano { CPF = "123.456.789-00" };
Animal animalNulo = null;

Console.WriteLine($"\nanimal1 é um Cachorro? {animal1 is Cachorro}");
Console.WriteLine($"animal1 é um Gato? {animal1 is Gato}");
Console.WriteLine($"animal2 é um Animal? {animal2 is Animal}");
Console.WriteLine($"animal1 é um Animal? {animal1 is Animal}");
Console.WriteLine($"pessoa é um Animal? {pessoa is Animal}");
Console.WriteLine($"animalNulo é um Animal? {animalNulo is Animal}");
Console.WriteLine($"10 é um int? {10 is int}");
Console.WriteLine($"10.00 é um double? {10.00 is double}\n");
```

### 2. Forma moderna (pattern matching)

```csharp
object[] objetosDiversos = new object[]
{  
	new Cachorro { Name = "Bento", Raca = "Labrador" },
	new Gato { Name = "Felix", vidasRestantes = 5 },
	new Humano { CPF = "123.456.789-00" },
	"Olá, Mundo!",
	 123
};

foreach (var item in objetosDiversos)
{
	if (item is Cachorro cachorro)
	{
		Console.WriteLine($"- Encontrado um cachorro, Nome: {cachorro.Name}, Raça: {cachorro.Raca}");
	}
	if (item is Gato gato)
	{
		Console.WriteLine($"- Encontrado um gato, Nome: {gato.Name}, Vidas Restantes: {gato.vidasRestantes}");
	}
	if (item is Humano humano)
	{
		Console.WriteLine($"- Encontrado uma pessoa, CPF: {humano.CPF}");
	}
	if (item is string texto)
	{
		Console.WriteLine($"- Encontrado um texto: '{texto}'");
	}
	if (item is int numero)
	{
		Console.WriteLine($"- Encontrado uma sequência númerica: {numero}");
	}
}

Console.WriteLine($"\n");
```

---

# Pattern Matching (correspondência de padrões)

É uma técnica que testa uma expressão para determinar se ela possui determinadas características.

---

# Operador AS

O operador `AS` é usado para **realizar a conversão segura de dois tipos** (safe cast) entre tipos de referência compatíveis. Ele tenta converter um tipo de objeto para outro tipo de referência. Se a conversão for bem-sucedida, ele retorna o objeto convertido, caso contrário retorna null em vez de lançar uma exceção.

## Como funciona?

A sintaxe básica do operador é:

```csharp
expressao as Tipo;
```

- `expressao`: É a variável ou o objeto que você quer tentar converter.
- `Tipo`: É o tipo de destino para o qual você deseja converter.

## Principais características

1. **Apenas para tipos de referência**: O operador `as` só pode ser usado com **tipos de referência** (classes, interfaces, arrays, delegates, etc.) e tipos que aceitam valor nulo (`Nullable<T>`).
2. **Retorna null em falhas**: Esta é a sua principal vantagem em relação a um _cast explícito_ (`(Tipo)expressao`). Se a `expressao` não for compatível com o `Tipo` especificado, ou se a `expressao` for `null`, o operador `as` simplesmente retorna `null`. Ele **nunca lança uma `InvalidCastException`**.
3. **Performance**: `as` é geralmente mais performático que uma combinação de `is` e um _cast_ separado, pois a verificação de tipo e a conversão são feitas em uma única operação

## Quando usar?

- **Verificação e Conversão Seguras**: Use o operador `as` quando não tem certeza se um objeto é de um determinado tipo (ou de um tipo compatível) e quer evitar que o seu código trave com uma exceção.
- **Em conjunto com verificação de null**: Após usar o operador `as`, você deve sempre verificar se não foi retornado null. Se retornou foi porque a conversão falhou.

## Como funciona na prática?

Imagine que você tenha uma hierarquia de classes

```csharp
class Animal { }
class Cachorro : Animal
{
    public void Latir() => Console.WriteLine("Au au!");
}
class Gato : Animal
{
    public void Miar() => Console.WriteLine("Miau!");
}
```

Agora vamos ver o operador `as` em ação:

```csharp
public static void ExemploAsBasico()
{
	Console.WriteLine("\n---- Operador AS ----\n");
	Animal animal1 = new Cachorro { Name = "Bento", Raca = "Labrador" };
	Animal animal2 = new Gato { Name = "Felix", vidasRestantes = 5 };

	// Usando o operador as
	Cachorro cachorro1 = animal1 as Cachorro; // aqui deu certo
	Cachorro cachorro2 = animal2 as Cachorro; // aqui deu errado
	Gato gato = animal2 as Gato; // aqui deu certo

	if (cachorro1 != null)
	{
		Console.WriteLine("---- Cenário 1: Conversão bem-sucedida ----");
		Console.WriteLine($"- Encontrado um cachorro, Nome: {cachorro1.Name}, Raça: {cachorro1.Raca}\n");
	}
	if (cachorro2 == null)
	{
		Console.WriteLine("---- Cenário 2: Conversão mal-sucedida ----");
		Console.WriteLine($"- Objeto não encontrado: O objeto que está tentando converter não é do tipo certo.\n");
	}
	if (gato != null)
	{
		Console.WriteLine("---- Cenário 3: Conversão bem-sucedida ----");
		Console.WriteLine($"- Encontrado um gato, Nome: {gato.Name}, Vidas Restantes: {gato.vidasRestantes}\n");
	}
}
```

### Explicação

Básicamente eu declaro 2 variáveis do `tipo Animal`uma chamada `animal1` que recebe um objeto Cachorro e tenho outra variável chamada `animal2` que recebe um objeto Gato. Depois eu crio uma variável cachorro do tipo Cachorro, pego a variável `animal1` que contém um Cachorro e `as Cachorro` tenta converter o objeto para o tipo Cachorro, como `animal1` realmente contém um `Cachorro`, a conversão funciona e `cachorro` recebe o objeto convertido.

```csharp
Animal animal1 = new Cachorro { Name = "Bento", Raca = "Labrador" };
Animal animal2 = new Gato { Name = "Felix", vidasRestantes = 5 };

Cachorro cachorro = animal1 as Cachorro;
```

## Diferença entre `as` e casting direto

### Com casting direto

```csharp
Animal meuAnimal = new Cachorro();
Cachorro cachorro = (Cachorro)meuAnimal; // Pode gerar exceção se falhar
```

### Com o operador as

```csharp
Animal meuAnimal = new Cachorro();
Cachorro cachorro = meuAnimal as Cachorro; // Retorna null se falhar
```

### Limitações importantes

O `as` só funciona em

- Tipos de referência (classes)
- Tipos anuláveis (como int?)
- Conversões que o compilador considera válidas
- Não funciona com tipos primitivos

```csharp
object obj = 42;
int numero = obj as int; // ERRO de compilação!
```

---

# Operadores Aritméticos

Operadores básicos:

- `(+)` Adição
- `(-)` Subtração
- `(*)` Multiplicação
- `(/)` Divisão
- `(%)` Módulo (resto da divisão)

---

# Operadores de Comparação

- `==` Igual
- `!=` Diferente
- `>` Maior que
- `<` Menor que
- `>=` Maior ou igual
- `<=` Menor ou igual

```csharp
Console.WriteLine("\n Operadores de Comparação\n");

int a = 10, b = 5, c = 10;

Console.WriteLine($"Valores: a = {a}, b = {b}, c = {c}\n");
Console.WriteLine($"a == c: {a == c}  (igual)");
Console.WriteLine($"a != b: {a != b}  (diferente)");
Console.WriteLine($"a > b:  {a > b}   (maior que)");
Console.WriteLine($"a < b:  {a < b}   (menor que)");
Console.WriteLine($"a >= c: {a >= c}  (maior ou igual)");
Console.WriteLine($"b <= a: {b <= a}  (menor ou igual)\n");
```

---

# Operadores Lógicos

- `&&` (E ou AND): Se ambas expressões for verdadeira
- `||` (OU ou OR): Se pelo menos uma das expressões for verdadeira
- `!` (Não ou NOT): Inverte o valor lógico
- `^` (Ou exclusivo ou XOR): True se apenas uma das expressões for verdadeira (mas não ambas)

```csharp
Console.WriteLine("\n Operadores Lógicos\n");

bool x = true, y = false;

Console.WriteLine($"Valores: x = {x}, y = {y}");
Console.WriteLine($"x && y: {x && y} (E lógico - AND)");
Console.WriteLine($"x || y: {x || y} (OU lógico - OR)"); Console.WriteLine($"!x: {!x} (NÃO lógico - NOT)");
Console.WriteLine($"x ^ y: {x ^ y} (OU exclusivo - XOR)\n");
```

```csharp
bool resultado = true ^ false; // true
bool resultado2 = true ^ true; // false
```

---

# Operadores de Atribuição

- `+=` (x = x + 5)
- `-=` (x = x - 3)
- `*=` (x = x \* 2)
- `/=` (x = x / 4)
- `%=` (x = x % 3)

```csharp
Console.WriteLine("\n Operadores de Atribuição\n");
int num = 10;
Console.WriteLine($"Valor inicial: {num}");
num += 5; Console.WriteLine($"num += 5: {num}");
num -= 3; Console.WriteLine($"num -= 3: {num}");
num *= 2; Console.WriteLine($"num *= 2: {num}");
num /= 4; Console.WriteLine($"num /= 4: {num}");
num %= 3; Console.WriteLine($"num %= 3: {num}");
Console.WriteLine();
```

---

# Operadores Condicionais

- `?:` Operador Ternário
- `??` Operador de Coalescência Nula
- `??=` Operador de Coalescência Nula (.NET +8.0)

### Ternário

O operador condicional ternário avalia uma expressão booleana e retorna o resultado de uma das duas expressões, dependendo se a expressão é avaliada como `true` ou `false`;

```csharp
Console.WriteLine("\nOperadores Condicionais\n");
int idade = 20;

string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade"; Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Resultado: {resultado}");
```

### Coalescência Nula

O operador de Coalescência Nula retorna o valor do seu operando à esquerda se não for `null`, caso contrário avalia o operando à direita e retorna o seu resultado. O operador `??` não avalia seu operando a direita se o operando à esquerda for avaliado como não nulo.

```csharp
Console.WriteLine("\nOperador Coalescência Nula (??):\n");

string nome = null;
string nomePadrao = nome ?? "Sem nome";
Console.WriteLine($"Nome: {nome ?? "Null"}");
Console.WriteLine($"Nome Padrão: {nomePadrao}\n");
```

### Atribuição de Coalescência Nula

O operador de atribuição de coalescência nula `??=` atribuir o valor do seu operando à direita ao seu operando à esquerda somente se o operador à esquerda for avaliado como null. O `??=`operador não avalia seu operando à direita se o operando à esquerda for avaliado como não nulo.

```csharp
Console.WriteLine("\nOperador de Atribuição de Coalescência Nula (??=):\n");
nome ??= "João";
Console.WriteLine($"nome após o operador de atribuição de coalescência nula: {nome}");
```

---

# Acesso a Membros

- `.` Acessa membros de uma instância ou tipo.
- `?.` Acessa membros **somente se o objeto não for `null`**. Evita exceção.
- `[ ]` Acessa elementos por índice em arrays, listas ou strings.
- `[..]` É sintaxe de slicing (fatiar), usada com **arrays ou spans** para **extrair subarrays**.

### ponto ( . )

```csharp
Console.WriteLine("\nExemplo 1");

Console.WriteLine("Ponto (.)\n");
var pessoa = new { Nome = "João", Idade = 23 };
Console.WriteLine($"pessoa.Nome: {pessoa.Nome}"); //acesso direto
```

### Condicional nulo ( ?. )

```csharp
Console.WriteLine("\nExemplo 2");

Console.WriteLine("Condicional Nulo (?.)\n");
string textoNulo = null;
Console.WriteLine($"textoNulo?.Length: {textoNulo?.Length ?? 0} (safe navigation)");
```

### acesso por índice ( [ ] )

```csharp
Console.WriteLine("\nExemplo 3");

Console.WriteLine("Índices ([])\n");
int[] array = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine($"array[2]: {array[2]} (acesso por índice)");
```

### slicing (fatiar)

```csharp
Console.WriteLine("\nExemplo 4");

Console.WriteLine("Slicing (fatiar) ([..])\n");
Console.WriteLine($"array[1..3]: [{string.Join(", ", array[1..3])}] (range)\n");
```

- `[..]` → **todo o array**
- `[..3]` → do início até o índice 2
- `[2..]` → do índice 2 até o final
- `[1..4]` → do índice 1 até 3 (fim é exclusivo)

---

# Operadores Especiais

- `typeof` Retorna o `System.Type` de um tipo em tempo de compilação
- `sizeof` Retorna o número de bytes ocupados por um tipo (em código unsafe).
- `default` Retorna o valor padrão de um tipo (ex: 0, null, false, etc)
- `nameof` Produz o nome de uma variável, de um tipo, ou membro como a constante de cadeia de caracteres.
- `new` O operador new é usado para criar objetos de classes, instanciar arrays, alocar memória no heap, chamar construtores.
- `stackalloc` O operador é usado para alocar memória na stack (em vez do heap), e só pode ser usado com tipos `Span<T>` ou ponteiros (unsafe). Útil para criar blocos temporários na memória, evitando o garbage collector.

### typeof

Retorna o tipo de um dado em tempo de compilação

```csharp
Console.WriteLine(typeof(int)); // System.Int32
Console.WriteLine(typeof(string)); // System.String
```

### sizeof

Retorna o tamanho em bytes de um tipo primitivo. Só pode ser usado com tipos simples ou em contexto unsafe.

```csharp
Console.WriteLine(sizeof(int)); // 4
Console.WriteLine(sizeof(double)); // 8
```

### nameof

Retorna o nome literal de uma variável, propriedade ou método como string.

```csharp
string nome = "João";
Console.WriteLine(nameof(nome)); // "nome"
```

### default

Usado para obter o valor padrão de um tipo. Pode ser usado por value types ou reference types

Sintaxe 1

```csharp
int valorPadrao = default(int);       // 0
bool estaAtivo = default(bool);       // false
string nome = default(string);        // null
```

Sintaxe 2

```csharp
int numero = default;           // equivalente a: int numero = 0;
string texto = default;         // equivalente a: string texto = null;
```

### Quando usar?

- Para inicializar variáveis com valor padrão
- Em **genéricos**, quando não se sabe o tipo exato.

```csharp
public T RetornarOuDefault<T>(bool retornarValor, T valor)
{
    return retornarValor ? valor : default(T);
}
```

### new

O operador new é usado com classes, structs, arrays, coleções e tipos anônimos. Memória gerenciada pelo Garbage Collector, mais lento que stackalloc, porém mais seguro.

```csharp
// 1. NEW COM TIPOS PRIMITIVOS
Console.WriteLine("1. NEW com tipos primitivos:");
int numero = new int(); // Equivale a: int numero = 0;
bool flag = new bool(); // Equivale a: bool flag = false;

Console.WriteLine($"int inicializado: {numero}");
Console.WriteLine($"bool inicializado: {flag}\n");
```

```csharp
// 2. NEW COM CLASSES
Console.WriteLine("2. NEW com classes:");

Pessoa pessoa1 = new Pessoa(); // Construtor padrão
pessoa1.Nome = "João";
pessoa1.Idade = 30;

Pessoa pessoa2 = new Pessoa("Maria", 25); // Construtor com parâmetros

Pessoa pessoa3 = new Pessoa // Object initializer syntax
{   Nome = "Pedro",
	Idade = 35
};

Console.WriteLine($"Pessoa1: {pessoa1.Nome}, {pessoa1.Idade}"); Console.WriteLine($"Pessoa2: {pessoa2.Nome}, {pessoa2.Idade}"); Console.WriteLine($"Pessoa3: {pessoa3.Nome}, {pessoa3.Idade}\n");
```

### stackalloc

O operador stackalloc é usado com arrays pequenos e temporários. Memória liberada automaticamente, mais rápido que new, porém usada apenas em uso local (não pode retornar nada) e limitado pelo tamanho da stack.

```csharp
Console.WriteLine("7. STACKALLOC básico:");

// stackalloc com Span<T> (forma segura - C# 7.2+)
Span<int> spanNumeros = stackalloc int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine("Números no span:");
for (int i = 0; i < spanNumeros.Length; i++)
{
	Console.WriteLine($" spanNumeros[{i}] = {spanNumeros[i]}");
}
// Modificando valores
spanNumeros[0] = 10;
spanNumeros[4] = 50;
Console.WriteLine($"Após modificação: [{string.Join(", ", spanNumeros.ToArray())}]\n");
```

---

# Operadores Unários

- `++` Incremento (pré e pós)
- `--` Decremento (pré e pós)
- `-` Negação unária
- `+` Positivo unário

---

# Precedência de Operadores

- `1. ()` Parênteses
- `2. +, -, ++, --` (unários)
- `3. * , /, %`
- `4. +, -` (binários)

```csharp
// Exemplos de precedência
int resultado1 = 2 + 3 * 4; // = 2 + 12 = 14
int resultado2 = (2 + 3) * 4; // = 5 * 4 = 20
int resultado3 = 10 - 6 / 2; // = 10 - 3 = 7
int resultado4 = (10 - 6) / 2; // = 4 / 2 = 2
```

```csharp
Console.WriteLine("Exemplos de precedência:");
Console.WriteLine($" 2 + 3 * 4 = {resultado1}");
Console.WriteLine($" (2 + 3) * 4 = {resultado2}");
Console.WriteLine($" 10 - 6 / 2 = {resultado3}");
Console.WriteLine($" (10 - 6) / 2 = {resultado4}");
```

---
