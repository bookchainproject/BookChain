using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AgeRangeMax", "Author", "Quantity", "ReleaseDate", "Title" },
                values: new object[] { 120, "J.K. Rowling", 10, new DateTime(2020, 9, 12, 18, 25, 56, 190, DateTimeKind.Local).AddTicks(9826), "Harry Potter and the Half-Blood Prince" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgeRangeMax", "Author", "ReleaseDate", "Title" },
                values: new object[] { 50, "J. R. R. Tolkien", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "Lord of the Rings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 60, 18, "G R R Martin", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "A Game of Thrones" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ReleaseDate", "Title" },
                values: new object[] { "Guillermo del Toro", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "Pan's Labyrinth" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 60, 14, "J.K. Rowling", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "Harry Potter and the Prisoner of Azkaban" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AgeRangeMin", "ReleaseDate" },
                values: new object[] { 14, new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "Philip  Pullman", 6f, new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "His Dark Materials" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 50, 14, "Bram Stoker", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "Dracula" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 90, 30, "Kevlin Henney", 6f, new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801), "97 Things every java programmer should know" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AgeRangeMax", "Author", "ReleaseDate" },
                values: new object[] { 70, "Uncle Bob", new DateTime(2020, 9, 12, 18, 25, 56, 194, DateTimeKind.Local).AddTicks(9801) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4b1dcd14-e77e-47a6-b929-1da4fe539ee8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b0bf9945-30a2-478c-ad2a-92fc2ab6fa46");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgeRangeMax", "Author", "Quantity", "ReleaseDate", "Title" },
                values: new object[] { 28, "Naoki Yoshida", 5, new DateTime(2020, 9, 12, 17, 59, 23, 780, DateTimeKind.Local).AddTicks(5743), "A Realm Reborn" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgeRangeMax", "Author", "ReleaseDate", "Title" },
                values: new object[] { 28, "Naoki Yoshida", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "Heavensward" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 22, 14, "Naoki Yoshida", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "Stormblood" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ReleaseDate", "Title" },
                values: new object[] { "Naoki Yoshida", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "Shadowbringers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 55, 16, "F. C. Yee", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "The rise of Kyoshi" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AgeRangeMin", "ReleaseDate" },
                values: new object[] { 6, new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "H. P. Lovecraft", 8f, new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "The Call of Cthulhu" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "ReleaseDate", "Title" },
                values: new object[] { 33, 16, "Someone Someonegton", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "Dexter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AgeRangeMax", "AgeRangeMin", "Author", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 67, 18, "Uncle Bob", 8f, new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741), "Clean Code" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AgeRangeMax", "Author", "ReleaseDate" },
                values: new object[] { 67, "Coder Coddington", new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 784, DateTimeKind.Local).AddTicks(5734));
        }
    }
}
