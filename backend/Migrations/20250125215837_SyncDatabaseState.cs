using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SyncDatabaseState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d082a02-4a21-4819-a514-adf0d734cad6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d5d757e-1240-481e-9979-a1ce3754c94f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91dac933-b591-4b9b-8a54-54eeead4f384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7443f24-7035-407f-b2ca-2237f8507074");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b18d85df-53e0-4d76-a2c9-4e8573fc8506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c02f3bb7-0120-437f-b475-2898c5ef6aef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebee8d8f-8e7d-481a-b753-b569480d1c81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "010337cf-eeb2-4574-8b5e-6e33b7c83696", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "1b5c84ab-f847-461f-a43f-cd1a92c3cfa1", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "2a568eef-0eb1-4b17-9672-8e0f9257cf48", null, "Admin", "ADMIN" },
                    { "7673b076-8924-448a-bd0c-acb8b23d5947", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "bb6c9cfa-dc10-41d3-a63f-901c7ed35eef", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "ca3c3355-a1db-4bec-a0c0-00fff63306b2", null, "User", "USER" },
                    { "d809c174-5c99-49c9-b114-053470500155", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "010337cf-eeb2-4574-8b5e-6e33b7c83696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b5c84ab-f847-461f-a43f-cd1a92c3cfa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a568eef-0eb1-4b17-9672-8e0f9257cf48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7673b076-8924-448a-bd0c-acb8b23d5947");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6c9cfa-dc10-41d3-a63f-901c7ed35eef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca3c3355-a1db-4bec-a0c0-00fff63306b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d809c174-5c99-49c9-b114-053470500155");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d082a02-4a21-4819-a514-adf0d734cad6", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "8d5d757e-1240-481e-9979-a1ce3754c94f", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "91dac933-b591-4b9b-8a54-54eeead4f384", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "a7443f24-7035-407f-b2ca-2237f8507074", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "b18d85df-53e0-4d76-a2c9-4e8573fc8506", null, "User", "USER" },
                    { "c02f3bb7-0120-437f-b475-2898c5ef6aef", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "ebee8d8f-8e7d-481a-b753-b569480d1c81", null, "Admin", "ADMIN" }
                });
        }
    }
}
