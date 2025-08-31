namespace heranca.model
{
    class ProdutoFisico : Produto
    {
        public int Estoque { get; }

        public ProdutoFisico(string nome, string descricao, decimal preco, string imagem)
           : base(nome, descricao, preco, imagem)
        {
            this.Estoque = 0;
        }

        public bool EstoqueDisponivel()
        {
            return Estoque > 0;
        }
      
    }
}
