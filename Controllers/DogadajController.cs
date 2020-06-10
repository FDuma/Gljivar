using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class DogadajController : Controller
    {
        private readonly IDogadajiService _dogadajService;

        public DogadajController(IDogadajiService dogadajService)
        {
            _dogadajService = dogadajService;

        }

        public async Task<IActionResult> Index()
        {
            var dogadajs = await _dogadajService.getDogadaji();
            return View(dogadajs);
        }

        [HttpGet]
        public async Task<IActionResult> NekiDogadaj(int id)
        {
            var dogadaj = await _dogadajService.getDogadajDetails(id);
            return View(dogadaj);
        }
    }
}