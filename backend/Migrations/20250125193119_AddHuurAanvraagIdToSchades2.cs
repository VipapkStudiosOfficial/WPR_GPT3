using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddHuurAanvraagIdToSchades2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e6fbf02-29c3-43fe-b32d-5432e78e4a12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17864369-6c48-4a8a-9ffd-6dab0f053901");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db61948-3429-4cd4-9d69-70ec9dc48d21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28f6a10e-7362-41fb-90cc-53e046f2371b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c776e9e-598b-4cd0-8db4-03bdc0b5eec9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf80f842-511b-41b6-b95b-81279db036e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2685ddf-a1de-41ba-bee8-2bae16666617");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f8e0ab9-7b46-44e7-9a26-a7883c95d92e", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "2efee481-4744-4068-a558-76759e0ab87c", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "6427e4f3-068c-48eb-b6e8-9666328ce9a6", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "badd2136-6ede-4b47-a5c8-c163f5c4f201", null, "User", "USER" },
                    { "be52b5c3-f290-4341-a83d-634499130c2d", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "ef512fd1-4990-470c-8aab-21ea48de5d4f", null, "Admin", "ADMIN" },
                    { "f2daec04-4800-49ef-813d-2c79281f9dc1", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f8e0ab9-7b46-44e7-9a26-a7883c95d92e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2efee481-4744-4068-a558-76759e0ab87c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6427e4f3-068c-48eb-b6e8-9666328ce9a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "badd2136-6ede-4b47-a5c8-c163f5c4f201");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be52b5c3-f290-4341-a83d-634499130c2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef512fd1-4990-470c-8aab-21ea48de5d4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2daec04-4800-49ef-813d-2c79281f9dc1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e6fbf02-29c3-43fe-b32d-5432e78e4a12", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "17864369-6c48-4a8a-9ffd-6dab0f053901", null, "Admin", "ADMIN" },
                    { "1db61948-3429-4cd4-9d69-70ec9dc48d21", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "28f6a10e-7362-41fb-90cc-53e046f2371b", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "2c776e9e-598b-4cd0-8db4-03bdc0b5eec9", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "bf80f842-511b-41b6-b95b-81279db036e4", null, "User", "USER" },
                    { "e2685ddf-a1de-41ba-bee8-2bae16666617", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" }
                });
        }
    }
}
