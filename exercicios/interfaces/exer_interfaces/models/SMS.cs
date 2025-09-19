using exer_interfaces.interfaces;

namespace exer_interfaces.models
{
    public class SMS : INotificavel
    {
        public string NumeroTelefone { get; set; }

        public void EnviarNotificacao()
        {
            Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
        }
    }
}
