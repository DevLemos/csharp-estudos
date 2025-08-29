namespace encapsulamento.model
{
    public class Quarto
    {
        public int Numero;
        private double valorDiaria;

        public Quarto(int numero)
        {
            this.Numero = numero;
        }
        public double ValorDiaria
        {
            get { return valorDiaria; }
            set
            {
                if (value > 0)
                    valorDiaria = value;
                else
                    Console.WriteLine("Erro: O valor da diária deve ser maior que zero.");
            }
        }
    }
}