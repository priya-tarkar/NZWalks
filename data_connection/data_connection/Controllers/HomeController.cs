using data_connection.DataDb;
using data_connection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace data_connection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            EcommerceContext ecom = new EcommerceContext();
            var empdata = ecom.Categories.Where(x=>x.Title=="priya");
            foreach(var i in empdata)
            {
                Console.WriteLine(i.Id);
            }

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