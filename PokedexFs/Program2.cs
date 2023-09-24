// using Pokedex;
// using Pokedex.http;
//
// Console.WriteLine("Pokémon and Pokémon character names are trademarks of Nintendo.");
// Console.WriteLine("Which pokemon do you want to get data about.");
// string? pokemonInput = Console.ReadLine();
// if (pokemonInput != null) pokemonInput = pokemonInput.ToLower().Trim();
//
// Uri uri = new Uri($"https://pokeapi.co/api/v2/pokemon/{pokemonInput}");
//
// // HttpHandler httpHandler = new HttpHandler();
// HttpHandlerLazy httpHandler = HttpHandlerLazy.Instance;
//
// // var pokemon = await httpHandler.RetPokemonDeserialized(uri);
// // Console.WriteLine(pokemon);
// Pokemon? pokemon = await httpHandler.RetPokemonDeserialized(uri);
// if (pokemon != null)
// {
//     Console.WriteLine(pokemon);
// }
//
//
// // var pokemon2 = await HttpHandler.RetPokemonDeserialized(uri);
//
//
//
//
