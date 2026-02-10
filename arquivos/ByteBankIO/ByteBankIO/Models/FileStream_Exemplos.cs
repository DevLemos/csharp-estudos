using System.Text;

namespace ByteBankIO.Models
{
    partial class FileStream_Exemplos
    {
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

        static void EscreverArquivoUTF(byte[] buffer, int bytesLidos)
        {
            var ut8 = new UTF8Encoding();

            Console.WriteLine("\nTransformando e armazenando em UTF-8...");
            string texto = ut8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }

        static void LeituraArquivo()
        {
            int bytesLidos = -1;
            var buffer = new byte[1024]; //1 KB
            int totalBytesLidos = 0;

            using (FileStream streamFile = new FileStream("Contas.txt", FileMode.Open))
            {
                Console.WriteLine("Começando a preencher o buffer com o fluxo de dados do arquivo...\n");
                while (bytesLidos != 0)
                {
                    bytesLidos = streamFile.Read(buffer, 0, 1024);

                    totalBytesLidos += bytesLidos;
                    Console.WriteLine($"\nBytes lidos: {bytesLidos}");

                    EscreverArquivoUTF(buffer, bytesLidos);
                }
                Console.WriteLine($"\nTotal de bytes lidos: {totalBytesLidos}");
                Console.WriteLine("\nFim! O fluxo de dados do arquivo acabou.\n");

                Console.WriteLine("Começando a percorrer o buffer preenchido com os bytes...");
                EscreverBuffer(buffer);
            }
        }
    }
}
