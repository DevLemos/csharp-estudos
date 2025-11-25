using System;
using System.Collections;
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

    public class ColecaoHashtable : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção: Hashtable -------\n");
            Console.WriteLine("Instanciando um Hashtable\n");

            Hashtable tabela = new Hashtable();

            Console.WriteLine("Adicionando valores...");
            tabela.Add("BR", "Brasil");
            tabela.Add("US", "Estados Unidos");
            tabela.Add("JP", "Japão");
            tabela.Add(1, "Número um");
            tabela.Add(2, "Número dois");

            Console.WriteLine("\nPercorrendo elementos adicionados\n");
            foreach (DictionaryEntry item in tabela)
            {
                Console.WriteLine($"Chave: {item.Key} e Valor: {item.Value}");
            }

            Console.WriteLine("\nAcessando valores adicionados por chave\n");
            Console.WriteLine($"{(string)tabela["BR"]}");

            Console.WriteLine("\nModificando valores adicionados por chave\n");
            tabela["BR"] = "República Federativa do Brasil";
            Console.WriteLine($"{(string)tabela["BR"]}");

            Console.WriteLine("\nVerificando se a chave existe\n");
            if (tabela.ContainsKey("US"))
            {
                Console.WriteLine($"Encontrado: {tabela["US"]}");
            }

            Console.WriteLine("\nVerificando se o valor existe\n");
            if (tabela.ContainsValue("Japão"))
            {
                Console.WriteLine("O valor Japão existe na tabela\n");
            }

            Console.WriteLine("Removendo valores...\n");
            tabela.Remove("US");
            Console.WriteLine("Estados Unidos removido\n");

            foreach (DictionaryEntry item in tabela)
            {
                Console.WriteLine($"Chave: {item.Key} e Valor: {item.Value}");
            }

            Console.WriteLine("\nTotal de elementos\n");
            Console.WriteLine($"Total: {tabela.Count}\n");
        }
    }

    public class ColecaoLinkedListGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção: LinkedList -------\n");
            Console.WriteLine("Instanciando um LinkedList\n");

            LinkedList<string> lista = new LinkedList<string>();

            Console.WriteLine("Adicionando elementos...\n");
            lista.AddFirst("Primeiro");
            lista.AddLast("Último");
            lista.AddLast("Penúltimo");

            Console.WriteLine("Percorrendo elementos...\n");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTrabalhando com nós...\n");

            LinkedListNode<string> no = lista.Find("Último");
            if (no != null)
            {
                lista.AddBefore(no, "Antes do último");
                lista.AddAfter(no, "Depois do último");
            }

            Console.WriteLine("Percorrendo elementos...\n");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemovendo elementos...\n");
            lista.Remove("Penúltimo");
            lista.RemoveFirst();
            lista.RemoveLast();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }

    public class ColecaoSortedDictionaryGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção: SortedDictionary -------\n");
            Console.WriteLine("Instanciando um SortedDictionary\n");

            SortedDictionary<int, string> dicionario = new SortedDictionary<int, string>();

            Console.WriteLine("Adicionando elementos...\n");
            dicionario.Add(3, "Três");
            dicionario.Add(1, "Um");
            dicionario.Add(5, "Cinco");
            dicionario.Add(2, "Dois");

            Console.WriteLine("Percorrendo elementos...\n");
            foreach (var item in dicionario)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("\nAcessando por chave...\n");
            Console.WriteLine($"Chave(3), Valor: {dicionario[3]}");

            Console.WriteLine("Modificando valor da chave 2...\n");
            dicionario[2] = "Dois modificado";

            foreach (var item in dicionario)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("\nVerificando se existe a chave...\n");
            if (dicionario.ContainsKey(1))
            {
                Console.WriteLine("Chave 1 existe");
            }

            Console.WriteLine("\nTentando obter valor com segurança da chave...\n");
            if(dicionario.TryGetValue(10, out string resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Chave não encontrada");
            }

            Console.WriteLine("\nRemovendo elemento da chave 3...\n");
            dicionario.Remove(3);

            Console.WriteLine("Percorrendo chaves...\n");
            foreach (int chave in dicionario.Keys)
            {
                Console.WriteLine($"Chave: {chave}");
            }

            Console.WriteLine();
        }
    }

    public class ColecaoSortedSetGenerica : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("------- Coleção: SortedSet -------\n");
            Console.WriteLine("Instanciando um SortedSet\n");

            SortedSet<int> conjunto = new SortedSet<int>();

            Console.WriteLine("Adicionando elementos...\n");
            conjunto.Add(5);
            conjunto.Add(1);
            conjunto.Add(3);
            conjunto.Add(1); // Duplicata - não será adicionada
            conjunto.Add(2);

            Console.WriteLine("Percorrendo elementos...\n");
            foreach (var numero in conjunto)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\nVerificando se existe um elemento...\n");
            bool existe = conjunto.Contains(2);

            if(existe)
                Console.WriteLine("Elemento 2 existe no conjunto\n");
            else
                Console.WriteLine("Elemento 2 não existe no conjunto\n");

            Console.WriteLine("Removendo elementos...\n");
            conjunto.Remove(2);

            foreach (var numero in conjunto)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\nOperações de conjuntos\n");
            SortedSet<int> outroConjunto = new SortedSet<int> { 2, 3, 4, 5, 6 };

            Console.WriteLine("Instânciando um novo conjunto\n");
            Console.WriteLine("Unindo conjuntos...\n");

            // União
            conjunto.UnionWith(outroConjunto);

            foreach (var numero in conjunto)
            {
                Console.WriteLine($"Número: {numero}");
            }

            Console.WriteLine();

            Console.WriteLine("Buscando elementos que não tem no primeiro conjunto mas tem no segundo...\n");
            // Interseção
            conjunto.IntersectWith(outroConjunto);

            foreach (var numero in conjunto)
            {
                Console.WriteLine($"Número: {numero}");
            }

            Console.WriteLine();
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

    public class ColecaoSortedList : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("\n------ SortedList: Implementação 01 ------\n");
            Console.WriteLine("Inicializando com valores\n");

            SortedList<int, string> minhaLista = new SortedList<int, string>();

            minhaLista.Add(3, "Terceiro");
            minhaLista.Add(2, "Segundo");
            minhaLista.Add(1, "Primeiro");

            foreach (KeyValuePair<int, string> item in minhaLista)
            {
                Console.WriteLine($"Id: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine("\n");

            //Percorrendo apenas os valores
            foreach (var item in minhaLista.Values)
            {
                Console.WriteLine($"Item: {item}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Acessando valores");
            string valor = minhaLista[2];
            Console.WriteLine("Valor: " + valor);

            Console.WriteLine("\n");

            Console.WriteLine("Acessando índices e valores");
            int indice = minhaLista.Keys[0];
            string valorIndice = minhaLista.Values[1];
            Console.WriteLine("Chave no índice [0]: " + indice);
            Console.WriteLine("Valor no índice[1]: " + valorIndice);
        }
    }

    public class ColecaoStack : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("\n------ Stack: Implementação 01 ------\n");
            Console.WriteLine("Inicializando a pilha\n");
            Stack<string> pilha = new Stack<string>();

            Console.WriteLine("Adicionando valores...");
            pilha.Push("Primeiro");
            pilha.Push("Segundo");
            pilha.Push("Terceiro");

            Console.WriteLine("Pegando o elemento que está no topo da pilha: " + pilha.Peek() + "\n");

            Console.WriteLine("Removendo valores...");
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());

            if (pilha.Count == 0)
            {
                Console.WriteLine("Pilha vazia!");
            }
        }
    }

    public class ColecaoQueue : ColecoesBase
    {
        public override void Colecao()
        {
            Console.WriteLine("\n------ Queue: Implementação 01 ------\n");
            Console.WriteLine("Inicializando a fila\n");

            Queue<string> filaAtendimento = new Queue<string>();

            Console.WriteLine("Adicionando pessoas na fila...\n");
            filaAtendimento.Enqueue("Carlos");
            filaAtendimento.Enqueue("Alex");
            filaAtendimento.Enqueue("Beatriz");

            Console.WriteLine("Primeira pessoa da fila: ");
            Console.WriteLine(filaAtendimento.Peek());

            Console.WriteLine("\nRemovendo as pessoas da fila...");

            Console.WriteLine(filaAtendimento.Dequeue());
            Console.WriteLine(filaAtendimento.Dequeue());
            Console.WriteLine(filaAtendimento.Dequeue());

            if (filaAtendimento.Count == 0)
            {
                Console.WriteLine("Fila vazia!");
            }
        }
    }
}