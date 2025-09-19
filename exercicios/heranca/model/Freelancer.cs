namespace heranca.model
{
    public class Freelancer : Funcionario
    {
        public decimal ValorProjeto { get; }

        public Freelancer(string nome, string cargo, string departamento, decimal valorProjeto)
            : base (nome, cargo, departamento)
        {
            ValorProjeto = valorProjeto;
        }
    }
}
