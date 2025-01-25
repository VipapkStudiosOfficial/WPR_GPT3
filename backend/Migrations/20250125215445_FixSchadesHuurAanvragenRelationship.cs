using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixSchadesHuurAanvragenRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e1ca917-643d-4c72-961e-5a9c8eeed9a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cdbb882-db1a-40c8-898a-a5ba94e6054f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fea8908-507f-46be-8da8-db3c9c5a4014");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f55409d-fbe0-4b80-a95b-55ec41b82d58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a133b4c8-92f9-4ebb-a8b6-3b0ea64a8b76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65a6d23-a93d-4718-9d84-a6516611a890");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4cb7f7d-6ab2-43de-a041-4e7dd02e0be1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0e1ca917-643d-4c72-961e-5a9c8eeed9a4", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "1cdbb882-db1a-40c8-898a-a5ba94e6054f", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "3fea8908-507f-46be-8da8-db3c9c5a4014", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "5f55409d-fbe0-4b80-a95b-55ec41b82d58", null, "User", "USER" },
                    { "a133b4c8-92f9-4ebb-a8b6-3b0ea64a8b76", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "e65a6d23-a93d-4718-9d84-a6516611a890", null, "Admin", "ADMIN" },
                    { "f4cb7f7d-6ab2-43de-a041-4e7dd02e0be1", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }
    }
}
