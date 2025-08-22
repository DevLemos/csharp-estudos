using classes_e_objetos.model;

namespace classes_e_objetos.model
{
    public class ProdutoDigital
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public InformacaoTecnica infoTecnica { get; set; }

        public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
        {
            Nome = nome;
            Preco = preco;
            infoTecnica = info;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco.ToString("0.00")}");
            Console.WriteLine($"Tamanho: {infoTecnica.TamanhoMB}MB");
            Console.WriteLine($"Compatível com: {infoTecnica.SistemaOperacional}");
        }

    }
}