namespace polimorfismo.model
{
    class BancoDeDados
    {
        List<Produto> produtos = new List<Produto>()
        {
            new ProdutoDigital("Curso", "OO em C#",
            100.00m, "Imagem ilustrativa", "Link"),
            new ProdutoFisico("Teclado", "Modelo compacto e silencioso," +
            " perfeito para produtividade diária.",
            80.00m, "Imagem")
        };

        public Produto BuscarProdutoPeloNome(string nome)
        {
            foreach(var p in produtos)
            {
                if (p.Nome.Equals(nome))
                {
                    return p;
                }
            }

            return null;
        }
    }
}
