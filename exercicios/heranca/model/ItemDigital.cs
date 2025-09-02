namespace heranca.model
{
    abstract class ItemDigital
    {
        public string Titulo { get; }

        public ItemDigital(string titulo)
        {
            Titulo = titulo;
        }
    }
}
