namespace heranca.model
{
    class SensorPresenca : Isensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença ativado.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de presença desativado.");
        }
    }
}
