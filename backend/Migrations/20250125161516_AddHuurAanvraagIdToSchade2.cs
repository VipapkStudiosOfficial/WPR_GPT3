using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddHuurAanvraagIdToSchade2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e4ebe32-eff8-484c-a48a-8bbe9a1f4e0a", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "42af2171-8f6d-45c4-8031-1cf0f4aa9c64", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "4d690fbb-fa87-4561-9767-9ccafe1ac5dd", null, "User", "USER" },
                    { "76a41577-52fa-4b24-acac-202bbb621546", null, "Admin", "ADMIN" },
                    { "aded5caf-c9f6-4a9b-9be8-1b726813bee8", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "ccb6090e-06dc-40d4-9d90-ddc4857a099b", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "fb9dce9d-b22e-41b8-a0cb-006875725f6d", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e4ebe32-eff8-484c-a48a-8bbe9a1f4e0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42af2171-8f6d-45c4-8031-1cf0f4aa9c64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d690fbb-fa87-4561-9767-9ccafe1ac5dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a41577-52fa-4b24-acac-202bbb621546");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aded5caf-c9f6-4a9b-9be8-1b726813bee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccb6090e-06dc-40d4-9d90-ddc4857a099b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb9dce9d-b22e-41b8-a0cb-006875725f6d");

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
        }
    }
}
