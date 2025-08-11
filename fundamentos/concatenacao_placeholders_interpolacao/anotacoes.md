# Concatenação

Une strings usando o operador `+` ou métodos especificos. Cria uma nova string a cada operação.

```csharp
public static void Main(string[] args)
{
	Console.WriteLine("--------- Concatenação ---------\\n");

	string nome = "Kauan";
	int idade = 23;

	//Operador +
	string resultado1 = "Olá " + nome + ", você tem " + idade + " anos";
	// saída: Olá Kauan, você tem 23 anos

	//String.Concat(mais eficiente para multiplas strings)

	string resultado2 = string.Concat("Nome: ", nome, " | Idade: ", idade);
	// saída: Nome: Kauan | Idade: 23
	Console.WriteLine(resultado1);
	Console.WriteLine(resultado2);

	//Concatenação em loop (problemático)
	string lista = "";
	for (int i = 1; i <= 3; i++)
	{
	      lista = lista + "Item : " + i + ", ";
	      Console.WriteLine(lista);
	}
}
```

## Porque concatenação em loop é problemático?

### Problema

Strings em C# **são imutáveis**, o que significa que toda vez que você altera uma string, uma nova string é criada na memória.

```csharp
string lista = "";
for (int i = 1; i <= 3; i++)
{
    lista = lista + "Item " + i + ", ";
}
```

### Iteração por iteracão:

- **Iteração 1**: cria uma nova string "Item 1, "
- **Iteração 2**: cria uma nova string "Item 1, Item 2, "
- **Iteração 3**: cria uma nova string "Item 1, Item 2, Item 3, "

Cada vez que você usa `+`, **todas as strings anteriores são copiadas para uma nova alocação** na memória. Para 3 itens, tudo bem, mas **com milhares de itens, o impacto é grande** (tempo + memória).

## Pra que serve?

- Juntar poucas strings simples
- Quando não precisa de formatação especial
- Operações pontuais (não em loops)

# Placeholders (string.Format)

Os placeholders substitui marcadores numerados `{0}`, `{1}`, etc. Pelos argumentos fornecidos e permite formatação avançada.

```csharp
public static void Main(string[] args)
{
	Console.WriteLine("\\n--------- Placeholders ---------\\n");

	string nome2 = "Maria";
	int idade2 = 30;
	decimal salario = 3500.75m;
	DateTime data = new DateTime(2002, 02, 20);

	//Básico - substitui {0} por nome, {1} por idade
	string resultado3 = string.Format(
	"Nome: {0} | Idade: {1}", nome2, idade2);
	// saída: Nome: Maria | Idade: 30
	Console.WriteLine(resultado3);

	//Com formatação especifica
	string resultado4 = string.Format(
	"Salário: {0:C} | Data: {1:dd/MM/yyyy}", salario, data);
	// saída: Salário: $3,500.75 | Data: 20/02/2002
	Console.WriteLine(resultado4);

	//Reutilização de argumentos
	string resultado5 = string.Format(
	"{0} trabalha aqui. {0} recebe por mês {1:C}", nome2, salario);
	// saída: Maria trabalha aqui. Maria recebe por mês $3,500.75
	Console.WriteLine(resultado5);

	//Alinhamento e largura
	// Resultado: "| Maria           |    30 | R$ 3.500,75 |"
	//                 ↑ 15 chars esquerda  ↑ 5 chars direita  ↑ 10 chars direita

	string tabela = string.Format(
	"| {0,-15} | {1,5} | {2,10:C} |", nome2, idade2, salario);
	 Console.WriteLine(tabela);

	// Console.WriteLine usa o mesmo sistema
	Console.WriteLine(
	"Produto: {0}, Preço: {1:F2}", "Notebook", 2500.99);
	// saída: Produto: Notebook, Preço: 2500.99
}
```

## Formatação Avançada

| Especificação | Nome                        | Descrição                                                                                                       | Exemplos                                                                                                      |
| ------------- | --------------------------- | --------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `"B" ou "b"`  | Binário                     | uma cadeia de caracteres <br>binários                                                                           | 42 ("B") -> 101010                                                                                            |
| `"C" ou "c"`  | Moeda                       | um valor de moeda                                                                                               | 123,456 ("C", en-US) -> $123,46<br>-123.456 ("C3", en-US) -> ($123,456)<br>123,456 ("C", fr-FR) -> 123,46 €   |
| `"D" ou "d"`  | Decimal                     | dígitos inteiros com sinal<br>negativo opcional                                                                 | 1234 ("D") -> 1234<br>-1234 ("D6") -> -001234                                                                 |
| `"E" ou "e"`  | Exponencial<br>(Ciêntífico) | notação exponencial                                                                                             | 1052.0329112756 ("E", en-US) <br>-> 1,052033E+003                                                             |
| `"F" ou "f"`  | Ponto fixo<br>(fixed point) | dígitos integrais e decimais<br>com sinal negativo opcional                                                     | 1234.567 ("F", en-US) -> 1234,57<br>-1234,56 ("F4", en-US) <br>-> -1234.5600                                  |
| `"G" ou "g"`  | Geral                       | o mais compacto da <br>notação de ponto fixo <br>ou ciêntífico                                                  | -123,456 ("G", en-US) -> -123.456<br>123,4546 ("G4", en-US) <br>-> 123,5                                      |
| `"N" ou "n"`  | Número                      | dígitos integrais e decimais,<br>separadores de grupo e <br>um separador decimal<br>com sinal negativo opcional | 1234,567 ("N", en-US) -> 1.234,57<br>1234 ("N1", ru-RU) -> 1234,0<br>-1234,56 ("N3", en-US) <br>-> -1.234.560 |
| `"P" ou "p"`  | Porcentagem                 | número multiplicado por<br>100 e exibido por um<br>sinal de porcentagem                                         | 1 ("P", en-US) -> 100,00 %<br>-0,39678 ("P1", en-US) -> -39,7 %                                               |
| `"X" ou "x"`  | Hexadecimal                 | uma cadeia de caracteres<br>hexadecimal                                                                         | 255 ("X") -> FF<br>255 ("x4") -> 00ff                                                                         |
| `"d"`         | Data                        | padrão de data abreviada                                                                                        | 2009-06-15T13:45:30 -> 6/15/2009 (en-US)                                                                      |
| `"D"`         | Data                        | padrão de data completa                                                                                         | 2009-06-15T13:45:30 -> Monday, June 15, 2009 (en-US)                                                          |
| `"f"`         | Data/Hora                   | padrão de data/hora<br>completa (hora abreviada)                                                                | 2009-06-15T13:45:30 -> Monday, June 15, 2009 1:45 PM (en-US)                                                  |
| `"F"`         | Data/Hora                   | padrão de data/hora<br>completa (hora completa)                                                                 | 2009-06-15T13:45:30 -> Monday, June 15, 2009 1:45:30 PM (en-US)                                               |
| `"g"`         | Data/Hora                   | padrão geral de data/hora (hora abreviada)                                                                      | 2009-06-15T13:45:30 -> 6/15/2009 1:45 PM (en-US)                                                              |
| `"G"`         | Data/Hora                   | padrão geral de data/hora (hora completa)                                                                       | 2009-06-15T13:45:30 -> 6/15/2009 1:45:30 PM (en-US)                                                           |
| `"M" , "m"`   | Mês/Dia                     | padrão de mês/dia                                                                                               | 2009-06-15T13:45:30 -> June 15 (en-US)                                                                        |
| `"O" , "o"`   | Data/Hora                   | padrão de data/hora<br>de ida e volta                                                                           | 2009-06-15T13:45:30 (DateTimeKind.Local) --> 2009-06-15T13:45:30.0000000-07:00                                |
| `"R", "r"`    | Data/Hora                   | padrão RFC1123                                                                                                  | 2009-06-15T13:45:30 -> Seg, 15 Jun 2009 13:45:30 GMT                                                          |
| `"s"`         | Data/Hora                   | padrão de data/hora<br>classificável                                                                            | 2009-06-15T13:45:30 (DateTimeKind.Local) -> 2009-06-15T13:45:30                                               |
| `"t"`         | Hora                        | padrão de hora <br>abreviada                                                                                    | 2009-06-15T13:45:30 -> 1:45 PM (en-US)                                                                        |
| `"T"`         | Hora                        | padrão de hora completa                                                                                         | 2009-06-15T13:45:30 -> 1:45:30 PM (en-US)                                                                     |
| `"u"`         | Data/Hora                   | padrão classificável universal de data/hora                                                                     | 2009-06-15T13:45:30 -> 2009-06-15 13:45:30Z                                                                   |
| `"U"`         | Data/Hora                   | padrão classificável universal de data/hora completo                                                            | 2009-06-15T13:45:30 -> segunda-feira, 15 de junho de 2009 8:45:30 PM (en-US)                                  |
| `"Y", "y"`    | Ano/Mês                     | padrão ano mês                                                                                                  | 2009-06-15T13:45:30 -> June 2009 (en-US)                                                                      |

## Especificadores Numéricos Padrão

`Currency (Moeda)`

```csharp
decimal valor = 1234.56m;
Console.WriteLine($"{valor:C}");    // R$ 1.234,56
Console.WriteLine($"{valor:C2}");   // R$ 1.234,56 (2 casas decimais)
Console.WriteLine($"{valor:C0}");   // R$ 1.235 (sem casas decimais)
```

`Decimal (apenas inteiros)`

```csharp
int numero = 123;
Console.WriteLine($"{numero:D}");   // 123
Console.WriteLine($"{numero:D5}");  // 00123 (5 dígitos, com zeros à esquerda)
```

`Fixed-point (ponto fixo)`

```csharp
double valor = 123.456789;
Console.WriteLine($"{valor:F}");    // 123,46 (2 casas por padrão)
Console.WriteLine($"{valor:F4}");   // 123,4568 (4 casas decimais)
```

`Number (número com separadores de milhares)`

```csharp
double numero = 1234567.89;
Console.WriteLine($"{numero:N}");   // 1.234.567,89
Console.WriteLine($"{numero:N0}");  // 1.234.568 (sem casas decimais)
```

`Percent (porcentagem)`

```csharp
double percentual = 0.1234;
Console.WriteLine($"{percentual:P}");   // 12,34%
Console.WriteLine($"{percentual:P0}");  // 12% (sem casas decimais)
```

`Scientific (notação científica)`

```csharp
double numero = 1234.567;
Console.WriteLine($"{numero:E}");   // 1,234567E+003
Console.WriteLine($"{numero:e2}");  // 1,23e+003 (2 casas decimais)
```

`Hexadecimal`

```csharp
int numero = 255;
Console.WriteLine($"{numero:X}");   // FF
Console.WriteLine($"{numero:x4}");  // 00ff (4 dígitos, minúsculas)
```

## Especificadores de Data e Hora

**Padrões completos:**

```csharp
DateTime agora = DateTime.Now;
Console.WriteLine($"{agora:F}");    // sexta-feira, 25 de julho de 2025 14:30:25
Console.WriteLine($"{agora:D}");    // sexta-feira, 25 de julho de 2025
Console.WriteLine($"{agora:T}");    // 14:30:25
```

**Padrões personalizados:**

```csharp
DateTime data = new DateTime(2025, 7, 25, 14, 30, 25);
Console.WriteLine($"{data:dd/MM/yyyy}");        // 25/07/2025
Console.WriteLine($"{data:HH:mm:ss}");          // 14:30:25
Console.WriteLine($"{data:dddd, MMMM dd}");     // sexta-feira, julho 25
Console.WriteLine($"{data:yyyy-MM-dd HH:mm}");  // 2025-07-25 14:30
```

**Números com formato customizado:**

```csharp
double valor = 1234.5;
Console.WriteLine($"{valor:#,##0.00}");     // 1.234,50
Console.WriteLine($"{valor:000000.000}");   // 001234,500
Console.WriteLine($"{valor:#.##}");         // 1234,5

```

## Especificadores com CultureInfo

```csharp
using System.Globalization;

decimal preco = 1234.56m;
var culturaBR = new CultureInfo("pt-BR");
var culturaUS = new CultureInfo("en-US");

Console.WriteLine(preco.ToString("C", culturaBR)); // R$ 1.234,56
Console.WriteLine(preco.ToString("C", culturaUS)); // $1,234.56
```

## Formatação Composta

A formatação composta em C#, é uma técnica de formatação de strings usando um template com placeholders numerados e uma lista de argumentos. A formatação composta usa um string de formato que contém texto fixo misturado com itens de formato. A sintaxe dos itens de formato são `{index[,width][:formatString]}`

### Componentes dos Itens de Formato

- `Índices(index)`: Especifica qual argumento usar (começando do 0)

```csharp
string.Format("{0} + {1} = {2}", 5, 3, 8); // "5 + 3 = 8"
```

- `Alinhamento(width)`: Define a largura do campo e alinhamento (opcional)

```csharp
string.Format("|{0,10}|{1,-10}|", "Direita", "Esquerda");
// "|    Direita|Esquerda  |"
```

- `Especificador de formato(opcional)`: Define como formatar o valor

```csharp
decimal preco = 123.456m;
string.Format("Preço: {0:C}", preco); // "Preço: R$ 123,46"
string.Format("Data: {0:dd/MM/yyyy}", DateTime.Now); // "Data: 25/07/2025"
```

### Onde é usado?

A formatação composta é usada em vários métodos:

- `string.Format()`
- `Console.WriteLine()`
- `StringBuilder.AppendFormat()`
- E outros métodos que aceitam strings de formato

### Exemplo

```csharp
string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                   "Ebenezer", "Francine", "George" };
decimal[] hours = { 40, 6.667m, 40.39m, 82,
                    40.333m, 80, 16.75m };

Console.WriteLine("{0,-20} {1,5}\\n", "Name", "Hours");

for (int counter = 0; counter < names.Length; counter++)
    Console.WriteLine("{0,-20} {1,5:N1}",
    names[counter],hours[counter]);

// The example displays the following output:
//      Name                 Hours
//
//      Adam                  40.0
//      Bridgette              6.7
//      Carla                 40.4
//      Daniel                82.0
//      Ebenezer              40.3
//      Francine              80.0
//      George                16.8
```

### Chaves de Escape

```csharp
 string teste = "chaves";
 Console.WriteLine("|{{0,-20}}|", teste);
//|{0,-20}|
```

```csharp
string teste = "chaves";
Console.WriteLine("|{{{0,-20}}}|", teste);
//|{chaves              }|
```

# Interpolação

Interpolação de strings em C# é uma forma moderna e mais legível de montar strings dinâmicas, ou seja, strings que combinam texto fixo com valores de variáveis. Usando `$` no começo e as valores entre `{}`, assim é a sintaxe da interpolação.

```csharp
Console.WriteLine("\n--------- Interpolação ---------\n");

string nome3 = "José";
int idade3 = 30;
decimal salario2 = 3500.75m;

// Básico - variáveis diretas
Console.WriteLine($"Nome: {nome3}, Idade: {idade3}");

//// Com formatação
Console.WriteLine($"Salário: {salario2:C}");

// Com expressões matemáticas
Console.WriteLine($"Você nasceu em {DateTime.Now.Year - idade3}");

// Com operador ternário
Console.WriteLine($"Status: {(idade3 >= 18 ? "Adulto" : "Menor")}");

// Com métodos
Console.WriteLine($"Nome maiúsculo: {nome3.ToUpper()}");

// Com propriedades/métodos de objetos
DateTime data2 = new DateTime(2023, 12, 25);
Console.WriteLine($"Hoje é {data2.DayOfWeek} e estamos no mês {data2.Month}");

// Alinhamento (igual aos placeholders)
Console.WriteLine($"| {nome3,-15} | {idade3,5} | {salario2,10:C} |");

// Multilinha com expressão
Console.WriteLine($@"
=== RELATÓRIO FUNCIONÁRIO ===
Nome: {nome3}
Idade: {idade3}
Salário: {salario2:C}
Categoria: {(salario2 > 4000 ? "Sênior" : "Júnior")}
Data: {DateTime.Now:dd/MM/yyyy HH:mm}");

var culturaBR = new CultureInfo("pt-BR");
var culturaUS = new CultureInfo("en-US");

Console.WriteLine($"Interpolação com cultura especifica, salário BR: {salario2.ToString("C", culturaBR)}");
Console.WriteLine($"Interpolação com cultura especifica, salário US: {salario2.ToString("C", culturaUS)}");
```

Resultado do código acima:

```csharp
--------- Interpolação ---------

Nome: José, Idade: 30
Salário: $3,500.75
Você nasceu em 1995
Status: Adulto
Nome maiúsculo: JOSÉ
Hoje é Monday e estamos no mês 12
| José            |    30 |  $3,500.75 |

            === RELATÓRIO FUNCIONÁRIO ===
            Nome: José
            Idade: 30
            Salário: $3,500.75
            Categoria: Júnior
            Data: 28/07/2025 10:58
Interpolação com cultura especifica, salário BR: R$ 3.500,75
Interpolação com cultura especifica, salário US: $3,500.75
```

## Exercício de Fixação

Em um novo programa, inicie as seguintes variáveis:

```csharp
string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;
```

Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:

```
Produtos:
Computador, cujo preço é $ 2100,00
Mesa de escritório, cujo preco é $ 650,50
Registro: 30 anos de idade, código 5290 e gênero: M
Medida com oito casas decimais: 53,23456700
Arredondado (três casas decimais): 53,235
Separador decimal invariant culture: 53.235
```

Resolução:

```csharp
using System;
using System.Globalization;

namespace Course {
	class Program {
		static void Main(string[] args) {
			string produto1 = "Computador";
			string produto2 = "Mesa de escritório";

			byte idade = 30;
			int codigo = 5290;
			char genero = 'M';

			double preco1 = 2100.0;
			double preco2 = 650.50;
			double medida = 53.234567;

			Console.WriteLine("Produtos:");
			Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
			Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
			Console.WriteLine();
			Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
			Console.WriteLine();
			Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
			Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
			Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
		}
	}
}
```
