namespace heranca.model
{
    public class PlacaMae
    {
        public string Fabricante { get; }
        public string Socket { get; }

        public PlacaMae(string fabricante, string socket)
        {
            this.Fabricante = fabricante;
            this.Socket = socket;
        }
    }
}
