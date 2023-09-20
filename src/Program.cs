using System.Text.Json;
using Pokedex;
using Pokedex.http;

Console.WriteLine("Pokémon and Pokémon character names are trademarks of Nintendo.");
Console.WriteLine("Which pokemon do you want to get data about.");
string pokemonInput = Console.ReadLine().Trim().ToLower();

Uri uri = new Uri($"https://pokeapi.co/api/v2/pokemon/{pokemonInput}");

HttpHandler httpHandler = new HttpHandler();
// string response = await httpHandler.RetStringResponse(uri);

// Console.WriteLine(response);

// var pokemon = JsonSerializer.Deserialize<Pokemon>(response);
// var pokemon = await httpHandler.RetPokemonDeserialized(uri);
var pokemonJson = await httpHandler.RetPokemonSerialized(uri);
Console.WriteLine(pokemonJson);



