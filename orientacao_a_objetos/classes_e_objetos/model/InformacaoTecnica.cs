namespace classes_e_objetos.model
{
    public class InformacaoTecnica
    {
        public double TamanhoMB { get; set; }
        public string SistemaOperacional { get; set; }

        public InformacaoTecnica(double tamanhomb, string sistemaOperacional)
        {
            TamanhoMB = tamanhomb;
            SistemaOperacional = sistemaOperacional;
        }
    }
}