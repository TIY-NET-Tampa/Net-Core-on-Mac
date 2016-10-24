using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebApplicationBasic.Models;

namespace WebApplicationBasic.Controllers
{
    public class HomeController : Controller
    {

        private MusicContext _context;

        public HomeController(MusicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Albums.ToList());
        }

        public IActionResult Create()
        {
            return View(new Album());
        }

        [HttpPost] // defining this to accept a POST
        [ValidateAntiForgeryToken] // setting up form Security
        public IActionResult Create(Album item) // defining route
        {
            if (ModelState.IsValid) // Checks if the Model is valid
            {
                _context.Albums.Add(item); // Stages commits to the database
                _context.SaveChanges(); // Commits changes to the database
                return RedirectToAction("Index"); //redirects to the home
            }
            return View(item); // back to Create page is something is wrong
        }




        public IActionResult Error()
        {
            return View();
        }
    }
}
