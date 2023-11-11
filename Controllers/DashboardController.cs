using LogixUserManagmentApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogixUserManagmentApp.Controllers
{
    public class Dashboard : Controller
    {
        private readonly ApplicationContext _context;
        public Dashboard(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _context.applicationUsers.ToListAsync();

            return View(users);
        }
    }
}