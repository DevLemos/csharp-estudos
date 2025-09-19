using heranca.model;

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "renata@email.com", "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "leonardo@email.com", "Diamante", "VIP789X");

Console.WriteLine("------------- Exercício 01 -------------\n");

Console.WriteLine(@$"Bem-vindo, cliente VIP: {cliente1.Nome}
Idade: {cliente1.Idade}
Nível de Fidelidade: {cliente1.NivelFidelidade}
Código VIP: {cliente1.CodigoVIP}
");

Console.WriteLine(@$"Bem-vindo, cliente VIP: {cliente2.Nome}
Idade: {cliente2.Idade}
Nível de Fidelidade: {cliente2.NivelFidelidade}
Código VIP: {cliente2.CodigoVIP}
");

Console.WriteLine("\n------------- Exercício 02 -------------\n");
Interno funcionario01 = new Interno("Juliana", "Gerente","Marketing",2350.00m);
Console.WriteLine(@$"Funcionário Interno: 
Nome: {funcionario01.Nome}
Cargo: {funcionario01.Cargo}
Salário: {funcionario01.Salario}
");

Freelancer funcionario02 = new Freelancer("Emerson", "Design", "Aplicação Web", 3500.00m);
Console.WriteLine(@$"Funcionário Freelancer: 
Nome: {funcionario02.Nome}
Cargo: {funcionario02.Cargo}
Valor do projeto: {funcionario02.ValorProjeto}
");

Console.WriteLine("\n------------- Exercício 03 -------------\n");
Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matemática");
Certificado cerf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);

Console.WriteLine("\n------------- Exercício 04 -------------\n");
Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
pergaminhoAntigo.MostrarDetalhes();

Console.WriteLine("\n------------- Exercício 05 -------------\n");
SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();

presenca.Ativar();
presenca.Desativar();

Console.WriteLine("\n------------- Exercício 06 -------------\n");
Processador cpu = new Processador("Intel", "i7-12700K");
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
Computador pc = new Computador(cpu, mobo);
pc.ExibirConfiguracao();

Console.WriteLine("\n------------- Exercício 07 -------------\n");
PagamentoCredito cliente3 = new PagamentoCredito("André", 23 ,"andre@email.com");
PagamentoBoleto cliente4 = new PagamentoBoleto("Juliana", 30 ,"juliana@email.com");

cliente3.ProcessarPagamento();
cliente4.ProcessarPagamento();

Console.WriteLine("\n------------- Exercício 08 -------------\n");
Funcionario func01 = new Funcionario("João Pedro", "suporte de infra", "TI");
Funcionario func02 = new Funcionario("Marina", "teste", "Consultoria");

Manutencao manutencao1 = new Manutencao("Atualização de servidor", func01);
Consultoria consultoria1 = new Consultoria("Planejamento estratégico", func02);
manutencao1.ExecutarServico();
consultoria1.ExecutarServico();

Console.WriteLine("\n------------- Exercício 09 -------------\n");
Quadrado quadrado = new();
quadrado.Lado = 10.20;
Console.WriteLine($"\nQuadrado");
Console.WriteLine($"Cálculo da área: {quadrado.CalcularArea()}");
Console.WriteLine($"Cálculo do perímetro: {quadrado.CalcularPerimetro()}");

Circulo circulo = new();
circulo.Raio = 5.00;
Console.WriteLine($"\nCirculo");
Console.WriteLine($"Cálculo da área: {circulo.CalcularArea()}");
Console.WriteLine($"Cálculo do perímetro: {circulo.CalcularPerimetro()}");

Triangulo triangulo = new();
triangulo.Base = 10.00;
triangulo.Altura = 8.20 ;
Console.WriteLine($"\nTriângulo");
Console.WriteLine($"Cálculo da área: {triangulo.CalcularArea()}");
Console.WriteLine($"Cálculo do perímetro: {triangulo.CalcularPerimetro()}");