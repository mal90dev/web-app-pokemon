using WebAppPokemon.Helpers;

namespace WebAppPokemon.Models.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        protected readonly DataContext _context;
        public PokemonRepository(DataContext context) => _context = context;

        public IEnumerable<Pokemon> GetPokemons()
        {
            return _context.Pokemons.ToList();
        }

        public Pokemon GetPokemonById(int id)
        {
            return _context.Pokemons.Find(id);
        }
    }
}
