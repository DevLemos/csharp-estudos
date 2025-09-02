namespace heranca.model
{
    public class Freelancer : Funcionario
    {
        public decimal ValorProjeto { get; }

        public Freelancer(string nome, string cargo, decimal valorProjeto)
            : base (nome, cargo)
        {
            ValorProjeto = valorProjeto;
        }
    }
}
