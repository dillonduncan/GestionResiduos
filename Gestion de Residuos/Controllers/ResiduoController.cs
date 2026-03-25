using GestionResiduos.DataContext;
using GestionResiduos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionResiduos.Controllers
{
    public class ResiduoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ResiduoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var listResiduos = _context.Residuos.ToList();
            if (listResiduos.Count > 0)
            {
                return View(await _context.Residuos.ToListAsync());
            }
            else
            {
                return View();
            }
        }
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Residuo residuo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residuo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(residuo);
        }
    }
}
