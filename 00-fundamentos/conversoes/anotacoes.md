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
