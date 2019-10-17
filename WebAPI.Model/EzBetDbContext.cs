using Microsoft.EntityFrameworkCore;
using WebAPI.Model.Entities;

namespace WebAPI.Model
{
    public class EzBetDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Bet> Bets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=ez_bet;Username=postgres;Password=test");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BetMapConfiguration());
            modelBuilder.ApplyConfiguration(new GameMapConfiguration());
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);            
        }
    }
}
