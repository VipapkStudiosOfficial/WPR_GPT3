using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f61ef09-528b-4120-9281-c8edd3439a9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35a892e4-9e0f-4bde-b59a-9a7919ce628a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b8d1471-69a1-4bcd-941e-287488035da3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "706e5f63-857a-4c2b-9253-7086438a4704");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d339456-98a5-4059-90e6-ff52298da16b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c60dc3-8431-4e28-9acf-ea4087ba911a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d83ea22f-eca8-4d8b-897e-3079b9ab8da6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2f61ef09-528b-4120-9281-c8edd3439a9c", null, "Admin", "ADMIN" },
                    { "35a892e4-9e0f-4bde-b59a-9a7919ce628a", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "3b8d1471-69a1-4bcd-941e-287488035da3", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "706e5f63-857a-4c2b-9253-7086438a4704", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "9d339456-98a5-4059-90e6-ff52298da16b", null, "User", "USER" },
                    { "c4c60dc3-8431-4e28-9acf-ea4087ba911a", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "d83ea22f-eca8-4d8b-897e-3079b9ab8da6", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" }
                });
        }
    }
}
