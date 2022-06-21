using Pkmn.Datos;
using Pkmn.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Logica.Clases
{
    public class Pokedex
    {
        public string ObtenerFicha(string nombre)
        {
            Pokemones pokemones = new Pokemones();
            Pokemon[] pokemonesArreglo = pokemones.ObtenerPkmns();
            string ficha="";
            for (int i = 0; i < pokemonesArreglo.Length; i++)
            {
                Pokemon pokemonSeleccionado = pokemonesArreglo[i];
                if (pokemonSeleccionado.Nombre == nombre)
                {
                    ficha = IdentificarPkmn(pokemonSeleccionado);
                }
            }
            return ficha;
        }

        public string IdentificarPkmn(Pokemon p)
        {
            return p.Nombre + "\n" +
                            "Un pokemon de Tipo:" + p.TipoPokemon + "\n" +
                            "Peso:" + p.Peso + "kilos\n" +
                            "Altura:" + p.Altura + "metros\n" +
                            "Descripcion:" + p.Descripcion; ;
        }
    }
}
