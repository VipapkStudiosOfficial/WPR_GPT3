﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20250125215837_SyncDatabaseState")]
    partial class SyncDatabaseState
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Abonnement", b =>
                {
                    b.Property<int>("AbonnementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbonnementId"));

                    b.Property<DateTime>("EindDatum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParticuliereHuurderPHId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZHId")
                        .HasColumnType("int");

                    b.Property<int?>("ZakelijkeHuurderZHId")
                        .HasColumnType("int");

                    b.HasKey("AbonnementId");

                    b.HasIndex("ParticuliereHuurderPHId");

                    b.HasIndex("ZakelijkeHuurderZHId");

                    b.ToTable("Abonnementen");
                });

            modelBuilder.Entity("Medewerker", b =>
                {
                    b.Property<int>("MedewerkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedewerkerId"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedewerkerId");

                    b.ToTable("Medewerkers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2a568eef-0eb1-4b17-9672-8e0f9257cf48",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ca3c3355-a1db-4bec-a0c0-00fff63306b2",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "010337cf-eeb2-4574-8b5e-6e33b7c83696",
                            Name = "ParticuliereHuurder",
                            NormalizedName = "PARTICULIEREHUURDER"
                        },
                        new
                        {
                            Id = "7673b076-8924-448a-bd0c-acb8b23d5947",
                            Name = "ZakelijkeBeheerder",
                            NormalizedName = "ZAKELIJKEBEHEERDER"
                        },
                        new
                        {
                            Id = "d809c174-5c99-49c9-b114-053470500155",
                            Name = "ZakelijkeHuurder",
                            NormalizedName = "ZAKELIJKEHUURDER"
                        },
                        new
                        {
                            Id = "bb6c9cfa-dc10-41d3-a63f-901c7ed35eef",
                            Name = "BackOfficeMedewerker",
                            NormalizedName = "BACKOFFICEMEDEWERKER"
                        },
                        new
                        {
                            Id = "1b5c84ab-f847-461f-a43f-cd1a92c3cfa1",
                            Name = "FrontOfficeMedewerker",
                            NormalizedName = "FRONTOFFICEMEDEWERKER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ParticuliereHuurder", b =>
                {
                    b.Property<int>("PHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PHId"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHId");

                    b.ToTable("ParticuliereHuurders");
                });

            modelBuilder.Entity("backend.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("MedewerkerId")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("PHId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("ZBId")
                        .HasColumnType("int");

                    b.Property<int?>("ZHId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("backend.Models.FotoUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SchadeId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchadeId");

                    b.ToTable("FotoUrls", (string)null);
                });

            modelBuilder.Entity("backend.Models.HuurAanvraag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AanvraagDatum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedewerkerId")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RejectReason")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VoertuigId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedewerkerId");

                    b.HasIndex("VoertuigId");

                    b.ToTable("HuurAanvragen");
                });

            modelBuilder.Entity("backend.Models.Schade", b =>
                {
                    b.Property<int>("SchadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchadeId"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HuurAanvraagId")
                        .HasColumnType("int");

                    b.Property<string>("ReparatieOpmerkingen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SchadeDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Schademelder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoertuigId")
                        .HasColumnType("int");

                    b.HasKey("SchadeId");

                    b.HasIndex("HuurAanvraagId");

                    b.HasIndex("VoertuigId");

                    b.ToTable("Schades", (string)null);
                });

            modelBuilder.Entity("backend.Models.Voertuig", b =>
                {
                    b.Property<int>("VoertuigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoertuigId"));

                    b.Property<string>("Huurder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kenteken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kleur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerhuurDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("VoertuigId");

                    b.ToTable("Voertuigen");
                });

            modelBuilder.Entity("backend.Models.ZakelijkeBeheerder", b =>
                {
                    b.Property<int>("ZBId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZBId"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BedrijfsNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KvKNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZBId");

                    b.ToTable("ZakelijkeBeheerders");
                });

            modelBuilder.Entity("backend.Models.ZakelijkeHuurder", b =>
                {
                    b.Property<int>("ZHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZHId"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZBId")
                        .HasColumnType("int");

                    b.Property<int?>("ZakelijkeBeheerderZBId")
                        .HasColumnType("int");

                    b.HasKey("ZHId");

                    b.HasIndex("ZakelijkeBeheerderZBId");

                    b.ToTable("ZakelijkeHuurders");
                });

            modelBuilder.Entity("Abonnement", b =>
                {
                    b.HasOne("ParticuliereHuurder", null)
                        .WithMany("Abonnementen")
                        .HasForeignKey("ParticuliereHuurderPHId");

                    b.HasOne("backend.Models.ZakelijkeHuurder", "ZakelijkeHuurder")
                        .WithMany()
                        .HasForeignKey("ZakelijkeHuurderZHId");

                    b.Navigation("ZakelijkeHuurder");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("backend.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("backend.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("backend.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backend.Models.FotoUrl", b =>
                {
                    b.HasOne("backend.Models.Schade", "Schade")
                        .WithMany("FotoUrls")
                        .HasForeignKey("SchadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schade");
                });

            modelBuilder.Entity("backend.Models.HuurAanvraag", b =>
                {
                    b.HasOne("Medewerker", null)
                        .WithMany("HuurAanvragen")
                        .HasForeignKey("MedewerkerId");

                    b.HasOne("backend.Models.Voertuig", "Voertuig")
                        .WithMany("HuurAanvragen")
                        .HasForeignKey("VoertuigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voertuig");
                });

            modelBuilder.Entity("backend.Models.Schade", b =>
                {
                    b.HasOne("backend.Models.HuurAanvraag", "HuurAanvraag")
                        .WithMany("Schades")
                        .HasForeignKey("HuurAanvraagId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("backend.Models.Voertuig", "Voertuig")
                        .WithMany("Schades")
                        .HasForeignKey("VoertuigId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HuurAanvraag");

                    b.Navigation("Voertuig");
                });

            modelBuilder.Entity("backend.Models.ZakelijkeHuurder", b =>
                {
                    b.HasOne("backend.Models.ZakelijkeBeheerder", "ZakelijkeBeheerder")
                        .WithMany()
                        .HasForeignKey("ZakelijkeBeheerderZBId");

                    b.Navigation("ZakelijkeBeheerder");
                });

            modelBuilder.Entity("Medewerker", b =>
                {
                    b.Navigation("HuurAanvragen");
                });

            modelBuilder.Entity("ParticuliereHuurder", b =>
                {
                    b.Navigation("Abonnementen");
                });

            modelBuilder.Entity("backend.Models.HuurAanvraag", b =>
                {
                    b.Navigation("Schades");
                });

            modelBuilder.Entity("backend.Models.Schade", b =>
                {
                    b.Navigation("FotoUrls");
                });

            modelBuilder.Entity("backend.Models.Voertuig", b =>
                {
                    b.Navigation("HuurAanvragen");

                    b.Navigation("Schades");
                });
#pragma warning restore 612, 618
        }
    }
}
