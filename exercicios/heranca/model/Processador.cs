namespace heranca.model
{
    public class Processador
    {
        public string Marca { get; }
        public string Modelo { get; }
        public Processador(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }
}
