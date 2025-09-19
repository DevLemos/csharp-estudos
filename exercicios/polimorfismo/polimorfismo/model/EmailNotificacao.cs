namespace polimorfismo.model
{
    class EmailNotificacao : INotificacao
    {
        public string EnviarMensagem(string mensagem)
        {
            return $"Enviando E-MAIL: {mensagem}";
        }
    }
}
