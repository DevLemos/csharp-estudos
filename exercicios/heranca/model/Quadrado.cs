namespace heranca.model
{
    class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
