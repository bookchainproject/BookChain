using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using BookChain.Data;

namespace BookChain.Controllers
{
    public class BranchesController : Controller
    {
        private readonly BookChainContext _context;

        public BranchesController(BookChainContext context)
        {
            _context = context;
        }

        /*
         * Index    (GET):               /Branches/?Params
         */

        // GET: Branches
        public async Task<IActionResult> Index(string country, string city, string name, string owner, string phone)
        {
            var branches = _context.Branch.AsQueryable();

            if (!String.IsNullOrWhiteSpace(country))
                branches = branches.Where(x => x.Country.Contains(country));
            if (!String.IsNullOrWhiteSpace(city))
                branches = branches.Where(x => x.City.Contains(city));
            if (!String.IsNullOrWhiteSpace(owner))
                branches = branches.Where(x => x.Owner.Contains(owner));
            if (!String.IsNullOrWhiteSpace(phone))
                branches = branches.Where(x => x.Phone.Contains(phone));
            if (!String.IsNullOrWhiteSpace(name))
                branches = branches.Where(x => x.Name.Contains(name));

            return View(await branches.ToListAsync());
        }

        public JsonResult ToJson()
        {
            return Json(_context.Branch.AsQueryable());
        }
    }
}
