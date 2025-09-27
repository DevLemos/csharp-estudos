using System;
using model.EstruturaControle;

namespace estruturas_de_controle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<EstruturaControle> exemplosEstrutura = new List<EstruturaControle>
            {
                new EstruturaIf(),
                new EstruturaSwitch(),
                new EstruturaFor(),
                new EstruturaWhile(),
                new EstruturaDoWhile(),
                new EstruturaForeach()
            };

            foreach (var estrutura in exemplosEstrutura)
            {
                estrutura.Metodo();
            }
        }
    }
}
