using System;
using classes_e_objetos.model;


namespace classes_e_objetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------- Instânciando um objeto: Produto -------\n");
            Produto item1 = new Produto();
            item1.nome = "Teclado";
            item1.descricao = "Modelo compacto e silencioso, perfeito para produtividade diária";
            item1.preco = 80.00m;
            item1.estoque = 15;

            Console.WriteLine(@$"Dados do item :
            Nome: {item1.nome};
            Descrição: {item1.descricao};
            Preço: {item1.preco};
            Estoque: {item1.estoque};            
            ");

            Console.WriteLine("------- Chamando método da classe -------\n");
            if (item1.EstaDisponivel())
            {
                Console.WriteLine("Produto está disponível");
            }

            Console.WriteLine("------- Chamando método da classe e passando valor como parâmetro -------\n");
            item1.AlterarPrecoComDesconto(0.2m);
            Console.WriteLine(@$"Dados do item :
            Nome: {item1.nome};
            Descrição: {item1.descricao};
            Preço: {item1.preco:F2};
            Estoque: {item1.estoque};            
            ");

            Console.WriteLine("------- Instânciando um objeto: Livro-------\n");
            Livro livro = new Livro { titulo = "Programador Autodidata", autor = "Cory" };
            Console.WriteLine(@$"Dados do livro :
            Título: {livro.titulo};
            Autor: {livro.autor};
            ");

            Console.WriteLine("------- Instânciando um objeto: Passagem -------\n");
            Passagem passagem = new Passagem("Roberto Souza", "Paris");
            Console.WriteLine(@$"Dados da passagem :
            Passageiro: {passagem.Passageiro};
            Destino: {passagem.Destino};
            ");

            Console.WriteLine("------- Instânciando um objeto: Conta Bancaria -------\n");
            ContaBancaria conta = new ContaBancaria("34100", 1000.00);
            Console.WriteLine(@$"Dados da conta :
            Número da conta: {conta.NumeroConta};
            Saldo atual: {conta.Saldo.ToString("0.00")};
            ");

            conta.Depositar(2000.00);
            Console.WriteLine(@$"Dados da conta :
            Número da conta: {conta.NumeroConta};
            Saldo atual: R$ {conta.Saldo:F2};
            ");

            Console.WriteLine("------- Instânciando um objeto: Funcionário -------\n");
            Funcionario funcionario = new Funcionario("Cleber Santana", "Estoquista");
            Console.WriteLine(@$"Dados do funcionário:
            Nome: {funcionario.Nome};
            Cargo atual: {funcionario.Cargo};
            ");


            if (funcionario.Promover("Vendedor"))
            {
                Console.WriteLine(@$"Dados do funcionário:
                Nome: {funcionario.Nome};
                Cargo atual: {funcionario.Cargo};
                ");
            }

            Console.WriteLine("------- Instânciando um objeto: Pedido -------\n");
            Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
            pedido.ExibirPedido();
            pedido.AtualizarStatus("Enviado");
            pedido.ExibirPedido();

            Console.WriteLine("------- Instânciando um objeto: Consulta -------\n");
            Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
            consulta.ExibirResumo();
            consulta.Reagendar(new DateTime(2025, 5, 25));
            consulta.ExibirResumo();

            Console.WriteLine("------- Instânciando um objeto: Produto Digital -------\n");
            InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
            ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
            produto.ExibirDetalhes();

        }
    }
}
