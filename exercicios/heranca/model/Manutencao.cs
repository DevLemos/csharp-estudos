namespace heranca.model
{
    class Manutencao : IServico
    {
        public string Tarefa { get; }
        public Funcionario Funcionario { get; }

        public Manutencao(string tarefa,Funcionario funcionario)
        {
            Tarefa = tarefa;
            Funcionario = funcionario;
        }
        public void ExecutarServico()
        {
            Console.WriteLine($"Executando serviço de manutenção: {Tarefa}");
            Console.WriteLine($"Responsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}");
        }
    }
}
