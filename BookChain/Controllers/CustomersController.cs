using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookChain.Data;
using BookChain.Models;
using Microsoft.AspNetCore.Authorization;
using TweetSharp;

namespace BookChain.Controllers
{
    public class CustomersController : Controller
    {
        private readonly BookChainContext _context;

        public CustomersController(BookChainContext context)
        {
            _context = context;
        }

        public bool IsPhoneAvailable(string phone)
        {
            return !CustomerExistsByPhone(phone);
        }

        /*
         * Index        (AUTH GET):          /Customers/?Params
         * View         (AUTH GET):          /Customers/Details/ID
         * Create       (AUTH GET+POST):     /Customers/Create
         * Edit         (AUTH GET+POST):     /Customers/Edit/ID
         * Delete       (AUTH GET+DELETE):   /Customers/Delete/ID
         */

        // GET: Customers
        [Authorize]
        public async Task<IActionResult> Index(string name, string phone, string email)
        {
            var customers = _context.Customer.AsQueryable();

            if (!String.IsNullOrWhiteSpace(name))
                customers = customers.Where(x => x.Name.Contains(name));
            if (!String.IsNullOrWhiteSpace(phone))
                customers = customers.Where(x => x.Phone.Contains(phone));
            if (!String.IsNullOrWhiteSpace(email))
                customers = customers.Where(x => x.Email.Contains(email));

            return View(await customers.ToListAsync());
        }

        // GET: Customers/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Name,Phone,Email,BirthDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.JoinDate = DateTime.Now;
                _context.Add(customer);
                await _context.SaveChangesAsync();
                TweetIfNewCustomersMilestone();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Phone,Email,BirthDate")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }

        private bool CustomerExistsByPhone(string phone)
        {
            return _context.Customer.Any(e => e.Phone.Equals(phone));
        }

        private void TweetIfNewCustomersMilestone()
        {
            const int MILESTONE_INDICATOR = 2;
            var numOfCustomers = _context.Customer.Count();
            if (numOfCustomers % MILESTONE_INDICATOR == 0 || numOfCustomers == 69 || numOfCustomers == 420)
            {
                System.Threading.Thread.Sleep(1000);  // sleep needed to insure tweet is sent
                var service = new TwitterService("M0iDSP4FqLIjpuXpE3qEosbaE", "EOr8rZzG6KrQ0ldGVb2ETAFe8VisaSnDr7Jg60wWVBai2ljzhx");
                service.AuthenticateWith("1165924809106178048-NAOC9da4imiKuySlkMJaGc4rby312e", "6juVINPkQjsjmfao9mMOHIgGMJBrMgJe66XRKEQH7aQZH");
                
                var tweetHead = "New Customer Milestone!";
                var announcement = "As of this moment we oficially have " + numOfCustomers + " customers.";

                TwitterStatus result = service.SendTweet(new SendTweetOptions
                {
                    Status = tweetHead + "\n" + announcement
                });
            }
        }
    }
}
