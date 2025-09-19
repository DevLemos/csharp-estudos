namespace heranca.model
{
    internal class Triangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return 0.5 * Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            // Considerando um triângulo genérico
            return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
        }
    }
}
