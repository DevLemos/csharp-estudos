# Using (Importação)

Quando utilizamos por exemplo **using** **System** em nossos programas estamos basicamente definindo a importação das bibliotecas que nosso programa vai utilizar.

- Isso é feito no inicio do programa
- Utilizamos a palavra reservada **using** para isso

```
using System
```

# Namespace

Em C#, um namespace é como uma gaveta organizadora onde você guarda suas classes, interfaces, enums, etc. Ele serve para organizar o código e evitar conflitos de nomes entre elementos com o mesmo nome.

Assim como não podemos ter dois arquivos com mesmo nome nas pastas, não podemos ter duas classes com mesmo nome em um namespace.

```
namespace escopo_programa
```

# Classe

Em C#, classe é um modelo (ou molde) para criar objetos. Ela define as propriedades (atributos) e métodos (funções) que descrevem o comportamento e as características de algo que você quer representar no sistema.

Estrutura básica de uma classe:

```
public class Pessoa
{
    // Atributos ou propriedades
    public string Nome;
    public int Idade;

    // Método (comportamento)
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
```

Como usar a classe:

```
Pessoa p = new Pessoa();
p.Nome = "Kauan";
p.Idade = 25;
p.Apresentar(); // Saída: Olá, meu nome é Kauan e tenho 25 anos.
```

Comportamentos principais de uma classe:

- **Campos**: variáveis declaradas dentro da classe
- **Propriedades**: forma segura de acessar/modificar campos
- **Métodos**: funções que executam ações
- **Construtores**: métodos especiais chamados ao criar o objeto
- **Modificadores de acesso**: public, private, protected, etc. Definem a visibilidade

# Método Principal

Em C#, o método principal é o ponto de entrada da aplicação. É onde a execução do programa começa.

```
static void Main(string[] args)
{
	Console.WriteLine("Olá, mundo!");
}
```

Explicando cada parte:

- **static**: pertence à própria classe, e não a um objeto
- **void**: significa que não retorna nenhum valor
- **Main**: nome padrão exigido pelo C#
- **string[] args**: parâmetros que podem ser passados pela linha de comando (opcional)

Exemplo prático:

```
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Parâmetros recebidos:");

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}
```

Como executar com parâmetros:

```
MeuPrograma.exe Kauan 25 Estudante
```

Resultado na tela:

```
Parâmetros recebidos:
Kauan
25
Estudante
```

# Escopo Completo

```
using System;

namespace escopo_programa
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Este é o escopo de um programa C#");
    }
  }
}
```
