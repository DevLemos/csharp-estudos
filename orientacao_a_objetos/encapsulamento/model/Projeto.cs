namespace encapsulamento.model
{
    public class Projeto
    {
        public string Nome { get; set; }
        private List<string> tarefas;

        public Projeto(string nome)
        {
            Nome = nome;
            tarefas = new List<string>();
        }

        public void AdicionarTarefa(string tarefa)
        {
            tarefas.Add(tarefa);
        }
        public void ExibirTarefas()
        {
            Console.WriteLine($"Projeto: {Nome}");
            Console.WriteLine($"Tarefas: ");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"- {tarefa}");
            }

            Console.WriteLine($"Total: {QuantidadeTarefas} tarefas");
        }

        public int QuantidadeTarefas
        {
            get { return tarefas.Count; }
        }
    }
}