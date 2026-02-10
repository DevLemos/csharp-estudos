
partial class Program
{
    static void Main(string[] args)
    {
        var enderecoArq = "contas.txt";

        using (FileStream fluxoArq = new FileStream(enderecoArq,FileMode.Open))
        {
            //Instanciando um leitor de fluxo de dados do arquivo
            var leitor = new StreamReader(fluxoArq);

            Console.WriteLine("Lendo o arquivo e retornando a primeira linha... \n");
            //Console.WriteLine(leitor.ReadLine());

            Console.WriteLine("\nLendo o arquivo até o final (dependendo do arquivo, pode ser prejudicial pois lê tudo de uma única vez)...\n");
            //Console.WriteLine(leitor.ReadToEnd());

            Console.WriteLine("\nLendo o arquivo e retornando o primeiro byte...\n");
            //Console.WriteLine(leitor.Read());

            Console.WriteLine("\nLendo o arquivo parte por parte (linha a linha)...");
            Console.WriteLine("Solução para quando não quiser ler o arquivo de uma única vez:\n");

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

        }
    }

}
