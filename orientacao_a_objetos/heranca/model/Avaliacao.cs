namespace heranca.model
{
    class Avaliacao
    {

        public int Nota { get; private set; }
        public string Comentario { get; private set; }

        public Avaliacao(int nota, string comentario)
        {
            Nota = nota;
            Comentario = comentario;
        }

    }
}
