using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden");

            migrationBuilder.DropTable(
                name: "HuurAanvraagen");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2364a09b-76f4-4b0c-b5e5-ceaa1c31151f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44c5cd09-fbc4-47c2-b6d4-37506f13764c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54280876-c5d4-4007-86ba-d4b2ad4a26ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704d691b-5d40-4656-98fb-cc51c7d3429b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf98972f-010e-4ae7-a55f-1c7018d9944a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d36df473-5820-49ae-9597-a42094bf3d2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df9959b7-44a0-486d-8964-31170297cb78");

            migrationBuilder.CreateTable(
                name: "HuurAanvragen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AanvraagDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoertuigId = table.Column<int>(type: "int", nullable: false),
                    MedewerkerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuurAanvragen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Medewerkers_MedewerkerId",
                        column: x => x.MedewerkerId,
                        principalTable: "Medewerkers",
                        principalColumn: "MedewerkerId");
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1296280e-8bce-455e-aa02-45e050e1cb4c", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "1e986674-0c42-480c-a76a-0f968b6d26cf", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "4cae96dd-cfce-4e2d-8365-928f529728c1", null, "Admin", "ADMIN" },
                    { "78b91c9a-ae4c-481a-ad09-e69e90c38387", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "db403c36-fbbb-4a68-9eb9-a8ab5221158f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "f7286bff-d4b8-46f8-988e-bc60ef1e49ac", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "fcb87f14-b115-4bc0-b2a2-18da576998ce", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_MedewerkerId",
                table: "HuurAanvragen",
                column: "MedewerkerId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_VoertuigId",
                table: "HuurAanvragen",
                column: "VoertuigId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden",
                column: "VoertuigId",
                principalTable: "Voertuigen",
                principalColumn: "VoertuigId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden");

            migrationBuilder.DropTable(
                name: "HuurAanvragen");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1296280e-8bce-455e-aa02-45e050e1cb4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e986674-0c42-480c-a76a-0f968b6d26cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cae96dd-cfce-4e2d-8365-928f529728c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b91c9a-ae4c-481a-ad09-e69e90c38387");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db403c36-fbbb-4a68-9eb9-a8ab5221158f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7286bff-d4b8-46f8-988e-bc60ef1e49ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcb87f14-b115-4bc0-b2a2-18da576998ce");

            migrationBuilder.CreateTable(
                name: "HuurAanvraagen",
                columns: table => new
                {
                    HuurAanvraagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoertuigId = table.Column<int>(type: "int", nullable: true),
                    ZakelijkeHuurderZHId = table.Column<int>(type: "int", nullable: true),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedewerkerId = table.Column<int>(type: "int", nullable: true),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZHId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuurAanvraagen", x => x.HuurAanvraagId);
                    table.ForeignKey(
                        name: "FK_HuurAanvraagen_Medewerkers_MedewerkerId",
                        column: x => x.MedewerkerId,
                        principalTable: "Medewerkers",
                        principalColumn: "MedewerkerId");
                    table.ForeignKey(
                        name: "FK_HuurAanvraagen_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId");
                    table.ForeignKey(
                        name: "FK_HuurAanvraagen_ZakelijkeHuurders_ZakelijkeHuurderZHId",
                        column: x => x.ZakelijkeHuurderZHId,
                        principalTable: "ZakelijkeHuurders",
                        principalColumn: "ZHId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2364a09b-76f4-4b0c-b5e5-ceaa1c31151f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "44c5cd09-fbc4-47c2-b6d4-37506f13764c", null, "Admin", "ADMIN" },
                    { "54280876-c5d4-4007-86ba-d4b2ad4a26ef", null, "User", "USER" },
                    { "704d691b-5d40-4656-98fb-cc51c7d3429b", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "bf98972f-010e-4ae7-a55f-1c7018d9944a", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "d36df473-5820-49ae-9597-a42094bf3d2c", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "df9959b7-44a0-486d-8964-31170297cb78", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraagen_MedewerkerId",
                table: "HuurAanvraagen",
                column: "MedewerkerId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraagen_VoertuigId",
                table: "HuurAanvraagen",
                column: "VoertuigId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraagen_ZakelijkeHuurderZHId",
                table: "HuurAanvraagen",
                column: "ZakelijkeHuurderZHId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden",
                column: "VoertuigId",
                principalTable: "Voertuigen",
                principalColumn: "VoertuigId");
        }
    }
}
