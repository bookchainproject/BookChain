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
    public class BooksController : Controller
    {
        private readonly BookChainContext _context;

        public BooksController(BookChainContext context)
        {
            _context = context;
        }

        /*
         * Index    (GET):               /Books/?Params
         * View     (GET):               /Books/Details/ID
         * Restock  (AUTH POST):         /Books/Restock/ID
         * Create   (AUTH GET+POST):     /Books/Create
         * Edit     (AUTH GET+POST):     /Books/Edit/ID
         * Delete   (AUTH GET+DELETE):   /Books/Delete/ID
         */

        // GET: Books
        public async Task<IActionResult> Index(string title, string author, string genre)
        {
            var books = _context.Book.AsQueryable();

            if (!String.IsNullOrWhiteSpace(title))
                books = books.Where(x => x.Title.Contains(title));
            if (!String.IsNullOrWhiteSpace(author))
                books = books.Where(x => x.Author.Contains(author));
            if (!String.IsNullOrWhiteSpace(genre))
                books = books.Where(x => x.Genre.Contains(genre));

            return View(await books.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Restock/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Restock(int id, [Bind("addedQuantity")] int addedQuantity, string returnUrl = null)
        {
            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid && addedQuantity >= 0)
            {
                try
                {
                    book.Quantity += addedQuantity;
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
            }
            return RedirectToAction(nameof(Details), new { id = id });
        }

        // GET: Books/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Title,Author,ReleaseDate,Rating,Genre,AgeRangeMin,AgeRangeMax,Price,Quantity")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                TweetAboutNewBook(book);

                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Author,ReleaseDate,Rating,Genre,AgeRangeMin,AgeRangeMax,Price")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
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
            return View(book);
        }

        // GET: Books/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.Id == id);
        }
        
        private void TweetAboutNewBook(Book book)
        {
            var service = new TwitterService("M0iDSP4FqLIjpuXpE3qEosbaE", "EOr8rZzG6KrQ0ldGVb2ETAFe8VisaSnDr7Jg60wWVBai2ljzhx");
            service.AuthenticateWith("1165924809106178048-NAOC9da4imiKuySlkMJaGc4rby312e", "6juVINPkQjsjmfao9mMOHIgGMJBrMgJe66XRKEQH7aQZH");

            var tweetHead = "New Book Alert!"; 
            var bookInfo = book.Title + " by " + book.Author;
            if (book.Rating > 8.5)
            {
                bookInfo += " with an incredible rating of " + book.Rating;
            }
            else if (book.Rating < 1.1)
            {
                bookInfo += ", a masterpiece with fabulous rating of " + book.Rating;
            }
            var bookStatus = "Only " + book.Quantity.ToString() + " left, for only " + book.Price.ToString() + "$ each";
            var tweetEnd = "Currently we have " + _context.Book.Count(e => e.Quantity > 0).ToString() + " different books";

            TwitterStatus result = service.SendTweet(new SendTweetOptions
            {
                Status = tweetHead + "\n" + bookInfo + "\n" + bookStatus + "\n" + tweetEnd
            });
        }
    }
}
