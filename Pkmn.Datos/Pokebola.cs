using Pkmn.Modelos.Clases;
using Pkmn.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Datos
{
    public class Pokebola : IPokebola
    {
        public Pokemon? pokemonDentroPokebola { get; set; }

        public bool EsOcupada()
        {
            if (pokemonDentroPokebola == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            //return pokemonDentroPokebola != null;   
        }
    }
}
