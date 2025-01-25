using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSchadeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schaden");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d8ae863-caa5-433c-b5d6-c9f3665cadb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "473d58ce-856c-45f1-a449-05aad134c389");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "487d2eec-3ee4-4d31-b889-8e6b722e2243");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56729952-c986-4fbc-b788-dbc58ab53eea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "714acc96-3fae-4184-b066-2b5a5ac62cb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73cb4a82-846d-47d6-b551-406de04cac50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b15761-f488-4072-aa75-5fe01c08471f");

            migrationBuilder.CreateTable(
                name: "Schades",
                columns: table => new
                {
                    SchadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoertuigId = table.Column<int>(type: "int", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchadeDatum = table.Column<DateTime>(type: "datetime", nullable: false),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReparatieOpmerkingen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schades", x => x.SchadeId);
                    table.ForeignKey(
                        name: "FK_Schades_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18cf54bc-7058-472a-9f78-a8e39d13967a", null, "User", "USER" },
                    { "2699a77c-af9d-4dc2-9ba7-0468800efd8f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "40bf7415-ba07-4ce9-b214-1e93670c349c", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "74be3864-01bf-46b6-94c5-e55240105842", null, "Admin", "ADMIN" },
                    { "a0446900-6ca2-4f2e-94e0-25c5b650ddd7", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "ee13e4cf-562d-46a2-988f-bc565c90ded7", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "f43d9462-44fe-4575-b20d-8f78f5a3b1c3", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schades_VoertuigId",
                table: "Schades",
                column: "VoertuigId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schades");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18cf54bc-7058-472a-9f78-a8e39d13967a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2699a77c-af9d-4dc2-9ba7-0468800efd8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40bf7415-ba07-4ce9-b214-1e93670c349c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74be3864-01bf-46b6-94c5-e55240105842");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0446900-6ca2-4f2e-94e0-25c5b650ddd7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee13e4cf-562d-46a2-988f-bc565c90ded7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f43d9462-44fe-4575-b20d-8f78f5a3b1c3");

            migrationBuilder.CreateTable(
                name: "Schaden",
                columns: table => new
                {
                    SchadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoertuigId = table.Column<int>(type: "int", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schaden", x => x.SchadeId);
                    table.ForeignKey(
                        name: "FK_Schaden_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d8ae863-caa5-433c-b5d6-c9f3665cadb1", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "473d58ce-856c-45f1-a449-05aad134c389", null, "Admin", "ADMIN" },
                    { "487d2eec-3ee4-4d31-b889-8e6b722e2243", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "56729952-c986-4fbc-b788-dbc58ab53eea", null, "User", "USER" },
                    { "714acc96-3fae-4184-b066-2b5a5ac62cb1", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "73cb4a82-846d-47d6-b551-406de04cac50", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "d3b15761-f488-4072-aa75-5fe01c08471f", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schaden_VoertuigId",
                table: "Schaden",
                column: "VoertuigId");
        }
    }
}
