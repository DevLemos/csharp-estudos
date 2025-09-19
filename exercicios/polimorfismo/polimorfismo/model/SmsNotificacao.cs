namespace polimorfismo.model
{
    class SmsNotificacao : INotificacao
    {
        public string EnviarMensagem(string mensagem)
        {
            return $"Enviando SMS: {mensagem}";
        }
    }
}
