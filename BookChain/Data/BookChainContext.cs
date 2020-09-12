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
                Name = "Moshe Shuki Maashush",
                Phone = "999-9999999",
                Email = "MosheShuki@gmail.com",
                BirthDate = new DateTime(1981, 3, 23),
                JoinDate = DateTime.Now,
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                Name = "Stich Hood",
                Phone = "404-4045404",
                Email = "Stichland@gmail.com",
                BirthDate = new DateTime(1999, 8, 5),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                Name = "Naaman Tsur",
                Phone = "054-342342",
                Email = "naaman123@gmail.com",
                BirthDate = new DateTime(1997, 12, 17),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 4,
                Name = "Lior Somdit",
                Phone = "192-123591",
                Email = "liroasdasd@gmail.com",
                BirthDate = new DateTime(1999, 1, 17),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 5,
                Name = "Kelsang forbes",
                Phone = "152-1637894",
                Email = "southerntemoke@gmail.com",
                BirthDate = new DateTime(1968, 8, 5),
                JoinDate = DateTime.Now,
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 6,
                Name = "Jianzhu thumb",
                Phone = "152-9182734",
                Email = "yokoyarocks@gmail.com",
                BirthDate = new DateTime(1965, 9, 5),
                JoinDate = DateTime.Now,
            });
        }

        private static void AddSeededBooks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "A Realm Reborn",
                Author = "Naoki Yoshida",
                ReleaseDate = DateTime.Now,
                Rating = 9.0f,
                Genre = "Fantasy",
                AgeRangeMin = 14,
                AgeRangeMax = 28,
                Price = 20,
                Quantity = 5,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Heavensward",
                Author = "Naoki Yoshida",
                ReleaseDate = DateTime.Now,
                Rating = 10.0f,
                Genre = "Fantasy",
                AgeRangeMin = 16,
                AgeRangeMax = 28,
                Price = 40,
                Quantity = 3,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "Stormblood",
                Author = "Naoki Yoshida",
                ReleaseDate = DateTime.Now,
                Rating = 7.0f,
                Genre = "Fantasy",
                AgeRangeMin = 14,
                AgeRangeMax = 22,
                Price = 40,
                Quantity = 11,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "Shadowbringers",
                Author = "Naoki Yoshida",
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
                Title = "The rise of Kyoshi",
                Author = "F. C. Yee",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Fantasy",
                AgeRangeMin = 16,
                AgeRangeMax = 55,
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
                AgeRangeMin = 6,
                AgeRangeMax = 99,
                Price = 30,
                Quantity = 18,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                Title = "The Call of Cthulhu",
                Author = "H. P. Lovecraft",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Fantasy",
                AgeRangeMin = 18,
                AgeRangeMax = 67,
                Price = 23,
                Quantity = 45,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "Dexter",
                Author = "Someone Someonegton",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Horror",
                AgeRangeMin = 16,
                AgeRangeMax = 33,
                Price = 54,
                Quantity = 35,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "Clean Code",
                Author = "Uncle Bob",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Programming",
                AgeRangeMin = 18,
                AgeRangeMax = 67,
                Price = 80,
                Quantity = 42,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "Effective Java",
                Author = "Coder Coddington",
                ReleaseDate = DateTime.Now,
                Rating = 8.0f,
                Genre = "Programming",
                AgeRangeMin = 18,
                AgeRangeMax = 67,
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
