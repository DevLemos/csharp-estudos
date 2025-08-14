using model.ColecoesBase;

namespace colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<ColecoesBase> colecoes = new List<ColecoesBase>
            {
                new ColecaoArray()
            };

            foreach (ColecoesBase colecao in colecoes)
            {
                colecao.Colecao();
            }

        }
    }
}
