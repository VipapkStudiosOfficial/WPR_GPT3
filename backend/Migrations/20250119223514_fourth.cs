using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2f61ef09-528b-4120-9281-c8edd3439a9c", null, "Admin", "ADMIN" },
                    { "35a892e4-9e0f-4bde-b59a-9a7919ce628a", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "3b8d1471-69a1-4bcd-941e-287488035da3", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "706e5f63-857a-4c2b-9253-7086438a4704", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "9d339456-98a5-4059-90e6-ff52298da16b", null, "User", "USER" },
                    { "c4c60dc3-8431-4e28-9acf-ea4087ba911a", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "d83ea22f-eca8-4d8b-897e-3079b9ab8da6", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f61ef09-528b-4120-9281-c8edd3439a9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35a892e4-9e0f-4bde-b59a-9a7919ce628a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b8d1471-69a1-4bcd-941e-287488035da3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "706e5f63-857a-4c2b-9253-7086438a4704");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d339456-98a5-4059-90e6-ff52298da16b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c60dc3-8431-4e28-9acf-ea4087ba911a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d83ea22f-eca8-4d8b-897e-3079b9ab8da6");

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
    }
}
