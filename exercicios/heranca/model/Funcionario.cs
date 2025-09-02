namespace heranca.model
{
    public class Funcionario
    {
        public string Nome { get; }
        public string Cargo { get; }

        public Funcionario(string nome, string cargo) 
        {
            Nome = nome;
            Cargo = cargo;
        }
    }
}
