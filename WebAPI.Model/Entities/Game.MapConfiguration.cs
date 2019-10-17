using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAPI.Model.Entities
{
    public class GameMapConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("game");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(255);
            builder.Property(c => c.BetStartDate);
            builder.Property(c => c.BetEndDate);
            builder.Property(c => c.GameState).HasMaxLength(16);
            builder.HasMany(c => c.Bets);
        }
    }
}
