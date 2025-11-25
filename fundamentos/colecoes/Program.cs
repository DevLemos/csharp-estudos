using model.ColecoesBase;

namespace colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<ColecoesBase> colecoes = new List<ColecoesBase>
            {
                new ColecaoArray(),
                new ColecaoHashtable(),
                new ColecaoLinkedListGenerica(),
                new ColecaoSortedDictionaryGenerica(),
                new ColecaoSortedSetGenerica(),
                new ColecaoListGenerica(),
                new ColecaoHashSetGenerica(),
                new ColecaoDictionaryGenerica(),
                new ColecaoSortedList(),
                new ColecaoStack(),
                new ColecaoQueue()
            };

            foreach (ColecoesBase colecao in colecoes)
            {
                colecao.Colecao();
            }

        }
    }
}
