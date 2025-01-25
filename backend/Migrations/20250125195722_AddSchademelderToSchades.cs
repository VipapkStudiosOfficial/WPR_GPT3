using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSchademelderToSchades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Schademelder",
                table: "Schades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "054caf9b-2e07-4f69-8890-85603f3f07c5", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "4b700cad-dfab-4706-baab-bb781e700b99", null, "Admin", "ADMIN" },
                    { "5ea66f6f-23a2-4f0e-a60a-3a14773064af", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "62e9f992-e5fb-49ea-b9ec-808f8924f0ad", null, "User", "USER" },
                    { "681051d3-4385-4373-b7f7-01b8ddf7c659", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "a32904e9-1029-455a-aa2a-e39815c5fcd4", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "b82b8012-9630-49b0-928f-35f5e2634891", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "054caf9b-2e07-4f69-8890-85603f3f07c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b700cad-dfab-4706-baab-bb781e700b99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ea66f6f-23a2-4f0e-a60a-3a14773064af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62e9f992-e5fb-49ea-b9ec-808f8924f0ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "681051d3-4385-4373-b7f7-01b8ddf7c659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a32904e9-1029-455a-aa2a-e39815c5fcd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b82b8012-9630-49b0-928f-35f5e2634891");

            migrationBuilder.DropColumn(
                name: "Schademelder",
                table: "Schades");

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
    }
}
