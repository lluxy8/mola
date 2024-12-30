using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mola.Models;

namespace mola.Controllers
{
    public class SpaController : Controller
    {
        private readonly AppDbContext _context;

        public SpaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var spas = _context.Spas.ToList();  
            return View(spas);
        }

        [Route("Spa/SpaDetay/{id}")]
        public async Task<IActionResult> SpaDetay(int id)
        {
            var RestoranResimler = await _context.SpaResims.Where(x => x.SpaId == id).ToListAsync();
            ViewBag.RestoranResimler = RestoranResimler;

            var Restoranlar = await _context.Spas.ToListAsync();
            ViewBag.Restoranlar = Restoranlar;

            var restoran = await _context.Spas.FirstOrDefaultAsync(r => r.Id == id);
            return View(restoran);
        }

    }
}
