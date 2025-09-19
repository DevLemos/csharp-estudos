namespace polimorfismo.model
{
    class Desenvolvedor : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "Relatório do desenvolvedor: escreve código e corrige bugs.";
        }
    }
}
