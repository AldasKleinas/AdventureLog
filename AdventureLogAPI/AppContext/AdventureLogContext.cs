using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AdventureLogAPI.Models
{
    public class AdventureLogContext : IdentityDbContext<IdentityUser>
    {
        public AdventureLogContext(DbContextOptions<AdventureLogContext> options)
            : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Character>()
                .HasOne(op => op.Icon)
                .WithMany(p => p.Characters)
                .HasForeignKey(op => op.IconId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Character>()
                .HasOne(op => op.Campaign)
                .WithMany(p => p.Characters)
                .HasForeignKey(op => op.CampaignId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CharacterNote>()
                .HasOne(op => op.Character)
                .WithMany(p => p.Notes)
                .HasForeignKey(op => op.CharacterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CharacterNote>()
                .HasOne(op => op.User)
                .WithMany(p => p.CharacterNotes)
                .HasForeignKey(op => op.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Map>()
                .HasOne(op => op.Campaign)
                .WithMany(p => p.Maps)
                .HasForeignKey(op => op.CampaignId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Pin>()
                .HasOne(op => op.Icon)
                .WithMany(p => p.Pins)
                .HasForeignKey(op => op.IconId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Pin>()
                .HasOne(op => op.Map)
                .WithMany(p => p.Pins)
                .HasForeignKey(op => op.MapId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PinNote>()
                .HasOne(op => op.Pin)
                .WithMany(p => p.Notes)
                .HasForeignKey(op => op.PinId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PinNote>()
                .HasOne(op => op.User)
                .WithMany(p => p.PinNotes)
                .HasForeignKey(op => op.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<CharacterNote> Notes { get; set; }
        public DbSet<Pin> Pins { get; set; }
        public DbSet<PinNote> NotesNotes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
