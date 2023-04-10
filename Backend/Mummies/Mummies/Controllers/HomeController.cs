using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mummies.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mummies.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private BurialRecordsDbContext context { get; set; }

        public HomeController(BurialRecordsDbContext temp) => context = temp;

        public IActionResult BurialRecords()
        {
            var b = context.BurialRecords.ToList();

            return View(b);
        }
    }
}

