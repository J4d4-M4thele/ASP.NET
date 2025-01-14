using Microsoft.AspNetCore.Mvc;
using RestaurantList.Data;
using RestaurantList.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantList.Controllers
{
    public class RestaurantList : Controller
    {
        private readonly RestaurantListContext _context;

        //variable constructor
        //dependancy injection initialises _context
        public RestaurantList(RestaurantListContext context)
        {
            _context = context;
        }

        //asynchronously fetches Restaurant records from database table
        public async Task<IActionResult> Index() 
        {
            //renders Index.cshtml
            return View(await _context.Restaurants.ToListAsync());
        }

    }
}
