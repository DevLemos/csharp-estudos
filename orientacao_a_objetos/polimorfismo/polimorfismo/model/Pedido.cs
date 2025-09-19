namespace polimorfismo.model
{
    class Pedido
    {
        private bool pago;
        public int Id { get; }
        public string Cliente { get; }
        public DateTime Data { get; }
        public decimal ValorTotal { get; }

        public List<Produto> Produtos { get; private set; }

        public Pedido(int id, string cliente, decimal valorTotal)
        {
            this.Id = id;
            this.Cliente = cliente;
            this.Data = DateTime.Now;
            this.ValorTotal = valorTotal;
            this.Produtos = new List<Produto>();
            this.pago = false;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Pedido #{Id} - Cliente: {Cliente}");
            Console.WriteLine($"Valor total: R$ {ValorTotal:F2}");
            Console.WriteLine($"Status: {(EstaExpirado() ? "Expirado" : "Válido")}");

            Console.WriteLine("Produtos do pedido:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.Nome);
            }
        }

        public bool EstaExpirado()
        {
            return !pago && DateTime.Now > Data.AddMinutes(15);
        }

        public void Pagar()
        {
            pago = true;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}
