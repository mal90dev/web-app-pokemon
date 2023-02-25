using Microsoft.EntityFrameworkCore;
using WebAppPokemon.Models;

namespace WebAppPokemon.Helpers
{
    public class DataContext: DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
