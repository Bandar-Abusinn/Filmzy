using Microsoft.AspNetCore.Mvc;
using Filmzy.Models;
using Filmzy.Models.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Filmzy.Models;

namespace Filmzy.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var products = _context.product.ToList();
    
            return View(products);
        }
       

        public IActionResult details(int id)
        {

            var productDetails = _context.details.Include(pd => pd.product).FirstOrDefault(pd => pd.product.Id == id);

            return View(productDetails);

        }

        public IActionResult invoice(int id)
        {
            var productDetails = _context.details.Include(pd => pd.product).FirstOrDefault(pd => pd.product.Id == id);

            return View(productDetails);



        }
        public IActionResult WhyChooseUs()
        {

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