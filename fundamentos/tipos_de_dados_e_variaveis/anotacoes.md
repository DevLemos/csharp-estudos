# Tipos de dados e Variáveis

C# é uma linguagem **fortemente tipada**, ou seja, você precisa definir o tipo de cada variável.

# Tipos de Valor (Value Types)

São armazenados diretamente na memória stack.

| Tipo         | Exemplo                       | Tamanho        | Uso                                             |
| ------------ | ----------------------------- | -------------- | ----------------------------------------------- |
| **int**      | int idade = 25;               | 4 bytes        | Números inteiros                                |
| **double**   | double pi = 3.14;             | 8 bytes        | Números com casas decimais                      |
| **float**    | float preco = 9.99f;          | 4 bytes        | Menos preciso que double                        |
| **bool**     | bool ativo = true;            | 1 byte         | Verdadeiro ou falso                             |
| **char**     | char letra = 'A';             | 2 bytes        | Um único caractere                              |
| **byte**     | byte idade = 255;             | 1 byte         | Inteiro sem sinal (0 a 255)                     |
| **sbyte**    | sbyte valor = -100;           | 1 byte         | Inteiro com sinal (-128 a 127)                  |
| **short**    | short pontos = 32000          | 2 bytes        | Inteiro com sinal (-32.768 a 32.767)            |
| **ushort**   | ushort valor = 65000          | 2 bytes        | Inteiro sem sinal (0 a 65.535)                  |
| **uint**     | uint saldo = 4000000000;      | 4 bytes        | Inteiro sem sinal (0 a 4 bilhões)               |
| **long**     | long populacao = 8000000000;  | 8 bytes        | Inteiro com sinal (±9 quintilhões)              |
| **ulong**    | ulong estrelas = 18000000000; | 8 bytes        | Inteiro sem sinal (0 a 18 quintilhões)          |
| **decimal**  | decimal preco = 199.99m;      | 16 bytes       | Alta precisão para dinheiro                     |
| **enum**     | enum Dia {Seg, Ter};          | 4 bytes        | Lista de constantes nomeadas (baseado em `int`) |
| **struct**   | struct Ponto { int x, y; }    | depende        | Agrupamento de tipos de valor                   |
| **DateTime** | DateTime hoje = DateTime.Now; | 8 bytes        | Representa uma data e hora                      |
| **int?**     | int? idade = null;            | + 1 byte extra | Tipo de valor que permite null                  |

# Tipos de Referência (Reference Types)

Armazenam referência para dados na heap.

| Tipo          | Exemplo                            | Uso                                                        |
| ------------- | ---------------------------------- | ---------------------------------------------------------- |
| **string**    | string nome = "Kauan";             | Texto (cadeia de caracteres)                               |
| **object**    | object qualquer = 42;              | Tipo base para todos os outros                             |
| **Arrays**    | int[ ] numeros = {1,2,3};          | Coleções de elementos do mesmo tipo                        |
| **dinamyc**   | dinamyc valor = "texto";           | Tipo determinado em tempo de execução (runtime)            |
| **class**     | class Pessoa { string Nome; };     | Tipo definido pelo usuário, instanciado com `new`          |
| **interface** | interface IAnimal { void Som(); }; | Contrato que outras classes podem implementar              |
| **delegate**  | delegate void Alerta();            | Referência para métodos com determinada assinatura         |
| **Tuple**     | var tupla = (1, "ok");             | Agrupamento de valores com diferentes tipos                |
| **record**    | record Pessoa(string Nome);        | Tipo imutável de referência, ideal para dados (desde C# 9) |

# Variáveis

Sintaxe

```
tipo nome = valor
```

Exemplos

```
int idade = 25;
double altura = 1.75;
bool estudando = true;
string nome = "Kauan";
```
