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
                new ColecaoListGenerica(),
                new ColecaoHashSetGenerica(),
                new ColecaoDictionaryGenerica()
            };

            foreach (ColecoesBase colecao in colecoes)
            {
                colecao.Colecao();
            }

        }
    }
}
