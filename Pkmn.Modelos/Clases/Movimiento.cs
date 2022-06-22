using Pkmn.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Modelos.Clases
{
    public class Movimiento
    {
        public string Nombre { get; set; }
        public Tipo Tipo { get; set; }
        public int Potencia { get; set; }
    }
}
