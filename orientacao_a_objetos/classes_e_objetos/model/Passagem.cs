namespace classes_e_objetos.model
{
    public class Passagem
    {
        public string Passageiro { get; set; }
        public string Destino { get; set; }

        public Passagem(string passageiro, string destino)
        {
            Passageiro = passageiro;
            Destino = destino;
        }
    }
}