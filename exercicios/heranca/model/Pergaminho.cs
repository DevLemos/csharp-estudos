namespace heranca.model
{
    class Pergaminho : ItemDigital
    {
        public string Conteudo { get; }

        public Pergaminho(string titulo, string conteudo)
            : base(titulo)
        {
            this.Conteudo = conteudo;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine("Detalhes do Pergaminho:");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Descrição: {Conteudo}");
        }
    }
}
