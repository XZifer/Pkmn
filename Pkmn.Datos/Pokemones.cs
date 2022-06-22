using Pkmn.Modelos.Clases;
using Pkmn.Modelos.Enumeradores;

namespace Pkmn.Datos
{
    public class Pokemones
    {
        public List<Pokemon> ListaPokemones { get; set; } = new List<Pokemon>();
        public Pokemones()
        {
            Pokemon s = new()
            {
                Nombre = "Squirtle",
                TipoPokemon = Tipo.Agua,
                Peso = 14.0m,
                Altura = 0.65m,
                Sexo = Sexo.Masculino,
                Vida = 100,
                Descripcion = "Esta pequeña tortuga Pokémon jala su largo cuello hacia su caparazón\n" +
                  "para lanzar increíbles ataques de agua con sorprendente alcance y exactitud.\n" +
                  "El golpe puede ser muy poderoso.\n"
            };
            Pokemon p = new()
            {
                Nombre = "Pinsir",
                TipoPokemon = Tipo.Bicho,
                Peso = 55.0m,
                Altura = 1.5m,
                Sexo = Sexo.Femenino,
                Vida = 85,
                Descripcion = ""
            };

            Pokemon b = new()
            {
                Nombre = "Bulbasaur",
                TipoPokemon = Tipo.Planta,
                Peso = 10.0m,
                Altura = 0.5m,
                Sexo = Sexo.Masculino,
                Vida = 80,
                Descripcion = ""
            };
            Pokemon c = new()
            {
                Nombre = "Charmander",
                TipoPokemon = Tipo.Fuego,
                Peso = 15.0m,
                Altura = 0.75m,
                Sexo = Sexo.Masculino,
                Vida = 70,
                Descripcion = ""
            };
            Pokemon pi = new()
            {
                Nombre = "Picachu",
                TipoPokemon = Tipo.Electrico,
                Peso = 10.0m,
                Altura = 85.0m,
                Sexo = Sexo.Masculino,
                Vida = 80,
                Descripcion = ""
            };
            ListaPokemones.Add(s);
            ListaPokemones.Add(p);
            ListaPokemones.Add(b);
            ListaPokemones.Add(c);
            ListaPokemones.Add(pi);
        }
        public Pokemon[] ObtenerPkmns()
        {
            return ListaPokemones.ToArray();
        }
        
        public Pokemon ObtenPkmnPorNombre(string nombre)
        {
            Pokemon elegido = null;
            foreach (Pokemon p in ListaPokemones)
            {
                if (p.Nombre == nombre)
                {
                    elegido = p;
                }
            }
            return elegido;
        }

        public List<Pokemon> ObtenPkmnDeInicio()
        {
            List<Pokemon> pokemonesInicio = new List<Pokemon>();
            foreach (Pokemon p in ListaPokemones)
            {
                if (p.Nombre == "Squirtle" || p.Nombre == "Bulbasaur" || p.Nombre == "Charmander")
                {
                    pokemonesInicio.Add(p);
                }
            }
            return pokemonesInicio;
        }

    }
}