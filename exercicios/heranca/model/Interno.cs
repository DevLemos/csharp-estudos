namespace heranca.model
{
    public class Interno : Funcionario
    {
        public decimal Salario { get;}

        public Interno(string nome, string cargo, string departamento, decimal salario)
            : base(nome, cargo, departamento)
        {
            Salario = salario;
        }
    }
}
