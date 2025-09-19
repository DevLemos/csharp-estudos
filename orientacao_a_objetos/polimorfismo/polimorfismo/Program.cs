using polimorfismo.model;

ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso perfeito para produtividade diária.",
80.00m, "Imagem");

Console.WriteLine(@$"Produto Físico 1: 
Nome: {item1.Nome}
Descricao: {item1.Descricao}
Preco: {item1.Preco}
Estoque: {item1.Estoque}
");

item1.AlterarPrecoComDesconto(10.0m);
Console.WriteLine(@$"Produto Físico 1 (desconto de 10%): 
Nome: {item1.Nome}
Descricao: {item1.Descricao}
Preco: {item1.Preco:F2}
Estoque: {item1.Estoque}
");

item1.Entregar("Endereço físico");
Console.WriteLine();

ProdutoFisico item2 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso perfeito para produtividade diária.",
80.00m, "Imagem", 20);

Console.WriteLine(@$"Produto Físico 2: 
Nome: {item2.Nome}
Descricao: {item2.Descricao}
Preco: {item2.Preco}
Estoque: {item2.Estoque}
");

item2.AlterarPrecoComDesconto(10);
Console.WriteLine(@$"Produto Físico 2 (desconto de 10): 
Nome: {item2.Nome}
Descricao: {item2.Descricao}
Preco: {item2.Preco}
Estoque: {item2.Estoque}
");


ProdutoDigital itemDigital = new ProdutoDigital("Curso de Marketing", "Curso para aprendizado",
80.00m, "Imagem", "linkdownnload");
itemDigital.Entregar("teste@gmail.com");
Console.WriteLine();

Pedido pedido = new Pedido(1, "Carlos", 120.00m);
pedido.AdicionarProduto(item1);
pedido.AdicionarProduto(itemDigital);
pedido.ExibirResumo();

BancoDeDados banco = new BancoDeDados();
var produto = (ProdutoFisico) banco.BuscarProdutoPeloNome("Teclado");
Console.WriteLine(@$"Produto: 
Nome: {produto.Nome}
Descricao: {produto.Descricao}
Preco: {produto.Preco}
Estoque: {produto.Estoque}
");
