using Pkmn.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Modelos.Clases
{
    public class Pokemon
    {
        public string Nombre { get; set; }
        public Tipo TipoPokemon { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public Sexo Sexo { get; set; }
        public int Vida { get; set; }
        public string Descripcion { get; set; }
    }
}
