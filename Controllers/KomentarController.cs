using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Models;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class KomentarController : Controller
    {
        private readonly IKomentarService _komentars;

        public KomentarController(IKomentarService _komentars)
        {
            _komentars = _komentars;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NoviProizvod()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NoviKomentar(int IdObjava, int IdGljivarDrustvo, int IdKorisnik, string Komentar1)
        {
            Komentar newComment = new Komentar()
            {
                IdObjava = IdObjava,
                IdGljivarDrustvo = IdGljivarDrustvo,
                IdKorisnik = IdKorisnik,
                Komentar1 = Komentar1,
                Datum = DateTime.Now,

            };


            await _komentars.addNewComment(newComment);
            return RedirectToAction("Index", "Home");
        }
    }
}