
using HeavyMetalBandsReadWriteSplittingExample.Models;
using HeavyMetalBandsReadWriteSplittingExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace HeavyMetalBandsReadWriteSplittingExample.Controllers
{
    public class HeavyMetalBandsController : Controller
    {
        private readonly IBandsService _bandsService;
        public HeavyMetalBandsController(IBandsService bandsService)
        {
            _bandsService = bandsService;
        }

        public async Task<IActionResult> Index() 
        {
            var bands = await _bandsService.GetAllAsync();
            return View(bands);
        }

        public async Task<IActionResult> Details(int id)
        {
            var band = await _bandsService.GetByIdAsync(id);
            if (band == null) return NotFound();
            return View(band);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BandDTO band)
        {
            if (!ModelState.IsValid)
                return View(band);

            await _bandsService.AddAsync(band); // WriteDbContext used inside service
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _bandsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
