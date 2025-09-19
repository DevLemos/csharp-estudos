namespace heranca.model
{
    class Consultoria : IServico
    {
        public string Tarefa { get; }
        public Funcionario Funcionario { get; }
        public Consultoria(string tarefa,Funcionario funcionario)
        {
            Tarefa = tarefa;
            Funcionario = funcionario;
        }

        public void ExecutarServico()
        {
            Console.WriteLine($"Executando serviço de consultoria: {Tarefa}");
            Console.WriteLine($"Responsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}");
        }
    }
}
