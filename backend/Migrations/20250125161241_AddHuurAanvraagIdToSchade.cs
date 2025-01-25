using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddHuurAanvraagIdToSchade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "HuurAanvraagId",
                table: "Schades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02f1608c-5988-45af-9884-bc366d7eb2ed", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "07ec294b-6618-4647-aa18-aefb28ef373e", null, "Admin", "ADMIN" },
                    { "584ccba6-e470-44a3-96d8-67026ec7a583", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "6179a1af-211f-4c4d-951e-8791ee43b9c8", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "7b142dc4-d1ec-4e25-b63b-bcceb2cbc269", null, "User", "USER" },
                    { "9191fead-f451-4ae5-bd64-02b356973875", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "cd7e95b5-cdef-412e-b45e-511f24b959bf", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schades_HuurAanvraagId",
                table: "Schades",
                column: "HuurAanvraagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades",
                column: "HuurAanvraagId",
                principalTable: "HuurAanvragen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schades_HuurAanvragen_HuurAanvraagId",
                table: "Schades");

            migrationBuilder.DropIndex(
                name: "IX_Schades_HuurAanvraagId",
                table: "Schades");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f1608c-5988-45af-9884-bc366d7eb2ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07ec294b-6618-4647-aa18-aefb28ef373e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "584ccba6-e470-44a3-96d8-67026ec7a583");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6179a1af-211f-4c4d-951e-8791ee43b9c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b142dc4-d1ec-4e25-b63b-bcceb2cbc269");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9191fead-f451-4ae5-bd64-02b356973875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd7e95b5-cdef-412e-b45e-511f24b959bf");

            migrationBuilder.DropColumn(
                name: "HuurAanvraagId",
                table: "Schades");

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
    }
}
