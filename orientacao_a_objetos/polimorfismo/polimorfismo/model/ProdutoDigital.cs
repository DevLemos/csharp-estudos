namespace polimorfismo.model
{
    class ProdutoDigital : Produto
    {
        private string linkDonwload;
        public DateTime DataCompra { get; }

        public ProdutoDigital(string nome, string descricao, decimal preco, string imagem, string linkDonwload)
            : base(nome, descricao, preco, imagem)
        {
            this.LinkDonwload = linkDonwload;
            this.DataCompra = DateTime.Now;
        }

        public string LinkDonwload
        {
            get { return linkDonwload; }
            set
            {
                if (value.Length > 0)
                {
                    linkDonwload = value;
                }
            }
        }

        public override void Entregar(string endereco)
        {
            Console.WriteLine($"Enviando {Nome} para o email {endereco}");
        }

    }
}
