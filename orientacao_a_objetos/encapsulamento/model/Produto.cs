namespace encapsulamento.model
{
    public class Produto
    {
        private string linkImagem; //atributo
        private string nome; //atributo

        // O compilador cria automaticamente um campo privado quando usamos auto-properties
        public string Descricao { get; } //auto-properties 
        public decimal Preco { get; } //auto-properties 
        public int Estoque { get; } //auto-properties 
        public DateTime DataCriacao { get; private set; } //modificações apenas em métodos da classe

        public Produto(string nome, string descricao, decimal preco, int estoque, string linkImagem)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Estoque = estoque;
            this.DataCriacao = DateTime.Now;
            this.linkImagem = linkImagem;
        }

        // Getter para nome
        public string GetNome()
        {
            return nome;
        }

        // Setter para nome
        public void SetNome(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                this.nome = nome;
            }
        }

        public string GetLinkImagem()
        {
            return linkImagem;
        }

        // propriedades
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
            }
        }
    }
}