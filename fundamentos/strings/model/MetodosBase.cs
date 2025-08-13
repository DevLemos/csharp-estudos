namespace model.MetodosBase
{
    public abstract class MetodosBase
    {
        public abstract void Metodo();
    }
    public class MetodoSplit : MetodosBase
    {
        public override void Metodo()
        {
            Console.WriteLine("-------- Método Split --------\n");

            Console.WriteLine("Exemplo 01\n");
            string linhaCsv = "João, 40, 9999999999";
            string telefone = linhaCsv.Split(",")[2];
            Console.WriteLine(telefone);

            Console.WriteLine("Exemplo 02\n");
            string log = "2025-08-12, Erro, Arquivo não encontrado";
            Console.WriteLine($"Data: {log.Split(",")[0]}");
            Console.WriteLine($"Tipo de erro: {log.Split(",")[1]}");
            Console.WriteLine($"Mensagem: {log.Split(",")[2]}");
        }
    }
    public class MetodoReplace : MetodosBase
    {
        public override void Metodo()
        {
            Console.WriteLine("\n-------- Método Replace --------\n");

            string linhaCsv = "João, 40, 9999999999";
            string novaLinha = linhaCsv.Replace(",", "-");
            Console.WriteLine(novaLinha);
        }
    }
    public class MetodoEndsWith : MetodosBase
    {
        public override void Metodo()
        {
            Console.WriteLine("\n-------- Método EndsWith --------\n");

            string imagem = "foto.jpg";
            bool valido = imagem.EndsWith(".jpg");

            if (valido)
            {
                Console.WriteLine("Carregando para o banco de dados");
            }
            else
            {
                Console.WriteLine("Formato Inválido!");
            }
        }
    }
    public class MetodoIndexOf : MetodosBase
    {
        public override void Metodo()
        {
            Console.WriteLine("\n-------- Método IndexOf --------\n");

            string email = "joao@alura.com.br";
            int posicao = email.IndexOf("@");
            string dominio = email.Substring(posicao + 1);
            Console.WriteLine(dominio);
        }
    }
    public class MetodoLength : MetodosBase
    {
        public override void Metodo()
        {
            Console.WriteLine("\n-------- Método Length --------\n");

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine()!;

            Console.WriteLine($"A frase digitada tem {frase.Length} caracteres.");
        }
    }
}