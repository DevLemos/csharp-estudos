using System;
using System.Globalization;

namespace concatenacao_placeholders_interpolacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------- Concatenação ---------\n");
            string nome = "Kauan";
            int idade = 23;

            //Operador +
            string resultado1 = "Olá " + nome + ", você tem " + idade + " anos" + "\n"; // saída: Olá Kauan, você tem 23 anos

            //String.Concat(mais eficiente para multiplas strings)
            string resultado2 = String.Concat("Nome: ", nome, " | Idade: ", idade + "\n"); // saída: Nome: Kauan | Idade: 23
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            //Concatenação em loop (problemático)
            string lista = "";

            for (int i = 1; i <= 3; i++)
            {
                lista = lista + "Item : " + i + ", ";
                Console.WriteLine(lista);
            }

            Console.WriteLine("\n--------- Placeholders ---------\n");

            string nome2 = "Maria";
            int idade2 = 30;
            decimal salario = 3500.75m;
            DateTime data = new DateTime(2002, 02, 20);

            //Básico - substitui {0} por nome, {1} por idade
            string resultado3 = String.Format("Nome: {0} | Idade: {1}", nome2, idade2); // saída: Nome: Maria | Idade: 30
            Console.WriteLine(resultado3);

            //Com formatação especifica
            string resultado4 = String.Format("Salário: {0:C} | Data: {1:dd/MM/yyyy}", salario, data); // saída: Salário: $3,500.75 | Data: 20/02/2002
            Console.WriteLine(resultado4);

            //Reutilização de argumentos
            string resultado5 = String.Format("{0} trabalha aqui. {0} recebe por mês {1:C}", nome2, salario); // saída: Maria trabalha aqui. Maria recebe por mês $3,500.75
            Console.WriteLine(resultado5);

            //Alinhamento e largura
            // Resultado: "| Maria           |    30 | R$ 3.500,75 |"
            //                 ↑ 15 chars esquerda  ↑ 5 chars direita  ↑ 10 chars direita
            string tabela = String.Format("\n| {0,-15} | {1,5} | {2,10:C} |", nome2, idade2, salario);
            Console.WriteLine(tabela);

            // Console.WriteLine usa o mesmo sistema
            Console.WriteLine("\nProduto: {0}, Preço: {1:F2}", "Notebook", 2500.99); // saída: Produto: Notebook, Preço: 2500.99

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                   "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82,
                    40.333m, 80, 16.75m };

            Console.WriteLine("\n{0,-20} {1,5}\n", "Name", "Hours");

            for (int counter = 0; counter < names.Length; counter++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[counter], hours[counter]);

            // The example displays the following output:
            //      Name                 Hours
            //      
            //      Adam                  40.0
            //      Bridgette              6.7
            //      Carla                 40.4
            //      Daniel                82.0
            //      Ebenezer              40.3
            //      Francine              80.0
            //      George                16.8

            //chaves de escape
            string teste = "chaves";
            Console.WriteLine("|{{{0,-20}}}|", teste);

            Console.WriteLine("\n--------- Interpolação ---------\n");

            string nome3 = "José";
            int idade3 = 30;
            decimal salario2 = 3500.75m;

            // Básico - variáveis diretas
            Console.WriteLine($"Nome: {nome3}, Idade: {idade3}");

            //// Com formatação
            Console.WriteLine($"Salário: {salario2:C}");

            // Com expressões matemáticas
            Console.WriteLine($"Você nasceu em {DateTime.Now.Year - idade3}");

            // Com operador ternário
            Console.WriteLine($"Status: {(idade3 >= 18 ? "Adulto" : "Menor")}");

            // Com métodos
            Console.WriteLine($"Nome maiúsculo: {nome3.ToUpper()}");

            // Com propriedades/métodos de objetos
            DateTime data2 = new DateTime(2023, 12, 25);
            Console.WriteLine($"Hoje é {data2.DayOfWeek} e estamos no mês {data2.Month}");

            // Alinhamento (igual aos placeholders)
            Console.WriteLine($"| {nome3,-15} | {idade3,5} | {salario2,10:C} |");

            // Multilinha com expressão
            Console.WriteLine($@"
            === RELATÓRIO FUNCIONÁRIO ===
            Nome: {nome3}
            Idade: {idade3}
            Salário: {salario2:C}
            Categoria: {(salario2 > 4000 ? "Sênior" : "Júnior")}
            Data: {DateTime.Now:dd/MM/yyyy HH:mm}");

            var culturaBR = new CultureInfo("pt-BR");
            var culturaUS = new CultureInfo("en-US");

            Console.WriteLine($"Interpolação com cultura especifica, salário BR: {salario2.ToString("C", culturaBR)}");
            Console.WriteLine($"Interpolação com cultura especifica, salário US: {salario2.ToString("C", culturaUS)}");
        }
    }
}