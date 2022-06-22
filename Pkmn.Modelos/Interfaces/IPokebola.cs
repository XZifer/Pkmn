using Pkmn.Modelos.Clases;

namespace Pkmn.Modelos.Interfaces
{
    public interface IPokebola
    {
        Pokemon? pokemonDentroPokebola { get; set; }

        bool EsOcupada();
    }
}