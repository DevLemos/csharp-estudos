namespace model.EstruturaControle
{
    public abstract class EstruturaControle
    {
        public abstract void Metodo();
    }
    public class EstruturaIf : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("------ Exemplo 1: Verificação de idade (if-else if-else) ------\n");

            int idade = 23;
            string categoria;

            if (idade < 13)
                categoria = "Criança";
            else if (idade < 18)
                categoria = "Adolescente";
            else if (idade < 60)
                categoria = "Adulto";
            else
                categoria = "Idoso";

            Console.WriteLine($"Categoria: {categoria}");

            Console.WriteLine("\n------ Exemplo 2: Validação de nota (if-else if-else) ------\n");

            double nota = 8.5;
            string conceito;

            if (nota >= 9.0)
                conceito = "Excelente";
            else if (nota >= 7.0)
                conceito = "Bom";
            else if (nota >= 5.0)
                conceito = "Regular";
            else
                conceito = "Insuficiente";

            Console.WriteLine($"Conceito: {conceito}\nNota: {nota}");

            Console.WriteLine("\n------ Exemplo 3: Condições compostas (if-else if-else) ------\n");
            int x = 10, y = 20, z = 15;

            if (x > 5 && y < 25)
            {
                Console.WriteLine("Primeira condição atendida");
            }

            if (x == 10 || z > 20)
            {
                Console.WriteLine("Segunda condição atendida");
            }

            if (!(x > y))
            {
                Console.WriteLine("x não é maior que y");
            }

        }
    }
    public class EstruturaSwitch : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("\n------ Exemplo 1: Switch / Case ------\n");

            Console.WriteLine("Digite uma opção (A,B,C): ");
            char opcao = Console.ReadKey(true).KeyChar;
            Console.WriteLine();

            switch (opcao)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Opção A: Cadastrar usuário");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Opção B: Listar usuários");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Opção C: Sair do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\n------ Exemplo 2: Dia da semana (Switch / Case) ------\n");

            int diaSemana = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => 1,
                DayOfWeek.Tuesday => 2,
                DayOfWeek.Wednesday => 3,
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 5,
                DayOfWeek.Saturday => 6,
                DayOfWeek.Sunday => 7,
                _ => 0
            };

            Console.WriteLine("Dia da semana: " + diaSemana);

            Console.WriteLine("\n------ Exemplo 3: Calculadora (Switch / Case) ------\n");

            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite agora o operador desejado ( +, -, *, / ): ");
            ConsoleKeyInfo operador = Console.ReadKey(true);
            double resultado = 0;

            switch (operador.KeyChar)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num1 != 0 && num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    break;
            }

            if (resultado > 0)
                Console.WriteLine($"Resultado da operação: {resultado:F2}");

            Console.WriteLine("\n------ Exemplo 4: Switch Expression (C# 8.0+) ------\n");
            Console.WriteLine("------ Busca de Mensagem Status Code ------\n");

            string mensagem = GetStatusMessage(200);

            // Sintaxe mais moderna
            string GetStatusMessage(int codigo) => codigo switch
            {
                200 => "OK",
                404 => "NÃO ENCONTRADO",
                500 => "ERRO INTERNO",
                _ => "CÓDIGO DESCONHECIDO"
            };

            Console.WriteLine("Mensagem: " + mensagem);


            // Com múltiplas condições
            Console.WriteLine("\n------ Múltiplas condições ------\n");

            string classificacao = ClassificarProduto("Roupas", 430);
            string ClassificarProduto(string categoria, decimal preco) => (categoria, preco) switch
            {
                ("Roupas", > 200) => "Luxo",
                ("Roupas", _) => "Casual",
                ("Eletrônicos", > 1000) => "Premium",
                ("Eletrônicos", _) => "Standard",
                _ => "Categoria desconhecida"
            };

            Console.WriteLine("Classificação de categoria: " + classificacao);

        }
    }
    public class EstruturaFor : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("\n------ Exemplo 1: Contagem simples (for) ------\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            Console.WriteLine("\n------ Exemplo 2: Contagem regressiva (for) ------\n");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Contagem regressiva: " + i);
            }

            Console.WriteLine("\n------ Exemplo 3: Incremento personalizado(for) ------\n");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine($"Número par: {i}");
            }

            Console.WriteLine("\n------ Exemplo 4: Percorrendo array(for) ------\n");
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posição: {i}, Número: {numeros[i]}");
            }

            Console.WriteLine("\n------ Exemplo 5: for aninhado - matriz(for) ------\n");
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n------ Exemplo 6: Múltiplas variáveis (for) ------\n");
            for (int i = 1, j = 10; i <= 5; i++, j--)
            {
                Console.WriteLine($"i:{i}, j: {j}");
            }

        }
    }
    public class EstruturaWhile : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("\n------ Exemplo 1: Contador simples (while) ------\n");

            int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine($"Iteração: {contador}");
                contador++;
            }

            Console.WriteLine("\n------ Exemplo 2: Validação de entrada (while) ------\n");
            string senha;
            int tentativas = 0;
            const int maxTentativas = 3;

            while (tentativas < maxTentativas)
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                if (senha == "123456")
                {
                    Console.WriteLine("Senha correta!");
                    break;
                }

                tentativas++;
                Console.WriteLine($"Senha incorreta. Tentativas restantes: {maxTentativas - tentativas}");
            }

            if (tentativas == maxTentativas)
            {
                Console.WriteLine("Número máximo de tentativas excedido!");
            }

            Console.WriteLine("\n------ Exemplo 3: Leitura de números até zero (while) ------\n");
            int numero;
            int soma = 0;

            Console.WriteLine("Digite números (0 para parar): ");
            while ((numero = int.Parse(Console.ReadLine())) != 0)
            {
                soma += numero;
                Console.WriteLine("Soma atual: " + soma);
            }

            Console.WriteLine("\n------ Exemplo 4: Jogo de adivinhação (while) ------\n");
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa;
            int numeroTentativas = 0;

            Console.WriteLine("Adivinhe o número entre 1 e 100:");

            while (true)
            {
                tentativa = int.Parse(Console.ReadLine());
                numeroTentativas++;

                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {numeroTentativas} tentativas!");
                    break;
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente um número maior.");
                }
                else
                {
                    Console.WriteLine("Muito alto! Tente um número menor.");
                }
            }
        }
    }
    public class EstruturaDoWhile : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("\n------ Exemplo 1: Menu que executa pelo menos uma vez (do-while) ------\n");
            char opcao;
            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Nova operação");
                Console.WriteLine("2 - Ver histórico");
                Console.WriteLine("3 - Configurações");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Nova operação selecionada");
                        break;
                    case '2':
                        Console.WriteLine("Histórico selecionado");
                        break;
                    case '3':
                        Console.WriteLine("Configurações selecionadas");
                        break;
                    case '0':
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != '0');

            Console.WriteLine("\n------ Exemplo 2: validação de entrada (do-while) ------\n");
            int idade;
            do
            {
                Console.Write("Digite sua idade (0-120): ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0 || idade > 120)
                {
                    Console.WriteLine("Idade inválida! Tente novamente.");
                }
            } while (idade < 0 || idade > 120);

            Console.WriteLine($"Idade válida: {idade} anos");

            Console.WriteLine("\n------ Exemplo 3: Jogo simples (do-while) ------\n");
            Random random = new Random();
            string jogarNovamente;

            do
            {
                int numeroSorteado = random.Next(1, 7);
                Console.Write("Adivinhe o número (1 - 7): ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSorteado)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                }
                else
                {
                    Console.WriteLine($"Errou! O número era {numeroSorteado}");
                }

                Console.Write("Deseja jogar novamente? (s/n) : ");
                jogarNovamente = Console.ReadLine().ToLower();
            } while (jogarNovamente == "s" || jogarNovamente == "sim");
        }
    }
    public class EstruturaForeach : EstruturaControle
    {
        public override void Metodo()
        {
            Console.WriteLine("\n------ Exemplo 1: Array de strings (foreach) ------\n");

            string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }

            Console.WriteLine("\n------ Exemplo 2: Lista de números (foreach) ------\n");
            List<int> numeros = new List<int> { 2, 4, 6, 8, 10, 12, 14 };
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Número: {numero}, Quadrado: {numero * numero}");
            }

            Console.WriteLine("\n------ Exemplo 3: Dicionário (foreach) ------\n");
            Dictionary<string, int> idades = new Dictionary<string, int>
            {
                {"Ana", 25},
                {"Bruno", 30},
                {"Carlos", 28}
            };

            foreach (KeyValuePair<string, int> pessoa in idades)
            {
                Console.WriteLine($"Nome: {pessoa.Key}, Idade: {pessoa.Value}");
            }
            Console.WriteLine();
            // Ou usando var para simplificar
            foreach (var pessoa in idades)
            {
                Console.WriteLine($"Nome: {pessoa.Key}, Idade: {pessoa.Value}");
            }

            Console.WriteLine("\n------ Exemplo 4: Array multidimensional (foreach) ------\n");
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            foreach (int valor in matriz)
            {
                Console.Write($"{valor} ");
            }

            Console.WriteLine("\n------ Exemplo 5: String (cada caractere) (foreach) ------\n");

            string palavra = "Programação";
            foreach (char letra in palavra)
            {
                Console.Write($"{letra} ");
            }

            Console.WriteLine("\n------ Exemplo 6: Coleção personalizada (foreach) ------\n");

        }
    }
}