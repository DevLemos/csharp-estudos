using encapsulamento.model;

// Console.WriteLine("----- Exemplo 01: Entendendo modificador private -----");
// ContaBancaria conta = new ContaBancaria(100);
// Console.WriteLine(conta.Saldo);

// Console.WriteLine(conta.Sacar(30));
// Console.WriteLine(conta.Saldo);

// Console.WriteLine("\n----- Exemplo 02: Getters e Setters -----");
// Produto produto01 = new Produto("Mesa", "Uma mesa de jantar para quatro pessoas", 1.500m, 2, "http://donwloadsimg.com");
// Console.WriteLine(@$"Produto:
// Nome: {produto01.GetNome()}
// ");
// produto01.SetNome("Cadeira");
// Console.WriteLine(@$"Produto pós mudança:
// Nome: {produto01.GetNome()}
// ");

// Console.WriteLine("\n----- Exemplo 03: Getters e setters com propriedades -----");
// Console.WriteLine(@$"Produto:
// Nome: {produto01.Nome}
// ");
// produto01.Nome = "Computador";
// Console.WriteLine(@$"Produto pós mudança:
// Nome: {produto01.Nome}
// ");

// Console.WriteLine("\n----- Exemplo 04: Getters e setters com auto-properties -----");
// Produto produto02 = new Produto("Teclado", "Teclado gamer com led RGB", 500m, 2, "http://donwloadsimg.com");
// Console.WriteLine(@$"Produto:
// Nome: {produto02.Nome}
// Descrição: {produto02.Descricao}
// Preço: {produto02.Preco}
// Quantidade estoque: {produto02.Estoque}
// Link Imagem: {produto02.GetLinkImagem()}
// Data da criação: {produto02.DataCriacao}
// ");

Console.WriteLine("\n----- Exercício 01: Monitoramento de veículo -----");
Veiculo veiculo01 = new Veiculo("KPSX0493");
veiculo01.AtualizarVelocidade(50.5);
Console.WriteLine(@$"Veículo:
Placa: {veiculo01.Placa}
Velocidade Atual: {veiculo01.VelocidadeAtual} km/h
");

Console.WriteLine("\n----- Exercício 02: Gerenciamento de Projetos -----");
Projeto projeto01 = new Projeto("PMS");
projeto01.AdicionarTarefa("Criar tela de login");
projeto01.AdicionarTarefa("Implementar banco de dados");
projeto01.ExibirTarefas();

Console.WriteLine("\n----- Exercício 03: Agenda com controle de contatos duplicados -----");
Agenda agenda01 = new Agenda("Kauan");
agenda01.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda01.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda01.AdicionarContato(new Contato("Julia", "21988776655"));
agenda01.ListarContatos();

Console.WriteLine("\n----- Exercício 04: Sistema de reserva para hotel -----");
Hospede hospede = new Hospede("Carlos Ribeiro");
Quarto quarto = new Quarto(100);
quarto.ValorDiaria = 124.40;
Reserva reserva = new Reserva(hospede, quarto, 3);
Console.WriteLine($"Reserva para: {hospede.Nome}");
Console.WriteLine($"Quarto: {quarto.Numero}");
Console.WriteLine($"Valor total: R${reserva.ValorTotal:F2}");


