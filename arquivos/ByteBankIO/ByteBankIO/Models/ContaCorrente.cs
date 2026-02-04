using System;


namespace ByteBankIO.Models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que zero.", nameof(valor));
            }

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que zero.", nameof(valor));
            }

            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para o saque.");

            }

            Saldo -= valor;
        }
    }
}
