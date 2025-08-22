using System;

namespace classes_e_objetos.model
{
    public class Produto
    {
        public string nome;
        public string descricao;
        public decimal preco;
        public int estoque;

        public bool EstaDisponivel()
        {
            return estoque > 0;
        }

        public void AlterarPrecoComDesconto(decimal desconto)
        {
            preco = preco * (1 - desconto);
        }
    }
}