using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente();

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