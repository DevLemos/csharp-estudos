namespace polimorfismo.model
{
    abstract class Produto
    {
        private string imagem;
        public string Nome { get; }
        public string Descricao { get; }
        public decimal Preco { get; private set; }
       
        public Produto(string nome, string descricao, decimal preco, string imagem)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Imagem = imagem;
        }

        public void AlterarPrecoComDesconto(decimal desconto)
        {
            Preco = Preco * (1 - desconto / 100);
        }
        public void AlterarPrecoComDesconto(int desconto)
        {
            Preco = Preco - desconto;
        }

        public string Imagem
        {
            get { return imagem; }
            set
            {
                if (value.Length > 0)
                {
                    imagem = value;
                }
            }
        }

        //public abstract void Entregar(string endereco);
        
        public virtual void Entregar(string endereco)
        {
            Console.WriteLine("Entrega genérica");
        }
    }
}
