void ExercicioMediaNotasAluno()
{
    Dictionary<string, List<double>> registroAluno = new Dictionary<string, List<double>>
    {
        {"Cleber", new List<double> { 10.0, 4.56, 7.22}},
        {"Ana", new List<double> { 4.0, 10.0, 2.23}}
    };

    foreach (var aluno in registroAluno)
    {
        double soma = 0;
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            soma += aluno.Value[i];
        }
        double media = soma / aluno.Value.Count;
        Console.WriteLine($"O aluno {aluno.Key} teve sua média de notas: {media:F1}");
    }
}

void ExercicioEstoqueLoja()
{
    Console.WriteLine();
    Dictionary<string, int> estoque = new Dictionary<string, int>
    {
        {"Uva", 10},
        {"Cereal", 7},
        {"Camiseta", 20},
        {"Calças", 3}
    };

    string produto = "Camiseta";

    if (estoque.ContainsKey(produto))
    {
        Console.WriteLine($"O produto {produto} tem {estoque[produto]} quantidades em estoque");
    }
    else
    {
        Console.WriteLine("Produto não encontrado no estoque.");
    }
}

void ExercicioQuiz()
{
    Console.WriteLine();
    Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
    {
        {"Qual é a capital do Brasil?","Brasília" },
        {"Quanto é 7 vezes 8?", "56"},
        { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
    };

    int pontuacao = 0;

    foreach (var pergunta in perguntasERespostas)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("Sua resposta: ");
        string respostaUsuario = Console.ReadLine();

        if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
        {
            Console.WriteLine("Correto!\n");
            pontuacao++;
        }
        else
        {
            Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
        }
    }

    Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");
}

void ExercicioUsuario()
{
    Console.WriteLine();
    Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        { "user1", "senha123" },
        { "user2", "abc456" },
    };

    string nomeUsuario = "user1";
    string senha = "senha123";

    if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
        Console.WriteLine("Login bem-sucedido!");
    else
        Console.WriteLine("Nome de usuário ou senha incorretos.");
}

ExercicioMediaNotasAluno();
ExercicioEstoqueLoja();
ExercicioQuiz();
ExercicioUsuario();