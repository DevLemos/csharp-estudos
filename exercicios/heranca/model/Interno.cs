namespace heranca.model
{
    public class Interno : Funcionario
    {
        public decimal Salario { get;}

        public Interno(string nome, string cargo, decimal salario)
            : base(nome, cargo)
        {
            Salario = salario;
        }
    }
}
