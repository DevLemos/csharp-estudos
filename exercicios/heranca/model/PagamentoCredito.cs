namespace heranca.model
{
    class PagamentoCredito : Pessoa, IPagamento
    {
        public PagamentoCredito(string nome, int idade, string email): base(nome, idade, email) {}

        public void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento com cartão de crédito para {Nome} - {Email}");
        }
    }
}
