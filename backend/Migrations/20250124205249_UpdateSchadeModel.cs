using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchadeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264f339b-c8e0-42c1-be35-78fb22076f76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b3e54d1-8efa-45ab-818f-7631e28c2e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "374fe102-f9af-42d7-9153-15b4f5315753");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f791d4a-c44a-4726-9614-1d9a591fae17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba06814-8149-4834-a697-92146d13c743");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "905ba40a-5334-4916-9c86-fe285e910f63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a206e904-2fd2-40f3-945c-cbd954febc5b");

            migrationBuilder.AlterColumn<string>(
                name: "FotoUrls",
                table: "Schaden",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "jsonb");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "FotoUrls",
                table: "Schaden",
                type: "jsonb",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "264f339b-c8e0-42c1-be35-78fb22076f76", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "2b3e54d1-8efa-45ab-818f-7631e28c2e02", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "374fe102-f9af-42d7-9153-15b4f5315753", null, "User", "USER" },
                    { "3f791d4a-c44a-4726-9614-1d9a591fae17", null, "Admin", "ADMIN" },
                    { "6ba06814-8149-4834-a697-92146d13c743", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "905ba40a-5334-4916-9c86-fe285e910f63", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "a206e904-2fd2-40f3-945c-cbd954febc5b", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" }
                });
        }
    }
}
