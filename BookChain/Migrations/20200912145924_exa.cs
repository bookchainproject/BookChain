using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class exa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 780, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 59, 23, 783, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Owner" },
                values: new object[] { "Bookstore Of Colman", "the dicant" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "Name", "Owner", "Phone", "Street" },
                values: new object[] { 10, "Books in the Shuk", "Adam Adamson", "052-25648562", "Allenby" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "City", "Name", "Owner", "Phone", "Street" },
                values: new object[] { 33, "Bat Yam", "Bookstore Of Mermaids", "Aquaman", "050-652684", "Ha-Rav Nisanbaum" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNumber", "City", "Name", "OpeningHours", "Owner", "Phone", "Street" },
                values: new object[] { 76, "Tel Aviv-Yafo", "Fantasy and other vegetables", "11:00 - 18:30", "comic man", "058-642869", "Frishman" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNumber", "Name", "OpeningHours", "Owner", "Phone", "Street" },
                values: new object[] { 100, "Bookstore Of Science", "08:00 - 20:00", "The great geek", "04-2564826", "Stella Maris" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2be63564-d843-4181-82dd-8d996346d542");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d3ce2573-c4d7-4397-baa8-cc4006c7494d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 342, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 345, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Owner" },
                values: new object[] { "Bookstore Of Managmenet", "Doctor Shakshuka" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "Name", "Owner", "Phone", "Street" },
                values: new object[] { 4, "Bookstore Of Parties", "Lady Luck", "052-0522250", "Shaul Hamelech" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "City", "Name", "Owner", "Phone", "Street" },
                values: new object[] { 8, "Eilat", "Bookstore Of Seas", "Mister Surfer", "050-2386234", "Agmonim" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNumber", "City", "Name", "OpeningHours", "Owner", "Phone", "Street" },
                values: new object[] { 1, "Tiberias", "Bookstore Of Nothing", "11:00 - 22:00", "Cool Chiller", "08-9423665", "HaKishon" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNumber", "Name", "OpeningHours", "Owner", "Phone", "Street" },
                values: new object[] { 26, "Bookstore Of Spades", "08:00 - 21:00", "Mad Scientist", "04-5371945", "Tchernichovski" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "JoinDate",
                value: new DateTime(2020, 9, 12, 17, 30, 38, 346, DateTimeKind.Local).AddTicks(8459));
        }
    }
}
