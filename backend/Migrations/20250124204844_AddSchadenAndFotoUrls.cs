using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSchadenAndFotoUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schades_Voertuigen_VoertuigId",
                table: "Schades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schades",
                table: "Schades");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18cf54bc-7058-472a-9f78-a8e39d13967a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2699a77c-af9d-4dc2-9ba7-0468800efd8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40bf7415-ba07-4ce9-b214-1e93670c349c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74be3864-01bf-46b6-94c5-e55240105842");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0446900-6ca2-4f2e-94e0-25c5b650ddd7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee13e4cf-562d-46a2-988f-bc565c90ded7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f43d9462-44fe-4575-b20d-8f78f5a3b1c3");

            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Schades");

            migrationBuilder.RenameTable(
                name: "Schades",
                newName: "Schaden");

            migrationBuilder.RenameIndex(
                name: "IX_Schades_VoertuigId",
                table: "Schaden",
                newName: "IX_Schaden_VoertuigId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchadeDatum",
                table: "Schaden",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<string>(
                name: "FotoUrls",
                table: "Schaden",
                type: "jsonb",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schaden",
                table: "Schaden",
                column: "SchadeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "264f339b-c8e0-42c1-be35-78fb22076f76", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "2b3e54d1-8efa-45ab-818f-7631e28c2e02", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "374fe102-f9af-42d7-9153-15b4f5315753", null, "User", "USER" },
                    { "3f791d4a-c44a-4726-9614-1d9a591fae17", null, "Admin", "ADMIN" },
                    { "6ba06814-8149-4834-a697-92146d13c743", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "905ba40a-5334-4916-9c86-fe285e910f63", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" },
                    { "a206e904-2fd2-40f3-945c-cbd954febc5b", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden",
                column: "VoertuigId",
                principalTable: "Voertuigen",
                principalColumn: "VoertuigId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schaden_Voertuigen_VoertuigId",
                table: "Schaden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schaden",
                table: "Schaden");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264f339b-c8e0-42c1-be35-78fb22076f76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b3e54d1-8efa-45ab-818f-7631e28c2e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "374fe102-f9af-42d7-9153-15b4f5315753");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f791d4a-c44a-4726-9614-1d9a591fae17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba06814-8149-4834-a697-92146d13c743");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "905ba40a-5334-4916-9c86-fe285e910f63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a206e904-2fd2-40f3-945c-cbd954febc5b");

            migrationBuilder.DropColumn(
                name: "FotoUrls",
                table: "Schaden");

            migrationBuilder.RenameTable(
                name: "Schaden",
                newName: "Schades");

            migrationBuilder.RenameIndex(
                name: "IX_Schaden_VoertuigId",
                table: "Schades",
                newName: "IX_Schades_VoertuigId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchadeDatum",
                table: "Schades",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Schades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schades",
                table: "Schades",
                column: "SchadeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18cf54bc-7058-472a-9f78-a8e39d13967a", null, "User", "USER" },
                    { "2699a77c-af9d-4dc2-9ba7-0468800efd8f", null, "ParticuliereHuurder", "PARTICULIEREHUURDER" },
                    { "40bf7415-ba07-4ce9-b214-1e93670c349c", null, "FrontOfficeMedewerker", "FRONTOFFICEMEDEWERKER" },
                    { "74be3864-01bf-46b6-94c5-e55240105842", null, "Admin", "ADMIN" },
                    { "a0446900-6ca2-4f2e-94e0-25c5b650ddd7", null, "ZakelijkeBeheerder", "ZAKELIJKEBEHEERDER" },
                    { "ee13e4cf-562d-46a2-988f-bc565c90ded7", null, "BackOfficeMedewerker", "BACKOFFICEMEDEWERKER" },
                    { "f43d9462-44fe-4575-b20d-8f78f5a3b1c3", null, "ZakelijkeHuurder", "ZAKELIJKEHUURDER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Schades_Voertuigen_VoertuigId",
                table: "Schades",
                column: "VoertuigId",
                principalTable: "Voertuigen",
                principalColumn: "VoertuigId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
