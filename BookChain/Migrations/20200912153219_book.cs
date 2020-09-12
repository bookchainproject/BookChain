using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2d2f5b78-4ae0-4d0e-87d4-71fa7bbe1e66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "21adfb54-0b38-4e8b-9612-e63ee8f7a445");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 192, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9800d6e4-ca74-462c-9c17-88db5dc3833a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7c021dcc-1709-4be9-a829-0426429d9691");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 190, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 25, 56, 195, DateTimeKind.Local).AddTicks(9817));
        }
    }
}
