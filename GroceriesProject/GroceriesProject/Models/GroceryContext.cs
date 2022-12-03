using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GroceriesProject.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class GroceriesContext:DbContext
    {
        public GroceriesContext()
        {

        }

        public GroceriesContext(DbContextOptions options)
            : base(options) { }
       
        public DbSet<GroceriesList> Groceries { get; set; }
        public DbSet<GroveriesPurchase> GroveriesPurchases { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GroceriesList>().HasKey(table => new {
                table.Name,
               
                
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q8DTPH8\\RAHULSERVER;Database=GroceryDb;Trusted_Connection=True;");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
