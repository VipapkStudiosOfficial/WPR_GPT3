using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddHuurAanvraagRelationshipToSchades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0c3ac382-d486-4373-881d-eb2a99bcffe8", null, "User", "USER" },
                    { "142b876d-a5fe-404d-8f66-7dfec638f415", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "448b2801-f739-46e2-a363-34bd60c3f095", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "6e1871cd-53e6-4e20-969a-7b438600e530", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "7f27e31f-8e87-4aed-8474-460b09716628", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "a20fe274-8b5d-4c87-bf28-360479ae7735", null, "Admin", "ADMIN" },
                    { "add87474-c80e-494b-9b6e-551302e97db9", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c3ac382-d486-4373-881d-eb2a99bcffe8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "142b876d-a5fe-404d-8f66-7dfec638f415");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "448b2801-f739-46e2-a363-34bd60c3f095");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e1871cd-53e6-4e20-969a-7b438600e530");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f27e31f-8e87-4aed-8474-460b09716628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a20fe274-8b5d-4c87-bf28-360479ae7735");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "add87474-c80e-494b-9b6e-551302e97db9");

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
    }
}
