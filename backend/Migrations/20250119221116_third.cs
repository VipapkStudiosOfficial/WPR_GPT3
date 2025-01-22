using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eb477f8-1b36-4eb9-9231-c031a17bc0bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581a7ad3-80ef-42eb-a0d7-b14f9013e293");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f2a699-b29c-430d-aa32-6e3e7dbe30e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "740e6fe8-9f82-4700-8295-03ff350da08e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef056c4-1ee7-4755-8a14-ab514ffd9546");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef5b00c-4f8b-48e6-beb6-75fef9e11f7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9138561-254a-4f28-8fc8-8b99b7354448");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2039e1a6-ba2d-431b-b6a5-49f351c5c47b", null, "Zakelijkebeheerder", "ZB" },
                    { "428c61ef-a844-4902-bcaa-1f84b9641ae3", null, "Zakelijkehuurder", "ZH" },
                    { "4b34af43-6af8-45b5-a804-ef95158a4b9c", null, "Frontofficemedewerker", "FOM" },
                    { "6995d12e-2ad0-47da-b206-ec20a6d874e0", null, "Admin", "ADMIN" },
                    { "858f0786-6296-4ba6-a712-eee0991e679f", null, "Particulierehuurder", "PH" },
                    { "93f7b871-60b0-446a-be5f-1ca11f3f0a8f", null, "Backofficemedewerker", "BOM" },
                    { "ae71499b-a588-4568-a5c2-c6f852120e78", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2039e1a6-ba2d-431b-b6a5-49f351c5c47b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "428c61ef-a844-4902-bcaa-1f84b9641ae3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b34af43-6af8-45b5-a804-ef95158a4b9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6995d12e-2ad0-47da-b206-ec20a6d874e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "858f0786-6296-4ba6-a712-eee0991e679f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93f7b871-60b0-446a-be5f-1ca11f3f0a8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae71499b-a588-4568-a5c2-c6f852120e78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eb477f8-1b36-4eb9-9231-c031a17bc0bb", null, "Admin", "ADMIN" },
                    { "581a7ad3-80ef-42eb-a0d7-b14f9013e293", null, "FrontOfficeMedewerker", "FOM" },
                    { "69f2a699-b29c-430d-aa32-6e3e7dbe30e9", null, "ZakelijkeBeheerder", "ZB" },
                    { "740e6fe8-9f82-4700-8295-03ff350da08e", null, "ParticuliereHuurder", "PH" },
                    { "8ef056c4-1ee7-4755-8a14-ab514ffd9546", null, "User", "USER" },
                    { "9ef5b00c-4f8b-48e6-beb6-75fef9e11f7c", null, "ZakelijkeHuurder", "ZH" },
                    { "f9138561-254a-4f28-8fc8-8b99b7354448", null, "BackOfficeMedewerker", "BOM" }
                });
        }
    }
}
