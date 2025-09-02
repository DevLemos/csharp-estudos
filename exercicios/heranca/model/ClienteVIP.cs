namespace heranca.model
{
    class ClienteVIP : Pessoa
    {
        public string NivelFidelidade { get; }
        public string CodigoVIP { get; }

        public ClienteVIP(string nome, int idade, string email, string nivelFidelidade, string codigoVIP)
            : base(nome, idade, email)
        {
            NivelFidelidade = nivelFidelidade;
            this.CodigoVIP = codigoVIP;
        }
    }
}
