namespace polimorfismo.model
{
    class Gerente : Funcionario
    {

        public override string GerarRelatorio()
        {
            return "Relatório do gerente: supervisiona a equipe.";
        }
    }
}
