using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppPokemon.Helpers;
using WebAppPokemon.Models;
using WebAppPokemon.Models.Repository;

namespace WebAppPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private IPokemonRepository _pokemonRepository;

        public PokemonsController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ActionName(nameof(GetPokemonsAsync))]
        public IEnumerable<Pokemon> GetPokemonsAsync()
        {
            return _pokemonRepository.GetPokemons();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetPokemonsById))]
        public ActionResult<Pokemon> GetPokemonsById(int id)
        {
            var pokemonByID = _pokemonRepository.GetPokemonById(id);
            if(pokemonByID == null)
            {
                return NotFound();
            }
            return pokemonByID;
        }

        [HttpPost]
        [ActionName("/filter")]
        public IEnumerable<Pokemon> GetPokemonsFilter(PokemonFilter filter)
        {
            var pokemonFilter = _pokemonRepository.GetPokemonsFilter(filter);
            if (pokemonFilter == null)
            {
                return (IEnumerable<Pokemon>)NotFound();
            }
            return pokemonFilter;
        }
    }
}
