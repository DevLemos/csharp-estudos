namespace classes_e_objetos.model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public bool Promover(string novoCargo)
        {
            if (Cargo != novoCargo)
            {
                Cargo = novoCargo;
                return true;
            }
            else
            {
                Console.WriteLine("ERRO: O novo cargo deve ser diferente do cargo atual.");
                return false;
            }
        }
    }
}