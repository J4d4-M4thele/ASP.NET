using Microsoft.AspNetCore.Mvc;
using RestaurantList.Models;
using System.Diagnostics;

namespace RestaurantList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //models are linked to context
        //controller handles requests to render views
        public IActionResult Index()
        {
            //looks to return view .cshtml
            return View();
        }
        //IActionResult returns view object
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
