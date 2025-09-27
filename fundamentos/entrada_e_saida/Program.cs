using System;
using System.Globalization;

namespace entrada_e_saida
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n------ Demonstração de métodos entrada e saída de dados ------ \n");

            Console.WriteLine("Escolha a seguir os métodos que deseja: ");
            Console.WriteLine("1. Read()");
            Console.WriteLine("2. ReadLine()");
            Console.WriteLine("3. ReadKey()");
            Console.WriteLine("4. Write()");
            Console.WriteLine("5. WriteLine()");
            Console.WriteLine("6. Clear()");
            Console.WriteLine("7. Exercício de fixação");

            Console.WriteLine("\nInforme o número: ");
            ConsoleKeyInfo teclaMenu = Console.ReadKey(true);

            switch (teclaMenu.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ExemploRead();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ExemploReadLine();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ExemploReadKey();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    ExemploWrite();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    ExemploWriteLine();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    ExemploClear();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    ExercicioFixacao();
                    break;
                default:
                    Console.WriteLine("\n\nOpção inválida!");
                    break;
            }
        }
        public static void ExemploRead()
        {
            Console.WriteLine("\nExemplo 1: ");
            Console.WriteLine("Console.Read() lê um caractere por vez (como int)");
            Console.WriteLine("Digite algumas letras e pressione ENTER:\n");

            Console.WriteLine("Sua entrada: ");

            // Read lê caractere por caractere  
            int entrada01 = Console.Read();
            int entrada02 = Console.Read();
            int entrada03 = Console.Read();

            //Limpa ENTER do buffer
            Console.ReadLine();

            Console.WriteLine($"\nPrimeiro caractere, código ASCII: {entrada01}, Caractere: ('{(char)entrada01}')");
            Console.WriteLine($"Segundo caractere, código ASCII: {entrada02}, Caractere: ('{(char)entrada02}')");
            Console.WriteLine($"Terceiro caractere, código ASCII: {entrada03}, Caractere: ('{(char)entrada03}')");

            Console.WriteLine("\nExemplo 2: ");
            Console.WriteLine("Digite 'S' para Sim ou 'N' para Não:");

            int resposta = Console.Read();
            char respostaChar = (char)resposta;

            //Limpa ENTER do buffer
            Console.ReadLine();

            if (respostaChar == 'S' || respostaChar == 's')
            {
                Console.WriteLine("Você escolheu SIM!");
            }
            else if (respostaChar == 'N' || respostaChar == 'n')
            {
                Console.WriteLine("Você escolheu NÃO!");
            }
            else
            {
                Console.WriteLine($"Opção inválida: '{respostaChar}'");
            }

            Console.WriteLine("\n" + new string('-', 50));
        }
        public static void ExemploReadLine()
        {
            //Exemplo 1
            //lendo até a quebra de linha
            Console.WriteLine("\n------ Exemplo 1 ------\n");
            Console.WriteLine("Entre com uma frase: ");
            string frase = Console.ReadLine();

            //lendo uma palavra por linha
            Console.WriteLine("Digite 3 palavras uma em cada linha: ");
            string palavra01 = Console.ReadLine();
            string palavra02 = Console.ReadLine();
            string palavra03 = Console.ReadLine();

            //lendo 3 palavras na mesma linha
            Console.WriteLine("Digite 3 palavras na mesma linha: ");
            string entrada = Console.ReadLine();
            string[] arrayStrings = entrada.Split(' ');
            string s1 = arrayStrings[0];
            string s2 = arrayStrings[1];
            string s3 = arrayStrings[2];

            Console.WriteLine("\nVocê digitou: ");
            Console.WriteLine($"Frase: {frase}");
            Console.WriteLine($"Primeira palavra: {palavra01}");
            Console.WriteLine($"Segunda palavra: {palavra02}");
            Console.WriteLine($"Terceira palavra: {palavra03}");
            Console.WriteLine($"Palavras digitadas na mesma linha: '{s1}', '{s2}', '{s3}'");

            //Exemplo 2
            Console.WriteLine("\n------ Exemplo 2 ------\n");

            Console.WriteLine("Entre com a idade: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o sexo: ");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a altura: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Agora entre com Nome, Sexo, idade e Altura na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void ExemploReadKey()
        {
            Console.WriteLine("\nReadKey Básico");
            Console.WriteLine("Pressione qualquer tecla: ");
            ConsoleKeyInfo tecla1 = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Tecla pressionada: {tecla1.Key}");
            Console.WriteLine($"Caractere: '{tecla1.KeyChar}'");
            Console.WriteLine($"Modificadores: {tecla1.Modifiers}");

            Console.WriteLine("\nReadKey com intercept");
            Console.WriteLine("Pressione qualquer tecla (não aparecerá na tela): ");
            ConsoleKeyInfo tecla2 = Console.ReadKey(true); //true intercepta = não mostra a tecla na tela
            Console.WriteLine($"Tecla interceptada: '{tecla2.KeyChar}' - {tecla2.Key}");

            Console.WriteLine("\nDetectar teclas especiais");
            Console.WriteLine("Pressione qualquer tecla especial (ESC, F1, Setas, etc): ");
            ConsoleKeyInfo tecla3 = Console.ReadKey();
            Console.WriteLine("Informações sobre a tecla pressionada:");
            Console.WriteLine($"Tecla: {tecla3.Key}");
            Console.WriteLine($"Caractere: '{tecla3.KeyChar}'");
            Console.WriteLine($"Modificadores: {tecla3.Modifiers}");

            Console.WriteLine("\nDetectar modificadores");
            Console.WriteLine("Pressione uma tecla com Ctrl, Alt ou Shift: \n");
            ConsoleKeyInfo tecla4 = Console.ReadKey();
            Console.WriteLine($"Tecla: {tecla4.Key}");

            if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Control))
                Console.WriteLine("Ctrl estava pressionado!");
            if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Alt))
                Console.WriteLine("Alt estava pressionado!");
            if (tecla4.Modifiers.HasFlag(ConsoleModifiers.Shift))
                Console.WriteLine("Shift estava pressionado!");

            Console.WriteLine("\n" + new string('-', 50));

        }
        public static void ExemploWrite()
        {
            Console.Write("Write: ");
            Console.Write("João");
            Console.Write(" | ");
            Console.Write("Maria");
            Console.Write(" | ");
            Console.Write("Pedro");
        }
        public static void ExemploWriteLine()
        {
            Console.WriteLine("WriteLine: ");
            Console.WriteLine("Maria");
            Console.WriteLine("João");
            Console.WriteLine("Pedro");
        }
        public static void ExemploClear()
        {
            Console.WriteLine("Texto 1");
            Console.WriteLine("Texto 2");
            Console.WriteLine("Testando......");
            Console.Clear();
            Console.WriteLine("Único texto visível da função");
        }   
        public static void ExercicioFixacao()
        {
            Console.WriteLine("\n------ Exercício de Fixação ------\n");

            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] arrayDados = Console.ReadLine().Split(' ');
            string sobrenomeArray = arrayDados[0];
            int idadeArray = int.Parse(arrayDados[1]);
            double alturaArray = double.Parse(arrayDados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenomeArray);
            Console.WriteLine(idadeArray);
            Console.WriteLine(alturaArray.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
