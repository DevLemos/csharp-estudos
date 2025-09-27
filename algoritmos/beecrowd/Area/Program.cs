using System;

namespace area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string entradaUsuario = Console.ReadLine();
            string[] valores = entradaUsuario.Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = (c * c) * 3.14159;
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIÂNGULO: {areaTriangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");
            
        }
    }
}
