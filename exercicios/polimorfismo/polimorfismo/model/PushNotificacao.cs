namespace polimorfismo.model
{
    class PushNotificacao : INotificacao
    {
        public string EnviarMensagem(string mensagem)
        {
            return $"Enviando PUSH: {mensagem}";
        }
    }
}
