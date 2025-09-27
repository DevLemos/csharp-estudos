using System.Collections.Generic;

namespace model.ColecoesBase
{
    public abstract class ColecoesBase
    {
        public abstract void Colecao();
    }

    public class ColecaoArray : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção básica: Array -------\n");
            Console.WriteLine("Primeiro exemplo para instanciar\n");
            string[] funcionarios1 = { "João", "Maria", "Cláudia", "Oscar" };
            Console.WriteLine($"Acessando valores: {funcionarios1[1]}");

            Console.WriteLine("\nSegundo exemplo para instanciar\n");
            string[] funcionarios2 = new string[4];
            Console.WriteLine($"Instanciando valores: {funcionarios2[0] = "João"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[1] = "Maria"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[2] = "Cláudia"}");
            Console.WriteLine($"Instanciando valores: {funcionarios2[3] = "Oscar"}");

            Console.WriteLine("\nTerceiro exemplo, percorrendo array com for\n");
            for (int i = 0; i < funcionarios1.Length; i++)
            {
                Console.WriteLine(funcionarios1[i]);
            }

            Console.WriteLine("\nQuarto exemplo, percorrendo array com foreach\n");
            foreach (string nome in funcionarios1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nQuinto exemplo, achando indice do elemento\n");
            int indice = Array.IndexOf(funcionarios2, "Maria");
            Console.WriteLine("Indice: {0}", indice);

            Console.WriteLine("\nSexto exemplo, Limitações de array\n");
            string[] novoArray = new string[5];
            Array.Copy(funcionarios1, novoArray, funcionarios1.Length);
            foreach (string nome in novoArray)
            {
                Console.WriteLine(nome);
            }
            novoArray[4] = "Joana";

        }
    }

    public class ColecaoListGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------ List: Implementação 01 ------\n");
            Console.WriteLine("Instanciando com valores");
            List<string> listaFuncionarios1 = new List<string>
            {
                "joão","Maria","Cláudia","Oscar"
            };

            foreach (string nome in listaFuncionarios1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\n------ List: Implementação 02 ------\n");
            Console.WriteLine("Instanciando sem valores e adicionando depois");
            List<string> listaFuncionarios2 = new List<string>();
            listaFuncionarios2.Add("Roberto");
            listaFuncionarios2.Add("Erick");
            listaFuncionarios2.Add("Carlos");
            listaFuncionarios2.Add("Brenda");

            for (int i = 0; i < listaFuncionarios2.Count; i++)
            {
                Console.WriteLine("Funcionário: " + listaFuncionarios2[i]);
            }

            Console.WriteLine("\n------ List: Métodos nativos ------\n");
            Console.WriteLine("utilizando métodos Add(), Remove(), Sort(), IndexOf() e Reverse()\n");
            List<string> listaConvidados = new List<string>();
            Console.WriteLine("Adicionando convidados...");
            listaConvidados.Add("Roberto");
            listaConvidados.Add("Erick");
            listaConvidados.Add("Carlos");
            listaConvidados.Add("Brenda");
            listaConvidados.Add("Juan");
            listaConvidados.Add("Alex");
            foreach (string nome in listaConvidados)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nRemovendo convidados...");
            listaConvidados.Remove("Roberto");
            listaConvidados.Remove("Erick");
            foreach (string nome in listaConvidados)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nOrdenando convidados...");
            listaConvidados.Sort();
            foreach (string nome in listaConvidados)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nInvertendo convidados...");
            listaConvidados.Reverse();
            foreach (string nome in listaConvidados)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nBuscando indice do convidado...");
            int indice = listaConvidados.IndexOf("Brenda");
            Console.WriteLine("Indice da convidada Brenda: " + indice);
        }
    }

    public class ColecaoHashSetGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("\n------ HashSet: Implementação 01 ------\n");
            HashSet<string> setFuncionarios1 = new HashSet<string>
            {
                "João","Pedro", "Caio", "Bianca", "Joana"
            };
            foreach (string nome in setFuncionarios1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\n------ HashSet: Implementação 02 ------\n");
            HashSet<string> setFuncionarios2 = new HashSet<string>();
            setFuncionarios2.Add("Carlos");
            setFuncionarios2.Add("Bruna");
            setFuncionarios2.Add("Wendel");
            setFuncionarios2.Add("Kauan");
            setFuncionarios2.Add("Lucas");

            foreach (string nome in setFuncionarios2)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\n------ HashSet: Método Contains() ------\n");
            if (setFuncionarios2.Contains("Carlos"))
                Console.WriteLine("O funcionário Carlos contém no meu conjunto.");
            else
                Console.WriteLine("O funcionário Carlos não existe no meu conjunto.");

        }
    }

    public class ColecaoDictionaryGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("\n------ Dictionary: Implementação 01 ------\n");
            Console.WriteLine("Inicializando com valores\n");
            Dictionary<int, string> produtos1 = new Dictionary<int, string>
            {
                { 4587963, "Teclado" },
                { 3374561, "Cadeira gamer" },
                { 2456987, "Notebook" },
                { 6356984, "Teclado" },
                { 8647921, "Mouse" }
            };

            foreach (var produto in produtos1)
            {
                Console.WriteLine($"Produto: {produto.Value}, ID: {produto.Key}");
            }

            Console.WriteLine("\n------ Dictionary: Implementação 02 ------\n");
            Console.WriteLine("Inicializando sem valores, adicionando depois pelo método Add()\n");
            Dictionary<int, string> produtos2 = new Dictionary<int, string>();
            produtos2.Add(4587963, "Teclado");
            produtos2.Add(3374561, "Cadeira gamer");
            produtos2.Add(2456987, "Notebook");
            produtos2.Add(6356984, "Teclado");
            produtos2.Add(8647921, "Mouse");


            foreach (var produto in produtos2)
            {
                Console.WriteLine($"Produto: {produto.Value}, ID: {produto.Key}");
            }

            Console.WriteLine("\n------ Dictionary: Busca pela chave ------\n");
            Dictionary<string, string> palavras = new Dictionary<string, string>
            {
                {"olá", "hello"},
                {"mundo","world"}
            };

            Console.WriteLine($"A tradução de olá é {palavras["olá"]}");

            Console.WriteLine("\n------ Dictionary: percorrendo ------\n");
            foreach (KeyValuePair<string, string> palavra in palavras)
            {
                Console.WriteLine($"Português: {palavra.Key}, Inglês: {palavra.Value}");
            }
        }
    }
}