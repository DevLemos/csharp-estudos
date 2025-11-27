using System;
using System.Linq;
using System.Collections.Generic;


#region Sintaxe de Consulta
Console.WriteLine("======= SINTAXE DE CONSULTA =======\n");
List<int> listaNumeros1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var pares1 = from numero in listaNumeros1
             where numero % 2 == 0
             select numero;

Console.WriteLine("======= NÚMEROS PARES =======");
foreach (int numero in pares1)
{
    Console.WriteLine($"Número: {numero}");
}
#endregion 

#region Sintaxe de Método
Console.WriteLine("\n======= SINTAXE DE MÈTODO =======\n");
List<int> listaNumeros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var pares2 = listaNumeros2.Where(n => n % 2 == 0);

Console.WriteLine("======= NÚMEROS PARES =======");
foreach (int numero in pares2)
{
    Console.WriteLine($"Número: {numero}");
}
#endregion

#region Operadores LINQ

Console.WriteLine("\n======= OPERADORES LINQ =======\n");

#region Where
List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos", "Amanda" };

Console.WriteLine("======= NOMES QUE COMEÇAM COM A LETRA 'A' =======\n");
var comA = nomes.Where(n => n.StartsWith("A"));

foreach (var nome in comA)
{
    Console.WriteLine($"Nomes: {nome}");
}
#endregion

#region Select
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("\n======= VALORES MÚLTIPLICADOS POR 2 =======\n");
var valorDobrado = numeros.Select(n => n * 2);

foreach (var valor in valorDobrado)
{
    Console.WriteLine($"Resultado: {valor}");
}
#endregion

#region OrderBy/OrderByDescending
List<string> frutas = new List<string> { "Banana", "Abacaxi", "Uva", "Maçã" };

Console.WriteLine("\n======= ORDENANDO ELEMENTOS =======\n");

Console.WriteLine("ORDEM ALFABÉTICA ->");
var ordenadas = frutas.OrderBy(f => f);

foreach (var fruta in ordenadas)
{
    Console.WriteLine($"Fruta: {fruta}");
}

Console.WriteLine("\nORDEM DECRESCENTE ->");
var decrescente = frutas.OrderByDescending(f => f);

foreach (var fruta in decrescente)
{
    Console.WriteLine($"Fruta: {fruta}");
}
#endregion

#region First/FirstOrDefault 
List<int> numeros2 = new List<int> { 10, 20, 30, 40 };

Console.WriteLine("\n======= PRIMEIRO ELEMENTO =======\n");
int primeiro = numeros2.First();
Console.WriteLine($"Primeiro número: {primeiro}\n");

int primeiroMaiorQue15 = numeros2.First(n => n > 15);
Console.WriteLine($"Primeiro número maior que 15: {primeiroMaiorQue15}\n");

int resultado = numeros2.FirstOrDefault(n => n > 100); // 0 (valor padrão)
Console.WriteLine($"Primeiro número maior que 100 ou Default: {resultado}\n");
#endregion

#region Any/All
List<int> numerosPares = new List<int> { 2, 4, 6, 8, 10 };

Console.WriteLine("\n======= VERIFICAÇÂO BOOLEANAS =======\n");

bool temPares = numerosPares.Any(n => n % 2 == 0);
Console.WriteLine($"Existem números pares ? {temPares}\n");

bool todosPares = numerosPares.All(n => n % 2 == 0);
Console.WriteLine($"Todos os números são pares ? {todosPares}\n");

bool existemNegativos = numerosPares.Any(n => n < 0);
Console.WriteLine($"Existem números negativos ? {existemNegativos}\n");
#endregion

#region Count/Sum/Average/Min/Max
List<int> numeros3 = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("\n======= AGREGAÇÔES =======\n");

int quantidade = numeros3.Count();
Console.WriteLine($"Quantidade de números na lista: {quantidade}\n");

int soma = numeros3.Sum();
Console.WriteLine($"Soma dos números da lista: {soma}\n");

double media = numeros3.Average();
Console.WriteLine($"Média dos números da lista: {media}\n");

int minimo = numeros3.Min();
Console.WriteLine($"Menor número da lista: {minimo}\n");

int maximo = numeros3.Max();
Console.WriteLine($"Maior número da lista: {maximo}\n");

int paresCount = numeros3.Count(n => n % 2 == 0); // 2
Console.WriteLine($"Quantidade de números pares na lista (com condição): {paresCount}\n");
#endregion

#region Take/Skip
List<int> numeros4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("\n======= PAGINAÇÃO =======\n");

var primeiros3 = numeros4.Take(3); 

Console.WriteLine($"Primeiros 3 elementos ->\n");
foreach (var num in primeiros3)
{
    Console.WriteLine($"Elemento: {num}");
}

var pula3 = numeros4.Skip(3); 
Console.WriteLine($"\nPulando os 3 primeiros elementos ->\n");
foreach (var num in pula3)
{
    Console.WriteLine($"Elemento: {num}");
}

Console.WriteLine($"\nPáginando elementos ->\n");
int itensPorPagina = 3;
int pagina = 2;
var paginaAtual = numeros4.Skip((pagina - 1) * itensPorPagina)
                          .Take(itensPorPagina);

foreach(var num in paginaAtual)
{
    Console.WriteLine($"Elemento: {num}");
}
#endregion

#region Distinct 
List<int> numerosDuplicados = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

Console.WriteLine("\n======= REMOVER DUPLICATAS =======\n");

var semDuplicatas = numerosDuplicados.Distinct();

Console.WriteLine($"Valores sem duplicatas ->\n");
foreach (var num in semDuplicatas)
{
    Console.WriteLine($"Elemento: {num}");
}
#endregion

#region GroupBy 
List<string> palavras = new List<string> { "casa", "carro", "bola", "balde", "avião" };

Console.WriteLine("\n======= AGRUPAR ELEMENTOS =======\n");

Console.WriteLine($"Agrupar por primeira letra ->\n");
var grupoLetras = palavras.GroupBy(p => p[0]);

Console.WriteLine($"Grupo de letras ->\n");
foreach (var grupo in grupoLetras)
{
    Console.WriteLine($"Letra: {grupo.Key}");

    foreach(var palavra in grupo)
    {
        Console.WriteLine($"  {palavra}");
    }
}
#endregion

#endregion