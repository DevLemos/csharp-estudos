using ScreenSound.Models;

namespace ScreenSound.Interfaces
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}
