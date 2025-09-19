using polimorfismo.model;

Console.WriteLine("------- Exercicio 01 -------");
Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));

Console.WriteLine("------- Exercicio 02 -------");
Funcionario funcionario01 = new Gerente();
Funcionario funcionario02 = new Desenvolvedor();

Console.WriteLine(funcionario01.GerarRelatorio());
Console.WriteLine(funcionario02.GerarRelatorio());

Console.WriteLine("------- Exercicio 03 -------");
List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};

foreach(var notificacao in notificacoes)
{
    Console.WriteLine(notificacao.EnviarMensagem("Sistema fora do ar!"));
}