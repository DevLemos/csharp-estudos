using System.Text;

class Program
{
    static void Main(string[] args)
    {
        LeituraArquivo();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        Console.WriteLine("\nPercorrendo...");
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }

        Console.WriteLine("\nFim! Esses foram os bytes preenchidos no buffer...");
    }

    static void EscreverArquivoUTF(byte[] buffer)
    {
        var ut8 = new UTF8Encoding();

        Console.WriteLine("\nTransformando e armazenando em UTF-8...");
        string texto = ut8.GetString(buffer);
        Console.Write(texto);
        Console.WriteLine("\nFinalizado!");
    }

    static void LeituraArquivo()
    {
        int bytesLidos = -1;
        var buffer = new byte[1024]; //1 KB
        int totalBytesLidos = 0;

        var streamFile = new FileStream("Contas.txt", FileMode.Open);

        Console.WriteLine("Começando a preencher o buffer com o fluxo de dados do arquivo...\n");
        while((bytesLidos = streamFile.Read(buffer, 0, buffer.Length)) > 0)
        {
            totalBytesLidos += bytesLidos;
            Console.WriteLine($"Bytes lidos: {bytesLidos}, Total bytes lidos: {totalBytesLidos}");
        }
        Console.WriteLine("\nFim! O fluxo de dados do arquivo acabou.\n");

        Console.WriteLine("Começando a percorrer o buffer preenchido com os bytes...");
        EscreverBuffer(buffer);

        Console.WriteLine("\nComeçando a percorrer o buffer preenchido com os bytes,transformados e armazenados em UTF-8...");
        EscreverArquivoUTF(buffer);
    }
}
