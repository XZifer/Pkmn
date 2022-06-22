using Pkmn.Modelos.Enumeradores;
using Pkmn.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Modelos.Clases
{
    public class Jugador
    {
        public Sexo? Sexo { get; set; }
        public int Edad { get; set; }
        public string Usuario { get; set; }
        public string Pasword { get; set; }
        public IPokedex Pokedex { get; set; }
        public List<IPokebola> Pokebolas { get; set; } = new List<IPokebola>();
    }
}
