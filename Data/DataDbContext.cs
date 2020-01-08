using Zachariasz_Jankowski.Models;
using Microsoft.EntityFrameworkCore;

namespace Zachariasz_Jankowski.Data
{
    public class DataDbContext : DbContext
    {
  
        public DbSet<Posts> posts { get; set; }
        public DbSet<Like> like { get; set; }
        public DbSet<Projects> project { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projects>()
                .HasKey(c => new { c.id});

            modelBuilder.Entity<Like>()
                .HasKey(c => new { c.username, c.post });
        }
        public DataDbContext(DbContextOptions<DataDbContext> options): base(options)
        {
        }
    }
}
