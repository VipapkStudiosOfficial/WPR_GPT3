using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchadesRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades",
                column: "HuurAanvraagId",
                principalTable: "HuurAanvragen",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades");

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
                    { "054caf9b-2e07-4f69-8890-85603f3f07c5", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "4b700cad-dfab-4706-baab-bb781e700b99", null, "Admin", "ADMIN" },
                    { "5ea66f6f-23a2-4f0e-a60a-3a14773064af", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "62e9f992-e5fb-49ea-b9ec-808f8924f0ad", null, "User", "USER" },
                    { "681051d3-4385-4373-b7f7-01b8ddf7c659", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "a32904e9-1029-455a-aa2a-e39815c5fcd4", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "b82b8012-9630-49b0-928f-35f5e2634891", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades",
                column: "HuurAanvraagId",
                principalTable: "HuurAanvragen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
