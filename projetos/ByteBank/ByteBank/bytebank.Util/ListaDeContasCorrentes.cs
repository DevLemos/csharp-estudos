using System;
using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _contas = null;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanho = 5)
        {
            _contas = new ContaCorrente[tamanho];
        }

        public void Adicionar(ContaCorrente conta)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _contas[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanho)
        {
            if (_contas.Length >= tamanho)
            {
                return;
            }
            Console.WriteLine("\nAumentando a capacidade da lista");
            ContaCorrente[] novoArray = new ContaCorrente[tamanho];

            for (int i = 0; i < _contas.Length; i++)
            {
                novoArray[i] = _contas[i];
            }

            _contas = novoArray;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceConta = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _contas[i];

                if (contaAtual == conta)
                {
                    indiceConta = i;
                    break;
                }
            }

            for (int i = indiceConta; i < _proximaPosicao - 1; i++)
            {
                _contas[i] = _contas[i + 1];
            }
            _proximaPosicao--;
            _contas[_proximaPosicao] = null;
        }

        public ContaCorrente RecuperarContaIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _contas[indice];
        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaIndice(indice);
            }
        }

        public void ExibirLista()
        {
            for (int i = 0; i < _contas.Length; i++)
            {
                if (_contas[i] != null)
                {
                    Console.WriteLine($"Indice: [{i}], Conta: {_contas[i].Conta}, Agência: {_contas[i].Numero_agencia}, Saldo: {_contas[i].Saldo.ToString("C")}");
                }
            }
        }

        public ContaCorrente MaiorSaldo()
        {
            ContaCorrente conta = null;

            double maiorValor = 0;

            for (int i = 0; i < _contas.Length; i++)
            {
                if (_contas[i] != null)
                {
                    if (maiorValor < _contas[i].Saldo)
                    {
                        maiorValor = _contas[i].Saldo;
                        conta = _contas[i];
                    }
                }
            }

            return conta;
        }
    }
}
