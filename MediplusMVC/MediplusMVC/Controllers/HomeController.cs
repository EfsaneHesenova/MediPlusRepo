using MediplusMVC.DAL;
using MediplusMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediplusMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderItem> sliderItems = await _context.SliderItems.OrderByDescending(s=> s.Id).Take(3).ToListAsync();
            return View(sliderItems);
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}
