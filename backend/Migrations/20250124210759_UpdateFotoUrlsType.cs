using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFotoUrlsType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14cec3ae-c804-4d0a-823a-a699c1186ae6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e875383-db42-4800-83d2-c2588498f8c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56b43030-0e1d-4531-8db1-dfa9c7055f62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5909ada4-861a-4796-badd-566c8c9c3df6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3419c56-6c43-484a-a5cf-70d3b1eb20eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd4abb2e-9c5a-49d2-bba7-4af012fe8165");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d006b498-305c-409d-b2e6-9967892d15c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "078b4b43-1897-4223-94ea-9e916ad31940", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "0f710d5e-3641-4ede-87fc-38ceacf4a2ea", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "15787af3-d0e3-42a0-a212-c7edf5a7efa2", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "51cce305-ddd5-48eb-93f8-ac2a1295759a", null, "User", "USER" },
                    { "5edfdefc-7772-45d0-87f8-dfafbdbd6bf8", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "7b6d7646-1cbf-4c31-9555-6b8790528809", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "cb49f2a2-1b60-4a4b-90c4-b4ff0a65f925", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "078b4b43-1897-4223-94ea-9e916ad31940");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f710d5e-3641-4ede-87fc-38ceacf4a2ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15787af3-d0e3-42a0-a212-c7edf5a7efa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51cce305-ddd5-48eb-93f8-ac2a1295759a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5edfdefc-7772-45d0-87f8-dfafbdbd6bf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6d7646-1cbf-4c31-9555-6b8790528809");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb49f2a2-1b60-4a4b-90c4-b4ff0a65f925");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14cec3ae-c804-4d0a-823a-a699c1186ae6", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "3e875383-db42-4800-83d2-c2588498f8c0", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "56b43030-0e1d-4531-8db1-dfa9c7055f62", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "5909ada4-861a-4796-badd-566c8c9c3df6", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "a3419c56-6c43-484a-a5cf-70d3b1eb20eb", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "cd4abb2e-9c5a-49d2-bba7-4af012fe8165", null, "User", "USER" },
                    { "d006b498-305c-409d-b2e6-9967892d15c0", null, "Admin", "ADMIN" }
                });
        }
    }
}
