using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class costumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "lopez@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "George Lopez", "111-9911199" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "JoinDate", "Name" },
                values: new object[] { "johnny@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "Johnny Deep" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "jackzaf@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "Jack Zafrani", "058-78594785" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "JoinDate", "Name" },
                values: new object[] { "vladdie@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "Vlad" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "michoacan@gmail.com", new DateTime(2020, 9, 12, 18, 40, 39, 750, DateTimeKind.Local).AddTicks(1067), "Joan Sebastian", "125-154589635" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "MosheShuki@gmail.com", new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851), "Moshe Shuki Maashush", "999-9999999" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "JoinDate", "Name" },
                values: new object[] { "Stichland@gmail.com", new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851), "Stich Hood" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "naaman123@gmail.com", new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851), "Naaman Tsur", "054-342342" });

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
                columns: new[] { "Email", "JoinDate", "Name" },
                values: new object[] { "southerntemoke@gmail.com", new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851), "Kelsang forbes" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "JoinDate", "Name", "Phone" },
                values: new object[] { "yokoyarocks@gmail.com", new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851), "Jianzhu thumb", "152-9182734" });
        }
    }
}
