using Microsoft.EntityFrameworkCore;

namespace Boekenbibliotheek.Models
{
    public class LibraryContext : DbContext
    {
        // Constructor accepting DbContextOptions
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        // This method is optional when using Dependency Injection, 
        // as configuration will be handled in Program.cs
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // You can keep this if you want a fallback configuration,
            // but it's not necessary when using dependency injection.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=library.db");
            }
        }
    }
}
