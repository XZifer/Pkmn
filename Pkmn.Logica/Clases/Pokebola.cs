using Pkmn.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Logica.Clases
{
    public class Pokebola
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
