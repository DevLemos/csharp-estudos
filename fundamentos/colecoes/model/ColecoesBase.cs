namespace model.ColecoesBase
{
    public abstract class ColecoesBase
    {
        public abstract void Colecao();
    }

    public class ColecaoArray : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção básica: Array -------\n");
            Console.WriteLine("Primeiro exemplo para instanciar\n");
            string[] funcionarios1 = { "João", "Maria", "Cláudia", "Oscar" };
            Console.WriteLine($"Acessando valores: {funcionarios1[1]}");

            Console.WriteLine("\nSegundo exemplo para instanciar\n");
            string[] funcionarios2 = new string[4];
            Console.WriteLine($"Instanciando valores: {funcionarios2[0] = "João"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[1] = "Maria"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[2] = "Cláudia"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[3] = "Oscar"}");
        }
    }
}