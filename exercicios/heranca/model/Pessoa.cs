namespace heranca.model
{
    abstract class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }
        public string Email { get; }
        public Pessoa(string nome, int idade, string email)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Email = email;
        }
    }
}
