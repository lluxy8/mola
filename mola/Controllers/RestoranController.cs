using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mola.Models;
using System.Threading.Tasks;

namespace mola.Controllers
{
    
    public class RestoranController : Controller
    {
        private readonly AppDbContext _context;

        public RestoranController(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var restorans =  _context.Restorans.ToList();

            return View(restorans);
        }

        [Route("Restoran/RestoranDetay/{id}")]
        public async Task<IActionResult> RestoranDetay(int id)
        {
            var RestoranResimler = await _context.RestoranResims.Where(x => x.RestoranId == id).ToListAsync();
            ViewBag.RestoranResimler = RestoranResimler;

            var Restoranlar = await _context.Restorans.ToListAsync();
            ViewBag.Restoranlar = Restoranlar;

            var restoran = await _context.Restorans.FirstOrDefaultAsync(r => r.Id == id);
            return View(restoran);
        }

    }
}
