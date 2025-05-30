
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
            var bands = await _bandsService.GetBandsAsync();
            return View(bands); 
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BandCreateRequest b)
        {
            if (!ModelState.IsValid)
                return View(b);

            var id = await _bandsService.AddBandAsync(b);
            return RedirectToAction("Index");
        }
    }
}
