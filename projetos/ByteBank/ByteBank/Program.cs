using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Indexação
//void TestaArrayDeContas()
//{
//    ListaDeContasCorrentes listaContasCorrente = new ListaDeContasCorrentes(3);
//    listaContasCorrente.Adicionar(new ContaCorrente(873));
//    listaContasCorrente.Adicionar(new ContaCorrente(874));
//    listaContasCorrente.Adicionar(new ContaCorrente(875));
//    listaContasCorrente.Adicionar(new ContaCorrente(876));
//    listaContasCorrente.Adicionar(new ContaCorrente(877));  

//    var contaKauan = new ContaCorrente(1);
//    listaContasCorrente.Adicionar(contaKauan);
//    //listaContasCorrente.ExibirLista();
//    //Console.WriteLine("===================================");
//    //listaContasCorrente.Remover(contaKauan);
//    //listaContasCorrente.ExibirLista();

//    for(int i = 0; i < listaContasCorrente.Tamanho; i++)
//    {
//        ContaCorrente conta = listaContasCorrente[i];
//        Console.WriteLine($"Indice [{i}], Conta: {conta.Conta}/{conta.Numero_agencia}");
//    }
//}

//TestaArrayDeContas();
#endregion

#region ArrayList
//ArrayList _listaDeContas = new ArrayList()
//{
//    new ContaCorrente(23, "34354") { Saldo = 100},
//    new ContaCorrente(21, "2222") { Saldo = 200},
//    new ContaCorrente(211, "3534543") { Saldo = 50}
//};
#endregion

#region Generics
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá Mundo!");
//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}
#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
     new ContaCorrente(23, "34354") { Saldo = 100},
     new ContaCorrente(21, "2222") { Saldo = 200},
     new ContaCorrente(211, "3534543") { Saldo = 50}
};

//AtendimentoCliente();
void AtendimentoCliente()
{
    char opcao = '0';

    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("==========================================================");
        Console.WriteLine("======               ATENDIMENTO                    ======");
        Console.WriteLine("======1              Cadastrar Conta                ======");
        Console.WriteLine("======2              Listar Conta                   ======");
        Console.WriteLine("======3              Remover Conta                  ======");
        Console.WriteLine("======4              Ordenar Conta                  ======");
        Console.WriteLine("======5              Registrar Conta                ======");
        Console.WriteLine("======6              Sair do Sistema                ======");
        Console.WriteLine("==========================================================");
        Console.WriteLine("\n\n");

        Console.WriteLine("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];

        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            case '3':

                break;
            case '4':

                break;
            case '5':

                break;
            case '6':

                break;


        }
    }

}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("==========================================================");
    Console.WriteLine("======                 LISTAR CONTAS                ======");
    Console.WriteLine("==========================================================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count == 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("==== Dados da Conta ====");
        Console.WriteLine("Número da conta: " + item.Conta);
        Console.WriteLine("Saldo da conta: " + item.Saldo);
        Console.WriteLine("Titular da conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular: " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("==========================================================");
    Console.WriteLine("======              CADASTRO DE CONTAS              ======");
    Console.WriteLine("==========================================================");
    Console.WriteLine("\n");
    Console.WriteLine("======              Informe dados da conta          ======");

    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe Nome do titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe CPF do titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe Profissão do titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ... ");
    Console.ReadKey();
}

