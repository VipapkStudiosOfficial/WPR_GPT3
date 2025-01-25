using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b46d14-1ada-486e-b171-9e4837ed7b7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "244af068-b955-43c6-a976-ba1fd00f3c29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420364a1-463c-486d-8f30-e84cf3adfa2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8bf99c4-75ef-43be-b64c-a98952682bab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b41b8fa4-7a8b-4183-b59f-104f2ea83916");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e251a62f-c486-43af-b90f-75e39a18ac24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd25e815-83d2-437d-bb31-9bf376c61676");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12d20981-3adb-4b7d-91fd-cf5ff023aba5", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "288ba96f-54ef-489f-beaf-fc0af986b249", null, "User", "USER" },
                    { "37101e11-27f4-410e-b749-7b44d57aa5e5", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "41d6be45-0038-454b-8548-01f88f3e7079", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "5dee8c73-97c0-42e6-adbc-f97309424bda", null, "Admin", "ADMIN" },
                    { "84d0657e-604b-47cd-a187-24d73080f60b", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "c9816686-c95f-4b42-b804-786edd8e7e12", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12d20981-3adb-4b7d-91fd-cf5ff023aba5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "288ba96f-54ef-489f-beaf-fc0af986b249");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37101e11-27f4-410e-b749-7b44d57aa5e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41d6be45-0038-454b-8548-01f88f3e7079");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dee8c73-97c0-42e6-adbc-f97309424bda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d0657e-604b-47cd-a187-24d73080f60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9816686-c95f-4b42-b804-786edd8e7e12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21b46d14-1ada-486e-b171-9e4837ed7b7e", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "244af068-b955-43c6-a976-ba1fd00f3c29", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "420364a1-463c-486d-8f30-e84cf3adfa2a", null, "Admin", "ADMIN" },
                    { "a8bf99c4-75ef-43be-b64c-a98952682bab", null, "User", "USER" },
                    { "b41b8fa4-7a8b-4183-b59f-104f2ea83916", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "e251a62f-c486-43af-b90f-75e39a18ac24", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "fd25e815-83d2-437d-bb31-9bf376c61676", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }
    }
}
