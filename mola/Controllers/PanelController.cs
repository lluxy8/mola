using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using mola.Models;

namespace mola.Controllers
{
    public class PanelController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<PanelController> _logger;

        public PanelController(AppDbContext context, ILogger<PanelController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RestoranEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RestoranEkle(Restoran restoran)
        {
            await _context.Restorans.AddAsync(restoran);
            await _context.SaveChangesAsync();
            return Ok("Oluşturuldu");
        }


        public IActionResult RestoranResimEkle()
        {
            var restorans = _context.Restorans.ToList();
            ViewBag.Restorans = restorans;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RestoranResimEkle(RestoranResim resim)
        {
            if(resim.RestoranId != 0)
            {
                await _context.RestoranResims.AddAsync(resim);
                await _context.SaveChangesAsync();
                return Ok("Resim Eklendi");
            }

            return View();
        }

        public async Task<IActionResult> Restoransil()
        {
            var restoran = await _context.Restorans.ToListAsync();
            return View(restoran);
        }


        [HttpPost]
        public async Task<IActionResult> RestoranSil(int id)
        {
            var restoran = await _context.Restorans.FirstOrDefaultAsync(x => x.Id == id);

            if (restoran != null)
            {
                _context.Restorans.Remove(restoran);
                await _context.SaveChangesAsync(); 
                return Ok("Silindi."); 
            }

            return View();
        }

        public IActionResult SpaEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SpaEkle(Spa spa)
        {
            if(spa.Kategori != "bos")
            {
                await _context.Spas.AddAsync(spa);
                await _context.SaveChangesAsync();
                return Ok("Oluşturuldu");
            }

            return View();     
        }

        public IActionResult SpaResimEkle()
        {
            var restorans = _context.Spas.ToList();
            ViewBag.Restorans = restorans;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SpaResimEkle(SpaResim resim)
        {
            if (resim.SpaId != 0)
            {
                await _context.SpaResims.AddAsync(resim);
                await _context.SaveChangesAsync();
                return Ok("Resim Eklendi");
            }

            return View();
        }

        public async Task<IActionResult> SpaSil()
        {
            var spas = await _context.Spas.ToListAsync();
            return View(spas);
        }


        [HttpPost]
        public async Task<IActionResult> SpaSil(int id)
        {
            var restoran = await _context.Spas.FirstOrDefaultAsync(x => x.Id == id);

            if (restoran != null)
            {
                _context.Spas.Remove(restoran);
                await _context.SaveChangesAsync();
                return Ok("Silindi.");
            }

            return View();
        }

        public IActionResult EtkinlikEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EtkinlikEkle(Etkinlik etkinlik)
        {
            if (etkinlik.Kategori != "bos")
            {
                await _context.Etkinliks.AddAsync(etkinlik);
                await _context.SaveChangesAsync();
                return Ok("Oluşturuldu");
            }

            return View();
        }

        public IActionResult EtkinlikResimEkle()
        {
            var restorans = _context.Etkinliks.ToList();
            ViewBag.Restorans = restorans;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EtkinlikResimEkle(EtkinlikResim resim)
        {
            if (resim.EtkinlikId != 0)
            {
                await _context.Etkinliksesims.AddAsync(resim);
                await _context.SaveChangesAsync();
                return Ok("Resim Eklendi");
            }

            return View();
        }

        public async Task<IActionResult> EtkinlikSil()
        {
            var ets = await _context.Etkinliks.ToListAsync();
            return View(ets);
        }


        [HttpPost]
        public async Task<IActionResult> EtkinlikSil(int id)
        {
            var restoran = await _context.Etkinliks.FirstOrDefaultAsync(x => x.Id == id);

            if (restoran != null)
            {
                _context.Etkinliks.Remove(restoran);
                await _context.SaveChangesAsync();
                return Ok("Silindi.");
            }

            return View();
        }





    }
}
