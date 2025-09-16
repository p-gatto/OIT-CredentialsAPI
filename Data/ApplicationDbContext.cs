using Microsoft.EntityFrameworkCore;

using CredentialsAPI.Models.Domains;

namespace CredentialsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Credential> Credentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Credential>()
                .HasIndex(c => c.Name);

            modelBuilder.Entity<Credential>()
                .HasIndex(c => c.Active);

            modelBuilder.Entity<Credential>()
                .HasIndex(c => c.Expired);
        }
    }
}