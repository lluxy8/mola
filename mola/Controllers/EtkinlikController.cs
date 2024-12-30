using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mola.Models;

namespace mola.Controllers
{
    public class EtkinlikController : Controller
    {
        AppDbContext _context;
        public EtkinlikController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var etkinliks = _context.Etkinliks.ToList();
            return View(etkinliks);
        }

        [Route("Etkinlik/EtkinlikDetay/{id}")]
        public async Task<IActionResult> EtkinlikDetay(int id)
        {
            var RestoranResimler = await _context.Etkinliksesims.Where(x => x.EtkinlikId == id).ToListAsync();
            ViewBag.RestoranResimler = RestoranResimler;

            var Restoranlar = await _context.Etkinliks.ToListAsync();
            ViewBag.Restoranlar = Restoranlar;

            var restoran = await _context.Etkinliks.FirstOrDefaultAsync(r => r.Id == id);
            return View(restoran);
        }
    }
}
