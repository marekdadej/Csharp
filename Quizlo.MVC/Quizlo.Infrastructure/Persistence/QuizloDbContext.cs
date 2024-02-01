using Microsoft.EntityFrameworkCore;
using Quizlo.Domain.Entities;

namespace Quizlo.Infrastructure.Persistence
{
    public class QuizloDbContext : DbContext
    {
        public DbSet<Domain.Entities.Quiz> Quizes { get; set; }
        public DbSet<Domain.Entities.Question> Questions { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=QuizloDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.Quiz>()
                .HasMany(q => q.Questions)
                .WithOne(q => q.Quiz) 
                .HasForeignKey(q => q.QuizId);

        }
    }
}
