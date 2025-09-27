Dictionary<string, List<int>> filmesRegistrados = new Dictionary<string, List<int>>
{
    {"Velozes e Furiosos", new List<int> { 10, 5, 9 }},
    {"Creed", new List<int> { 5, 5, 4 }}
};

void ExibirLogo()
{
    Console.WriteLine(@"    
    ███████╗██╗██╗░░░░░███╗░░░███╗███████╗░██████╗
    ██╔════╝██║██║░░░░░████╗░████║██╔════╝██╔════╝
    █████╗░░██║██║░░░░░██╔████╔██║█████╗░░╚█████╗░
    ██╔══╝░░██║██║░░░░░██║╚██╔╝██║██╔══╝░░░╚═══██╗
    ██║░░░░░██║███████╗██║░╚═╝░██║███████╗██████╔╝
    ╚═╝░░░░░╚═╝╚══════╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░
    ");
}
void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("1 - Registrar um filme");
    Console.WriteLine("2 - Mostrar todos os filmes");
    Console.WriteLine("3 - Avaliar um filme");
    Console.WriteLine("0 - Sair");

    ConsoleKeyInfo opcaoMenu = Console.ReadKey();
    Console.WriteLine();

    switch (opcaoMenu.Key)
    {
        case ConsoleKey.NumPad1:
        case ConsoleKey.D1:
            RegistrarFilme();
            break;
        case ConsoleKey.NumPad2:
        case ConsoleKey.D2:
            MostrarFilmesRegistrados();
            break;
        case ConsoleKey.NumPad3:
        case ConsoleKey.D3:
            AvaliarFilme();
            break;
        case ConsoleKey.NumPad0:
        case ConsoleKey.D0:
            Console.WriteLine("Saindo do sistema..");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarFilme()
{
    Console.Clear();
    ExibirTituloOpcao("Registro dos filmes");
    Console.WriteLine("Digite o nome do filme que deseja: ");
    string nomeFilme = Console.ReadLine();
    filmesRegistrados.Add(nomeFilme, new List<int>());
    Console.WriteLine($"O filme {nomeFilme} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarFilmesRegistrados()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo filmes registrados: ");

    foreach (string filme in filmesRegistrados.Keys)
    {
        Console.WriteLine($"Filme: {filme}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarFilme()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar filme");

    Console.Write("Digite o nome do filme que deseja avaliar: ");
    string nomeFilme = Console.ReadLine();

    if (filmesRegistrados.ContainsKey(nomeFilme))
    {
        Console.Write($"Qual a nota que o filme {nomeFilme} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        filmesRegistrados[nomeFilme].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o filme {nomeFilme}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nO filme {nomeFilme} não foi encontrado!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
ExibirMenu();
