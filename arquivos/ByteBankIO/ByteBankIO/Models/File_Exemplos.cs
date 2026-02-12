using System.IO;

partial class Program
{
    static void EscrevendoArquivoSimples()
    {
        File.WriteAllText("FileTeste.txt", "Novo Arquivo!");
    }

    static void LeituraArquivoArray()
    {
        string path = "C:\\Users\\kauan\\Documents\\Projetos\\csharp\\arquivos\\ByteBankIO\\ByteBankIO\\contas.txt";

        string[] linhas = File.ReadAllLines(path);
        Console.WriteLine($"Quantidade de linhas: {linhas.Length}");

        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }

    static void LeituraArquivoString()
    {
        string path = "C:\\Users\\kauan\\Documents\\Projetos\\csharp\\arquivos\\ByteBankIO\\ByteBankIO\\contas.txt";

        string conteudo = File.ReadAllText(path);

        Console.WriteLine(conteudo);
    }

    static void LeituraArquivoBytes()
    {
        string path = "C:\\Users\\kauan\\Documents\\Projetos\\csharp\\arquivos\\ByteBankIO\\ByteBankIO\\contas.txt";

       var bytes = File.ReadAllBytes(path);

        Console.WriteLine($"Arquivo contas.txt possui {bytes.Length} Bytes.");
    }

    static void CriandoArquivoCasoNaoExista()
    {
        string path = "C:\\Users\\kauan\\Documents\\Projetos\\csharp\\arquivos\\ByteBankIO\\ByteBankIO\\primeiro_arquivo.txt";

        if (!File.Exists(path))
        {
            //Criando o arquivo
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Primeira linha do arquivo...");
                sw.WriteLine("Segunda linha do arquivo...");
                sw.WriteLine("Terceira linha do arquivo...");
            }
        }

        //Criando o arquivo
        using (StreamReader leitor = File.OpenText(path))
        {
            string s;
            while ((s = leitor.ReadLine()) != null)
            {
                Console.WriteLine(s);

            }
        }
    }
}