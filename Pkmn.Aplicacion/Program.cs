using Pkmn.Datos;
using Pkmn.Logica.Clases;
using Pkmn.Modelos.Clases;
using Pkmn.Modelos.Enumeradores;

Pokedex pokedex = new Pokedex();

string ficha = pokedex.ObtenerFicha("Bulbasaur");

//Console.WriteLine(ficha);

Pokemones pokemones = new Pokemones();
Pokemon[] pokemonArray = pokemones.ObtenerPkmns();

string ficha2 = pokedex.IdentificarPkmn(pokemonArray[0]);

//Console.WriteLine(ficha2);

Pokebola pokebolaRoja = new Pokebola();
Console.WriteLine("Tiene un pokemon la pokebolaroja:"+pokebolaRoja.EsOcupada());

pokebolaRoja.pokemonDentroPokebola = pokemonArray[1];
Console.WriteLine("Tiene un pokemon la pokebolaroja:" + pokebolaRoja.EsOcupada());

string fichaPokemonEnPokebola = pokedex.IdentificarPkmn(pokebolaRoja.pokemonDentroPokebola);
Console.WriteLine(fichaPokemonEnPokebola);

pokebolaRoja.pokemonDentroPokebola = null;
Console.WriteLine("Tiene un pokemon la pokebolaroja:" + pokebolaRoja.EsOcupada());

