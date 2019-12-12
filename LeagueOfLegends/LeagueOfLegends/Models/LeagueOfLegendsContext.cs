using Microsoft.EntityFrameworkCore;

namespace LeagueOfLegends.Models
{
    public class LeagueOfLegendsContext : DbContext
    {
        public LeagueOfLegendsContext()
        {
        }

        public LeagueOfLegendsContext(DbContextOptions<LeagueOfLegendsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Heroes> Heroes { get; set; }
        public virtual DbSet<HeroesTypes> HeroesTypes { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<HeroesTypes>(entity =>
            {
                entity.HasKey(e => new { e.TypesId, e.HeroesId });

                entity.HasOne(d => d.Heroes)
                    .WithMany(p => p.HeroesTypes)
                    .HasForeignKey(d => d.HeroesId);

                entity.HasOne(d => d.Types)
                    .WithMany(p => p.HeroesTypes)
                    .HasForeignKey(d => d.TypesId);
            });

            modelBuilder.Entity<Types>().HasData(
                new Types() { Id = 1, Name = "Sát thủ" },
                new Types() { Id = 2, Name = "Xạ thủ" },
                new Types() { Id = 3, Name = "Pháp sư" },
                new Types() { Id = 4, Name = "Hỗ trợ" },
                new Types() { Id = 5, Name = "Đỡ đòn" },
                new Types() { Id = 6, Name = "Đấu sĩ" },
                new Types() { Id = 7, Name = "Đánh xa" },
                new Types() { Id = 8, Name = "Cận chiến" }
            );

            modelBuilder.Entity<Heroes>().HasData(
              new Heroes() { Id = 1, Name = "Lux", Health = 575, HealthRegen = 6, AttackDamage = 57, Armor = 30, MagicResist = 31, MovementSpeed = 330 }
            );

            modelBuilder.Entity<HeroesTypes>().HasData(
                new HeroesTypes() { TypesId = 3, HeroesId = 1 },
                new HeroesTypes() { TypesId = 4, HeroesId = 1 },
                new HeroesTypes() { TypesId = 7, HeroesId = 1 }
            );
        }
    }
}
