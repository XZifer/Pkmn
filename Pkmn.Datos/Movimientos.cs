using Pkmn.Modelos.Clases;
using Pkmn.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn.Datos
{
    public class Movimientos
    {
        public List<Movimiento> ListaMovimientos { get; set; } = new List<Movimiento>();
        public Movimientos()
        {
            Movimiento Placaje = new()
            {
                Nombre = "Placaje",
                Tipo = Tipo.Normal,
                Potencia = 20
            };
            Movimiento Latigo = new()
            {
                Nombre = "Latigo",
                Tipo = Tipo.Normal,
                Potencia = 0
            };
            Movimiento Burbuja = new()
            {
                Nombre = "Burbuja",
                Tipo = Tipo.Agua,
                Potencia = 30
            };
            ListaMovimientos.Add(Placaje);
            ListaMovimientos.Add(Latigo);
            ListaMovimientos.Add(Burbuja);
        }
        public List<Movimiento> ObtenerMovimiento()
        {
            return ListaMovimientos;
        }
    }
}
