using System.Text;

partial class Program
{
    static void CriarArquivoComWriter()
    {
        string path = "contasExportadas2.csv";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        using (StreamWriter escritor = new StreamWriter(stream))
        {
            var conta = "456, 7895, 4785.40, Gustavo Santos";
            escritor.Write(conta);
        }
    }

    static void EscrevendoFormaSimples()
    {
        //Criando o arquivo e escrevendo com WriteLine
        using (StreamWriter sw = File.CreateText("writeLine.txt"))
        {
            sw.WriteLine("======= Escrevendo com WriteLine =======");
            sw.WriteLine("Primeira linha do arquivo...");
            sw.WriteLine("Segunda linha do arquivo...");
            sw.WriteLine("Terceira linha do arquivo...");
        }

        //Criando o arquivo e escrevendo com Write
        using (StreamWriter sw = File.CreateText("write.txt"))
        {
            sw.Write("======= Escrevendo com Write =======");
            sw.Write("Primeira linha do arquivo...");
            sw.Write("Segunda linha do arquivo...");
            sw.Write("Terceira linha do arquivo...");
        }

        string nome = "João";
        int idade = 30;
        decimal salario = 5000.50m;

        //Criando o arquivo, escrevendo com WriteLine e com formatação
        using (StreamWriter sw = File.CreateText("WriteLine_formatacao.txt"))
        {
            sw.WriteLine("======= Escrevendo com WriteLine =======");
            sw.WriteLine($"Nome: {nome}");
            sw.WriteLine($"Idade: {idade}");
            sw.WriteLine($"Salário: R$ {salario:F2}");
        }

        //Criando o arquivo, escrevendo com WriteLine e ultilizando flush()
        using (StreamWriter sw = File.CreateText("log.txt"))
        {
            sw.WriteLine("======= Escrevendo com WriteLine =======");
            sw.WriteLine("Início do processo...");
            sw.Flush(); //Garante que foi escrito no disco AGORA

            Thread.Sleep(5000); //Simulando um processo demorado
            sw.WriteLine("Fim do processo...");
        }

        //Criando o arquivo, escrevendo com WriteLine e ultilizando AutoFlush
        using (StreamWriter sw = File.CreateText("log2.txt"))
        {
            sw.AutoFlush = true; //Habilita o AutoFlush
            sw.WriteLine("Log 1"); // Escrito imediatamente
            sw.WriteLine("Log 2"); // Escrito imediatamente
        }
    }

    static void CriarArquivoEmBytes()
    {
        string path = "contasExportadas.csv";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            var conta = "456, 7895, 4785.40, Gustavo Santos";
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(conta);
            stream.Write(bytes, 0, bytes.Length);
        }
    }

    static void EscritaBinaria()
    {
        string path = "testeBinario.txt";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        using (var escritor = new BinaryWriter(stream))
        {
            escritor.Write(456);
            escritor.Write(545444);
            escritor.Write(4000.50);
            escritor.Write("Gustavo Braga");
        }
    }

    static void LeituraBinaria()
    {
        string path = "testeBinario.txt";

        using (FileStream stream = new FileStream(path, FileMode.Open))
        using (var leitor = new BinaryReader(stream))
        {
            var agencia = leitor.ReadInt32();
            var numero = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            string mensagem = $"Contas Corrente\n" +
                                  $"Titular: {titular}\n" +
                                  $"Agência: {agencia}\n" +
                                  $"Conta: {numero}\n" +
                                  $"Salário: R$ {saldo:F2}\n";
            Console.WriteLine(mensagem);

        }
    }

    static void TestaEscritaFlush()
    {
        string path = "teste.txt";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        using (StreamWriter escritor = new StreamWriter(stream))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); //Garante que a linha seja escrita no arquivo imediatamente, despeja o buffer para o arquivo
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}
