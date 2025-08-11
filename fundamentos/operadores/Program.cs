using System;
using model;

namespace operadores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Seja bem-vindo!");
            Console.WriteLine("Segue abaixo operadores C#: \n");

            Console.WriteLine("1. Teste de tipo");
            Console.WriteLine("2. Aritméticos");
            Console.WriteLine("3. Comparação");
            Console.WriteLine("4. Lógicos");
            Console.WriteLine("5. Atribuição");
            Console.WriteLine("6. Condicionais");
            Console.WriteLine("7. Acesso a membros");
            Console.WriteLine("8. Unários");
            Console.WriteLine("9. Precedência operadores");

            Console.WriteLine("\nSelecione qual operador deseja: ");
            string numeroSelecionado = Console.ReadLine();

            if (int.TryParse(numeroSelecionado, out int numeroConvertido))
            {
                switch (numeroConvertido)
                {
                    case 1:
                        ExemploTesteDeTipo();
                        break;
                    case 2:
                        ExemploAritmeticos();
                        break;
                    case 3:
                        ExemploComparacao();
                        break;
                    case 4:
                        ExemploLogicos();
                        break;
                    case 5:
                        ExemploAtribuicao();
                        break;
                    case 6:
                        ExemploCondicionais();
                        break;
                    case 7:
                        ExemploAcessoMembros();
                        break;
                    case 8:
                        ExemploUnarios();
                        break;
                    case 9:
                        PrecedenciaOperadores();
                        break;
                    default:
                        Console.WriteLine("Não existe esse menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro: Valor digitado não é um número inteiro.");
            }
        }

        public static void ExemploTesteDeTipo()
        {
            ExemploIsBasico();
            ExemploAsBasico();
            ExemploTypeof();
        }
        public static void ExemploIsBasico()
        {
            Console.WriteLine($"\n----------------------------------------------------");

            Console.WriteLine("\nExemplo 1");
            Console.WriteLine("Operador IS serve para verificar a compatibilidade");
            Console.WriteLine("de tipo de um objeto em tempo de execução.");

            Animal animal1 = new Cachorro { Name = "Bento", Raca = "Labrador" };
            Animal animal2 = new Gato { Name = "Felix", vidasRestantes = 5 };
            Humano pessoa = new Humano { CPF = "123.456.789-00" };
            Animal animalNulo = null;

            Console.WriteLine($"\nanimal1 é um Cachorro? {animal1 is Cachorro}");
            Console.WriteLine($"animal1 é um Gato? {animal1 is Gato}");
            Console.WriteLine($"animal2 é um Animal? {animal2 is Animal}");
            Console.WriteLine($"animal1 é um Animal? {animal1 is Animal}");
            Console.WriteLine($"pessoa é um Animal? {pessoa is Animal}");
            Console.WriteLine($"animalNulo é um Animal? {animalNulo is Animal}");
            Console.WriteLine($"10 é um int? {10 is int}");
            Console.WriteLine($"10.00 é um double? {10.00 is double}\n");

            Console.WriteLine($"----------------------------------------------------\n");
            Console.WriteLine("Exemplo 2: Pattern Matching");
            Console.WriteLine("Esse é o uso mais comum e moderno no C#\n");

            //Como humano não é animal, vou criar uma lista genética de objetos
            object[] objetosDiversos = new object[]
            {
                new Cachorro { Name = "Bento", Raca = "Labrador" },
                new Gato { Name = "Felix", vidasRestantes = 5 },
                new Humano { CPF = "123.456.789-00" },
                "Olá, Mundo!",
                123
            };

            foreach (var item in objetosDiversos)
            {
                if (item is Cachorro cachorro)
                {
                    Console.WriteLine($"- Encontrado um cachorro, Nome: {cachorro.Name}, Raça: {cachorro.Raca}");
                }
                if (item is Gato gato)
                {
                    Console.WriteLine($"- Encontrado um gato, Nome: {gato.Name}, Vidas Restantes: {gato.vidasRestantes}");
                }
                if (item is Humano humano)
                {
                    Console.WriteLine($"- Encontrado uma pessoa, CPF: {humano.CPF}");
                }
                if (item is string texto)
                {
                    Console.WriteLine($"- Encontrado um texto: '{texto}'");
                }
                if (item is int numero)
                {
                    Console.WriteLine($"- Encontrado uma sequência númerica: {numero}");
                }
            }

            Console.WriteLine($"\n");

        }
        public static void ExemploAsBasico()
        {
            Console.WriteLine($"\n----------------------------------------------------");

            Console.WriteLine("\nExemplo 3");
            Console.WriteLine("Operador AS");

            Animal animal1 = new Cachorro { Name = "Bento", Raca = "Labrador" };
            Animal animal2 = new Gato { Name = "Felix", vidasRestantes = 5 };

            // Usando o operador as
            Cachorro cachorro1 = animal1 as Cachorro; //aqui deu certo
            Cachorro cachorro2 = animal2 as Cachorro; //aqui deu errado
            Gato gato = animal2 as Gato; //aqui deu certo

            if (cachorro1 != null)
            {
                Console.WriteLine("---- Cenário 1: Conversão bem-sucedida ----");
                Console.WriteLine($"- Encontrado um cachorro, Nome: {cachorro1.Name}, Raça: {cachorro1.Raca}\n");
            }
            if (cachorro2 == null)
            {
                Console.WriteLine("---- Cenário 2: Conversão mal-sucedida ----");
                Console.WriteLine($"- Objeto não encontrado: O objeto que está tentando converter não é do tipo certo.\n");
            }
            if (gato != null)
            {
                Console.WriteLine("---- Cenário 3: Conversão bem-sucedida ----");
                Console.WriteLine($"- Encontrado um gato, Nome: {gato.Name}, Vidas Restantes: {gato.vidasRestantes}\n");
            }

        }
        public static void ExemploTypeof()
        {
            Console.WriteLine($"\n----------------------------------------------------");

            Console.WriteLine("\nExemplo 4");
            Console.WriteLine("Operador Typeof");

            Console.WriteLine($"Typeof: {typeof(int)}"); //System.Int32
            Console.WriteLine($"Typeof: {typeof(string)}"); //System.String
            Console.WriteLine($"Typeof: {typeof(DateTime)}\n"); //System.DateTime

            if (typeof(int) == typeof(System.Int32))
            {
                Console.WriteLine("São equivalentes");
            }

        }
        public static void ExemploAritmeticos()
        {
            Console.WriteLine("\n---- Exemplos Aritméticos ----\n");

            //valores para os exemplos
            int a = 15;
            int b = 4;
            double x = 15.5;
            double y = 4.2;

            Console.WriteLine($"Valores: A = {a}, B = {b}, X = {x:F1}, Y = {y:F1}\n");

            // 1. ADIÇÃO (+)
            Console.WriteLine("1. Adição (+)\n");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"X + Y = {x + y}");
            Console.WriteLine($"10 + 20 = {10 + 20}\n");

            // 2. SUBTRAÇÃO (-)
            Console.WriteLine("2. Subtração (-)\n");
            Console.WriteLine($"A - B = {a - b}");
            Console.WriteLine($"X - Y = {x - y:F1}");
            Console.WriteLine($"10 - 20 = {10 - 20}\n");

            // 3.MULTIPLICAÇÃO(*)
            Console.WriteLine("3. Multiplicação (*)\n");
            Console.WriteLine($"A * B = {a * b}");
            Console.WriteLine($"X * Y = {x * y:F1}");
            Console.WriteLine($"7 * 6 = {7 * 6}\n");

            // 4. DIVISÃO (/)
            Console.WriteLine("4. Divisão (/)\n");
            Console.WriteLine($"A / B = {a / b}");
            Console.WriteLine($"X / Y = {x / y:F1}");
            Console.WriteLine($"15.0 / 4.0 = {15.0 / 4.0:F2}\n");

            // 5. MÓDULO/RESTO (%)
            Console.WriteLine("5. Módulo/Resto (%)\n");
            Console.WriteLine($"A % B = {a % b}");
            Console.WriteLine($"10 % 3 = {10 % 3}");
            Console.WriteLine($"20 % 7 = {20 % 7}");
            Console.WriteLine($"8 % 2 = {8 % 2} (par, resto = 0)\n");
        }
        public static void ExemploComparacao()
        {
            Console.WriteLine("\n---- Operadores de Comparação ----\n");
            int a = 10, b = 5, c = 10;
            Console.WriteLine($"Valores: a = {a}, b = {b}, c = {c}\n");
            Console.WriteLine($"a == c: {a == c}  (igual)");
            Console.WriteLine($"a != b: {a != b}  (diferente)");
            Console.WriteLine($"a > b:  {a > b}   (maior que)");
            Console.WriteLine($"a < b:  {a < b}   (menor que)");
            Console.WriteLine($"a >= c: {a >= c}  (maior ou igual)");
            Console.WriteLine($"b <= a: {b <= a}  (menor ou igual)\n");
        }
        public static void ExemploLogicos()
        {
            Console.WriteLine("\n---- Operadores Lógicos ----\n");

            bool x = true, y = false;

            Console.WriteLine($"Valores: x = {x}, y = {y}");
            Console.WriteLine($"x && y: {x && y} (E lógico - AND)");
            Console.WriteLine($"x || y: {x || y} (OU lógico - OR)");
            Console.WriteLine($"!x: {!x} (NÃO lógico - NOT)");
            Console.WriteLine($"x ^ y: {x ^ y} (OU exclusivo - XOR)\n");
        }
        public static void ExemploAtribuicao()
        {
            Console.WriteLine("\n---- Operadores de Atribuição ----\n");
            int num = 10;
            Console.WriteLine($"Valor inicial: {num}");
            num += 5; Console.WriteLine($"num += 5: {num}");
            num -= 3; Console.WriteLine($"num -= 3: {num}");
            num *= 2; Console.WriteLine($"num *= 2: {num}");
            num /= 4; Console.WriteLine($"num /= 4: {num}");
            num %= 3; Console.WriteLine($"num %= 3: {num}");
            Console.WriteLine();
        }
        public static void ExemploCondicionais()
        {

            Console.WriteLine("\nOperador Ternário (?:):\n");
            int idade = 20;
            string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Resultado: {resultado}\n");

            Console.WriteLine("\nOperador Coalescência Nula (??):\n");
            string nome = null;
            string nomePadrao = nome ?? "Sem nome";
            Console.WriteLine($"Nome: {nome ?? "Null"}");
            Console.WriteLine($"Nome Padrão: {nomePadrao}\n");

            Console.WriteLine("\nOperador de Atribuição de Coalescência Nula (??=):\n");
            nome ??= "João";
            Console.WriteLine($"nome após o operador de atribuição de coalescência nula: {nome}");
        }
        public static void ExemploAcessoMembros()
        {
            Console.WriteLine($"\n----------------------------------------------------");

            Console.WriteLine("\nExemplo 1");
            Console.WriteLine("Ponto (.)\n");
            var pessoa = new { Nome = "João", Idade = 23 };
            Console.WriteLine($"pessoa.Nome: {pessoa.Nome}"); //acesso direto

            Console.WriteLine("\nExemplo 2");
            Console.WriteLine("Condicional Nulo (?.)\n");
            string textoNulo = null;
            Console.WriteLine($"textoNulo?.Length: {textoNulo?.Length ?? 0} (safe navigation)");

            Console.WriteLine("\nExemplo 3");
            Console.WriteLine("Índices ([])\n");
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"array[2]: {array[2]} (acesso por índice)");

            Console.WriteLine("\nExemplo 4");
            Console.WriteLine("Slicing (fatiar) ([..])\n");

            Console.WriteLine($"array[1..3]: [{string.Join(", ", array[1..3])}] (range)\n");
        }
        public static void ExemploUnarios()
        {
            Console.WriteLine("\n---- Exemplos Unários ----\n");

            Console.WriteLine("1. Incremento(++)\n");
            int num1 = 5;
            int num2 = 5;
            Console.WriteLine($"Valor inicial: {num1}");
            Console.WriteLine($"++num1 (pré-incremento) {++num1}");
            Console.WriteLine($"num2++ (pós-incremento) {num2++}");
            Console.WriteLine($"Valor de num2 após incremento {num2}\n");

            Console.WriteLine("2. Decremento(--)\n");
            int num3 = 10;
            int num4 = 10;
            Console.WriteLine($"Valor inicial: {num3}");
            Console.WriteLine($"--num3 (pré-incremento) {--num3}");
            Console.WriteLine($"num4-- (pós-incremento) {num4--}");
            Console.WriteLine($"Valor de num4 após incremento {num4}\n");

            Console.WriteLine("3. Negação Unária(-)\n");
            int positivo = 40;
            int negativo = -positivo;
            Console.WriteLine($"Valor positivo: {positivo}");
            Console.WriteLine($"Valor negativo {negativo}");
            Console.WriteLine($"Dupla negação {-negativo}\n");

            Console.WriteLine("4. Positivo Unário(+)\n");
            int valor = -25;
            Console.WriteLine($"Valor original: {valor}");
            Console.WriteLine($"Com + unário: {+valor} (não muda o sinal)");
            Console.WriteLine($"Para tornar positivo {Math.Abs(valor)}\n");
        }
        public static void PrecedenciaOperadores()
        {
            Console.WriteLine("\n---- PRECEDÊNCIA DE OPERADORES ----");
            Console.WriteLine("Ordem (maior para menor precedência):");
            Console.WriteLine("1. () - Parênteses");
            Console.WriteLine("2. +, - (unários), ++, --");
            Console.WriteLine("3. *, /, %");
            Console.WriteLine("4. +, - (binários)");
            Console.WriteLine();

            // Exemplos de precedência
            int resultado1 = 2 + 3 * 4;        // = 2 + 12 = 14
            int resultado2 = (2 + 3) * 4;      // = 5 * 4 = 20
            int resultado3 = 10 - 6 / 2;       // = 10 - 3 = 7
            int resultado4 = (10 - 6) / 2;     // = 4 / 2 = 2

            Console.WriteLine("Exemplos de precedência:");
            Console.WriteLine($"2 + 3 * 4 = {resultado1}");
            Console.WriteLine($"(2 + 3) * 4 = {resultado2}");
            Console.WriteLine($"10 - 6 / 2 = {resultado3}");
            Console.WriteLine($"(10 - 6) / 2 = {resultado4}");
        }
    }
}
