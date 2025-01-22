using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e8d87ca-4124-45bb-a861-6eba6a1dfa5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21af45fc-e579-417c-a29a-ed86734e9faa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e49dec8-f8dc-4fdf-a976-7ffffa898ce5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c42e4d0-d7b6-4775-b337-db90206dfcc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9b63da8-dc23-4a56-a692-3030ab7dbf89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bc29ba-6a04-4794-b503-a26ce1ca12c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2d2faab-4c8d-4340-9dee-8d6547db9edc");

            migrationBuilder.AlterColumn<decimal>(
                name: "Prijs",
                table: "Voertuigen",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eb477f8-1b36-4eb9-9231-c031a17bc0bb", null, "Admin", "ADMIN" },
                    { "581a7ad3-80ef-42eb-a0d7-b14f9013e293", null, "FrontOfficeMedewerker", "FOM" },
                    { "69f2a699-b29c-430d-aa32-6e3e7dbe30e9", null, "ZakelijkeBeheerder", "ZB" },
                    { "740e6fe8-9f82-4700-8295-03ff350da08e", null, "ParticuliereHuurder", "PH" },
                    { "8ef056c4-1ee7-4755-8a14-ab514ffd9546", null, "User", "USER" },
                    { "9ef5b00c-4f8b-48e6-beb6-75fef9e11f7c", null, "ZakelijkeHuurder", "ZH" },
                    { "f9138561-254a-4f28-8fc8-8b99b7354448", null, "BackOfficeMedewerker", "BOM" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eb477f8-1b36-4eb9-9231-c031a17bc0bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581a7ad3-80ef-42eb-a0d7-b14f9013e293");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f2a699-b29c-430d-aa32-6e3e7dbe30e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "740e6fe8-9f82-4700-8295-03ff350da08e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef056c4-1ee7-4755-8a14-ab514ffd9546");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef5b00c-4f8b-48e6-beb6-75fef9e11f7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9138561-254a-4f28-8fc8-8b99b7354448");

            migrationBuilder.AlterColumn<string>(
                name: "Prijs",
                table: "Voertuigen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e8d87ca-4124-45bb-a861-6eba6a1dfa5e", null, "ParticuliereHuurder", "PH" },
                    { "21af45fc-e579-417c-a29a-ed86734e9faa", null, "BackOfficeMedewerker", "BOM" },
                    { "3e49dec8-f8dc-4fdf-a976-7ffffa898ce5", null, "Admin", "ADMIN" },
                    { "5c42e4d0-d7b6-4775-b337-db90206dfcc7", null, "ZakelijkeHuurder", "ZH" },
                    { "c9b63da8-dc23-4a56-a692-3030ab7dbf89", null, "FrontOfficeMedewerker", "FOM" },
                    { "d7bc29ba-6a04-4794-b503-a26ce1ca12c3", null, "ZakelijkeBeheerder", "ZB" },
                    { "e2d2faab-4c8d-4340-9dee-8d6547db9edc", null, "User", "USER" }
                });
        }
    }
}
