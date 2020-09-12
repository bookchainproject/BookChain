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
using BookChain.Models.Worker;

namespace BookChain.Controllers
{
    public class WorkersController : Controller
    {
        private readonly BookChainUserManager _userManager;

        public WorkersController(BookChainUserManager userManager)
        {
            _userManager = userManager;
        }
        public bool IsPhoneAvailable(string phone)
        {
            return !WorkerExistsByPhone(phone);
        }

        public bool IsEmailAvailable(string email)
        {
            return !WorkerExistsByEmail(email);
        }

        /*
         * Index        (AUTH GET):           /Workers/?Params
         * View         (AUTH GET):           /Workers/Details/ID
         * Fire         (ADMIN POST):         /Workers/Fire/ID
         * Search       (AUTH GET):           /Workers/Search/ID?Params
         * Create       (ADMIN GET+POST):     /Workers/Create
         * Edit         (SELF GET+POST):      /Workers/Edit
         * MyPage       (SELF GET):           /Workers/MyPage
         * Delete       (ADMIN GET+DELETE):   /Workers/Delete/ID
         */

        // GET: Workers
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index(string name, string phone, string email)
        {
            var workers = _userManager.Users.AsQueryable();

            if (!String.IsNullOrWhiteSpace(name))
                workers = workers.Where(x => x.Name.Contains(name));
            if (!String.IsNullOrWhiteSpace(phone))
                workers = workers.Where(x => x.Phone.Contains(phone));
            if (!String.IsNullOrWhiteSpace(email))
                workers = workers.Where(x => x.Email.Contains(email));

            workers = workers.Where(x => x.ResignationDate.Equals(new DateTime()));

            return View(await workers.ToListAsync());
        }

        // GET: Workers/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _userManager.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null)
            {
                return NotFound();
            }

            return View(worker);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Fire(int id, string returnUrl = null)
        {
            var worker = await _userManager.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    worker.ResignationDate = DateTime.Now;
                    var result = await _userManager.UpdateAsync(worker);
                    if (!result.Succeeded)
                    {
                        return NotFound();
                    }

                    result = await _userManager.RemoveFromRoleAsync(worker, "Worker");
                    if (!result.Succeeded)
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(worker.Id))
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
            return RedirectToAction(nameof(Index));
        }

        // GET: Workers/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Name,Phone,Salary,Email,Password")] WorkerCreationModel workerCreation)
        {
            if (ModelState.IsValid)
            {
                Worker worker = new Worker
                {
                    UserName = workerCreation.Email,
                    Email = workerCreation.Email,
                    Name = workerCreation.Name,
                    Phone = workerCreation.Phone,
                    Salary = workerCreation.Salary,
                    JoinDate = DateTime.Now
                };

                var result = await _userManager.CreateAsync(worker, workerCreation.Password);
                if (!result.Succeeded)
                {
                    return View(workerCreation);
                }
                result = await _userManager.AddToRoleAsync(worker, "Worker");
                if (!result.Succeeded)
                {
                    return View(workerCreation);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(workerCreation);
        }

        // GET: Workers/MyPage
        public async Task<IActionResult> MyPage()
        {
            var worker = await _userManager.GetUserAsync(HttpContext.User);
            if (worker == null)
            {
                return RedirectToAction(nameof(WorkersAuthController.Login), "WorkersAuth");
            }

            return RedirectToAction(nameof(Edit));
        }

        // GET: Workers/Edit
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            var worker = await _userManager.GetUserAsync(HttpContext.User);
            if (worker == null)
            {
                return RedirectToAction(nameof(WorkersAuthController.AccessDenied), "WorkersAuth");
            }

            WorkerEditModel workerEdit = new WorkerEditModel
            {
                Name = worker.Name,
                Phone = worker.Phone,
                Salary = worker.Salary,
                Email = worker.Email,
                Password = ""
            };

            return View(workerEdit);
        }

        // POST: Workers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Phone,Salary,Email,Password")] WorkerEditModel workerEdit)
        {
            var worker = await _userManager.GetUserAsync(HttpContext.User);
            if (worker == null || worker.Id != id)
            {
                return RedirectToAction(nameof(WorkersAuthController.AccessDenied), "WorkersAuth");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (!String.IsNullOrWhiteSpace(workerEdit.Password) &&
                        !String.IsNullOrEmpty(workerEdit.Password))
                    {
                        worker.PasswordHash = _userManager.PasswordHasher.HashPassword(worker, workerEdit.Password);
                    }
                    worker.Email = workerEdit.Email;
                    worker.Name = workerEdit.Name;
                    worker.Phone = workerEdit.Phone;
                    worker.Salary = workerEdit.Salary;

                    var result = await _userManager.UpdateAsync(worker);
                    if (!result.Succeeded)
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(worker.Id))
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
            return View(workerEdit);
        }

        // GET: Workers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _userManager.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null)
            {
                return NotFound();
            }

            return View(worker);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var worker = await _userManager.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(worker);
            if (!result.Succeeded)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool WorkerExists(int id)
        {
            return _userManager.Users.Any(e => e.Id == id);
        }
        private bool WorkerExistsByPhone(string phone)
        {
            return _userManager.Users.Any(e => e.Phone.Equals(phone));
        }
        private bool WorkerExistsByEmail(string email)
        {
            return _userManager.Users.Any(e => e.Email.Equals(email));
        }
    }
}
