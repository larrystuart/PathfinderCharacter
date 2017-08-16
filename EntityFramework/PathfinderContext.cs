using Microsoft.EntityFrameworkCore;
using PathfinderCharacter.Models;

namespace PathfinderCharacter
{
    public class PathfinderContext : DbContext
    {
        public PathfinderContext(DbContextOptions<PathfinderContext> options)
            : base(options)
        { }

        public DbSet<RawSpell> RawSpells { get; set; }
        
        public DbSet<Bloodline> Bloodlines { get; set; }

        //public DbSet<Models.Character.Character> Characters { get; set; }
        public DbSet<CastingTime> CastingTime { get; set; }
        public DbSet<CurrencyUnit> CurrencyUnits { get; set; }
        public DbSet<Domain> Domains { get; set; }
        //public Duration Duration { get; set; }
        public DbSet<HeroClass> HeroClasses { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<ModificationType> ModificationTypes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<ReferenceSource> ReferenceSources { get; set; }
        public DbSet<SavingThrow> SavingThrows { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Descriptor> SpellDescriptors { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Subschool> Subschools { get; set; }
        public DbSet<TimeUnit> TimeUnits { get; set; }
        public DbSet<StatKey> StatKeys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modifier>()
                .HasIndex(m => m.IdToModify);
        }

    }
}
