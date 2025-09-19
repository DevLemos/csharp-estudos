using exer_interfaces.interfaces;

namespace exer_interfaces.models
{
    public class Servico : IPagavel
    {
        public string Nome { get; set; }
        public decimal TaxaHoraria { get; set; }
        public int HorasTrabalhadas { get; set; }

        public decimal CalcularPagamento()
        {
            return TaxaHoraria * HorasTrabalhadas;
        }
    }
}
