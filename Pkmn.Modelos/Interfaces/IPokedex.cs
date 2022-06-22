using Pkmn.Modelos.Clases;

namespace Pkmn.Modelos.Interfaces
{
    public interface IPokedex
    {
        string IdentificarPkmn(Pokemon p);
        string ObtenerFicha(string nombre);
    }
}