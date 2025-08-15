# Coleções

Coleções são estruturas de dados em C# utilizadas para armazenar grupos de objetos relacionados de forma organizada. Essas coleções permitem funcionalidades para adicionar, remover, buscar e iterar sobre os elementos.

---

# Arrays

A coleção mais simples que podemos utilizar para armazenar vários dados é o array.

```csharp
string funcionario = "João";
string funcionario1 = "Maria";
string funcionario2 = "Cláudia";
string funcionario3 = "Oscar";
```

```csharp
string[] funcionarios = {"João","Maria","Cláudia","Oscar"};
```

Os dois códigos armazenam exatamente os mesmos dados. A diferença é que utilizando o array não precisamos criar várias variáveis diferentes, criamos uma só e armazenamos todos os dados dentro dela.

Podemos usar colchetes também depois do operador new para indicar o tamanho desse array, assim o compilador vai reservar as posições na memória de acordo com o tamanho. Também podemos inicializar um array assim:

```csharp
string[] funcionarios = new string[4];
funcionarios[0] = "João";
funcionarios[1] = "Maria";
funcionarios[2] = "Cláudia";
funcionarios[3] = "Oscar";
```

Além de acessar as posições com colchetes para inicializar um array, também podemos localizar um valor específico com os colchetes.

```csharp
string[] funcionarios = {"João","Maria","Cláudia","Oscar"};

Console.WriteLine($"Acessando valores: {funcionarios1[1]}"); //Maria
```

Podemos fazer uma busca por índices também percorrendo um array utilizando o `for`tradicional, mas caso queira utilizar o `foreach`também é possível.

```csharp
string[] funcionarios = {"João","Maria","Cláudia","Oscar"};

for (int i = 0; i < funcionarios.Length; i++)
{
    Console.WriteLine(funcionarios[i]);
}
```

```csharp
 string[] funcionarios = {"João","Maria","Cláudia","Oscar"};

 foreach (string nome in funcionarios)
 {
     Console.WriteLine(nome);
 }
```

também é possível localizar o índice de determinado elemento usando o método `IndexOf`:

- Utilizamos a classe específica `Array` onde contém diversos métodos para trabalhar com muitos dados.
- Um desses métodos é o `IndexOf`
- Outros métodos úteis dessa classe são `Sort()` para ordenar os elementos que estão no array e `Reverse()` para inverter os elementos.

```csharp
string[] funcionarios = {"João","Maria","Cláudia","Oscar"};

int indice = Array.IndexOf(funcionarios, "Maria");
Console.WriteLine("Indice: {0}", indice); //1
```

## Limitações de Arrays

Arrays são uma estrutura bem limitada. Uma vez que declaramos o tamanho de um array, ele terá esse tamanho para sempre. Por isso adicionar e remover elementos se torna uma operação muito trabalhosa. Abaixo temos um exemplo de inserção, repare que temos que criar um novo array para conseguir guardar um novo elemento.

```csharp
string[] funcionarios = {"João","Maria","Cláudia","Oscar"};
string[] novoArray = new string[5];

Array.Copy(funcionarios1, novoArray, funcionarios1.Length);
foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
novoArray[4] = "Joana";
```

## Somando os valores do array

Seu desafio é **criar um programa que automatize esse cálculo**, percorrendo uma lista de valores e exibindo o montante final, garantindo que nenhum valor seja deixado de fora.

Crie um programa que:

- Declare um array de números representando doações.
- Utilize um loop para somar todos os valores contidos no array.
- Exiba o total calculado na tela.

```csharp
double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };

double total = 0;

foreach (double valor in doacoes)
{
    total += valor;
}

Console.WriteLine("Total de doações: " + total);
```

## Ordenando listas

Você está desenvolvendo um sistema de gerenciamento para uma conferência de inovação tecnológica. Durante o credenciamento, os participantes precisam ser chamados em ordem alfabética para evitar congestionamentos. Porém, a lista inicial de inscritos foi cadastrada sem organização, e o comitê exige que o **terceiro nome da lista ordenada seja destacado para uma cerimônia especial.**

Crie um programa que:

- Declare um array com nomes de participantes.
- Ordene esse array alfabeticamente.
- Identifique e exiba o terceiro nome da lista após a ordenação.

```csharp
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

Array.Sort(nomes);

Console.WriteLine($"O terceiro nome da lista após ordenação é: {nomes[2]}");
```

## Desvendando o código

Você está explorando um cofre cibernético. Ao chegar ao último corredor, você se depara com um cadeado inteligente que protege um artefato tecnológico perdido. O mecanismo de segurança exige que você decifre um código baseado em posições dentro da sequência numérica `5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9`.

O sistema gera uma combinação única a cada acesso, onde:

- O primeiro dígito é a posição onde o número 19 está localizado.
- O segundo dígito é a posição onde o número 42 está localizado.
- O terceiro dígito é a posição onde o número 7 está localizado.

Crie um programa que:

- Declare um array de números inteiros.
- Localize no array o índice de cada um dos números da combinação.
- Exiba a combinação no console.

```csharp
int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

int primeiroDigito = Array.IndexOf(numeros, 19);
int segundoDigito = Array.IndexOf(numeros, 42);
int terceiroDigito = Array.IndexOf(numeros, 7);

Console.WriteLine($"\nCombinação do cadeado: {primeiroDigito}-{segundoDigito}-{terceiroDigito}");
```

---

# Coleções Genéricas

Dada as limitações dos arrays, o C# tem um namespace chamado`System.Collections.Generic`, onde podemos trabalhar com coleções genéricas.

- A grande vantagem das coleções genéricas é a flexibilidade no tamanho. Assim, conseguimos adicionar e remover elementos de forma fácil e rápida. Além disso, eles também tem métodos mais sofisticados para lhe dar com os dados.
- Vamos ver a seguir as coleções genéricas mais utilizadas, cada uma com suas particularidades.

# List<T>

As listas são representadas pela classe `List`e tem um comportamento muito parecido com os arrays.

- **Diferença**: Dada a implementação os arrays são estruturas mais fáceis para busca dos dados por meio dos índices, enquanto as listas são melhores para trabalharmos com tamanhos dinâmicos de dados (podendo inserir e remover elementos com facilidade).
- Por ser uma coleção genérica, ao declarar uma List, devemos dizer qual o tipo de dado que ela irá armazenar. Esse tipo ele é passado entre os sinais `<>`.
- Existem duas formas de criar uma lista:

```csharp
//Primeiro exemplo

List<string> listaFuncionarios = new List<string>
{
    "joão","Maria","Cláudia","Oscar"
};
```

```csharp
//Segundo exemplo
List<string> listaFuncionarios= new List<string>();
listaFuncionarios.Add("Roberto");
listaFuncionarios.Add("Erick");
listaFuncionarios.Add("Carlos");
listaFuncionarios.Add("Brenda");
```

Para percorrer podemos utilizar tanto o for tradicional quanto o foreach igual nos arrays. Repare que também conseguimos utilizar os colchetes para indexar uma lista. Embora de forma visual seja igual aos arrays, por baixo dos panos é diferente e menos eficiente em listas.

```csharp
List<string> listaFuncionarios = new List<string>
{
    "joão","Maria","Cláudia","Oscar"
};

//percorrendo com for
for (int i = 0; i < listaFuncionarios.Count; i++)
{
    Console.WriteLine("Funcionário: " + listaFuncionarios[i]);
}

//percorrendo com foreach
foreach (string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
```

## Métodos mais utilizados

- `Add()`: Usado para adicionar elementos na lista
- `Remove()`: Usado para remover elementos da lista
- `Sort()`: Usado para ordenar os elementos
- `Reverse()`: Usado para inverter os elementos
- `IndexOf()`: Usado para trazer o índice do elemento na lista

Veja que os métodos `IndexOf()`, `Sort()` e `Reverse()` são nativos em listas `List<T>`, permitindo chamá-los diretamente com `nomeDaLista.Metodo()`. Já nos arrays, esses métodos não fazem parte da estrutura, sendo acessados pela classe auxiliar `Array`. Esse é um dos benefícios das coleções genéricas, seus métodos não dependem de classes utilitárias.

```csharp
Console.WriteLine("\n------ List: Métodos nativos ------\n");
Console.WriteLine("utilizando métodos Add(), Remove(), Sort(), IndexOf() e Reverse()\n");

List<string> listaConvidados = new List<string>();

Console.WriteLine("Adicionando convidados...");
listaConvidados.Add("Roberto");
listaConvidados.Add("Erick");
listaConvidados.Add("Carlos");
listaConvidados.Add("Brenda");
listaConvidados.Add("Juan");
listaConvidados.Add("Alex");
foreach (string nome in listaConvidados)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\nRemovendo convidados...");
listaConvidados.Remove("Roberto");
listaConvidados.Remove("Erick");
foreach (string nome in listaConvidados)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\nOrdenando convidados...");
listaConvidados.Sort();
foreach (string nome in listaConvidados)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\nInvertendo convidados...");
listaConvidados.Reverse();
foreach (string nome in listaConvidados)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\nBuscando indice do convidado...");
int indice = listaConvidados.IndexOf("Brenda");
Console.WriteLine("Indice da convidada Brenda: " + indice);
```

---

# HashSet<T>

HashSet é um tipo de coleção genérica bastante utilizada, geralmente chamada de **conjuntos** e que são representados pela classe `HashSet`.

- Os conjuntos são estruturas que **não permitem dados duplicados**. Além disso, como nas listas a adição e remoção dos elementos é bastante prática.
- Outra característica dos conjuntos é que neles não conseguimos manter a mesma ordem de inserção dos elementos.
- Por ser uma coleção genérica, ao declarar um `HashSet`, devemos específicar o tipo de dado que irá armazenar. Esse tipo deve ser passado entre os sinais `<>`
- Existem duas formas de criar os conjuntos. Assim como nas listas, em nenhuma inicialização o tamanho é fixo.

```csharp
HashSet<string> setFuncionarios = new HashSet<string>
{
    "João","Pedro", "Caio", "Bianca", "Joana"
};
```

```csharp
HashSet<string> setFuncionarios = new HashSet<string>();
setFuncionarios.Add("Carlos");
setFuncionarios.Add("Bruna");
setFuncionarios.Add("Wendel");
setFuncionarios.Add("Kauan");
setFuncionarios.Add("Lucas");
```

- Nos conjuntos também temos os métodos `Add()` e `Remove()` de forma nativa. Inclusive costumam ser mais rápidos em conjuntos do que em listas.
- Como a ordem de inserção não é mantida nos HashSet, eles não guardam índices para os elementos. Assim não faz sentido que tenham os métodos `Sort()`, `Reverse()`, `IndexOf()`, que dependem de índice para funcionar.
- O método mais utilizado em conjuntos é o `Contains()`, que serve para verificar se um elemento existe ou não no conjunto. Essa também é uma operação mais rápida nos conjuntos em comparação com listas.

```csharp
if (setFuncionarios2.Contains("Carlos"))
    Console.WriteLine("O funcionário Carlos contém no meu conjunto.");
else
    Console.WriteLine("O funcionário Carlos não existe no meu conjunto.");
```

- Os `HashSet` se baseiam em conjuntos matemáticos. Neste tipo de conjunto, **não há repetição de elementos**, e não há uma ordem específica para eles. A operação mais importante em um conjunto é saber se o elemento pertence a ele ou não.

## Propriedade

- `Count` ⇒ Obtém o número de elementos contidos em um conjunto.

## Métodos mais utilizados

- `Add()`⇒ Adiciona o elemento especificado a um conjunto.
- `Remove()` ⇒ Remove o elemento especificado de um objeto `HashSet<T>`.
- `Clear()` ⇒ Remove todos os elementos de um objeto `HashSet<T>`.
- `Contains()` ⇒ Determina se um objeto `HashSet<T>` contém o elemento especificado.
- `Equals()` ⇒ Determina se o objeto especificado é igual ao objeto atual.

---

# Dictionary<TKey, TValue>

Utilizamos essa estrutura quando trabalhamos com pares chave e valor, focado principalmente em buscas. A seguir um exemplo simples:

- Dentro dos dicionários nos `gerenics <>`, passamos dois tipos: primeiro o tipo da chave, e depois o tipo do valor dos elementos. Neste exemplo abaixo a chave é do tipo int e os valores string.
- Os dicionários podem ser inicializados de duas formas:

```csharp
 Dictionary<int, string> produtos = new Dictionary<int, string>
 {
		 { 4587963, "Teclado" },
		 { 3374561, "Cadeira gamer" },
		 { 2456987, "Notebook" },
		 { 6356984, "Teclado" },
		 { 8647921, "Mouse" }
 };
```

```csharp
Dictionary<int, string> produtos = new Dictionary<int,string>();
produtos.Add(4587963, "Teclado");
produtos.Add(3374561, "Cadeira gamer");
produtos.Add(2456987, "Notebook");
produtos.Add(6356984, "Teclado");
produtos.Add(8647921, "Mouse");
```

## Exemplo básico

<aside>
💡

Imagine que estamos trabalhando em uma loja de eletrônicos, e os produtos tem ids únicos, conforme os valores da tabela. Se os ids começassem em 0 e fossem aumentando sequencialmente, poderíamos representar os produtos com listas. Buscar o produto 4 seria como acessar a posição 4. Porém, nesse caso os ids aparecem aleatoriamente, sendo mais fácil armazená-los também.

</aside>

| **ID**  | **Nome**      |
| ------- | ------------- |
| 4587963 | Teclado       |
| 3374561 | Cadeira gamer |
| 2456987 | Notebook      |
| 6356984 | Teclado       |
| 8647921 | Mouse         |

Para representar os produtos da tabela como um dicionário , iremos guardar duas informações de uma vez:

- Chave (deve ser única) ⇒ Id do produto
- Valor ⇒ nome do produto

```csharp
 Dictionary<int, string> produtos = new Dictionary<int, string>
 {
		 { 4587963, "Teclado" },
		 { 3374561, "Cadeira gamer" },
		 { 2456987, "Notebook" },
		 { 6356984, "Teclado" },
		 { 8647921, "Mouse" }
 };
```

A **operação mais comum** em dicionários é a **busca pela chave**. Essa busca pode ser feita com os colchetes: `nomeDicionario[chaveBuscada]`.

```csharp
Dictionary<string, string> palavras = new Dictionary<string, string>
{
     {"olá", "hello"},
     {"mundo","world"}
};

Console.WriteLine($"A tradução de olá é {palavras["olá"]}");
```

Também podemos **percorrer** um dicionário. Essa operação pode ser feita de duas maneiras:

```csharp
foreach (var produto in produtos)
{
    Console.WriteLine($"Produto: {produto.Value}, ID: {produto.Key}");
}
```

```csharp
foreach (KeyValuePair<string, string> palavra in palavras)
{
    Console.WriteLine($"Português: {palavra.Key}, Inglês: {palavra.Value}");
}
```

- No foreach, a variável produto serve para representar um único elemento por vez. Como
  cada elemento é um par de chave e valor, esses elementos são então representados pelo
  tipo `KeyValuePair`, em que indicamos também o tipo da chave e do valor no `generics
(<>)`. Caso queiramos simplificar, basta usar o `var` para que haja a inferência de tipos.

## Exemplo: Escola de programação

Uma pessoa está desenvolvendo um programa em C# que gerencia as notas dos alunos em uma escola de programação. Cada aluno está associado a uma lista de linguagens de programação que ele estudou, e outra lista de notas correspondentes a essas linguagens, como no código abaixo:

```csharp
var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};
```

Código para descobrir a média das notas de Maria em Python:

```csharp
List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();
Console.WriteLine(mediaMariaEmPython);
```
