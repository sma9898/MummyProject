using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MummyProject.Models;
using MummyProject.Models.ViewModels;

namespace MummyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MummyDbContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, MummyDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index(long age, int page = 1)
        {
            return View(new BurialListViewModel
            {
                Burials = _context.Burial
                .Where(b => b.AgeEstimate == age).ToList(),
                

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = 5,
                    TotalNumItems = _context.Burial.Count()
                }
            });
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
