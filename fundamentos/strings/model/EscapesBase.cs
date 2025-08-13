namespace model.EscapesBase
{
    public abstract class EscapesBase
    {
        public abstract void Exemplo();
    }

    public class ExemploTabulacao : EscapesBase
    {
        public override void Exemplo()
        {
            Console.WriteLine("\n----- Exemplo escape de tabulação -----\n");

            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:");
            string endereco = Console.ReadLine()!;

            Console.WriteLine("Digite o valor do frete:");
            double frete = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a data de entrega:");
            string data = Console.ReadLine()!;

            Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
            Console.WriteLine($"Cliente:\t \"{nome}\"");
            Console.WriteLine($"Endereço:\t \"{endereco}\"");
            Console.WriteLine($"Valor do frete: R$ {frete.ToString("0.00")}");
            Console.WriteLine($"Data:\t\t {data}\n");
            Console.WriteLine("==========================================");
        }
    }
}