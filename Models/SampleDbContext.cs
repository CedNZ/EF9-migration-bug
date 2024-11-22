using Microsoft.EntityFrameworkCore;

namespace EF9_historyTableSchema.Models
{
    public class SampleDbContext : DbContext
    {
        public DbSet<One> Ones => Set<One>();
        public DbSet<Two> Twos => Set<Two>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<One>(e =>
            {
                e.ToTable(nameof(Ones), builder => builder.IsTemporal());
            });

            modelBuilder.Entity<Two>(e =>
            {
                e.ToTable(nameof(Twos), builder => builder.IsTemporal());
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EF9_historyTableSchema;Trusted_Connection=True;");
        }
    }
}
