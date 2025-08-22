namespace classes_e_objetos.model
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public double Depositar(double valor)
        {
            return Saldo += valor;
        }
    }
}