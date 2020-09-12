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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using BookChain.Models.Worker;

namespace BookChain.Controllers
{
    public class WorkersAuthController : Controller
    {
        private readonly BookChainUserManager _userManager;
        private readonly BookChainSignInManager _signInManager;

        public WorkersAuthController(BookChainUserManager userManager,
                                     BookChainSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /*
         * Login        (GET+POST):     /WorkersAuth/Login
         * Logout       (POST):         /WorkersAuth/Logout
         * AccessDenied (GET):          /WorkersAuth/AccessDenied
         */

        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AccessDenied(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // POST: Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Password")] WorkerLoginModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.Where(u => u.Email.Equals(model.Email)).Single();
                var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
