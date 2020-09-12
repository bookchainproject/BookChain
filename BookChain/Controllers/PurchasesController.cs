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
using System.Linq.Expressions;
using BookChain.Models.Purchase;
using BookChain.Models.Worker;

namespace BookChain.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly BookChainContext _context;
        private readonly BookChainUserManager _userManager;

        public PurchasesController(BookChainContext context,
                                   BookChainUserManager userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        /*
         * Index            (AUTH GET):          /Purchases/?Params
         * Buy              (AUTH GET+POST):     /Purchases/Buy/?Params
         * Receipt          (AUTH GET):          /Purchases/Receipt/ID
         * BooksStatistics  (AUTH GET):          /Purchases/BooksStatistics
         * GenersStatistics (AUTH GET):          /Purchases/GenersStatistics
         * DatesStatistics  (AUTH GET):          /Purchases/DatesStatistics
         */

        // GET: Purchases
        [Authorize]
        public async Task<IActionResult> Index(string buyerName, string buyerPhone, string bookTitle, string sellerName)
        {
            var purchases = _context.Purchase
                .Join(_context.Customer,        // Get buyer info from customers with purchase's buyer ID
                      purchaseSelector => purchaseSelector.BuyerId,
                      customerSelector => customerSelector.Id,
                (purchase, customer) => new Purchase()
                {
                    // Keep purchase data
                    Id = purchase.Id,
                    PaidPrice = purchase.PaidPrice,
                    OrderDate = purchase.OrderDate,
                    BookId = purchase.BookId,
                    Book = purchase.Book,
                    SellerId = purchase.SellerId,
                    Seller = purchase.Seller,

                    // Get buyer data
                    BuyerId = customer.Id,
                    Buyer = customer
                }).Join(_context.Book,          // Get book info from books with purchase's book ID
                        purchaseSelector => purchaseSelector.BookId,
                        bookSelector => bookSelector.Id,
                (purchase, book) => new Purchase()
                {
                    // Keep purchase data
                    Id = purchase.Id,
                    PaidPrice = purchase.PaidPrice,
                    OrderDate = purchase.OrderDate,
                    BuyerId = purchase.BuyerId,
                    Buyer = purchase.Buyer,
                    SellerId = purchase.SellerId,
                    Seller = purchase.Seller,

                    // Get book data
                    BookId = book.Id,
                    Book = book
                }).Join(_userManager.Users,     // Get seller info from users with purchase's seller ID
                        purchaseSelector => purchaseSelector.SellerId,
                        workerSelector => workerSelector.Id,
                (purchase, worker) => new Purchase()
                {
                    // Keep purchase data
                    Id = purchase.Id,
                    PaidPrice = purchase.PaidPrice,
                    OrderDate = purchase.OrderDate,
                    BuyerId = purchase.BuyerId,
                    Buyer = purchase.Buyer,
                    BookId = purchase.BookId,
                    Book = purchase.Book,

                    // Get book data
                    SellerId = worker.Id,
                    Seller = worker
                }).Select(m => new              // Combine everything with a SELECT clause
                {
                    // Keep purchase data
                    m.Id,
                    m.PaidPrice,
                    m.OrderDate,
                    m.BuyerId,
                    m.Buyer,
                    m.BookId,
                    m.Book,
                    m.SellerId,
                    m.Seller
                }).AsQueryable();

            if (!String.IsNullOrWhiteSpace(buyerName))
                purchases = purchases.Where(x => x.Buyer.Name.Contains(buyerName));
            if (!String.IsNullOrWhiteSpace(buyerPhone))
                purchases = purchases.Where(x => x.Buyer.Phone.Contains(buyerPhone));
            if (!String.IsNullOrWhiteSpace(bookTitle))
                purchases = purchases.Where(x => x.Book.Title.Contains(bookTitle));
            if (!String.IsNullOrWhiteSpace(sellerName))
                purchases = purchases.Where(x => x.Seller.Name.Contains(sellerName));

            var purchasesViewList = new List<PurchaseModel>();

            try
            {
                var purchasesList = await purchases.ToListAsync();
            
                foreach (var purchase in purchasesList)
                {
                    var view = new PurchaseModel
                    {
                        BuyerName = purchase.Buyer.Name,
                        BuyerPhone = purchase.Buyer.Phone,
                        BookTitle = purchase.Book.Title,
                        PaidPrice = purchase.PaidPrice,
                        SellerName = purchase.Seller.Name,
                        OrderDate = purchase.OrderDate
                    };

                    purchasesViewList.Add(view);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return View(purchasesViewList);
        }

        [Authorize]
        private JsonResult Statistics<T>(Expression<Func<Purchase, T>> keySelector)
        {
            var purchases = _context.Purchase
                .Join(_context.Book,          // Get book info from books with purchase's book ID
                        purchaseSelector => purchaseSelector.BookId,
                        bookSelector => bookSelector.Id,
                (purchase, book) => new Purchase()
                {
                    // Keep purchase data
                    Id = purchase.Id,
                    PaidPrice = purchase.PaidPrice,
                    OrderDate = purchase.OrderDate,
                    BuyerId = purchase.BuyerId,
                    Buyer = purchase.Buyer,
                    SellerId = purchase.SellerId,
                    Seller = purchase.Seller,

                    // Get book data
                    BookId = book.Id,
                    Book = book
                }).GroupBy(keySelector).Select(group => new
                {
                    BookId = group.First().BookId,
                    Genre = group.First().Book.Genre,
                    OrderDate = group.First().OrderDate.Date,
                    Count = group.Count(),
                    Revenue = group.Sum(p => p.PaidPrice)
                }).AsQueryable();

            return Json(purchases);
        }

        [Authorize]
        public JsonResult BooksStatistics()
        {
            return Statistics<int>(p => p.BookId);
        }
        [Authorize]
        public JsonResult GenersStatistics()
        {
            return Statistics<String>(p => p.Book.Genre);
        }
        [Authorize]
        public JsonResult DatesStatistics()
        {
            return Statistics<DateTime>(p => p.OrderDate.Date);
        }

        // GET: Purchases/Buy/?Params
        [Authorize]
        public async Task<IActionResult> Buy(String BuyerPhone, int BookId)
        {
            var worker = await _userManager.GetUserAsync(HttpContext.User);
            if (worker == null)
            {
                return RedirectToAction(nameof(WorkersAuthController.AccessDenied), "WorkersAuth");
            }
            if (!string.IsNullOrEmpty(BuyerPhone))
            {
                PurchaseCreationModel purchase = new PurchaseCreationModel
                {
                    BuyerPhone = BuyerPhone,
                    BookId = BookId
                };
                return View(purchase);
            }
            return View();
        }

        // POST: Purchases/Buy
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Buy([Bind("BuyerPhone,BookId")] PurchaseCreationModel purchaseView)
        {
            Worker worker;
            try
            {
                worker = await _userManager.GetUserAsync(HttpContext.User);
            }
            catch
            {
                return RedirectToAction(nameof(WorkersAuthController.AccessDenied), "WorkersAuth");
            }

            if (worker == null)
            {
                return RedirectToAction(nameof(WorkersAuthController.AccessDenied), "WorkersAuth");
            }

            var workerId = worker.Id;

            if (workerId == 0 || String.IsNullOrWhiteSpace(purchaseView.BuyerPhone))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Find corspond related models
                var buyer = await _context.Customer.FirstOrDefaultAsync(b => b.Phone.Equals(purchaseView.BuyerPhone));
                var seller = await _userManager.Users.FirstOrDefaultAsync(b => b.Id == workerId);
                var book = await _context.Book.FirstOrDefaultAsync(b => b.Id == purchaseView.BookId);

                // Create customer if not found
                if (buyer == null)
                {
                    return RedirectToAction(nameof(CustomersController.Create), "Customers");
                }

                // Login seller if not found
                if (seller == null)
                {
                    return NotFound();
                }

                // Book not available
                if (book == null || book.Quantity == 0)
                {
                    return NotFound();
                }

                Purchase purchase = new Purchase();
                purchase.BuyerId = buyer.Id;
                purchase.BookId = book.Id;
                purchase.PaidPrice = book.Price;
                purchase.SellerId = worker.Id;
                purchase.OrderDate = DateTime.Now;

                _context.Add(purchase);
                await _context.SaveChangesAsync();
                // Waiting for Twitter to accept my developer account
                // TweetIfNewPurchaseMilestone();

                // Update the quantity of the book
                try
                {
                    book.Quantity -= 1;
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Receipt), new { id = purchase.Id });
            }
            return View(purchaseView);
        }

        // GET: Purchases/Receipt/5
        public async Task<IActionResult> Receipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Purchase idPurchase = await _context.Purchase.FirstOrDefaultAsync(m => m.Id == id);
            if (idPurchase == null)
            {
                return NotFound();
            }
            Book idBook = await _context.Book.  // needed to have the book details in the receipt, and for the queries
                FirstOrDefaultAsync(m => m.Id == idPurchase.BookId);
            if (idBook == null)
            {
                return NotFound();
            }
            Customer idCustomer = await _context.Customer  // needed to have the buyer name in the receipt
                .FirstOrDefaultAsync(m => m.Id == idPurchase.BuyerId);
            if (idCustomer == null)
            {
                return NotFound();
            }

            List<Tuple<string, Book>> recommendedBooks = new List<Tuple<string, Book>>();
            // One reccomendation will be based on other customers who bought the same book, one based on books by the same author and just a book with a good rating

            List<int> booksToExcludeFromRecommendations = new List<int>();

            // Add books that are not in stock, or that the customer already owns
            booksToExcludeFromRecommendations.AddRange(await _context.Purchase.Where(p => p.BuyerId == idPurchase.BuyerId).Select(p => p.BookId).ToListAsync());
            booksToExcludeFromRecommendations.AddRange(await _context.Book.Where(b => b.Quantity <= 0).Select(b => b.Id).ToListAsync());

            // Recommendation based on other customers
            IEnumerable<Customer> customersWhoBoughtSameBook = await _context.Purchase.Where(m => m.BookId == idPurchase.BookId && m.BuyerId != idPurchase.BuyerId).Select(m => m.Buyer).Distinct().ToListAsync();
            var recommendedBookByOtherCustomers = customersWhoBoughtSameBook.Join(_context.Purchase,
            customerSelector => customerSelector.Id,
            purchaseSelector => purchaseSelector.BuyerId,
            (customer, purchase) => new
            {
                BookId = purchase.BookId,
            }).Where(p => !booksToExcludeFromRecommendations.Any(p2 => p.BookId == p2)).GroupBy(p => p.BookId)
            .Select(group => new { bookId = group.First().BookId, count = group.Count() }).OrderByDescending(p => p.count).FirstOrDefault();

            if (recommendedBookByOtherCustomers != null)
            {
                var book = await _context.Book
                    .FirstOrDefaultAsync(m => m.Id == recommendedBookByOtherCustomers.bookId);
                if (book == null)
                {
                    return NotFound();
                }

                booksToExcludeFromRecommendations.Add(book.Id);
                recommendedBooks.Add(new Tuple<string, Book>("Others also bought", book));
            }

            // Recommendation based on the author
            var recommendedBookBySameAuthor = await _context.Book.Where(p => p.Author == idBook.Author && !booksToExcludeFromRecommendations.Any(p2 => p.Id == p2)).OrderByDescending(b => b.Rating).FirstOrDefaultAsync();
            if (recommendedBookBySameAuthor != null)
            {
                booksToExcludeFromRecommendations.Add(recommendedBookBySameAuthor.Id);
                recommendedBooks.Add(new Tuple<string, Book>("By the same author", recommendedBookBySameAuthor));
            }

            // Recommendation based on rating
            var recommendedBookByRating = await _context.Book.Where(p => !booksToExcludeFromRecommendations.Any(p2 => p.Id == p2)).OrderByDescending(b => b.Rating).FirstOrDefaultAsync();
            if (recommendedBookByRating != null)
            {
                booksToExcludeFromRecommendations.Add(recommendedBookByRating.Id);
                recommendedBooks.Add(new Tuple<string, Book>("You may also like", recommendedBookByRating));
            }

            // Construct PurchaseReceiptModel object
            var purchaseReceipt = new PurchaseReceiptModel();
            purchaseReceipt.RecentPurchase = idPurchase;
            purchaseReceipt.BookReccomendations = recommendedBooks;

            return View(purchaseReceipt);
        }

        private bool PurchaseExists(int id)
        {
            return _context.Purchase.Any(e => e.Id == id);
        }

        private void TweetIfNewPurchaseMilestone()
        {
            const int MILESTONE_INDICATOR = 100;
            var numOfPurchases = _context.Purchase.Count();
            if (numOfPurchases % MILESTONE_INDICATOR == 0 || numOfPurchases == 69 || numOfPurchases == 420)
            {
                System.Threading.Thread.Sleep(1000);  // sleep needed to insure tweet is sent
                var service = new TwitterService("consumerKey", "consumerSecret");
                service.AuthenticateWith("accessToken", "accessTokenSecret");

                var tweetHead = "New Purchase Milestone!";
                var announcement = "As of this moment we oficially sold " + numOfPurchases + " books.";

                TwitterStatus result = service.SendTweet(new SendTweetOptions
                {
                    Status = tweetHead + "\n" + announcement
                });
            }
        }
    }
}
