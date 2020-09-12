using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class DB_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "db4f1709-105d-4ac7-802e-71453c36be2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9bc52d43-2235-40fb-ab8b-e4155516eaaf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 113, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 116, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 49, 10, 117, DateTimeKind.Local).AddTicks(677));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 42, 54, 362, DateTimeKind.Local).AddTicks(7581));

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
    }
}
