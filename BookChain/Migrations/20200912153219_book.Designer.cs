﻿// <auto-generated />
using System;
using BookChain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookChain.Migrations
{
    [DbContext(typeof(BookChainContext))]
    [Migration("20200912153219_book")]
    partial class book
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookChain.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeRangeMax");

                    b.Property<int>("AgeRangeMin");

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Genre");

                    b.Property<int>("Price");

                    b.Property<int>("Quantity");

                    b.Property<float>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgeRangeMax = 120,
                            AgeRangeMin = 14,
                            Author = "J.K. Rowling",
                            Genre = "Fantasy",
                            Price = 20,
                            Quantity = 10,
                            Rating = 9f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 192, DateTimeKind.Local).AddTicks(2090),
                            Title = "Harry Potter and the Half-Blood Prince"
                        },
                        new
                        {
                            Id = 2,
                            AgeRangeMax = 50,
                            AgeRangeMin = 16,
                            Author = "J. R. R. Tolkien",
                            Genre = "Fantasy",
                            Price = 40,
                            Quantity = 3,
                            Rating = 10f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "Lord of the Rings"
                        },
                        new
                        {
                            Id = 3,
                            AgeRangeMax = 60,
                            AgeRangeMin = 18,
                            Author = "G R R Martin",
                            Genre = "Fantasy",
                            Price = 40,
                            Quantity = 11,
                            Rating = 7f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = 4,
                            AgeRangeMax = 32,
                            AgeRangeMin = 19,
                            Author = "Guillermo del Toro",
                            Genre = "Horror",
                            Price = 40,
                            Quantity = 7,
                            Rating = 8f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "Pan's Labyrinth"
                        },
                        new
                        {
                            Id = 5,
                            AgeRangeMax = 60,
                            AgeRangeMin = 14,
                            Author = "J.K. Rowling",
                            Genre = "Fantasy",
                            Price = 67,
                            Quantity = 24,
                            Rating = 8f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "Harry Potter and the Prisoner of Azkaban"
                        },
                        new
                        {
                            Id = 6,
                            AgeRangeMax = 99,
                            AgeRangeMin = 14,
                            Author = "J. R. R. Tolkien",
                            Genre = "Fantasy",
                            Price = 30,
                            Quantity = 18,
                            Rating = 8f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 7,
                            AgeRangeMax = 67,
                            AgeRangeMin = 18,
                            Author = "Philip  Pullman",
                            Genre = "Fantasy",
                            Price = 23,
                            Quantity = 45,
                            Rating = 6f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "His Dark Materials"
                        },
                        new
                        {
                            Id = 8,
                            AgeRangeMax = 50,
                            AgeRangeMin = 14,
                            Author = "Bram Stoker",
                            Genre = "Horror",
                            Price = 54,
                            Quantity = 35,
                            Rating = 8f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "Dracula"
                        },
                        new
                        {
                            Id = 9,
                            AgeRangeMax = 90,
                            AgeRangeMin = 30,
                            Author = "Kevlin Henney",
                            Genre = "Programming",
                            Price = 80,
                            Quantity = 42,
                            Rating = 6f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "97 Things every java programmer should know"
                        },
                        new
                        {
                            Id = 10,
                            AgeRangeMax = 70,
                            AgeRangeMin = 18,
                            Author = "Uncle Bob",
                            Genre = "Programming",
                            Price = 128,
                            Quantity = 37,
                            Rating = 8f,
                            ReleaseDate = new DateTime(2020, 9, 12, 18, 32, 19, 196, DateTimeKind.Local).AddTicks(1850),
                            Title = "Effective Java"
                        });
                });

            modelBuilder.Entity("BookChain.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingNumber");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("OpeningHours")
                        .IsRequired();

                    b.Property<string>("Owner")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Branch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingNumber = 2,
                            City = "Rishon Lezion",
                            Country = "Israel",
                            Name = "Bookstore Of Colman",
                            OpeningHours = "08:00 - 20:00",
                            Owner = "the dicant",
                            Phone = "03-9634390",
                            Street = "HaDayagim"
                        },
                        new
                        {
                            Id = 2,
                            BuildingNumber = 10,
                            City = "Tel Aviv",
                            Country = "Israel",
                            Name = "Books in the Shuk",
                            OpeningHours = "09:00 - 18:00",
                            Owner = "Adam Adamson",
                            Phone = "052-25648562",
                            Street = "Allenby"
                        },
                        new
                        {
                            Id = 3,
                            BuildingNumber = 33,
                            City = "Bat Yam",
                            Country = "Israel",
                            Name = "Bookstore Of Mermaids",
                            OpeningHours = "06:00 - 17:00",
                            Owner = "Aquaman",
                            Phone = "050-652684",
                            Street = "Ha-Rav Nisanbaum"
                        },
                        new
                        {
                            Id = 4,
                            BuildingNumber = 76,
                            City = "Tel Aviv-Yafo",
                            Country = "Israel",
                            Name = "Fantasy and other vegetables",
                            OpeningHours = "11:00 - 18:30",
                            Owner = "comic man",
                            Phone = "058-642869",
                            Street = "Frishman"
                        },
                        new
                        {
                            Id = 5,
                            BuildingNumber = 100,
                            City = "Haifa",
                            Country = "Israel",
                            Name = "Bookstore Of Science",
                            OpeningHours = "08:00 - 20:00",
                            Owner = "The great geek",
                            Phone = "04-2564826",
                            Street = "Stella Maris"
                        });
                });

            modelBuilder.Entity("BookChain.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1981, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "MosheShuki@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Moshe Shuki Maashush",
                            Phone = "999-9999999"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1999, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Stichland@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Stich Hood",
                            Phone = "404-4045404"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1997, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "naaman123@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Naaman Tsur",
                            Phone = "054-342342"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1999, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "liroasdasd@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Lior Somdit",
                            Phone = "192-123591"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1968, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "southerntemoke@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Kelsang forbes",
                            Phone = "152-1637894"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1965, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yokoyarocks@gmail.com",
                            JoinDate = new DateTime(2020, 9, 12, 18, 32, 19, 197, DateTimeKind.Local).AddTicks(1851),
                            Name = "Jianzhu thumb",
                            Phone = "152-9182734"
                        });
                });

            modelBuilder.Entity("BookChain.Models.Purchase.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("BuyerId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PaidPrice");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("BookChain.Models.Worker.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime>("JoinDate");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime>("ResignationDate");

                    b.Property<int>("Salary");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BookChain.Models.Worker.WorkerRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "2d2f5b78-4ae0-4d0e-87d4-71fa7bbe1e66",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "21adfb54-0b38-4e8b-9612-e63ee8f7a445",
                            Name = "Worker",
                            NormalizedName = "WORKER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookChain.Models.Purchase.Purchase", b =>
                {
                    b.HasOne("BookChain.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookChain.Models.Customer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookChain.Models.Worker.Worker", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BookChain.Models.Worker.WorkerRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BookChain.Models.Worker.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BookChain.Models.Worker.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BookChain.Models.Worker.WorkerRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookChain.Models.Worker.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BookChain.Models.Worker.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
