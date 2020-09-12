using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookChain.Models.Worker;

namespace BookChain.Data
{
    public class BookChainInititalizer
    {
        public static void SeedUsers(BookChainUserManager userManager)
        {
            // throw new NotImplementedException();
            if (userManager.FindByEmailAsync("admin@book.chain").Result == null)
            {
                Worker admin = new Worker
                {
                    UserName = "Admin",
                    Email = "admin@book.chain",
                    Name = "Manager",
                    Phone = "000-0000000",
                    Salary = 0,
                    JoinDate = DateTime.Now
                };

                IdentityResult result = userManager.CreateAsync(admin, "root123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "Admin").Wait();
                }
                else
                {
                    throw new Exception("Unable to create admin manager");
                }
            }

            if (userManager.FindByEmailAsync("nobody@book.chain").Result == null)
            {
                Worker worker = new Worker
                {
                    UserName = "Nobody",
                    Email = "nobody@nowhere.com",
                    Name = "Israel Israeli",
                    Phone = "052-4625684",
                    Salary = 32,
                    JoinDate = DateTime.Now
                };

                IdentityResult result = userManager.CreateAsync(worker, "nobody1").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(worker, "Worker").Wait();
                }
                else
                {
                    throw new Exception("Unable to create first worker");
                }
            }

            if (userManager.FindByEmailAsync("itamar@book.chain").Result == null)
            {
                Worker worker = new Worker
                {
                    UserName = "Itamar",
                    Email = "itamar@book.chain",
                    Name = "Itamar",
                    Phone = "050-1234567",
                    Salary = 6258,
                    JoinDate = DateTime.Now
                };

                IdentityResult result = userManager.CreateAsync(worker, "itamar-marom1").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(worker, "Worker").Wait();
                }
                else
                {
                    throw new Exception("Unable to create second worker");
                }
            }

            if (userManager.FindByEmailAsync("jack@book.chain").Result == null)
            {
                Worker worker = new Worker
                {
                    UserName = "jack",
                    Email = "jack@book.chain",
                    Name = "Jack",
                    Phone = "050-416567",
                    Salary = 5000,
                    JoinDate = DateTime.Now
                };

                IdentityResult result = userManager.CreateAsync(worker, "mexico2020").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(worker, "Worker").Wait();
                }
                else
                {
                    throw new Exception("Unable to create third worker");
                }
            }

        }
    }
}
