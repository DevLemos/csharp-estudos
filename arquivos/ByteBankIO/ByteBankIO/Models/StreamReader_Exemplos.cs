using ByteBankIO.Models;
partial class Program
{
    static void ExemploMetodosPrincipais()
    {
        var enderecoArq = "contas.txt";

        using (FileStream fluxoArq = new FileStream(enderecoArq, FileMode.Open))
        using (var leitor = new StreamReader(fluxoArq))
        {

            Console.WriteLine("Lendo o arquivo e retornando a primeira linha... \n");
            Console.WriteLine(leitor.ReadLine());

            Console.WriteLine("\nLendo o arquivo até o final (dependendo do arquivo, pode ser prejudicial pois lê tudo de uma única vez)...\n");
            Console.WriteLine(leitor.ReadToEnd());

            Console.WriteLine("\nLendo o arquivo e retornando o primeiro byte...\n");
            Console.WriteLine(leitor.Read());

            Console.WriteLine("\nLendo o arquivo parte por parte (linha a linha)...");
            Console.WriteLine("Solução para quando não quiser ler o arquivo de uma única vez:\n");

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

        }
    }
    static void LendoArquivoConvertendoParaContaCorrente()
    {
        var enderecoArq = "contas.txt";

        using (FileStream fluxoArq = new FileStream(enderecoArq, FileMode.Open))
        using (var leitor = new StreamReader(fluxoArq))
        {

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                ContaCorrente conta = ConverterStringParaContaCorrente(linha!);
                string mensagem = $"Contas Corrente\n" +
                                  $"Titular: {conta.Titular.Nome}\n" +
                                  $"Agência: {conta.Agencia}\n" +
                                  $"Conta: {conta.Numero}\n" +
                                  $"Salário: R$ {conta.Saldo:F2}\n";
                Console.WriteLine(mensagem);
            }
        }
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');
        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2]);
        var titular = campos[3];

        Cliente cliente = new Cliente { Nome = titular };

        var resultado = new ContaCorrente(numero, agencia);
        resultado.Depositar(saldo);
        resultado.Titular = cliente;

        return resultado;
    }
}

