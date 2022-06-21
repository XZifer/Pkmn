using Pkmn.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Datos
{
    public class Pokebolas
    {
        public List<Pokebola> ListaPokemones { get; set; } = new List<Pokebola>();
        public Pokebolas()
        {
            Pokebola pkball = new()
            {
                PokebolaNombre = "Pokeball"
            };
        }
    }
}
