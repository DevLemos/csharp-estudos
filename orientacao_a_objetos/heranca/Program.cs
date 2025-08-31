using heranca.model;

ProdutoFisico item01 = new ProdutoFisico("Cadeira","Cadeira para mesa de jantar", 120.40m,"Imagem Ilustrativa");

item01.Avaliar(10, "Excelente!");

Console.WriteLine(@$"Produto Físico:
Nome: {item01.Nome}
Descrição: {item01.Descricao}
Preço: {item01.Preco}
Imagem: {item01.Imagem}
Nota: {item01.Avaliacao.Nota}
Comentário: {item01.Avaliacao.Comentario}
");

ProdutoDigital item02 = new ProdutoDigital("Curso Marketing Digital", "Curso online para ganhar dinheiro", 50.40m, "Imagem Ilustrativa", "www.linkdonwload.com");
Console.WriteLine(@$"Produto Digital:
Nome: {item02.Nome}
Descrição: {item02.Descricao}
Preço: {item02.Preco}
Imagem: {item02.Imagem}
Link: {item02.LinkDonwload}
Está expirado: {item02.EstaExpirado()}
");

Pedido pedido01 = new Pedido(1,"Kauan", 120m);
pedido01.ExibirResumo();


