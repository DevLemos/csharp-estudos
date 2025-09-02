namespace heranca.model
{
    class SensorTemperatura : Isensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de temperatura ativado.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de temperatura desativado.");
        }
    }
}
