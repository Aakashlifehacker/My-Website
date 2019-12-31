using Zachariasz_Jankowski.Models;
using Microsoft.EntityFrameworkCore;

namespace Zachariasz_Jankowski.Data
{
    public class DataDbContext : DbContext
    {
        public DbSet<Test> test { get; set; }
        public DbSet<Posts> posts { get; set; }
        public DbSet<Like> like { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                .HasKey(c => new { c.username, c.post });

            modelBuilder.Entity<Like>()
                .HasKey(c => new { c.username, c.post });
        }
        public DataDbContext(DbContextOptions<DataDbContext> options): base(options)
        {
        }
    }
}
