using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext : IdentityDbContext<Account>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Abonnement> Abonnementen {get; set;} = null!;
        public DbSet<HuurAanvraag> HuurAanvraagen {get; set;} = null!;
        public DbSet<ParticuliereHuurder> ParticuliereHuurders {get; set;} = null!;
        public DbSet<ZakelijkeBeheerder> ZakelijkeBeheerders {get; set;} = null!;
        public DbSet<ZakelijkeHuurder> ZakelijkeHuurders {get; set;} = null!;
        public DbSet<Medewerker> Medewerkers {get; set;} = null!;
        public DbSet<Schade> Schaden {get; set;} = null!;
        public DbSet<Voertuig> Voertuigen {get; set;} = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>{
                new IdentityRole{
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole{
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole{
                    Name = "ParticuliereHuurder",
                    NormalizedName = "PARTICULIEREHUURDER"
                },
                new IdentityRole{
                    Name = "ZakelijkeBeheerder",
                    NormalizedName = "ZAKELIJKEBEHEERDER"
                },
                new IdentityRole{
                    Name = "ZakelijkeHuurder",
                    NormalizedName = "ZAKELIJKEHUURDER"
                },
                new IdentityRole{
                    Name = "BackOfficeMedewerker",
                    NormalizedName = "BACKOFFICEMEDEWERKER"
                },
                new IdentityRole{
                    Name = "FrontOfficeMedewerker",
                    NormalizedName = "FRONTOFFICEMEDEWERKER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}