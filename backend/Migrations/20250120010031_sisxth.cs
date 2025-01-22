using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class sisxth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03bfa6a1-2a18-4261-96cb-1b95dda655f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f50a3fe-b113-41b1-aa80-59629cc253db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f74aaab-ad2c-4508-9adc-66e81d5935cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "585e386e-8632-4700-9ce7-345f8611b1b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9049b347-1e21-425b-a003-8bf1754233de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1ea20e0-e66c-47c7-b700-8a374b07ea41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0fe438d-f832-4cee-bc0f-1e9170df08f0");

            migrationBuilder.DropColumn(
                name: "HuurDatum",
                table: "Voertuigen");

            migrationBuilder.DropColumn(
                name: "InleverDatum",
                table: "Voertuigen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "480c479a-62ae-46e0-b7ab-877eb0d36e57", null, "User", "USER" },
                    { "4b9cd982-a18e-4b22-92ba-457d49db368b", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "5b7f1023-5ff8-4567-b2cf-bc2322e5d835", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "6b93bca3-9562-45cd-b772-68441546e6ef", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "92e90392-2c4b-4654-9fd4-6545a59f79cc", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "a1cc242c-f7d3-44dc-8d49-9c324ea0ebc3", null, "Admin", "ADMIN" },
                    { "b9aafa61-66d1-4be7-8bb7-a28a3453d0f8", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480c479a-62ae-46e0-b7ab-877eb0d36e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b9cd982-a18e-4b22-92ba-457d49db368b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b7f1023-5ff8-4567-b2cf-bc2322e5d835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b93bca3-9562-45cd-b772-68441546e6ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92e90392-2c4b-4654-9fd4-6545a59f79cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1cc242c-f7d3-44dc-8d49-9c324ea0ebc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9aafa61-66d1-4be7-8bb7-a28a3453d0f8");

            migrationBuilder.AddColumn<DateTime>(
                name: "HuurDatum",
                table: "Voertuigen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InleverDatum",
                table: "Voertuigen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03bfa6a1-2a18-4261-96cb-1b95dda655f9", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "0f50a3fe-b113-41b1-aa80-59629cc253db", null, "User", "USER" },
                    { "1f74aaab-ad2c-4508-9adc-66e81d5935cb", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "585e386e-8632-4700-9ce7-345f8611b1b3", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "9049b347-1e21-425b-a003-8bf1754233de", null, "Admin", "ADMIN" },
                    { "c1ea20e0-e66c-47c7-b700-8a374b07ea41", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "f0fe438d-f832-4cee-bc0f-1e9170df08f0", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" }
                });
        }
    }
}
