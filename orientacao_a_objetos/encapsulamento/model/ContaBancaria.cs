namespace encapsulamento.model
{
    public class ContaBancaria
    {
        private decimal _saldo; // Campo privado - só pode ser acessado dentro desta classe

        // Construtor público
        public ContaBancaria(decimal saldoInicial)
        {
            _saldo = saldoInicial;  //Pode acessar porque estamos dentro da classe
        }

        private bool VerificaSaque(decimal valor)
        {
            return valor > 0 && valor <= _saldo;
        }

        // Método público que usa o método privado
        public bool Sacar(decimal valor)
        {
            if (VerificaSaque(valor)) // Pode chamar método privado
            {
                _saldo -= valor; // Pode acessar campo privado
                return true;
            }
            return false;
        }

        // Propriedade pública para expor o saldo (somente leitura)
        public decimal Saldo
        {
            get { return _saldo; }
        }
    }
}