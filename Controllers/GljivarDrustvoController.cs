using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class GljivarDrustvoController : Controller
    {
        private readonly IKorisnikService _korisnikService;
        private readonly IGljivarDrustvoService _gljivarDrustvoService;
        private readonly IObjavaService _objavaService;
        private readonly IDogadajiService _dogadajiService;
        public GljivarDrustvoController(IKorisnikService korisnikService, IGljivarDrustvoService gljivarDrustvoService, IObjavaService objavaService, IDogadajiService dogadajiService)
        {
            _korisnikService = korisnikService;
            _gljivarDrustvoService = gljivarDrustvoService;
            _objavaService = objavaService;
            _dogadajiService = dogadajiService;

        }

        public async Task<IActionResult> Index()
        {
            var gljivarDrustvo = await _gljivarDrustvoService.getGljivarDrustvo();
            return View(gljivarDrustvo);
        }

        [HttpGet]
        public async Task<IActionResult> NekiGljivarDrustvo(int id)
        {
            var gljivarDrustvo = await _gljivarDrustvoService.getGljivarDrustvoDetails(id);
            var objave = await _objavaService.getObjavas();
            ViewBag.objave = objave;
            var korisnici = await _korisnikService.getKorisnici();
            ViewBag.korisnici = korisnici;
            var dogadaji = await _dogadajiService.getDogadaji();
            ViewBag.dogadaji = dogadaji;

            return View(gljivarDrustvo);
        }
    }
}