using Microsoft.AspNetCore.Mvc;
using Pokedex;
using Pokedex.http;

namespace PokedexFs.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonControllerFt : ControllerBase
{
    private static readonly Pokemon[] Pokemons = { };
    private static Pokemon _pokemon;
    private readonly ILogger<PokemonControllerFt> _logger;
    private readonly Uri _uri;
    private static readonly HttpHandlerLazy httpHandler = HttpHandlerLazy.Instance;
    
    public PokemonControllerFt(ILogger<PokemonControllerFt> logger, string pokemonName)
    {
        _logger = logger;
        _uri = new Uri($"https://pokeapi.co/api/v2/pokemon/{pokemonName}");
        
    }
    

}