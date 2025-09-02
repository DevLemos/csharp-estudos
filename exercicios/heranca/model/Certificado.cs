namespace heranca.model
{
    class Certificado
    {
        public Certificado(Profissao profissao) 
        {
            Console.WriteLine($"Certificado emitido para {profissao.Titulo}");
        }
    }
}
