using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Models;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class GljivaController : Controller
    {
        private readonly IGljivaService _gljivaService;

        public GljivaController(IGljivaService gljivaService)
        {
            _gljivaService = gljivaService;

        }

        public async Task<IActionResult> IndexAsync()
        {
            var gljiva = await _gljivaService.getGljive();
            return View(gljiva);
        }

        [HttpGet]
        public async Task<IActionResult> NekaGljiva(int id)
        {
            var gljivas = await _gljivaService.getGljiveUMjestu(id);
            List<String> mjestos = new List<string>();
            foreach (var g in gljivas)
            {
                mjestos.Add(g.IdGljiva1.Naziv);
            }
            ViewBag.gljivaUMjestu = mjestos;

            var gljiva = await _gljivaService.getGljivaDetails(id);
            return View(gljiva);
        }

    }
}