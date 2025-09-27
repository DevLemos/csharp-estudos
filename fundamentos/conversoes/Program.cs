using System;
using System.Globalization;

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

            //Parse e TryParse
            var valor1 = int.Parse("123");
            var valor2 = double.Parse("25.50");
            var valor3 = bool.Parse("true");
            var valor4 = DateTime.Parse("12/01/2022");

            Console.WriteLine($"\nResultado int: {valor1}");
            Console.WriteLine($"Resultado double: {valor2:F2}");
            Console.WriteLine($"Resultado bool: {valor3}");
            Console.WriteLine($"Resultado DateTime: {valor4}");

            //Gerando exceção
            //int valorErrado = int.Parse("abc"); // Lança FormatException

            //TryParse (evita exceção) mais seguro
            string numeroTexto = "123";
            if (int.TryParse(numeroTexto, out int valorFormatado))
            {
                Console.WriteLine($"Conversão bem-sucedida: {valorFormatado}");
            }
            else
            {
                Console.WriteLine("Falha na conversão");
            }

            //IFormatProvider (formatar e interpretar dependendo da cultura)
            string valorBR = "1.234,60"; // Brasil usa vírgula para decimal
            string valorUS = "1,234.60"; // EUA usa ponto para decimal

            //Parse considerando a cultura brasileira
            decimal valorDecimalBR = decimal.Parse(valorBR, new CultureInfo("pt-BR"));
            //Parse considerando a cultura americana
            decimal valorDecimalUS = decimal.Parse(valorUS, new CultureInfo("en-US"));

            //Pega a cultura do sistema
            Console.WriteLine($"\nCultura atual do sistema: {CultureInfo.CurrentCulture.Name}\n");

            Console.WriteLine($"Valor BR formatado em PT: {valorDecimalBR.ToString(new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Valor BR formatado em US: {valorDecimalBR.ToString(new CultureInfo("en-US"))}");

            Console.WriteLine($"Valor US formatado em PT: {valorDecimalUS.ToString(new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Valor US formatado em US: {valorDecimalUS.ToString(new CultureInfo("en-US"))}\n");

            //Gerando erro de próposito
            if (decimal.TryParse(valorBR, NumberStyles.Number, new CultureInfo("en-US"), out decimal resultadoConversao))
            {
                Console.WriteLine($"Valor convertido com sucesso: {resultadoConversao}");
            }
            else
            {
                Console.WriteLine($"Erro: Não conseguiu fazer a conversão de '{valorBR}' com cultura en-US");
            }

        }
    }
}
