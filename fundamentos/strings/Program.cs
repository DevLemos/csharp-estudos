using System;
using model.MetodosBase;
using model.EscapesBase;
using System.Text.RegularExpressions;

namespace strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<MetodosBase> metodos = new List<MetodosBase>
            {
                new MetodoSplit(),
                new MetodoReplace(),
                new MetodoEndsWith(),
                new MetodoIndexOf(),
                new MetodoLength()
            };

            foreach (var exemplo in metodos)
            {
                exemplo.Metodo();
            }

            List<EscapesBase> exemplos = new List<EscapesBase>
            {
                new ExemploTabulacao()
            };

            foreach (var item in exemplos)
            {
                item.Exemplo();
            }

            Console.WriteLine("\n------ Exemplo RegEx 01 ------\n");

            Console.Write("Digite sua chave PIX: ");
            string chavePix = Console.ReadLine();

            string padraoCPF = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            string padraoCNPJ = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
            string padraoTelefone = @"^\(\d{2}\)\d{4,5}-\d{4}$";
            string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            string tipoChave;

            if (Regex.IsMatch(chavePix, padraoCPF))
                tipoChave = "CPF";
            else if (Regex.IsMatch(chavePix, padraoCNPJ))
                tipoChave = "CNPJ";
            else if (Regex.IsMatch(chavePix, padraoTelefone))
                tipoChave = "Telefone";
            else if (Regex.IsMatch(chavePix, padraoEmail))
                tipoChave = "E-mail";
            else
                tipoChave = "Formato inválido!";

            Console.WriteLine($"O tipo da chave PIX é: {tipoChave}");

            Console.WriteLine("\n------ Exemplo RegEx Agrupado 02 ------\n");
            string email = "teste@gmail.com";
            string padraoEmailAgrupado = @"(^[a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$)";

            string dominio = Regex.Match(email, padraoEmailAgrupado).Groups[2].Value;
            Console.WriteLine($"Domínio do seu email: {dominio}");

            Console.WriteLine("\n------ Exemplo RegEx Código Cupom 03 ------\n");
            Console.Write("Digite o código do cupom: ");
            string cupom = Console.ReadLine();
            string cupomPadrao = @"^\d+$";
            bool cupomValido = Regex.IsMatch(cupom, cupomPadrao);

            if (cupomValido)
                Console.WriteLine("O código do cupom é válido!");
            else
                Console.WriteLine("O código do cupom é inválido!");

            Console.WriteLine("\n------ Exemplo RegEx Recibo 04 ------\n");
            Console.WriteLine("Digite o texto do recibo: ");
            string texto = Console.ReadLine();
            string regex01 = @"R\$ \d+,\d{2}";

            string valor = Regex.Match(texto, regex01).Value;

            Console.WriteLine("Valor encontrado: " + valor);

            Console.WriteLine("\n------ Exemplo RegEx Espaços em branco 05 ------\n");
            Console.WriteLine("Digite sua frase: ");
            string frase = Console.ReadLine();
            string regex02 = @"\s+";

            string fraseLimpa = Regex.Replace(frase, regex02, " ").Trim();
            Console.WriteLine($"Frase antiga: {frase}");
            Console.WriteLine($"Frase nova: {fraseLimpa}");

            Console.WriteLine("\n------ Exemplo RegEx Substituindo links 06 ------\n");
            Console.WriteLine("Digite o texto: ");
            string textoDois = Console.ReadLine();

            string regex03 = @"https?://\S+";
            string resultado = Regex.Replace(textoDois, regex03, "[LINK]");
            Console.WriteLine(resultado);
        }
    }
}
