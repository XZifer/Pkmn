using Pkmn.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Modelos.Clases
{
    internal class Jugador
    {
        public Sexo SexoEntrenador { get; set; }
        public int Edad { get; set; }
        public string Usuario { get; set; }
        public string Pasword { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Pokemon[] Pkdex { get; set; }
        public Pokemon[] Pokebolas { get; set; }
    }
}
