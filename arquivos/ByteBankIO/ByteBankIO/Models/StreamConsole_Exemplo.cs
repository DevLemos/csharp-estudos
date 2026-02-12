using System.Text;
partial class Program
{
    static void StreamEntrada()
    {
        using (var fluxoEntrada = Console.OpenStandardInput())
        using (var fileStream = new FileStream("entradas_console.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1KB

            while (true)
            {
                var bytesLidos = fluxoEntrada.Read(buffer, 0, 1024);
                fileStream.Write(buffer, 0, bytesLidos);
                fileStream.Flush();
                Console.WriteLine($"Bytes lidos no console: {bytesLidos}");
            }
        }
    }
}