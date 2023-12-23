using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}

// DbContext represents a connection or session that's used to query and save instances of entities in a database.
// PizzaDb is our Context class
class PizzaDb :DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}
