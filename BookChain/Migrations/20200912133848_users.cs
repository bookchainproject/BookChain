using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookChain.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    ResignationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    AgeRangeMin = table.Column<int>(nullable: false),
                    AgeRangeMax = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    BuildingNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Owner = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    OpeningHours = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    PaidPrice = table.Column<int>(nullable: false),
                    SellerId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Customer_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 2, "caa257a1-4432-42cd-b9bc-7166ecb318c6", "Worker", "WORKER" },
                    { 1, "cde8f18f-1301-4dab-bbdf-b8147c985af2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AgeRangeMax", "AgeRangeMin", "Author", "Genre", "Price", "Quantity", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 10, 67, 18, "Coder Coddington", "Programming", 128, 37, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Effective Java" },
                    { 9, 67, 18, "Uncle Bob", "Programming", 80, 42, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Clean Code" },
                    { 8, 33, 16, "Someone Someonegton", "Horror", 54, 35, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Dexter" },
                    { 7, 67, 18, "H. P. Lovecraft", "Fantasy", 23, 45, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "The Call of Cthulhu" },
                    { 1, 28, 14, "Naoki Yoshida", "Fantasy", 20, 5, 9f, new DateTime(2020, 9, 12, 16, 38, 47, 509, DateTimeKind.Local).AddTicks(8199), "A Realm Reborn" },
                    { 5, 55, 16, "F. C. Yee", "Fantasy", 67, 24, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "The rise of Kyoshi" },
                    { 4, 32, 19, "Naoki Yoshida", "Horror", 40, 7, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Shadowbringers" },
                    { 3, 22, 14, "Naoki Yoshida", "Fantasy", 40, 11, 7f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Stormblood" },
                    { 2, 28, 16, "Naoki Yoshida", "Fantasy", 40, 3, 10f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "Heavensward" },
                    { 6, 99, 6, "J. R. R. Tolkien", "Fantasy", 30, 18, 8f, new DateTime(2020, 9, 12, 16, 38, 47, 512, DateTimeKind.Local).AddTicks(8204), "The Hobbit" }
                });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "BuildingNumber", "City", "Country", "Name", "OpeningHours", "Owner", "Phone", "Street" },
                values: new object[,]
                {
                    { 1, 2, "Rishon Lezion", "Israel", "Bookstore Of Managmenet", "08:00 - 20:00", "Doctor Shakshuka", "03-9634390", "HaDayagim" },
                    { 3, 8, "Eilat", "Israel", "Bookstore Of Seas", "06:00 - 17:00", "Mister Surfer", "050-2386234", "Agmonim" },
                    { 4, 1, "Tiberias", "Israel", "Bookstore Of Nothing", "11:00 - 22:00", "Cool Chiller", "08-9423665", "HaKishon" },
                    { 5, 26, "Haifa", "Israel", "Bookstore Of Spades", "08:00 - 21:00", "Mad Scientist", "04-5371945", "Tchernichovski" },
                    { 2, 4, "Tel Aviv", "Israel", "Bookstore Of Parties", "09:00 - 18:00", "Lady Luck", "052-0522250", "Shaul Hamelech" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "BirthDate", "Email", "JoinDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "MosheShuki@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Moshe Shuki Maashush", "999-9999999" },
                    { 2, new DateTime(1999, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stichland@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Stich Hood", "404-4045404" },
                    { 3, new DateTime(1997, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "naaman123@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Naaman Tsur", "054-342342" },
                    { 4, new DateTime(1999, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "liroasdasd@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Lior Somdit", "192-123591" },
                    { 5, new DateTime(1968, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "southerntemoke@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Kelsang forbes", "152-1637894" },
                    { 6, new DateTime(1965, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "yokoyarocks@gmail.com", new DateTime(2020, 9, 12, 16, 38, 47, 513, DateTimeKind.Local).AddTicks(8206), "Jianzhu thumb", "152-9182734" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_BookId",
                table: "Purchase",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_BuyerId",
                table: "Purchase",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_SellerId",
                table: "Purchase",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
