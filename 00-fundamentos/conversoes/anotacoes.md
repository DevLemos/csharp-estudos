# Conversão Implícita

Conversão implícita é quando o C# faz a conversão automaticamente, sem precisar do programador indicar. Isso só acontece quando não há risco de perda de dados.

```csharp
int inteiro = 100;
long numeroMaior = inteiro;
```

- Conversão implícita de **int** para **long**.
- **Int** cabe perfeitamente em long, então o compilador faz a conversão sem reclamar.

## Regras

- O tipo de destino deve ser maior (mais capaz) que o original.
- Apenas entre tipos compatíveis.

## Exemplo

Neste exemplo estamos pegando o valor que contém dentro da variável **c** que é do tipo **float** e colocando dentro da variável **d** que é um **double**. O double aceita até 8 bytes e o float até 4 bytes, então essa conversão vai ser feita sem perda de dados, pois estamos colocando um menor dentro de um que é maior.

```csharp
 //conversão implícita
float c = 4.5f;
double d = c;

Console.WriteLine(d);
```

---

# Conversão Explícita

Conversão explícita é quando você força a conversão entre tipos, usando operador de **casting (tipo).** Usado quando existe rísco de perda de dados ou quando os tipos não são implicitamente compátiveis.

```csharp
double numeroDecimal = 10.5;
int inteiro = (int)numeroDecimal;
```

- Conversão explícita perde o **.5**

## Regras

- Pode causar perda de dados.
- Pode gerar exceções em tempo de execução.

## Exemplo

Neste exemplo tem duas variáveis que entregam resultados diferentes por conta de seus tipos. A variável b do tipo float está fazendo a conversão explícita com casting da variável a double para float mas neste exemplo não tem perda de dados. Logo abaixo, segue outro exemplo com a variável n do tipo int, neste casting tem perda de dados pois um double não cabe em um int.

```csharp
//conversão explicita (casting)
double a = 5.1;
float b = (float)a;
int n = (int)a;

Console.WriteLine(b);
Console.WriteLine(n);
```

---

# Casting (conversão forçada)

**Casting** é o nome do ato de fazer uma conversão explícita, geralmente com (tipo).

```csharp
var novoTipo = (tipoDesejado)variavelOriginal;
```

```csharp
object obj = "Kauan";
string nome = (string)obj;
```

# Parse e TryParse

**Parse** e **TryParse** são métodos que temos para converter, ou tentar converter, uma string para outro tipo de forma explícita no C#.

# Parse

O Parse funciona como uma extensão aos métodos built-in (tipos primitivos), onde podemos invocar o método informando uma string (cadeia de caracteres), como por exemplo: `int.Parse("123")`. Ele converte essa string em um tipo especifico, mas **lança uma exceção** se a conversão falhar.

Link documentação: https://learn.microsoft.com/pt-br/dotnet/api/system.int32.parse?view=net-8.0

## Exemplos

```csharp
var valor = int.Parse("123");
var valor2 = bool.Parse("true");
var valor3 = DateTime.Parse("01/01/2022");

Console.WriteLine(valor);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
```

Como resultado da execução deste programa temos o seguinte texto sendo impresso na tela.

```
123
True
1/1/2022 12:00:00 AM
```

---

# TryParse

O método `TryParse` tem a mesma função do `Parse`, converter (tentar transformar) uma string em outro tipo de dado (`int`, `double`, `DateTime`, etc) de forma segura, sem gerar exceção se a conversão falhar.

```csharp
string numeroTexto = "123";
if (int.TryParse(numeroTexto, out int numero))
{
    Console.WriteLine($"Conversão bem-sucedida: {numero}");
}
else
{
    Console.WriteLine("Falha na conversão");
}

// Mais conciso com C# 7+
if (int.TryParse("456", out var outroNumero))
{
    // usar outroNumero aqui
}
```

---

# IFormatProvider

É uma interface em C# presente no `namespace System`, que desempenha um papel crucial na formatação e análise de dados de acordo com regras especificas de cultura e localização. Basicamente ela define um mecanismo para obter um objeto que sabe formatar valores (como números, datas, moedas) ou analisar strings para convertê-las em tipos de dados, levando em consideração sua cultura.

## Object GetFormat(Type formatType)

Esse método é usado internamente por métodos de formatação e análise (como `ToString( )`, `Parse( )`, `Format( )`) para solicitar um objeto que implementa uma interface de formatação especifica (como `NumberFormatInfo` para números, `DateTimeFormatInfo` para datas e horas).

## Exemplos de Uso na Prática

Temos um `DateTime` e estamos passando o valor **01/01/2022** para o mesmo. Este valor foi proposital para não causar nenhum erro. Agora vamos considerar uma nova data 28/10/2021, onde temos o formato `dd/MM/yyyy`, um formato utilizado aqui no Brasil, mas diferente dos EUA (formato padrão do .NET) que utiliza `MM/dd/yyyy`.

```
Unhandled exception. System.FormatException: String '28/10/2021' was not recognized as a valid DateTime.
   at System.DateTime.Parse(String s)
   at Program.<Main>$(String[] args) in C:\dev\CsharpTryParse\Program.cs:line 8
```

Neste caso, a conversão falharia, pois `28/10/2021` não é uma data válida nos EUA, o correto seria `10/28/2021`, mas felizmente conseguimos contornar isto utilizando uma cultura.

```csharp
var culture = new CultureInfo("pt-BR");
var valor3 = DateTime.Parse("28/10/2021", culture);
```

Note que agora temos um objeto do tipo `CultureInfo`, que define a cultura como `pt-BR` (Português do Brasil) e quando executamos o `Parse`, informamos também a cultura, resultando no sucesso da conversão.

Importante ressaltar que os valores de exemplo das variáveis são do tipo `string` e eu estou convertendo para `decimal` utilizando o `Parse` e `TryParse`. Logo após utilizo o `ToString ()` para formatar a impressão.

```csharp
//IFormatProvider (formatar e interpretar dependendo da cultura)
string valorBR = "1.234,60"; // Brasil usa vírgula para decimal
string valorUS = "1,234.60"; // EUA usa ponto para decimal

//Parse considerando a cultura brasileira
decimal valorDecimalBR = decimal.Parse(valorBR, new CultureInfo("pt-BR"));
 Console.WriteLine($"Valor convertido para decimal BR: {valorDecimalBR.ToString(new CultureInfo("pt-BR"))}");

 //Parse considerando a cultura americana
decimal valorDecimalUS = decimal.Parse(valorUS, new CultureInfo("en-US"));
Console.WriteLine($"Valor convertido para decimal US: {valorDecimalUS.ToString(new CultureInfo("en-US"))}");


// TryParse com cultura específica
if (decimal.TryParse(valorBR, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal resultadoConversao))
{
	Console.WriteLine($"Valor: {resultadoConversao}");
}
```

Pegando a `cultura atual` do sistema:

```csharp
//Pega a cultura do sistema
Console.WriteLine($"Cultura atual do sistema:{CultureInfo.CurrentCulture.Name}\n");
```

**Parse** e **TryParse** são métodos que temos para converter, ou tentar converter, uma string para outro tipo de forma explícita no C#.

# Parse

O Parse funciona como uma extensão aos métodos built-in (tipos primitivos), onde podemos invocar o método informando uma string (cadeia de caracteres), como por exemplo: `int.Parse("123")`. Ele converte essa string em um tipo especifico, mas **lança uma exceção** se a conversão falhar.

Link documentação: https://learn.microsoft.com/pt-br/dotnet/api/system.int32.parse?view=net-8.0

## Exemplos

```csharp
var valor = int.Parse("123");
var valor2 = bool.Parse("true");
var valor3 = DateTime.Parse("01/01/2022");

Console.WriteLine(valor);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
```

Como resultado da execução deste programa temos o seguinte texto sendo impresso na tela.

```
123
True
1/1/2022 12:00:00 AM
```

---

# TryParse

O método `TryParse` tem a mesma função do `Parse`, converter (tentar transformar) uma string em outro tipo de dado (`int`, `double`, `DateTime`, etc) de forma segura, sem gerar exceção se a conversão falhar.

```csharp
string numeroTexto = "123";
if (int.TryParse(numeroTexto, out int numero))
{
    Console.WriteLine($"Conversão bem-sucedida: {numero}");
}
else
{
    Console.WriteLine("Falha na conversão");
}

// Mais conciso com C# 7+
if (int.TryParse("456", out var outroNumero))
{
    // usar outroNumero aqui
}
```

---

# IFormatProvider

É uma interface em C# presente no `namespace System`, que desempenha um papel crucial na formatação e análise de dados de acordo com regras especificas de cultura e localização. Basicamente ela define um mecanismo para obter um objeto que sabe formatar valores (como números, datas, moedas) ou analisar strings para convertê-las em tipos de dados, levando em consideração sua cultura.

## Object GetFormat(Type formatType)

Esse método é usado internamente por métodos de formatação e análise (como `ToString( )`, `Parse( )`, `Format( )`) para solicitar um objeto que implementa uma interface de formatação especifica (como `NumberFormatInfo` para números, `DateTimeFormatInfo` para datas e horas).

## Exemplos de Uso na Prática

Temos um `DateTime` e estamos passando o valor **01/01/2022** para o mesmo. Este valor foi proposital para não causar nenhum erro. Agora vamos considerar uma nova data 28/10/2021, onde temos o formato `dd/MM/yyyy`, um formato utilizado aqui no Brasil, mas diferente dos EUA (formato padrão do .NET) que utiliza `MM/dd/yyyy`.

```
Unhandled exception. System.FormatException: String '28/10/2021' was not recognized as a valid DateTime.
   at System.DateTime.Parse(String s)
   at Program.<Main>$(String[] args) in C:\dev\CsharpTryParse\Program.cs:line 8
```

Neste caso, a conversão falharia, pois `28/10/2021` não é uma data válida nos EUA, o correto seria `10/28/2021`, mas felizmente conseguimos contornar isto utilizando uma cultura.

```csharp
var culture = new CultureInfo("pt-BR");
var valor3 = DateTime.Parse("28/10/2021", culture);
```

Note que agora temos um objeto do tipo `CultureInfo`, que define a cultura como `pt-BR` (Português do Brasil) e quando executamos o `Parse`, informamos também a cultura, resultando no sucesso da conversão.

Importante ressaltar que os valores de exemplo das variáveis são do tipo `string` e eu estou convertendo para `decimal` utilizando o `Parse` e `TryParse`. Logo após utilizo o `ToString ()` para formatar a impressão.

```csharp
//IFormatProvider (formatar e interpretar dependendo da cultura)
string valorBR = "1.234,60"; // Brasil usa vírgula para decimal
string valorUS = "1,234.60"; // EUA usa ponto para decimal

//Parse considerando a cultura brasileira
decimal valorDecimalBR = decimal.Parse(valorBR, new CultureInfo("pt-BR"));
 Console.WriteLine($"Valor convertido para decimal BR: {valorDecimalBR.ToString(new CultureInfo("pt-BR"))}");

 //Parse considerando a cultura americana
decimal valorDecimalUS = decimal.Parse(valorUS, new CultureInfo("en-US"));
Console.WriteLine($"Valor convertido para decimal US: {valorDecimalUS.ToString(new CultureInfo("en-US"))}");


// TryParse com cultura específica
if (decimal.TryParse(valorBR, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal resultadoConversao))
{
	Console.WriteLine($"Valor: {resultadoConversao}");
}
```

Pegando a `cultura atual` do sistema:

```csharp
//Pega a cultura do sistema
Console.WriteLine($"Cultura atual do sistema:{CultureInfo.CurrentCulture.Name}\n");
```
