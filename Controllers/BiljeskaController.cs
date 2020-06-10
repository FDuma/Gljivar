using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class BiljeskaController : Controller
    {
        private readonly IBiljeskaService _biljeskaService;
        
        public BiljeskaController(IBiljeskaService biljeskaService)
        {
            _biljeskaService = biljeskaService;

        }

        public async Task<IActionResult> Index()
        {
            var biljeskas = await _biljeskaService.getBiljeske();
            return View(biljeskas);
        }

        [HttpGet]
        public async Task<IActionResult> NekaBiljeska(int id)
        {
            var biljeska = await _biljeskaService.getBiljeskaDetails(id);
            return View(biljeska);
        }

    }
}