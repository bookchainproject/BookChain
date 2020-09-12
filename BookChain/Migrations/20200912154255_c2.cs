using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class c2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5849bdc4-30b2-4340-8e2b-e72e48e34f61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b3999055-4e21-44df-837f-e12155392743");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 358, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 361, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "heizer@gmail.com", new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581), "Miles Heizer", "125-458985659" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3c18b379-9d9a-43b8-8b90-9a63afac8e73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b1092f27-c448-4971-ae5f-da0d78b308b3");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 746, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 749, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "liroasdasd@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "Lior Somdit", "192-123591" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));
        }
    }
}
