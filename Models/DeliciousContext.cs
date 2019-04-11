using Microsoft.EntityFrameworkCore;

namespace delicious.Models
{
    public class DeliciousContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DeliciousContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
    }
}