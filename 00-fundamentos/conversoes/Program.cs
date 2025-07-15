using System;

namespace conversoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Funções para min e max
            Console.WriteLine("Funções que retornam o valor mínimo e máximo de cada tipo: \n");
            Console.WriteLine($"double (máximo): {double.MaxValue}");
            Console.WriteLine($"float (máximo): {float.MaxValue}");
            Console.WriteLine($"long (mínimo): {long.MinValue}");
            Console.WriteLine($"sbyte (mínimo): {sbyte.MinValue}");

            //conversão implícita
            Console.WriteLine("\nConversão implícita: ");
            Console.WriteLine("sem perda de dados.");
            float c = 4.5f;
            double d = c;
            Console.WriteLine($"Resultado: {d}");

            //conversão explicita (casting)
            Console.WriteLine("\nConversão explícita (casting): \n");
            double a = 5.1;
            float b = (float)a;
            int n = (int)a;

            Console.WriteLine($"sem perda de dados: {b}");
            Console.WriteLine($"com perda de dados: {n}");

            //Dica: conversão explicita (casting)
            Console.WriteLine("\nDica: ");
            Console.WriteLine("Sem perder os dados");
            Console.WriteLine("Conversão explícita (casting): \n");
            int k = 5;
            int j = 2;

            double resultado = (double)k / j;
            Console.WriteLine($"Resultado de divisão do tipo int: {resultado}");
        }
    }
}
