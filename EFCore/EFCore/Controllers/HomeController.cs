using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TESTEF.Persistence.Models;
using TestEFCore.Models;

namespace TestEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestContext _context;


        public  HomeController(TestContext TestContext)
        {
            _context = TestContext;
        }

        public IActionResult Index()
        {
            var students = _context.Student.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
