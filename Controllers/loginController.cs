using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login.Models;
using Microsoft.EntityFrameworkCore;
using login.Data;

namespace login.Controllers
{
    public class loginController : Controller
    {
        private readonly loginContext _context;

        public loginController(loginContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(users model)
        {
            var user = _context.users.SingleOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (user != null)
            {
                
                return RedirectToAction("Welcome");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Welcome()
        {
            return View("Home");
        }

    }
}
