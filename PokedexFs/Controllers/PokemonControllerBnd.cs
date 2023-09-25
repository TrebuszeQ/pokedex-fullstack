using Pokedex;
using Pokedex.http;

namespace PokedexFs.Controllers;

// singleton
public sealed class PokemonControllerBnd
{
    private static Lazy<PokemonControllerBnd> instance { get; } = new (
       () => new PokemonControllerBnd());

    public static PokemonControllerBnd Instance => instance.Value;
        
    private static readonly Pokemon[] Pokemons = { };
    private static Pokemon _pokemon;
    private static readonly HttpHandlerLazy httpHandler = HttpHandlerLazy.Instance;
    
    
}