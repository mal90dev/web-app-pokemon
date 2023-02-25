namespace WebAppPokemon.Models.Repository
{
    public interface IPokemonRepository
    {
        Pokemon GetPokemonById(int id);
        IEnumerable<Pokemon> GetPokemons();
    }
}
