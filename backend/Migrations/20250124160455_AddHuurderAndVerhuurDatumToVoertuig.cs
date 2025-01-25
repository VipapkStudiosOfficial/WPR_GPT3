using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddHuurderAndVerhuurDatumToVoertuig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1296280e-8bce-455e-aa02-45e050e1cb4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e986674-0c42-480c-a76a-0f968b6d26cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cae96dd-cfce-4e2d-8365-928f529728c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b91c9a-ae4c-481a-ad09-e69e90c38387");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db403c36-fbbb-4a68-9eb9-a8ab5221158f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7286bff-d4b8-46f8-988e-bc60ef1e49ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcb87f14-b115-4bc0-b2a2-18da576998ce");

            migrationBuilder.AddColumn<string>(
                name: "Huurder",
                table: "Voertuigen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "VerhuurDatum",
                table: "Voertuigen",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d8ae863-caa5-433c-b5d6-c9f3665cadb1", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "473d58ce-856c-45f1-a449-05aad134c389", null, "Admin", "ADMIN" },
                    { "487d2eec-3ee4-4d31-b889-8e6b722e2243", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "56729952-c986-4fbc-b788-dbc58ab53eea", null, "User", "USER" },
                    { "714acc96-3fae-4184-b066-2b5a5ac62cb1", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "73cb4a82-846d-47d6-b551-406de04cac50", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "d3b15761-f488-4072-aa75-5fe01c08471f", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d8ae863-caa5-433c-b5d6-c9f3665cadb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "473d58ce-856c-45f1-a449-05aad134c389");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "487d2eec-3ee4-4d31-b889-8e6b722e2243");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56729952-c986-4fbc-b788-dbc58ab53eea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "714acc96-3fae-4184-b066-2b5a5ac62cb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73cb4a82-846d-47d6-b551-406de04cac50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b15761-f488-4072-aa75-5fe01c08471f");

            migrationBuilder.DropColumn(
                name: "Huurder",
                table: "Voertuigen");

            migrationBuilder.DropColumn(
                name: "VerhuurDatum",
                table: "Voertuigen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1296280e-8bce-455e-aa02-45e050e1cb4c", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "1e986674-0c42-480c-a76a-0f968b6d26cf", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "4cae96dd-cfce-4e2d-8365-928f529728c1", null, "Admin", "ADMIN" },
                    { "78b91c9a-ae4c-481a-ad09-e69e90c38387", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "db403c36-fbbb-4a68-9eb9-a8ab5221158f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "f7286bff-d4b8-46f8-988e-bc60ef1e49ac", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "fcb87f14-b115-4bc0-b2a2-18da576998ce", null, "User", "USER" }
                });
        }
    }
}
