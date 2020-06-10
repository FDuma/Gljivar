using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Models;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly IKorisnikService _korisnikService;
        private readonly IBiljeskaService _biljeskaService;
        private readonly IMjestoService _mjestoService;
        private readonly IGljivarDrustvoService _gljivarDrustvoService;
        public KorisnikController(IKorisnikService korisnikService, IBiljeskaService biljeskaService, IMjestoService mjestoService, IGljivarDrustvoService gljivarDrustvoService)
        {
            _korisnikService = korisnikService;
            _biljeskaService = biljeskaService;
            _mjestoService = mjestoService;
            _gljivarDrustvoService = gljivarDrustvoService;
    }

        public async Task<IActionResult> Index()
        {
            var korisnik = await _korisnikService.getKorisnici();
            return View(korisnik);
        }

        [HttpGet]
        public async Task<IActionResult> NekiKorisnik(int id)
        {
            var korisnik = await _korisnikService.getKorisnikDetails(id);

            //tu bi mogle ici i biljeske i gljivarsko drustvo kojima taj korisnik pripada
            var biljeskas = await _biljeskaService.getBiljeskeAutora(id);
            ViewBag.biljeske = biljeskas;

            return View(korisnik);
        }

        [HttpGet]
        public async Task<IActionResult> NoviKorisnik()
        {
            var mjes = await _mjestoService.getMjestos();
            var gljivarDrustvos = await _gljivarDrustvoService.getGljivarDrustvo();
            ViewBag.gljivarDrustvo = gljivarDrustvos;
            return View(mjes);
        }

        [HttpPost]
        public async Task<IActionResult> NoviKorisnik(string pass, bool isAdmin, int kontaktBroj, string email, int idMjesta, 
            int idGljivarDrustvo, string ime, string prezime, string korisnickoIme)
            
        {
            Korisnik korisnik;
            if (idGljivarDrustvo != -1)
            {
                korisnik = new Korisnik()
                {
                    Pass = pass,
                    IsAdmin = isAdmin,
                    KontaktBroj = kontaktBroj,
                    Email = email,
                    IdMjesta = idMjesta,
                    IdGljivarskoDrustvo = idGljivarDrustvo,
                    Ime = ime,
                    Prezime = prezime,
                    KorisnickoIme = korisnickoIme
                };
            } else
            {
                korisnik = new Korisnik()
                {
                    Pass = pass,
                    IsAdmin = isAdmin,
                    KontaktBroj = kontaktBroj,
                    Email = email,
                    IdMjesta = idMjesta,
                    IdGljivarskoDrustvo = null,
                    Ime = ime,
                    Prezime = prezime,
                    KorisnickoIme = korisnickoIme
                };
            }
            
            


            await _korisnikService.addKorisnik(korisnik);
            return RedirectToAction("Index", "Korisnik");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _korisnikService.deleteKorisnik(id);
            return RedirectToAction("Index", "Korisnik");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            ViewBag.mjesta = await _mjestoService.getMjestos();
            ViewBag.gljivarDrustvo = await _gljivarDrustvoService.getGljivarDrustvo();

            var kor = await _korisnikService.getKorisnikDetails(id);
            return View(kor);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, string pass, bool isAdmin, int kontaktBroj, string email, int idMjesta,
            int idGljivarDrustvo, string ime, string prezime, string korisnickoIme)
        {
            Korisnik korisnik = new Korisnik()
            {
                Pass = pass,
                IsAdmin = isAdmin,
                KontaktBroj = kontaktBroj,
                Email = email,
                IdMjesta = idMjesta,
                IdGljivarskoDrustvo = idGljivarDrustvo,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme
            };

            await _korisnikService.updateKorisnik(id, korisnik);
            return RedirectToAction("Index", "Korisnik");
        }

    }
}