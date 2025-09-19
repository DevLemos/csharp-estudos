namespace heranca.model
{
    public class Funcionario
    {
        public string Nome { get; }
        public string Cargo { get; }

        public string Departamento { get; }

        public Funcionario(string nome, string cargo, string departamento) 
        {
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
        }
    }
}
