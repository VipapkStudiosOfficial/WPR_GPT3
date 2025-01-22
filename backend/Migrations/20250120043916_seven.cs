using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonnementen_ZakelijkeHuurder_ZakelijkeHuurderZHId",
                table: "Abonnementen");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraagen_ZakelijkeHuurder_ZakelijkeHuurderZHId",
                table: "HuurAanvraagen");

            migrationBuilder.DropForeignKey(
                name: "FK_ZakelijkeHuurder_ZakelijkeBeheerder_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZakelijkeHuurder",
                table: "ZakelijkeHuurder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZakelijkeBeheerder",
                table: "ZakelijkeBeheerder");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480c479a-62ae-46e0-b7ab-877eb0d36e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b9cd982-a18e-4b22-92ba-457d49db368b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b7f1023-5ff8-4567-b2cf-bc2322e5d835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b93bca3-9562-45cd-b772-68441546e6ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92e90392-2c4b-4654-9fd4-6545a59f79cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1cc242c-f7d3-44dc-8d49-9c324ea0ebc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9aafa61-66d1-4be7-8bb7-a28a3453d0f8");

            migrationBuilder.RenameTable(
                name: "ZakelijkeHuurder",
                newName: "ZakelijkeHuurders");

            migrationBuilder.RenameTable(
                name: "ZakelijkeBeheerder",
                newName: "ZakelijkeBeheerders");

            migrationBuilder.RenameIndex(
                name: "IX_ZakelijkeHuurder_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurders",
                newName: "IX_ZakelijkeHuurders_ZakelijkeBeheerderZBId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZakelijkeHuurders",
                table: "ZakelijkeHuurders",
                column: "ZHId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZakelijkeBeheerders",
                table: "ZakelijkeBeheerders",
                column: "ZBId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2364a09b-76f4-4b0c-b5e5-ceaa1c31151f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "44c5cd09-fbc4-47c2-b6d4-37506f13764c", null, "Admin", "ADMIN" },
                    { "54280876-c5d4-4007-86ba-d4b2ad4a26ef", null, "User", "USER" },
                    { "704d691b-5d40-4656-98fb-cc51c7d3429b", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "bf98972f-010e-4ae7-a55f-1c7018d9944a", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "d36df473-5820-49ae-9597-a42094bf3d2c", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "df9959b7-44a0-486d-8964-31170297cb78", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnementen_ZakelijkeHuurders_ZakelijkeHuurderZHId",
                table: "Abonnementen",
                column: "ZakelijkeHuurderZHId",
                principalTable: "ZakelijkeHuurders",
                principalColumn: "ZHId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraagen_ZakelijkeHuurders_ZakelijkeHuurderZHId",
                table: "HuurAanvraagen",
                column: "ZakelijkeHuurderZHId",
                principalTable: "ZakelijkeHuurders",
                principalColumn: "ZHId");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakelijkeHuurders_ZakelijkeBeheerders_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurders",
                column: "ZakelijkeBeheerderZBId",
                principalTable: "ZakelijkeBeheerders",
                principalColumn: "ZBId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonnementen_ZakelijkeHuurders_ZakelijkeHuurderZHId",
                table: "Abonnementen");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraagen_ZakelijkeHuurders_ZakelijkeHuurderZHId",
                table: "HuurAanvraagen");

            migrationBuilder.DropForeignKey(
                name: "FK_ZakelijkeHuurders_ZakelijkeBeheerders_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZakelijkeHuurders",
                table: "ZakelijkeHuurders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZakelijkeBeheerders",
                table: "ZakelijkeBeheerders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2364a09b-76f4-4b0c-b5e5-ceaa1c31151f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44c5cd09-fbc4-47c2-b6d4-37506f13764c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54280876-c5d4-4007-86ba-d4b2ad4a26ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704d691b-5d40-4656-98fb-cc51c7d3429b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf98972f-010e-4ae7-a55f-1c7018d9944a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d36df473-5820-49ae-9597-a42094bf3d2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df9959b7-44a0-486d-8964-31170297cb78");

            migrationBuilder.RenameTable(
                name: "ZakelijkeHuurders",
                newName: "ZakelijkeHuurder");

            migrationBuilder.RenameTable(
                name: "ZakelijkeBeheerders",
                newName: "ZakelijkeBeheerder");

            migrationBuilder.RenameIndex(
                name: "IX_ZakelijkeHuurders_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurder",
                newName: "IX_ZakelijkeHuurder_ZakelijkeBeheerderZBId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZakelijkeHuurder",
                table: "ZakelijkeHuurder",
                column: "ZHId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZakelijkeBeheerder",
                table: "ZakelijkeBeheerder",
                column: "ZBId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "480c479a-62ae-46e0-b7ab-877eb0d36e57", null, "User", "USER" },
                    { "4b9cd982-a18e-4b22-92ba-457d49db368b", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "5b7f1023-5ff8-4567-b2cf-bc2322e5d835", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "6b93bca3-9562-45cd-b772-68441546e6ef", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "92e90392-2c4b-4654-9fd4-6545a59f79cc", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "a1cc242c-f7d3-44dc-8d49-9c324ea0ebc3", null, "Admin", "ADMIN" },
                    { "b9aafa61-66d1-4be7-8bb7-a28a3453d0f8", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnementen_ZakelijkeHuurder_ZakelijkeHuurderZHId",
                table: "Abonnementen",
                column: "ZakelijkeHuurderZHId",
                principalTable: "ZakelijkeHuurder",
                principalColumn: "ZHId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraagen_ZakelijkeHuurder_ZakelijkeHuurderZHId",
                table: "HuurAanvraagen",
                column: "ZakelijkeHuurderZHId",
                principalTable: "ZakelijkeHuurder",
                principalColumn: "ZHId");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakelijkeHuurder_ZakelijkeBeheerder_ZakelijkeBeheerderZBId",
                table: "ZakelijkeHuurder",
                column: "ZakelijkeBeheerderZBId",
                principalTable: "ZakelijkeBeheerder",
                principalColumn: "ZBId");
        }
    }
}
