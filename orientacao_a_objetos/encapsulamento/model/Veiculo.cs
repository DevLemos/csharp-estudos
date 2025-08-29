namespace encapsulamento.model
{
    public class Veiculo
    {
        public string Placa { get; set; }
        private double velocidadeAtual;

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public void AtualizarVelocidade(double novaVelocidade)
        {
            if (novaVelocidade > 0 && novaVelocidade > velocidadeAtual)
            {
                velocidadeAtual = novaVelocidade;
            }
        }

        public double VelocidadeAtual
        {
            get
            {
                return velocidadeAtual;
            }
        }
    }
}