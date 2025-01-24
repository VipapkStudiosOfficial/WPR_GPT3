using System.Collections.Generic;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext : IdentityDbContext<Account>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Abonnement> Abonnementen { get; set; } = null!;
        public DbSet<HuurAanvraag> HuurAanvragen { get; set; } = null!;
        public DbSet<ParticuliereHuurder> ParticuliereHuurders { get; set; } = null!;
        public DbSet<ZakelijkeBeheerder> ZakelijkeBeheerders { get; set; } = null!;
        public DbSet<ZakelijkeHuurder> ZakelijkeHuurders { get; set; } = null!;
        public DbSet<Medewerker> Medewerkers { get; set; } = null!;
        public DbSet<Schade> Schaden { get; set; } = null!;
        public DbSet<Voertuig> Voertuigen { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Identity Roles
            var roles = new List<IdentityRole>
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "ParticuliereHuurder", NormalizedName = "PARTICULIEREHUURDER" },
                new IdentityRole { Name = "ZakelijkeBeheerder", NormalizedName = "ZAKELIJKEBEHEERDER" },
                new IdentityRole { Name = "ZakelijkeHuurder", NormalizedName = "ZAKELIJKEHUURDER" },
                new IdentityRole { Name = "BackOfficeMedewerker", NormalizedName = "BACKOFFICEMEDEWERKER" },
                new IdentityRole { Name = "FrontOfficeMedewerker", NormalizedName = "FRONTOFFICEMEDEWERKER" }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            // HuurAanvraag -> Voertuig
            builder.Entity<HuurAanvraag>()
                .HasOne(a => a.Voertuig)
                .WithMany(v => v.HuurAanvragen)
                .HasForeignKey(a => a.VoertuigId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Schade -> Voertuig (optioneel)
            builder.Entity<Schade>()
                .HasOne(s => s.Voertuig)
                .WithMany(v => v.Schades)
                .HasForeignKey(s => s.VoertuigId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
