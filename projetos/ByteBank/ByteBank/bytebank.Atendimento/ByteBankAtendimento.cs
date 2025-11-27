using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
    internal class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
             new ContaCorrente(23) { Saldo = 100, Titular = new Cliente { Cpf = "5454", Nome = "Carlos Henrique" }},
             new ContaCorrente(23) { Saldo = 100, Titular = new Cliente { Cpf = "5454", Nome = "Carlos Henrique" }},
             new ContaCorrente(23) { Saldo = 100, Titular = new Cliente { Cpf = "5454", Nome = "Carlos Henrique" }},
             new ContaCorrente(22) { Saldo = 100, Titular = new Cliente { Cpf = "5454", Nome = "Kauan Henrique" }},
             new ContaCorrente(21) { Saldo = 200, Titular = new Cliente { Cpf = "54367657", Nome = "Carlos Henrique" }},
             new ContaCorrente(211) { Saldo = 50, Titular = new Cliente { Cpf = "232", Nome = "Carlos Henrique" }},
             new ContaCorrente(234) { Saldo = 50, Titular = new Cliente { Cpf = "34544655546", Nome = "Carlos Henrique" }}
        };

        public void AtendimentoCliente()
        {
            try
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
                    Console.WriteLine("======5              Pesquisar Conta                ======");
                    Console.WriteLine("======6              Sair do Sistema                ======");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("Digite a opção desejada: ");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception ex)
                    {
                        throw new ByteBankException(ex.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverContas();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;


                    }
                }
            }
            catch (ByteBankException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Encerrando aplicação...");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("======              PESQUISAR CONTAS                ======");
            Console.WriteLine("==========================================================");
            Console.WriteLine("\n");

            Console.WriteLine("Deseja pesquisar por (1) NÚMERO DA CONTA - (2) CPF TITULAR - (3) NÚMERO DA AGÊNCIA ?");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Informe o número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do Titular: ");
                        string _cpfTitular = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaCpfTitular(_cpfTitular);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Informe o número da Agência: ");
                        int numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaAgencia(numeroAgencia);
                        ExibirListaContas(contasPorAgencia);

                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.Write("Opção não implementada.");
                        break;
                    }

            }
        }

        private void ExibirListaContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("A consulta não retornou dados...");
            }
            else
            {
                foreach (var conta in contasPorAgencia)
                {
                    Console.WriteLine(conta.ToString());
                }
            }
        }

        private List<ContaCorrente> ConsultaAgencia(int numeroAgencia)
        {
            var consulta = (from conta in _listaDeContas
                            where conta.Numero_agencia == numeroAgencia
                            select conta).ToList();

            return consulta;
        }

        private ContaCorrente ConsultaCpfTitular(string? cpfTitular)
        {
            return _listaDeContas.Where(conta => conta.Titular.Cpf.Equals(cpfTitular)).FirstOrDefault();
        }

        private ContaCorrente ConsultaNumeroConta(string? numeroConta)
        {
            var consulta = (from conta in _listaDeContas
                            where conta.Conta == numeroConta
                            select conta).FirstOrDefault();

            return consulta;
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenada");
            Console.ReadKey();
        }

        private void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("======                REMOVER CONTAS                ======");
            Console.WriteLine("==========================================================");
            Console.WriteLine("\n");

            Console.Write("Informe o número da conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item; break;
                }
            }

            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.Write("Conta foi removida da lista!");
            }
            else
            {
                Console.Write("Conta para remoção não encontrada");
            }

            Console.ReadKey();

        }

        private void ListarContas()
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
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("======              CADASTRO DE CONTAS              ======");
            Console.WriteLine("==========================================================");
            Console.WriteLine("\n");
            Console.WriteLine("======              Informe dados da conta          ======");
            Console.Write("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número da Conta [NOVA]: {conta.Conta}");

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

    }
}
