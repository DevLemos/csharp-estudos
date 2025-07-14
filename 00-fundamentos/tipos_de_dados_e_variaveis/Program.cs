using System;

namespace tipos_de_dados_e_variaveis
{

  //Tipos por valor
  enum DiaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado }
  struct Ponto
  {
    public int X;
    public int Y;
  }

  //Tipo por referência 
  class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      TiposPorValor();
      TiposPorReferencia();
    }

    static void TiposPorValor()
    {
      Console.WriteLine("Tipos por valor: \n");
      int? idade = null;
      int n2 = 1000;
      int n3 = 2147483647;
      double n6 = 4.5;
      float n5 = 4.5f;
      bool completo = false;
      char genero = 'F';
      char letra = '\u0041';
      byte n1 = 126;
      sbyte valor1 = -128;
      short pontos = 32000;
      ushort valor2 = 65000;
      uint saldoInt = 4000000000;
      long n4 = 2147483648L;
      ulong estrelas = 18000000000;
      decimal saldo = 2.000m;
      DateTime hoje = DateTime.Now;
      DiaSemana diaSemanaHoje = DiaSemana.Segunda; //enum
      Ponto p; //struct
      p.X = 10;
      p.Y = 20;

      Console.WriteLine(idade);
      Console.WriteLine(n2);
      Console.WriteLine(n3);
      Console.WriteLine(n5);
      Console.WriteLine(n6);
      Console.WriteLine(completo);
      Console.WriteLine(genero);
      Console.WriteLine(letra);
      Console.WriteLine(n1);
      Console.WriteLine(valor1);
      Console.WriteLine(pontos);
      Console.WriteLine(valor2);
      Console.WriteLine(saldoInt);
      Console.WriteLine(n4);
      Console.WriteLine(estrelas);
      Console.WriteLine(saldo);
      Console.WriteLine(hoje);
      Console.WriteLine(diaSemanaHoje);
      Console.WriteLine($"Ponto: ({p.X}, {p.Y})");
    }

    static void TiposPorReferencia()
    {
      Console.WriteLine("\nTipos por referência: \n");
      //string
      string primeiroNome = "Kauan";
      string sobrenome = primeiroNome;
      sobrenome = "Lemos";
      Console.WriteLine($"Nome: {primeiroNome} | Sobrenome: {sobrenome}"); // mostra que string é imutável

      // object (tipo base de todos os tipos)
      object obj1 = "Texto";
      object obj2 = 123;
      Console.WriteLine(obj1);
      Console.WriteLine(obj2);

      //array
      int[] numeros = { 1, 2, 3 };
      int[] copia = numeros;
      copia[0] = 99;
      Console.WriteLine($"numeros[0]: {numeros[0]} | copia[0] {copia[0]}"); // ambos mudam

      Pessoa p1 = new Pessoa { Nome = "Caio", Idade = 20 };
      Pessoa p2 = p1;
      p2.Nome = "Bento";
      Console.WriteLine($"Pessoa 1: {p1.Nome} | Pessoa 2: {p2.Nome}"); // ambos = Bento 

      // dynamic (tipo flexível em tempo de execução)
      dynamic variavel = 10;
      Console.WriteLine($"dynamic como int: {variavel}");
      variavel = "Agora sou string";
      Console.WriteLine($"dynamic como string: {variavel}");
    }
  }
}

