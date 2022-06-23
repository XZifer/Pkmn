using Pkmn.Datos;
using Pkmn.Modelos.Clases;
using Pkmn.Modelos.Enumeradores;

namespace Pkmn.Aplicacion
{ 
    public class Program
    {
        public static void Main()
        {
            //Mensaje de bienvenida
            Console.WriteLine("Bienvenido a Pokemon!!!");
            //Registra usuario
            RegistraUsuario();
            //Selecciona pokemons
            SeleccionaPkmn();
            //Crea Jugador
        }

        private static void RegistraUsuario()
        {
            Jugador jugador = new Jugador();
            Console.WriteLine("Escribe tu Nombre:");
            jugador.Usuario = Console.ReadLine();
            while (jugador.Edad == 0)
            {
                ElegirEdad(jugador);
            }
            Console.WriteLine("Escribe una contraseña: ");
            jugador.Pasword = Console.ReadLine();
            while (jugador.Sexo == null)
            {
                ElegirSexo(jugador);
            }
            Pokedex pokedexNuevo = new Pokedex();
            jugador.Pokedex = pokedexNuevo;
           
        }

        private static void SeleccionaPkmn()
        {
            // Pedir que seleccione un pokemon
            Pokemones pokemonesiniciales = new Pokemones();
            Console.WriteLine("Elije uno de nuestros pokemones iniciales:");

            // Mostrar la lista de los nombres de pokemones disponibles de inicio
            MostrarPokemon(pokemonesiniciales);
            // (Bien podria haberlo puesto con un Console.WriteLine("S-Squirtle\n" + "B-Bulbasaur\n" + "C-Charmander\n")            

            // Pedir que se ingrese (S-Squitle, C-Charmander, B-Bulbasaur) del pokemon que quiere seleccionar
            string YoTeElijo = Console.ReadLine();

            // Obtener el Pokemon pokemonSeleccionado = ???? Pokemones.ObtenPkmnPorNombre(nombre)
            if (YoTeElijo.ToUpper() != "S"
                && YoTeElijo.ToUpper() != "B"
                && YoTeElijo.ToUpper() != "C")
            {
                YoTeElijo = null;
                while (YoTeElijo == null)
                {
                    Console.Clear();
                    Console.WriteLine("Intentalo Nuevamente:");
                    MostrarPokemon(pokemonesiniciales);
                    YoTeElijo = Console.ReadLine();
                    YoTeElijo = PkmnElegido(YoTeElijo);
                }
            }
            else
            {
                YoTeElijo = PkmnElegido(YoTeElijo);
            }
            Pokemon miInicial = pokemonesiniciales.ObtenPkmnPorNombre(YoTeElijo);
            Console.WriteLine("{0} Yo te elijo!!!", YoTeElijo);
            // Crear instancia de pokebola
            Pokebola pokeball = new Pokebola();
            // Meter el pokemon a la pokebola
            pokeball.pokemonDentroPokebola = miInicial;
            // Agregar la pokebola a la lista de pokebolas del jugador
            
            // Crear 2 instancia de pokebolas sin pokemonDentroDePokebola
            // Agregar a la lista de pokebolas del jugador las 2 pokebolas vacias

            //Validar si el jugador tiene pokebolas en la lista de pokebolas
            //Si tiene, buscar una pokebola que tenga pokemon pokebola.EsOcupada 

            //Con el Pokedex obtener la ficha e imprimirla en pantalla

            //Si hay pokebolas vacias, imprimir en pantalla el numero de pokebolas vacias

            //string ficha = jugador.Pokedex.ObtenerFicha("Bulbasaur");
            //Console.WriteLine(ficha);
        }

        private static string PkmnElegido(string YoTeElijo)
        {
            switch (YoTeElijo.ToUpper())
            {
                case "S":
                    YoTeElijo = "Squirtle";
                    break;
                case "B":
                    YoTeElijo = "Bulbasaur";
                    break;
                case "C":
                    YoTeElijo = "Charmander";
                    break;
                default:
                    YoTeElijo = null;
                    break;
            }

            return YoTeElijo;
        }

        private static void MostrarPokemon(Pokemones pokemonesiniciales)
        {
            Pokemon[] iniciales = pokemonesiniciales.ObtenPkmnDeInicio().ToArray();
            foreach (Pokemon pkmn in iniciales)
            {
                //string fichaPkmn = pokedexNuevo.IdentificarPkmn(pkmn);
                //Console.WriteLine(fichaPkmn);
                switch (pkmn.Nombre)
                {
                    case "Squirtle":
                        Console.WriteLine("S-" + pkmn.Nombre);
                        break;
                    case "Bulbasaur":
                        Console.WriteLine("B-" + pkmn.Nombre);
                        break;
                    case "Charmander":
                        Console.WriteLine("C-" + pkmn.Nombre);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ElegirEdad(Jugador jugador)
        {
            Console.WriteLine("Escribe tu Edad: 1-99");
            string EdadStr = Console.ReadLine();
            if (int.TryParse(EdadStr,out int EdadNumero))
            {
                if (EdadNumero <= 99 && EdadNumero >= 1)
                {
                    jugador.Edad = EdadNumero;  
                }
            }
        }

        private static void ElegirSexo(Jugador jugador)
        {
            Console.WriteLine("Selecciona tu sexo:M-Masculino o F-Femenino");
            string SexoString = Console.ReadLine();
            switch (SexoString.ToUpper())
            {
                case "M":
                    jugador.Sexo = Sexo.Masculino;
                    break;
                case "F":
                    jugador.Sexo = Sexo.Femenino;
                    break;
                default:
                    break;
            }
        }

        public void Pruebas()
        {
            Pokedex pokedex = new Pokedex();

            string ficha = pokedex.ObtenerFicha("Bulbasaur");

            //Console.WriteLine(ficha);

            Pokemones pokemones = new Pokemones();
            Pokemon[] pokemonArray = pokemones.ObtenerPkmns();

            string ficha2 = pokedex.IdentificarPkmn(pokemonArray[0]);

            //Console.WriteLine(ficha2);

            Pokebola pokebolaRoja = new Pokebola();
            Console.WriteLine("Tiene un pokemon la pokebolaroja:" + pokebolaRoja.EsOcupada());

            pokebolaRoja.pokemonDentroPokebola = pokemonArray[1];
            Console.WriteLine("Tiene un pokemon la pokebolaroja:" + pokebolaRoja.EsOcupada());

            string fichaPokemonEnPokebola = pokedex.IdentificarPkmn(pokebolaRoja.pokemonDentroPokebola);
            Console.WriteLine(fichaPokemonEnPokebola);

            pokebolaRoja.pokemonDentroPokebola = null;
            Console.WriteLine("Tiene un pokemon la pokebolaroja:" + pokebolaRoja.EsOcupada());

        }
    }
}