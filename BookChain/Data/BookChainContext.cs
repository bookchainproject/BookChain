using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookChain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using BookChain.Models.Worker;
using BookChain.Models.Purchase;

namespace BookChain.Data
{
    public class BookChainContext : IdentityDbContext<Worker, WorkerRole, int>
    {
        public BookChainContext(DbContextOptions<BookChainContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Branch> Branch { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CreateSchemas(modelBuilder);

            CreateUserRoles(modelBuilder);

            AddSeededBooks(modelBuilder);

            // Setting two starting customers
            AddCostumers(modelBuilder);

            // Setting five starting branches
            AddBranches(modelBuilder);
        }

        private static void AddBranches(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 1,
                Country = "Israel",
                City = "Rishon Lezion",
                Street = "HaDayagim",
                BuildingNumber = 2,
                Name = "Bookstore Of Colman",
                Owner = "the dicant",
                Phone = "03-9634390",
                OpeningHours = "08:00 - 20:00"
            });
            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 2,
                Country = "Israel",
                City = "Tel Aviv",
                Street = "Allenby",
                BuildingNumber = 10,
                Name = "Books in the Shuk",
                Owner = "Adam Adamson",
                Phone = "052-25648562",
                OpeningHours = "09:00 - 18:00"
            });

            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 3,
                Country = "Israel",
                City = "Bat Yam",
                Street = "Ha-Rav Nisanbaum",
                BuildingNumber = 33,
                Owner = "Aquaman",
                Phone = "050-652684",
                OpeningHours = "06:00 - 17:00",
                Name = "Bookstore Of Mermaids"
            });

            // Frishman St 76, 
            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 4,
                Country = "Israel",
                Street = "Frishman",
                City = "Tel Aviv-Yafo",
                BuildingNumber = 76,
                Name = "Fantasy and other vegetables",
                Owner = "comic man",
                Phone = "058-642869",
                OpeningHours = "11:00 - 18:30"
            });

            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 5,
                Country = "Israel",
                Street = "Stella Maris",
                City = "Haifa",
                BuildingNumber = 100,
                Name = "Bookstore Of Science",
                Owner = "The great geek",
                Phone = "04-2564826",
                OpeningHours = "08:00 - 20:00"
            });
        }

        private static void AddCostumers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                Name = "George Lopez",
                Phone = "111-9911199",
                Email = "lopez@gmail.com",
                BirthDate = new DateTime(1981, 3, 23),
                JoinDate = DateTime.Now,
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                Name = "Johnny Deep",
                Phone = "404-4045404",
                Email = "johnny@gmail.com",
                BirthDate = new DateTime(1999, 8, 5),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                Name = "Jack Zafrani",
                Phone = "058-78594785",
                Email = "jackzaf@gmail.com",
                BirthDate = new DateTime(1997, 12, 17),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 4,
                Name = "Miles Heizer",
                Phone = "125-458985659",
                Email = "heizer@gmail.com",
                BirthDate = new DateTime(1999, 1, 17),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 5,
                Name = "Vlad",
                Phone = "152-1637894",
                Email = "vladdie@gmail.com",
                BirthDate = new DateTime(1968, 8, 5),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 6,
                Name = "Joan Sebastian",
                Phone = "125-154589635",
                Email = "michoacan@gmail.com",
                BirthDate = new DateTime(1965, 9, 5),
                JoinDate = DateTime.Now,
            });
        }

        private static void AddSeededBooks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Harry Potter and the Half-Blood Prince",
                Author = "J.K. Rowling",
                ReleaseDate = DateTime.Now,
                Rating = 9.0f,
                Genre = "Fantasy",
                AgeRangeMin = 14,
                AgeRangeMax = 120,
                Price = 20,
                Quantity = 10
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Lord of the Rings",
                Author = "J. R. R. Tolkien",
                ReleaseDate = DateTime.Now,
                Rating = 10.0f,
                Genre = "Fantasy",
                AgeRangeMin = 16,
                AgeRangeMax = 50,
                Price = 40,
                Quantity = 3,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "A Game of Thrones",
                Author = "G R R Martin",
                ReleaseDate = DateTime.Now,
                Rating = 7.0f,
                Genre = "Fantasy",
                AgeRangeMin = 18,
                AgeRangeMax = 60,
                Price = 40,
                Quantity = 11,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "Pan's Labyrinth",
                Author = "Guillermo del Toro",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Horror",
                AgeRangeMin = 19,
                AgeRangeMax = 32,
                Price = 40,
                Quantity = 7,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = "J.K. Rowling",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Fantasy",
                AgeRangeMin = 14,
                AgeRangeMax = 60,
                Price = 67,
                Quantity = 24,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                Title = "The Hobbit",
                Author = "J. R. R. Tolkien",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Fantasy",
                AgeRangeMin = 14,
                AgeRangeMax = 99,
                Price = 30,
                Quantity = 18,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                ReleaseDate = DateTime.Now,
                Title = "His Dark Materials",
                Author = "Philip  Pullman",
                Rating = 6.0f,
                Genre = "Fantasy",
                AgeRangeMin = 18,
                AgeRangeMax = 67,
                Price = 23,
                Quantity = 45,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "Dracula",
                Author = "Bram Stoker",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Horror",
                AgeRangeMin = 14,
                AgeRangeMax = 50,
                Price = 54,
                Quantity = 35,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "97 Things every java programmer should know",
                Author = "Kevlin Henney",
                ReleaseDate = DateTime.Now,
                Rating = 6.0f,
                Genre = "Programming",
                AgeRangeMin = 30,
                AgeRangeMax = 90,
                Price = 80,
                Quantity = 42,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "Effective Java",
                Author = "Uncle Bob",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Programming",
                AgeRangeMin = 18,
                AgeRangeMax = 70,
                Price = 128,
                Quantity = 37,
            });
        }

        private static void CreateUserRoles(ModelBuilder modelBuilder)
        {
            // Setting up workers roles
            modelBuilder.Entity<WorkerRole>().HasData(new WorkerRole
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "Admin".ToUpper()
            });

            modelBuilder.Entity<WorkerRole>().HasData(new WorkerRole
            {
                Id = 2,
                Name = "Worker",
                NormalizedName = "Worker".ToUpper()
            });
        }

        private static void CreateSchemas(ModelBuilder modelBuilder)
        {
            // Purchase holds books (many-to-many), with no reference in the book
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Book)
                .WithMany()
                .HasForeignKey(p => p.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // Purchase holds a customer (one-to-one), with no reference in the customer
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Buyer)
                .WithMany()
                .HasForeignKey(p => p.BuyerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Purchase holds a worker (one-to-one), with no reference in the worker
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Seller)
                .WithMany()
                .HasForeignKey(w => w.SellerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Generate IDs for book customer and purchase
            modelBuilder.Entity<Book>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Purchase>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
