using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Blogownia.Models; // Upewnij się, że używasz odpowiedniej przestrzeni nazw dla Twoich modeli

namespace Blogownia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Definicje DbSet dla Twoich modeli
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        // Możesz dodać więcej DbSet dla innych modeli

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tutaj możesz skonfigurować relacje, klucze obce itp.
        }
    }
}
