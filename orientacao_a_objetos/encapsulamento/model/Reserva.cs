namespace encapsulamento.model
{
    public class Reserva
    {
        private int diarias;
        public Hospede hospede { get; }
        public Quarto quarto { get; }
        public Reserva(Hospede hospede, Quarto quarto, int diarias)
        {
            if (diarias <= 0)
            {
                throw new ArgumentException("O número de diárias deve ser maior que zero.");
            }

            this.hospede = hospede;
            this.quarto = quarto;
            this.diarias = diarias;
        }

        public double ValorTotal
        {
            get { return quarto.ValorDiaria * diarias; }
        }
    }
}