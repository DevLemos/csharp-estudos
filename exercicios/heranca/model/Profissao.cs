namespace heranca.model
{
    abstract class Profissao
    {
        public string Titulo { get; }

        public Profissao(string titulo) 
        { 
            Titulo = titulo;
        }
    }
}
