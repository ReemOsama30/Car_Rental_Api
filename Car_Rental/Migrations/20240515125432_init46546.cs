using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Rental.Migrations
{
    /// <inheritdoc />
    public partial class init46546 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Maintenance_MaintenanceId",
                table: "Payments");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27a9b558-1725-4e9a-a5c0-01306e096a3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "366354c7-6fea-40d9-b4d2-328a2ce75982");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41f4dce3-62c5-435a-ae0d-ccd93cff3a4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737c313f-a5cb-4c58-ba57-1e85e52a118b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c3304fe-f33c-4811-9f16-cd011aabc0c7");

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01637d59-93d9-4e60-9f27-242674c9dabb", 0, "egypt", "042d4718-581e-480b-a89e-a0c7f4a3ff28", "user2@example.com", false, false, false, null, "Jane", null, null, "Doe", "+1-555-5678", false, "bbb760bb-6542-46fa-8e41-e1ff46b3499f", false, "user2@example.com" },
                    { "67b2962b-71c0-4f5b-aed5-5963b1bba0dd", 0, "egypt", "2ce6bd82-0c1a-46e2-9eb4-05a95e0a0614", "user4@example.com", false, false, false, null, "Emily", null, null, "Johnson", "+1-555-3456", false, "d826c0d7-9755-4019-b664-c40bc23e3763", false, "user4@example.com" },
                    { "cc6c7669-2b82-42ee-9d66-29aea3d463e6", 0, "egypt", "53b09e47-72d0-479b-85dd-b9711559a473", "user5@example.com", false, false, false, null, "Brown", null, null, "William", "+1-555-7890", false, "5b5e74d1-2273-4191-8ff4-301dc8bac29b", false, "user5@example.com" },
                    { "cce7a5a5-8a0d-4eb4-a406-51b75404d318", 0, "egypt", "cd8069c0-956a-452b-98c1-406d1471ce37", "user3@example.com", false, false, false, null, "Michael", null, null, "Smith", "+1-555-9012", false, "7400e3a3-2b45-4bca-bbeb-2c2d047aacfc", false, "user3@example.com" },
                    { "d914d8c5-7e42-4df6-8d88-1d4ce1a38fe3", 0, "egypt", "c96a93cb-b876-4f0e-b1e0-18dc7fd6f7b8", "user1@example.com", false, false, false, null, "John", null, null, "Doe", "+1-555-1234", false, "696d7b1b-3ccb-4edd-beb1-9134804c662e", false, "user1@example.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Maintenance_MaintenanceId",
                table: "Payments",
                column: "MaintenanceId",
                principalTable: "Maintenance",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Maintenance_MaintenanceId",
                table: "Payments");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01637d59-93d9-4e60-9f27-242674c9dabb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b2962b-71c0-4f5b-aed5-5963b1bba0dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc6c7669-2b82-42ee-9d66-29aea3d463e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cce7a5a5-8a0d-4eb4-a406-51b75404d318");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d914d8c5-7e42-4df6-8d88-1d4ce1a38fe3");

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27a9b558-1725-4e9a-a5c0-01306e096a3a", 0, "egypt", "e669acd3-b59d-425d-b24d-51c60703bc58", "user2@example.com", false, false, false, null, "Jane", null, null, "Doe", "+1-555-5678", false, "b802d717-e5d6-469d-a129-88825d01576d", false, "user2@example.com" },
                    { "366354c7-6fea-40d9-b4d2-328a2ce75982", 0, "egypt", "873580d6-7686-499e-be7c-58877e8daa53", "user4@example.com", false, false, false, null, "Emily", null, null, "Johnson", "+1-555-3456", false, "51cc11ef-7b16-4003-9b04-7041bcefa7a0", false, "user4@example.com" },
                    { "41f4dce3-62c5-435a-ae0d-ccd93cff3a4c", 0, "egypt", "f565282c-c420-4f8b-9e0d-85c5fb088e9d", "user1@example.com", false, false, false, null, "John", null, null, "Doe", "+1-555-1234", false, "fded7c7b-8c80-405c-b377-e06c5fa15291", false, "user1@example.com" },
                    { "737c313f-a5cb-4c58-ba57-1e85e52a118b", 0, "egypt", "f28358ce-519d-461f-a94d-6ee6db763c7e", "user5@example.com", false, false, false, null, "Brown", null, null, "William", "+1-555-7890", false, "351e2091-554d-46a1-9c2c-dd29e317dbf6", false, "user5@example.com" },
                    { "8c3304fe-f33c-4811-9f16-cd011aabc0c7", 0, "egypt", "03d50961-3167-4c43-a1d1-699b6de22f1e", "user3@example.com", false, false, false, null, "Michael", null, null, "Smith", "+1-555-9012", false, "5bcdeb65-d10e-4f23-9d05-9f569a231d1b", false, "user3@example.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Maintenance_MaintenanceId",
                table: "Payments",
                column: "MaintenanceId",
                principalTable: "Maintenance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
