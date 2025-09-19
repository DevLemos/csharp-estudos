using exer_interfaces.interfaces;

namespace exer_interfaces.models
{
    class Produto : IPagavel
    {
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public decimal CalcularPagamento()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
