namespace heranca.model
{
    class PagamentoBoleto : Pessoa, IPagamento
    {
        public PagamentoBoleto(string nome, int idade, string email) : base(nome, idade, email) { }        
        public void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento via boleto para {Nome} - {Email}");
        }
    }
}
